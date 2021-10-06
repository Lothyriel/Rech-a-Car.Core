using Dominio.CupomModule;
using Infra.DAO.ParceiroModule;
using Infra.DAO.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace Infra.DAO.CupomModule
{
    public class CupomDAO : EntidadeDAO<Cupom>, ICupomRepository
    {
        #region 
        private const string sqlInserirCupom =
       @"INSERT INTO TBCUPONS
	                (	
		                [NOME], 
		                [VALOR_PERCENTUAL], 
		                [VALOR_FIXO],
                        [DATA_VALIDADE],
                        [IDPARCEIRO],
                        [USOS],
                        [VALOR_MINIMO]
	                )
	                VALUES
	                (
                        @NOME, 
		                @VALOR_PERCENTUAL, 
		                @VALOR_FIXO,
                        @DATA_VALIDADE,
                        @IDPARCEIRO,
                        @USOS,
                        @VALOR_MINIMO
	                )";

        private const string sqlEditarCupom =
        @"UPDATE TBCUPONS
                    SET
                        [NOME] = @NOME, 
		                [VALOR_PERCENTUAL] = @VALOR_PERCENTUAL, 
		                [VALOR_FIXO] = @VALOR_FIXO,
                        [DATA_VALIDADE] = @DATA_VALIDADE,
                        [IDPARCEIRO] = @IDPARCEIRO,
                        [USOS] = @USOS,
                        [VALOR_MINIMO] = @VALOR_MINIMO
                     
                    WHERE 
                        ID = @ID";

        private const string sqlExcluirCupom =
        @"DELETE 
	                FROM
                        TBCUPONS
                    WHERE 
                        ID = @ID";

        private const string sqlExisteCupom =
         @"SELECT 
                    COUNT(*) 
                FROM 
                    [TBCUPONS]
                WHERE 
                    [ID] = @ID";

        private const string sqlSelecionarTodosCupons =
        @"SELECT * FROM TBCUPONS";

        private const string sqlSelecionarTodosCuponsOrdenadosPorUso =
        @"SELECT * FROM TBCUPONS ORDER BY [USOS] DESC";


        private const string sqlSelecionarCupomPorId =
                @"SELECT *
	                FROM
                        TBCUPONS
                    WHERE 
                        ID = @ID";

        private const string sqlSelecionarCupomPorNome =
                @"SELECT *
	                FROM
                        [TBCUPONS]
                    WHERE 
                        [NOME] = @NOME";


        #endregion

        public override string sqlSelecionarPorId => sqlSelecionarCupomPorId;
        public override string sqlSelecionarTodos => sqlSelecionarTodosCupons;
        public override string sqlInserir => sqlInserirCupom;
        public override string sqlEditar => sqlEditarCupom;
        public override string sqlExcluir => sqlExcluirCupom;
        public override string sqlExists => sqlExisteCupom;

        public override List<Cupom> Registros => OrdenadoPorUsos();
        public List<Cupom> OrdenadoPorUsos()
        {
            return Db.GetAll(sqlSelecionarTodosCuponsOrdenadosPorUso, ConverterEmEntidade);
        }
        public override Cupom ConverterEmEntidade(IDataReader reader)
        {
            int id = Convert.ToInt32(reader["ID"]);
            string nome = Convert.ToString(reader["NOME"]);
            int valor_Percentual = Convert.ToInt32(reader["VALOR_PERCENTUAL"]);
            double valor_Fixo = Convert.ToDouble(reader["VALOR_FIXO"]);
            DateTime data = Convert.ToDateTime(reader["DATA_VALIDADE"]);
            int idParceiro = Convert.ToInt32(reader["IDPARCEIRO"]);
            int usos = Convert.ToInt32(reader["USOS"]);
            double valorMinimo = Convert.ToDouble(reader["VALOR_MINIMO"]);

            var parceiro = new ParceiroDAO().GetById(idParceiro);

            return new Cupom(nome, valor_Percentual, valor_Fixo, data, parceiro, valorMinimo, usos)
            {
                Id = id
            };
        }
        public override Dictionary<string, object> ObterParametrosRegistro(Cupom cupom)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", cupom.Id },
                { "NOME", cupom.Nome },
                { "VALOR_PERCENTUAL", cupom.ValorPercentual },
                { "VALOR_FIXO", cupom.ValorFixo },
                { "DATA_VALIDADE", cupom.DataValidade },
                { "IDPARCEIRO", cupom.Parceiro.Id },
                { "USOS", cupom.Usos },
                { "VALOR_MINIMO", cupom.ValorMinimo }
            };
            return parametros;
        }
        public Cupom GetByName(string nome)
        {
            return Db.Get(sqlSelecionarCupomPorNome, ConverterEmEntidade, Db.AdicionarParametro("NOME", nome));
        }
    }
}
