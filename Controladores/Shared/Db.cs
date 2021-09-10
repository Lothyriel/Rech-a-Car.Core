using ConfigurationManager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Controladores.Shared
{
    public delegate T ConverterDelegate<T>(IDataReader reader);

    public static class Db
    {
        public static readonly string bancoSelecionado;
        private static readonly DbProviderFactory factory;
        private static readonly string connectionString;

        static Db()
        {
            var ConfigurationManager = JsonManager.InitConfiguration();
            bancoSelecionado = ConfigurationManager.GetSection("bancoDeDados").Value;
            connectionString = ConfigurationManager.GetSection("ConnectionStrings").GetSection("SQLServer").Value;

            string nomeProvedor = ConfigurationManager.GetSection("SQLProvider").Value;
            DbProviderFactories.RegisterFactory(nomeProvedor, SqlClientFactory.Instance);
            factory = DbProviderFactories.GetFactory(nomeProvedor);
        }
        public static int Insert(string sql, Dictionary<string, object> parameters)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;

                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql.GetUltimoIdInserido();
                    command.Connection = connection;

                    command.SetParameters(parameters);
                    connection.Open();

                    int id = Convert.ToInt32(command.ExecuteScalar());

                    connection.Close();

                    return id;
                }
            }
        }
        public static void Update(string sql, Dictionary<string, object> parameters)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;

                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.Connection = connection;

                    command.SetParameters(parameters);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }
        public static void Delete(string sql, Dictionary<string, object> parameters = null)
        {
            Update(sql, parameters);
        }
        public static List<T> GetAll<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters = null)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;

                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.Connection = connection;
                    command.SetParameters(parameters);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        var list = new List<T>();

                        while (reader.Read())
                        {
                            var obj = convert(reader);
                            list.Add(obj);
                        }
                        return list;
                    }
                }
            }
        }
        public static T Get<T>(string sql, ConverterDelegate<T> convert, Dictionary<string, object> parameters=null)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;

                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;
                    command.Connection = connection;

                    command.SetParameters(parameters);

                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        T t = default;

                        if (reader.Read())
                            t = convert(reader);

                        return t;
                    }
                }
            }
        }
        public static bool Exists(string sql, Dictionary<string, object> parameters)
        {
            using (DbConnection connection = factory.CreateConnection())
            {
                connection.ConnectionString = connectionString;

                using (DbCommand command = connection.CreateCommand())
                {
                    command.CommandText = sql;

                    command.Connection = connection;

                    command.SetParameters(parameters);

                    connection.Open();

                    int numberRows = Convert.ToInt32(command.ExecuteScalar());

                    return numberRows > 0;
                }
            }
        }
        private static void SetParameters(this DbCommand command, Dictionary<string, object> parameters)
        {
            if (parameters == null || parameters.Count == 0)
                return;

            foreach (var parameter in parameters)
            {
                if (parameter.Value is string valueStr && string.IsNullOrEmpty(valueStr))
                    parameters[parameter.Key] = null;

                string name = parameter.Key;
                object value = parameter.Value ?? DBNull.Value;
                DbParameter dbParameter = command.CreateParameter();
                dbParameter.ParameterName = name;
                dbParameter.Value = value;

                command.Parameters.Add(dbParameter);
            }
        }
        private static string GetUltimoIdInserido(this string sql)
        {
            return sql + ";SELECT SCOPE_IDENTITY()";
        }
        public static Dictionary<string, object> AdicionarParametro(string campo, object valor, Dictionary<string, object> parametros = null)
        {
            if (parametros == null)
                parametros = new Dictionary<string, object>();
            parametros.Add(campo, valor);
            return parametros;
        }
    }
}