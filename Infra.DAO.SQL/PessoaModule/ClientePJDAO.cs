using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Shared;
using Infra.DAO.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace Infra.DAO.PessoaModule
{
    public class ClientePJDAO : EntidadeDAO<ClientePJ>, IClientePJRepository
    {
        #region Queries
        private const string sqlInserirClientePJ =
    @"INSERT INTO [TBCLIENTEPJ]
                (
                    [NOME],       
                    [TELEFONE],             
                    [ENDERECO],
                    [EMAIL],
                    [DOCUMENTO]
                )
            VALUES
                (
                    @NOME,       
                    @TELEFONE,             
                    @ENDERECO,
                    @EMAIL,
                    @DOCUMENTO
                )";

        private const string sqlEditarClientePJ =
            @" UPDATE [TBCLIENTEPJ]
                SET 
                    [NOME] = @NOME,       
                    [TELEFONE] = @TELEFONE,             
                    [ENDERECO] = @ENDERECO,
                    [EMAIL] = @EMAIL,
                    [DOCUMENTO] = @DOCUMENTO
                WHERE [ID] = @ID";

        private const string sqlExcluirClientePJ =
            @"DELETE FROM [TBCLIENTEPJ] 
                WHERE [ID] = @ID";

        private const string sqlSelecionarClientePJPorId =
            @"SELECT TBClientePJ.ID,TBClientePJ.EMAIL, TBClientePJ.NOME, TBClientePJ.TELEFONE, TBClientePJ.ENDERECO, TBClientePJ.DOCUMENTO, 
            TBMotorista.ID AS ID_MOTORISTA, TBMotorista.NOME AS NOME_MOTORISTA, TBMotorista.TELEFONE AS TELEFONE_MOTORISTA, 
                  TBMotorista.ENDERECO AS ENDERECO_MOTORISTA, TBMotorista.DOCUMENTO AS DOCUMENTO_MOTORISTA, TBMotorista.ID_CNH, TBMotorista.ID_EMPRESA
            FROM     
                  TBClientePJ LEFT JOIN
                  TBMotorista ON TBClientePJ.ID = TBMotorista.ID_EMPRESA
             WHERE 
                TBClientePJ.[ID] = @ID";

        private const string sqlSelecionarTodosClientePJ =
            @"SELECT TBClientePJ.ID,TBClientePJ.EMAIL, TBClientePJ.NOME, TBClientePJ.TELEFONE, TBClientePJ.ENDERECO, TBClientePJ.DOCUMENTO, 
                TBMotorista.ID AS ID_MOTORISTA, TBMotorista.NOME AS NOME_MOTORISTA, TBMotorista.TELEFONE AS TELEFONE_MOTORISTA, 
                  TBMotorista.ENDERECO AS ENDERECO_MOTORISTA, TBMotorista.DOCUMENTO AS DOCUMENTO_MOTORISTA, TBMotorista.ID_CNH, TBMotorista.ID_EMPRESA
              FROM     
                  TBClientePJ LEFT JOIN
                  TBMotorista ON TBClientePJ.ID = TBMotorista.ID_EMPRESA";

        private const string sqlExisteClientePJ =
            @"SELECT 
                COUNT(*) 
            FROM 
                [TBCLIENTEPJ]
            WHERE 
                [ID] = @ID";

        #endregion
        public override string sqlSelecionarPorId => sqlSelecionarClientePJPorId;
        public override string sqlSelecionarTodos => sqlSelecionarTodosClientePJ;
        public override string sqlInserir => sqlInserirClientePJ;
        public override string sqlEditar => sqlEditarClientePJ;
        public override string sqlExcluir => sqlExcluirClientePJ;
        public override string sqlExists => sqlExisteClientePJ;

        public IRepository<Motorista> MotoristaRepository => new MotoristaDAO();

        public override ClientePJ ConverterEmEntidade(IDataReader reader)
        {
            var id = Convert.ToInt32(reader["ID"]);
            var nome = Convert.ToString(reader["NOME"]);
            var telefone = Convert.ToString(reader["TELEFONE"]);
            var documento = Convert.ToString(reader["DOCUMENTO"]);
            var endereco = Convert.ToString(reader["ENDERECO"]);
            var email = Convert.ToString(reader["EMAIL"]);


            var empresa = new ClientePJ(nome, telefone, endereco, documento, email)
            {
                Id = id,
            };

            var motoristas = new List<Motorista>();

            do
            {
                if (reader.IsDBNull(reader.GetOrdinal("ID_MOTORISTA")))
                    break;

                var id_motorista = Convert.ToInt32(reader["ID_MOTORISTA"]);
                var nome_motorista = Convert.ToString(reader["NOME_MOTORISTA"]);
                var telefone_motorista = Convert.ToString(reader["TELEFONE_MOTORISTA"]);
                var endereco_motorista = Convert.ToString(reader["ENDERECO_MOTORISTA"]);
                var documento_motorista = Convert.ToString(reader["DOCUMENTO_MOTORISTA"]);

                var id_cnh = Convert.ToInt32(reader["ID_CNH"]);
                var cnh = new CnhDAO().GetById(id_cnh);

                motoristas.Add(new Motorista(nome_motorista, telefone_motorista, endereco_motorista, documento_motorista, cnh, empresa)
                {
                    Id = id_motorista
                });

            } while (reader.Read());
            empresa.Motoristas = motoristas;

            return empresa;
        }
        public override Dictionary<string, object> ObterParametrosRegistro(ClientePJ cliente)
        {
            var parametros = new Dictionary<string, object>
            {
                { "ID", cliente.Id },
                { "NOME", cliente.Nome },
                { "ENDERECO", cliente.Endereco },
                { "TELEFONE", cliente.Telefone },
                { "DOCUMENTO", cliente.Documento },
                { "EMAIL", cliente.Email },
            };

            return parametros;
        }
    }
    public class MotoristaDAO : DAO<Motorista>, IRepository<Motorista>
    {

        #region Queries
        private const string sqlSelecionarMotoristaPorId =
            @"SELECT *
             FROM
                [TBMOTORISTA]
             WHERE 
                [ID] = @ID";

        private const string sqlInserirMotorista =
            @"INSERT INTO [TBMOTORISTA]
                (
                    [NOME],
                    [TELEFONE],
                    [ENDERECO],
                    [DOCUMENTO],
                    [ID_EMPRESA],
                    [ID_CNH]
                )
            VALUES
                (
                    @NOME,
                    @TELEFONE,
                    @ENDERECO,
                    @DOCUMENTO,
                    @ID_EMPRESA,
                    @ID_CNH
                )";

        private const string sqlEditarMotorista =
                @"UPDATE [TBMOTORISTA]
                    SET     
                    [NOME] = @NOME,             
                    [TELEFONE] = @TELEFONE,
                    [ENDERECO] = @ENDERECO,
                    [DOCUMENTO] = @DOCUMENTO,
                    [ID_CNH] = @ID_CNH
                    WHERE [ID] = @ID";

        private const string sqlExcluirMotorista =
            @"DELETE FROM [TBMOTORISTA] 
                            WHERE [ID] = @ID";

        public override List<Motorista> Registros => throw new NotImplementedException();

        #endregion

        public override void Inserir(Motorista motorista)
        {
            new CnhDAO().Inserir(motorista.Cnh);
            motorista.Id = Db.Insert(sqlInserirMotorista, ObterParametrosMotorista(motorista));
        }

        public override void Editar(int id, Motorista motorista)
        {
            new CnhDAO().Editar(motorista.Cnh.Id, motorista.Cnh);
            motorista.Id = id;
            Db.Update(sqlEditarMotorista, ObterParametrosMotorista(motorista));
        }

        public override void Excluir(int id_motorista, Type tipo = null)
        {
            Db.Delete(sqlExcluirMotorista, Db.AdicionarParametro("ID", id_motorista));
        }

        public override Motorista GetById(int id, Type tipo = null)
        {
            throw new NotSupportedException();
        }

        protected static Dictionary<string, object> ObterParametrosMotorista(Motorista motorista)
        {
            var parametros = new Dictionary<string, object>
                {
                { "ID", motorista.Id },
                { "NOME", motorista.Nome },
                { "TELEFONE", motorista.Telefone },
                { "ENDERECO", motorista.Endereco },
                { "DOCUMENTO", motorista.Documento },
                { "ID_CNH", motorista.Cnh.Id },
                { "ID_EMPRESA", motorista.Empresa.Id }
                };

            return parametros;
        }

        public override bool Existe(int id, Type tipo = null)
        {
            throw new NotImplementedException();
        }
    }
}