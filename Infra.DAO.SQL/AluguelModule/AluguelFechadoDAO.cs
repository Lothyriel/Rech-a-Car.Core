using ConfigurationManager;
using Dominio.AluguelModule;
using Dominio.Repositories;
using Dominio.ServicoModule;
using Infra.DAO.Shared;
using System;
using System.Collections.Generic;
using System.Data;

namespace Infra.DAO.AluguelModule
{
    public class AluguelFechadoDAO : DAO<AluguelFechado>, IAluguelFechadoRepository
    {
        private AluguelDAO AluguelDAO = new();

        private const string sqlGetAlugueisFechados =
            @"SELECT *
             FROM
                [TBALUGUEL]
             WHERE
                [DATA_DEVOLVIDA] != NULL
            AND
                [ID] = @ID";

        private const string sqlFecharAluguel =
            @" UPDATE [TBALUGUEL]
                SET 
                    [DATA_DEVOLVIDA] = @DATA_DEVOLVIDA,       
                    [TANQUE_UTILIZADO] = @TANQUE_UTILIZADO,             
                    [KM_RODADOS] = @KM_RODADOS,
                    [TOTAL] = @TOTAL      
                WHERE [ID] = @ID";

        public override void Editar(int id, AluguelFechado entidade)
        {
            entidade.Id = id;
            Db.Update(sqlFecharAluguel, Db.AdicionarParametro("ID", id, ObterParametrosRegistro(entidade)));
        }

        public override bool Excluir(int id, Type tipo = null)
        {
            throw new NotSupportedException();
        }

        public override AluguelFechado GetById(int id, Type tipo = null)
        {
            throw new NotSupportedException();
        }
        public override bool Existe(int id, Type tipo = null)
        {
            throw new NotSupportedException();
        }

        public override void Inserir(AluguelFechado entidade)
        {
            throw new NotSupportedException();
        }

        public override List<AluguelFechado> Registros => Db.GetAll(sqlGetAlugueisFechados, ConverterEmEntidade);

        private AluguelFechado ConverterEmEntidade(IDataReader reader)
        {
            var aluguel = AluguelDAO.ConverterEmEntidade(reader);

            var tanqueUtilizado = Convert.ToDouble(reader["TANQUE_UTILIZADO"]);
            var kmRodados = Convert.ToInt32(reader["KM_RODADOS"]);
            var dataDevolvida = Convert.ToDateTime(reader["DATA_DEVOLVIDA"]);

            var servicosNecessarios = new List<Servico>();

            return new AluguelFechado(aluguel, kmRodados, tanqueUtilizado, servicosNecessarios, dataDevolvida);
        }
        private static Dictionary<string, object> ObterParametrosRegistro(AluguelFechado aluguel)
        {
            return new Dictionary<string, object>
            {
                { "DATA_DEVOLVIDA", aluguel.DataDevolvida },
                { "TANQUE_UTILIZADO", aluguel.TanqueUtilizado },
                { "KM_RODADOS", aluguel.KmRodados },
                { "TOTAL", aluguel.CalcularTotal(ConfigsAluguel.Configs) },
            };
        }
    }
}