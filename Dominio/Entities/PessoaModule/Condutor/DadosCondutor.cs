using Dominio.PessoaModule.Condutor;
using Dominio.Shared;
using System.Collections.Generic;

namespace Dominio.Entities.PessoaModule.Condutor
{
    public class DadosCondutor : Entidade
    {
        public DadosCondutor(CNH cnh, List<Multa> multas = null)
        {
            Cnh = cnh;
            Multas = multas ?? new List<Multa>();
        }
        public DadosCondutor()
        {

        }

        public virtual CNH Cnh { get; init; }
        public virtual List<Multa> Multas { get; init; }

        public override string Validar()
        {
            return Cnh.Validar();
        }
    }
}