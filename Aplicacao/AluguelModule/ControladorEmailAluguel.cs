using Controladores.AluguelModule;
using Controladores.Shared;
using Dominio.AluguelModule;
using EmailAluguelPDF;
using Infra.Extensions.Methods;
using System;
using System.Data;
using System.IO;

namespace Aplicacao.AluguelModule.EmailAluguel
{
    public class ControladorEmailAluguel
    {
        #region Queries
        private const string sqlInserirEmail =
            @"INSERT INTO [TBEMAIL]
              (
                [ID_ALUGUEL],       
                [PDF]            
              )
                VALUES
              (
                @ID_ALUGUEL,
                @PDF
              )";

        private const string sqlAlterarEmailEnviado =
            @"UPDATE [TBEMAIL]
                SET 
                    [DATA_ENVIADO] = @DATA_ENVIADO
                WHERE [ID] = @ID";

        private const string sqlGetProxEnvio =
            @"SELECT TOP 1 *
                FROM [TBEMAIL] 
			  WHERE [DATA_ENVIADO] IS NULL
                ORDER BY [DATA_ENVIADO] DESC";

        private const string sqlExisteEmailPendente =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBEMAIL]
            WHERE 
                [DATA_ENVIADO] IS NULL";

        #endregion

        public static void InserirParaEnvio(Aluguel aluguel, MemoryStream msPDF)
        {
            var bytesPdf = msPDF.ToArray();
            Db.Insert(sqlInserirEmail, Db.AdicionarParametro("ID_ALUGUEL", aluguel.Id, Db.AdicionarParametro("PDF", bytesPdf)));
        }

        public static void AlterarEnviado(int id)
        {
            Db.Update(sqlAlterarEmailEnviado, Db.AdicionarParametro("ID", id, Db.AdicionarParametro("DATA_ENVIADO", DateTime.Now)));
        }
        public EnvioEmailAluguel GetProxEnvio()
        {
            if (Db.Exists(sqlExisteEmailPendente))
                return Db.Get(sqlGetProxEnvio, ConverterEmEntidade);
            else
                return null;
        }
        private EnvioEmailAluguel ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var aluguel = new ControladorAluguel().GetById(Convert.ToInt32(reader["ID_ALUGUEL"]));
            MemoryStream ms = ((byte[])reader["PDF"]).ToMemoryStream();
            //Document pdf = ms.ToPdf();

            return new EnvioEmailAluguel(aluguel, ms) { Id = id };
        }
    }
    [Serializable]
    public class FilaEmailVazia : Exception
    {
        public FilaEmailVazia()
        {
        }

        public FilaEmailVazia(string message) : base(message)
        {
        }
    }
    public class EnvioEmailAluguel : EnvioEmail
    {
        public EnvioEmailAluguel(Aluguel aluguel, MemoryStream attachment) : base(attachment)
        {
            Aluguel = aluguel;
        }
        public Aluguel Aluguel { get; }
    }
}
