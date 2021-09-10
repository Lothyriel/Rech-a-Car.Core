using Controladores.ServicoModule;
using Controladores.Shared;
using Dominio.AluguelModule;
using Dominio.ServicoModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controladores.AluguelModule
{
    public class ControladorAluguelFechado : Controlador<AluguelFechado>
    {
        private ControladorAluguel Controlador = new ControladorAluguel();

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
            new ControladorServico().DesalugarServicosAlugados(id);
        }

        public override void Excluir(int id, Type tipo = null)
        {
            throw new NotSupportedException();
        }

        public override AluguelFechado GetById(int id, Type tipo = null)
        {
            throw new NotSupportedException();
        }

        public override void Inserir(AluguelFechado entidade)
        {
            throw new NotSupportedException();
        }

        protected override List<AluguelFechado> ObterRegistros()
        {
            return Db.GetAll(sqlGetAlugueisFechados, ConverterEmEntidade);
        }

        private AluguelFechado ConverterEmEntidade(IDataReader reader)
        {
            var aluguel = Controlador.ConverterEmEntidade(reader);

            var tanqueUtilizado = Convert.ToDouble(reader["TANQUE_UTILIZADO"]);
            var kmRodados = Convert.ToInt32(reader["KM_RODADOS"]);
            var dataDevolvida = Convert.ToDateTime(reader["DATA_DEVOLVIDA"]);

            var servicosNecessarios = new List<Servico>();

            return new AluguelFechado(aluguel, kmRodados, tanqueUtilizado, servicosNecessarios, dataDevolvida);
        }

        private Dictionary<string, object> ObterParametrosRegistro(AluguelFechado aluguel)
        {
            return new Dictionary<string, object>
            {
                { "DATA_DEVOLVIDA", aluguel.DataDevolvida },
                { "TANQUE_UTILIZADO", aluguel.TanqueUtilizado },
                { "KM_RODADOS", aluguel.KmRodados },
                { "TOTAL", aluguel.CalcularTotal() },
            };
        }
    }
}