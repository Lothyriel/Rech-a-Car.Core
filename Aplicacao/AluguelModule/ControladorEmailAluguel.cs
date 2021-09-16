using Dominio.AluguelModule;
using EmailAluguelPDF;
using Infra.DAO.AluguelModule;
using Infra.DAO.Shared;
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
        public EnvioResumoAluguel GetProxEnvio()
        {
            if (Db.Exists(sqlExisteEmailPendente))
                return Db.Get(sqlGetProxEnvio, ConverterEmEntidade);
            else
                return null;
        }
        private EnvioResumoAluguel ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var aluguel = new AluguelDAO().GetById(Convert.ToInt32(reader["ID_ALUGUEL"]));
            MemoryStream ms = ((byte[])reader["PDF"]).ToMemoryStream();
            //Document pdf = ms.ToPdf();

            return new EnvioResumoAluguel(aluguel, ms) { Id = id };
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
    public class EnvioResumoAluguel : EnvioEmail
    {
        public EnvioResumoAluguel(Aluguel aluguel, MemoryStream attachment) : base(attachment)
        {
            Aluguel = aluguel;
        }
        public Aluguel Aluguel { get; }
    }
}
