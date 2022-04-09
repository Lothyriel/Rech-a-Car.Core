using Dominio.VeiculoModule;
using Infra.DAO.Shared;
using Infra.Extensions.Methods;
using System;
using System.Collections.Generic;
using System.Data;

namespace Infra.DAO.VeiculoModule
{
    public class VeiculoDAO : EntidadeDAO<Veiculo>, IVeiculoRepository
    {
        #region Queries
        private const string sqlInserirVeiculo =
            @"INSERT INTO [TBVEICULO]
                (
                    [MODELO],       
                    [MARCA],             
                    [ID_CATEGORIA],
                    [ANO],
                    [PLACA],
                    [CAPACIDADE],
                    [PORTAS],
                    [CHASSI],
                    [PORTA_MALAS],
                    [FOTO],
                    [AUTOMATICO],
                    [QUILOMETRAGEM],
                    [CAPACIDADE_TANQUE],
                    [TIPO_COMBUSTIVEL]
                )
            VALUES
                (
                    @MODELO,       
                    @MARCA,             
                    @ID_CATEGORIA,
                    @ANO,
                    @PLACA,
                    @CAPACIDADE,
                    @PORTAS,
                    @CHASSI,
                    @PORTA_MALAS,
                    @FOTO,
                    @AUTOMATICO,
                    @QUILOMETRAGEM,
                    @CAPACIDADE_TANQUE,
                    @TIPO_COMBUSTIVEL
                )";

        private const string sqlEditarVeiculo =
            @"UPDATE [TBVEICULO]
                SET 
                    [MODELO] = @MODELO,       
                    [MARCA] = @MARCA,             
                    [ID_CATEGORIA] = @ID_CATEGORIA,
                    [ANO] = @ANO,
                    [PLACA] = @PLACA,
                    [CAPACIDADE] = @CAPACIDADE,
                    [PORTAS] = @PORTAS,
                    [CHASSI] = @CHASSI,
                    [PORTA_MALAS] = @PORTA_MALAS,
                    [FOTO] = @FOTO,
                    [AUTOMATICO] = @AUTOMATICO,
                    [QUILOMETRAGEM] = @QUILOMETRAGEM,
                    [CAPACIDADE_TANQUE] = @CAPACIDADE_TANQUE,
                    [TIPO_COMBUSTIVEL] = @TIPO_COMBUSTIVEL
                WHERE [ID] = @ID";

        private const string sqlExcluirVeiculo =
            @"DELETE FROM [TBVEICULO] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarVeiculoPorId =
            @"SELECT *
             FROM
                [TBVEICULO]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosVeiculos =
            @"SELECT *
             FROM
                [TBVEICULO]";

        private const string sqlExisteVeiculo =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBVEICULO]
            WHERE 
                [ID] = @ID";

        private const string sqlAdicionarQuilometragem =
            @"UPDATE [TBVEICULO]
                SET 
                    [QUILOMETRAGEM] = @NOVA_QUILOMETRAGEM
                WHERE [ID] = @ID";


        private const string sqlSelecionarVeiculoDisponivel =
            @"SELECT * 
            FROM TBVeiculo 
            LEFT JOIN 
                TBAluguel ON TBAluguel.ID_VEICULO = TBVeiculo.ID
            WHERE 
                TBAluguel.ID_VEICULO IS NULL
            OR
                TBAluguel.DATA_DEVOLVIDA IS NOT NULL";

        #endregion

        public override string sqlSelecionarPorId => sqlSelecionarVeiculoPorId;
        public override string sqlSelecionarTodos => sqlSelecionarTodosVeiculos;
        public override string sqlInserir => sqlInserirVeiculo;
        public override string sqlEditar => sqlEditarVeiculo;
        public override string sqlExcluir => sqlExcluirVeiculo;
        public override string sqlExists => sqlExisteVeiculo;

        public void AdicionarQuilometragem(Veiculo veiculo, int kmRodados)
        {
            Db.Update(sqlAdicionarQuilometragem, Db.AdicionarParametro("NOVA_QUILOMETRAGEM", kmRodados + veiculo.Quilometragem, Db.AdicionarParametro("ID", veiculo.Id)));
        }
        public override Veiculo ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var modelo = Convert.ToString(reader["MODELO"]);
            var marca = Convert.ToString(reader["MARCA"]);
            var placa = Convert.ToString(reader["PLACA"]);
            var chassi = Convert.ToString(reader["CHASSI"]);
            var portas = Convert.ToInt32(reader["PORTAS"]);
            var ano = Convert.ToInt32(reader["ANO"]);
            var porta_malas = Convert.ToInt32(reader["PORTA_MALAS"]);
            var capacidade = Convert.ToInt32(reader["CAPACIDADE"]);
            var automatico = Convert.ToBoolean(reader["AUTOMATICO"]);
            var id_categoria = Convert.ToInt32(reader["ID_CATEGORIA"]);
            var tipoCombustivel = Convert.ToInt32(reader["TIPO_COMBUSTIVEL"]);
            var quilometragem = Convert.ToInt32(reader["QUILOMETRAGEM"]);
            var capacidadeTanque = Convert.ToInt32(reader["CAPACIDADE_TANQUE"]);
            var foto = ((byte[])reader["FOTO"]).ToImage();

            var categoria = new CategoriaDAO().GetById(id_categoria);

            return new Veiculo(modelo, marca, ano, placa, quilometragem, capacidade, portas, chassi, porta_malas, capacidadeTanque, foto, automatico, categoria, (TipoCombustivel)tipoCombustivel)
            {
                Id = id
            };
        }
        public List<Veiculo> GetDisponiveis()
        {
            return Db.GetAll(sqlSelecionarVeiculoDisponivel, ConverterEmEntidade);
        }
        public override Dictionary<string, object> ObterParametrosRegistro(Veiculo veiculo)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", veiculo.Id },
                { "MODELO", veiculo.Modelo },
                { "MARCA", veiculo.Marca },
                { "ANO", veiculo.Ano },
                { "PLACA", veiculo.Placa },
                { "CAPACIDADE", veiculo.Capacidade },
                { "PORTAS", veiculo.Portas },
                { "CHASSI", veiculo.Chassi },
                { "PORTA_MALAS", veiculo.PortaMalas },
                { "FOTO", veiculo.Foto.ToByteArray()  },
                { "AUTOMATICO", veiculo.Automatico },
                { "ID_CATEGORIA", veiculo.Categoria.Id },
                { "QUILOMETRAGEM", veiculo.Quilometragem },
                { "CAPACIDADE_TANQUE", veiculo.CapacidadeTanque },
                { "TIPO_COMBUSTIVEL", veiculo.TipoDeCombustivel }
            };

            return parametros;
        }
    }
}