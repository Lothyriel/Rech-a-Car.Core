using Controladores.Shared;
using Dominio.PessoaModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controladores.PessoaModule
{
    public class ControladorFuncionario : ControladorEntidade<Funcionario>
    {
        #region Queries
        private const string sqlInserirFuncionario =
    @"INSERT INTO [TBFUNCIONARIO]
                (
                    [NOME],       
                    [TELEFONE],             
                    [ENDERECO],
                    [DOCUMENTO],
                    [FOTO],
                    [CARGO],
                    [USER]
                )
            VALUES
                (
                    @NOME,       
                    @TELEFONE,             
                    @ENDERECO,
                    @DOCUMENTO,
                    @FOTO,
                    @CARGO,
                    @USER
                )";

        private const string sqlEditarFuncionario =
            @" UPDATE [TBFUNCIONARIO]
                SET 
                    [NOME] = @NOME,       
                    [TELEFONE] = @TELEFONE,             
                    [ENDERECO] = @ENDERECO,
                    [DOCUMENTO] = @DOCUMENTO,
                    [CARGO] = @CARGO,
                    [FOTO] = @FOTO,
                    [USER] = @USER
                WHERE [ID] = @ID";

        private const string sqlExcluirFuncionario =
            @"DELETE FROM [TBFUNCIONARIO] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarFuncionario =
            @"SELECT *
             FROM
                [TBFUNCIONARIO]
             WHERE 
                [ID] = @ID";

        private const string sqlSelecionarTodosFuncionarios =
            @"SELECT *
             FROM
                [TBFUNCIONARIO]";

        private const string sqlExisteFuncionario =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBFUNCIONARIO]
            WHERE 
                [ID] = @ID";

        private const string sqlExisteFuncionarioPorUser =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBFUNCIONARIO]
            WHERE 
                [USER] = @USER";

        private const string sqlGetFuncionarioPorUser =
            @"SELECT * 
            FROM 
                [TBFUNCIONARIO]
            WHERE 
                [USER] = @USER";

        #endregion
        public override string sqlSelecionarPorId => sqlSelecionarFuncionario;
        public override string sqlSelecionarTodos => sqlSelecionarTodosFuncionarios;
        public override string sqlInserir => sqlInserirFuncionario;
        public override string sqlEditar => sqlEditarFuncionario;
        public override string sqlExcluir => sqlExcluirFuncionario;
        public override string sqlExists => sqlExisteFuncionario;

        public override void Inserir(Funcionario entidade)
        {
            base.Inserir(entidade);
            ControladorSenha.Inserir(entidade.Id, entidade.Senha);
        }
        public override void Editar(int id, Funcionario entidade)
        {
            base.Editar(id, entidade);
            ControladorSenha.Editar(entidade.Id, entidade.Senha);
        }
        public override Funcionario ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var nome = Convert.ToString(reader["NOME"]);
            var telefone = Convert.ToString(reader["TELEFONE"]);
            var documento = Convert.ToString(reader["DOCUMENTO"]);
            var cargo = Convert.ToInt32(reader["CARGO"]);
            var endereco = Convert.ToString(reader["ENDERECO"]);
            var user = Convert.ToString(reader["USER"]);
            var foto = RecuperarImagem((byte[])reader["FOTO"]);

            return new Funcionario(nome, telefone, endereco, documento, (Cargo)cargo, foto, user)
            {
                Id = id
            };
        }
        public override Dictionary<string, object> ObterParametrosRegistro(Funcionario funcionario)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", funcionario.Id },
                { "NOME", funcionario.Nome },
                { "ENDERECO", funcionario.Endereco },
                { "TELEFONE", funcionario.Telefone },
                { "CARGO", funcionario.Cargo },
                { "DOCUMENTO", funcionario.Documento },
                { "USER", funcionario.NomeUsuario },
                { "SENHA", funcionario.Senha},
                { "FOTO", SalvarImagem(funcionario.Foto) }
            };

            return parametros;
        }
        public bool ExisteUsuario(string usuario)
        {
            return Db.Exists(sqlExisteFuncionarioPorUser, Db.AdicionarParametro("USER", usuario));
        }
        public Funcionario GetByUserName(string usuario)
        {
            return Db.Get(sqlGetFuncionarioPorUser, ConverterEmEntidade, Db.AdicionarParametro("USER", usuario));
        }
    }
}
