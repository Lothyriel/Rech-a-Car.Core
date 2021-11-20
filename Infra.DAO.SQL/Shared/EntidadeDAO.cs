using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace Infra.DAO.Shared
{
    public abstract class EntidadeDAO<T> : DAO<T> where T : IEntidade
    {
        public abstract string sqlSelecionarPorId { get; }
        public abstract string sqlSelecionarTodos { get; }
        public abstract string sqlInserir { get; }
        public abstract string sqlEditar { get; }
        public abstract string sqlExcluir { get; }
        public abstract string sqlExists { get; }
        public override T GetById(int id, Type tipo = null)
        {
            return Db.Get(sqlSelecionarPorId, ConverterEmEntidade, Db.AdicionarParametro("ID", id));
        }
        public override bool Inserir(T entidade)
        {
            try
            {
                entidade.Id = Db.Insert(sqlInserir, ObterParametrosRegistro(entidade));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public override bool Editar(int id, T entidade)
        {
            try
            {
                entidade.Id = id;
                Db.Update(sqlEditar, ObterParametrosRegistro(entidade));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public override bool Excluir(int id, Type tipo = null)
        {
            try
            {
                Db.Delete(sqlExcluir, Db.AdicionarParametro("ID", id));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public override bool Existe(int id, Type tipo = null)
        {
            return Db.Exists(sqlExists, Db.AdicionarParametro("ID", id));
        }
        public override List<T> Registros => Db.GetAll(sqlSelecionarTodos, ConverterEmEntidade);
        public abstract T ConverterEmEntidade(IDataReader reader);
        public abstract Dictionary<string, object> ObterParametrosRegistro(T entidade);
    }
}