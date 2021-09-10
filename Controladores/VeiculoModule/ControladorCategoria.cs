using Controladores.Shared;
using Dominio.PessoaModule;
using Dominio.VeiculoModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controladores.VeiculoModule
{
    public class ControladorCategoria : ControladorEntidade<Categoria>
    {
        #region Queries
        private const string sqlSelecionarGrupoPorId =
            @"SELECT *
             FROM
                [TBCATEGORIA]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosGrupos =
            @"SELECT *
             FROM
                [TBCATEGORIA]";

        private const string sqlInserirGrupo =
            @"INSERT INTO [TBCATEGORIA]
                (
                    [QUILOMETRAGEM_FRANQUIA],
                    [PRECO_KM],
                    [PRECO_DIARIA],
                    [TIPO_CNH],
                    [PRECO_LIVRE],
                    [NOME]
                )
            VALUES
                (
                    @QUILOMETRAGEM_FRANQUIA,
                    @PRECO_KM,
                    @PRECO_DIARIA,
                    @TIPO_CNH,
                    @PRECO_LIVRE,
                    @NOME
                )";

        private const string sqlEditarGrupo =
                @" UPDATE [TBCATEGORIA]
                SET     
                    [QUILOMETRAGEM_FRANQUIA] = @QUILOMETRAGEM_FRANQUIA,             
                    [PRECO_KM] = @PRECO_KM,
                    [PRECO_DIARIA] = @PRECO_DIARIA,
                    [TIPO_CNH] = @TIPO_CNH,
                    [PRECO_LIVRE] = @PRECO_LIVRE,
                    [NOME] = @NOME
                WHERE [ID] = @ID";

        private const string sqlExcluirGrupo =
                @" DELETE FROM [TBCATEGORIA] WHERE [ID] = @ID";

        private const string sqlExisteGrupo =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCATEGORIA]
            WHERE 
                [ID] = @ID";

        #endregion

        public override string sqlSelecionarPorId => sqlSelecionarGrupoPorId;
        public override string sqlSelecionarTodos => sqlSelecionarTodosGrupos;
        public override string sqlInserir => sqlInserirGrupo;
        public override string sqlEditar => sqlEditarGrupo;
        public override string sqlExcluir => sqlExcluirGrupo;
        public override string sqlExists => sqlExisteGrupo;

        public override Dictionary<string, object> ObterParametrosRegistro(Categoria categoria)
        {
            var parametros = new Dictionary<string, object>
                {
                { "ID", categoria.Id },
                { "QUILOMETRAGEM_FRANQUIA", categoria.QuilometragemFranquia },
                { "PRECO_KM", categoria.PrecoKm },
                { "PRECO_DIARIA", categoria.PrecoDiaria },
                { "NOME", categoria.Nome },
                { "PRECO_LIVRE", categoria.PrecoLivre },
                { "TIPO_CNH", categoria.TipoDeCnh },
                };

            return parametros;
        }
        public override Categoria ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var franquia = Convert.ToInt32(reader["QUILOMETRAGEM_FRANQUIA"]);
            var precokm = Convert.ToDouble(reader["PRECO_KM"]);
            var diaria = Convert.ToDouble(reader["PRECO_DIARIA"]);
            var tipoCnh = Convert.ToInt32(reader["TIPO_CNH"]);
            var precoLivre = Convert.ToDouble(reader["PRECO_LIVRE"]);
            var nome = Convert.ToString(reader["NOME"]);

            return new Categoria(nome, diaria, precokm, franquia, precoLivre, (TipoCNH)tipoCnh)
            {
                Id = id
            };
        }
    }
}
