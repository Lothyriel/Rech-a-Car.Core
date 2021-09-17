using Dominio.ServicoModule;
using Infra.DAO.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace Infra.DAO.SQL.AluguelModule
{
    public class ServicoDAO : EntidadeDAO<Servico>, IServicoRepository
    {
        #region Queries
        private const string sqlInserirServico =
           @"INSERT INTO [TBServico]
             (   
                [NOME],            
                [TAXA]
             )
          VALUES
             (            
                @NOME,            
                @TAXA
             )";

        private const string sqlEditarServico =
           @"UPDATE [TBServico]
            SET
                [NOME] = @NOME,          
                [TAXA] = @TAXA
            WHERE
                [ID] = @ID";

        private const string sqlExcluirServico =
           @"DELETE FROM [TBServico] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarServicoPorId =
           @"SELECT *        
            FROM
               [TBServico]
            WHERE 
               [ID] = @ID";

        private const string sqlSelecionarTodosServicos =
           @"SELECT *
            FROM 
               [TBServico]";

        private const string sqlSelecionarServicosDisponiveis =
           @"SELECT *
            FROM 
               [TBServico]
            WHERE
                [ID_ALUGUEL] IS NULL";

        private const string sqlSelecionarServicosAlugados =
            @"SELECT *
            FROM 
               [TBServico]
            WHERE
                [ID_ALUGUEL]=@ID_ALUGUEL";

        private const string sqlExisteServico =
           @"SELECT 
                COUNT(*) 
            FROM 
                [TBServico]
            WHERE 
                [ID] = @ID";

        private const string sqlDesalugarServicosAlugados =
        @"UPDATE [TBServico]
                    SET
                        [ID_ALUGUEL] = NULL         
                    WHERE
                        [ID_ALUGUEL] = @ID_ALUGUEL";

        private const string sqlEditarAluguelServico =
                @"UPDATE [TBServico]
                        SET
                          [ID_ALUGUEL] = @ID_ALUGUEL         
                      WHERE
                        [ID] = @ID";

        #endregion

        public override string sqlSelecionarPorId => sqlSelecionarServicoPorId;
        public override string sqlSelecionarTodos => sqlSelecionarTodosServicos;
        public override string sqlInserir => sqlInserirServico;
        public override string sqlEditar => sqlEditarServico;
        public override string sqlExcluir => sqlExcluirServico;
        public override string sqlExists => sqlExisteServico;

        public override Servico ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            double taxa = Convert.ToDouble(reader["TAXA"]);

            return new Servico(nome, taxa)
            {
                Id = id
            };
        }
        public override Dictionary<string, object> ObterParametrosRegistro(Servico servico)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", servico.Id },
                { "NOME", servico.Nome },
                { "TAXA", servico.Taxa },
            };
            return parametros;
        }
        public List<Servico> GetServicosAlugados(int idAluguel)
        {
            return Db.GetAll(sqlSelecionarServicosAlugados, ConverterEmEntidade, Db.AdicionarParametro("ID_ALUGUEL", idAluguel));
        }
        public void AlugarServicos(int idAluguel, List<Servico> servicos)
        {
            foreach (var servico in servicos)
                Db.Update(sqlEditarAluguelServico, Db.AdicionarParametro("ID_ALUGUEL", idAluguel, Db.AdicionarParametro("ID", servico.Id)));
        }
        public List<Servico> ServicosDisponiveis()
        {
            return Db.GetAll(sqlSelecionarServicosDisponiveis, ConverterEmEntidade);
        }
        public void DesalugarServicosAlugados(int idAluguel)
        {
            Db.Update(sqlDesalugarServicosAlugados, Db.AdicionarParametro("ID_ALUGUEL", idAluguel));
        }
    }
}