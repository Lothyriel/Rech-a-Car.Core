using Controladores.AluguelModule;
using Controladores.Shared;
using Dominio.AluguelModule;
using Infra.Extensions.Methods;
using iText.Layout;
using System;
using System.Data;
using System.IO;

namespace EmailAluguelPDF
{
    public class ControladorEmail
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
        public EnvioEmail GetProxEnvio()
        {
            if (Db.Exists(sqlExisteEmailPendente))
                return Db.Get(sqlGetProxEnvio, ConverterEmEntidade);
            else
                return null;
        }
        private EnvioEmail ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var aluguel = new ControladorAluguel().GetById(Convert.ToInt32(reader["ID_ALUGUEL"]));
            MemoryStream ms = ((byte[])reader["PDF"]).ToMemoryStream();
            Document pdf = ms.ToPdf();

            return new EnvioEmail(aluguel, pdf) { Id = id };
        }
    }
}
