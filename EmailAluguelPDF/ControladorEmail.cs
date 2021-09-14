using Controladores.AluguelModule;
using Controladores.Shared;
using Dominio.AluguelModule;
using iText.Kernel.Pdf;
using iText.Layout;
using System;
using System.Collections.Generic;
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

        #endregion

        public void InserirParaEnvio(EnvioEmail envio)
        {
            var ms = new MemoryStream();
            envio.Pdf.Save(ms);
            Db.Insert(sqlInserirEmail, Db.AdicionarParametro("ID_ALUGUEL", envio.Aluguel.Id, Db.AdicionarParametro("PDF", ms)));
        }
        public void AlterarEnviado(int id)
        {
            Db.Update(sqlAlterarEmailEnviado, Db.AdicionarParametro("ID", id, Db.AdicionarParametro("DATA_ENVIADO", DateTime.Now)));
        }
        public EnvioEmail GetProxEnvio()
        {
            return Db.Get(sqlGetProxEnvio, ConverterEmEntidade);
        }
        private EnvioEmail ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var aluguel = new ControladorAluguel().GetById(Convert.ToInt32(reader["ID_ALUGUEL"]));
            var doc = new Document(new PdfDocument(new PdfWriter(new MemoryStream((byte[])reader["PDF"]))));
            return new EnvioEmail(aluguel, doc) { Id = id };
        }
    }
}
