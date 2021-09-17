using Dominio.AluguelModule;
using Dominio.CupomModule;
using Dominio.PessoaModule.ClienteModule;
using Infra.DAO.CupomModule;
using Infra.DAO.PessoaModule;
using Infra.DAO.Shared;
using Infra.DAO.SQL.AluguelModule;
using Infra.DAO.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace Infra.DAO.AluguelModule
{
    public class AluguelDAO : EntidadeDAO<Aluguel>, IAluguelRepository
    {
        #region Queries
        private const string sqlInserirAluguel =
    @"INSERT INTO [TBALUGUEL]
                (
                    [ID_CLIENTE],       
                    [ID_CONDUTOR],             
                    [ID_VEICULO],
                    [ID_FUNCIONARIO],
                    [TIPO_PLANO],
                    [DATA_ALUGUEL],
                    [DATA_DEVOLUCAO],
                    [ID_CUPOM]
                )
            VALUES
                (
                    @ID_CLIENTE,       
                    @ID_CONDUTOR,      
                    @ID_VEICULO,     
                    @ID_FUNCIONARIO,
                    @TIPO_PLANO,
                    @DATA_ALUGUEL,
                    @DATA_DEVOLUCAO,
                    @ID_CUPOM
                )";

        private const string sqlEditarAluguel =
            @" UPDATE [TBALUGUEL]
                SET 
                    [ID_CLIENTE] = @ID_CLIENTE,       
                    [ID_CONDUTOR] = @ID_CONDUTOR,             
                    [ID_VEICULO] = @ID_VEICULO,
                    [ID_FUNCIONARIO] = @ID_FUNCIONARIO,       
                    [TIPO_PLANO] = @TIPO_PLANO,
                    [DATA_ALUGUEL] = @DATA_ALUGUEL,
                    [DATA_DEVOLUCAO] = @DATA_DEVOLUCAO,
                    [ID_CUPOM] = @ID_CUPOM
                WHERE [ID] = @ID";

        private const string sqlExcluirAluguel =
            @"DELETE FROM [TBALUGUEL] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarAluguelPorId =
            @"SELECT *
             FROM
                [TBALUGUEL]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosAlugueis =
            @"SELECT *
             FROM
                [TBALUGUEL]";

        private const string sqlExisteAluguel =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBALUGUEL]
            WHERE 
                [ID] = @ID";

        #endregion
        public override string sqlSelecionarPorId => sqlSelecionarAluguelPorId;
        public override string sqlSelecionarTodos => sqlSelecionarTodosAlugueis;
        public override string sqlInserir => sqlInserirAluguel;
        public override string sqlEditar => sqlEditarAluguel;
        public override string sqlExcluir => sqlExcluirAluguel;
        public override string sqlExists => sqlExisteAluguel;

        public override Aluguel ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var id_veiculo = Convert.ToInt32(reader["ID_VEICULO"]);
            var id_cliente = Convert.ToInt32(reader["ID_CLIENTE"]);
            var id_condutor = Convert.ToInt32(reader["ID_CONDUTOR"]);
            var id_funcionario = Convert.ToInt32(reader["ID_FUNCIONARIO"]);

            var dataAluguel = Convert.ToDateTime(reader["DATA_ALUGUEL"]);
            var dataDevolucao = Convert.ToDateTime(reader["DATA_DEVOLUCAO"]);
            var tipoPlano = Convert.ToInt32(reader["TIPO_PLANO"]);

            var funcionario = new FuncionarioDAO().GetById(id_funcionario);
            var veiculo = new VeiculoDAO().GetById(id_veiculo);

            var ehClientePF = id_condutor == id_cliente;

            var cliente = new ClienteDAO().GetById(id_cliente, ehClientePF ? typeof(ClientePF) : typeof(ClientePJ));

            var condutor = ehClientePF ? null : ((ClientePJ)cliente).Motoristas.Find(x => x.Id == id_condutor);

            var servicos = new ServicoDAO().GetServicosAlugados(id);

            var id_cupom = reader["ID_CUPOM"];

            Cupom cupom = null;
            if (id_cupom is int _id_cupom)
                cupom = new CupomDAO().GetById(_id_cupom);

            return new Aluguel(veiculo, servicos, (Plano)tipoPlano, dataAluguel, cliente, funcionario, dataDevolucao, condutor, cupom)
            {
                Id = id
            };
        }
        public override Dictionary<string, object> ObterParametrosRegistro(Aluguel aluguel)
        {
            return new Dictionary<string, object>
            {
                { "ID", aluguel.Id },
                { "ID_CLIENTE", aluguel.Cliente.Id },
                { "ID_CONDUTOR", aluguel.Condutor.Id },
                { "ID_FUNCIONARIO", aluguel.Funcionario.Id },
                { "ID_VEICULO", aluguel.Veiculo.Id },
                { "ID_CUPOM", aluguel.Cupom?.Id},
                { "TIPO_PLANO", aluguel.TipoPlano },
                { "DATA_ALUGUEL", aluguel.DataAluguel },
                { "DATA_DEVOLUCAO", aluguel.DataDevolucao }
            };
        }
    }
}