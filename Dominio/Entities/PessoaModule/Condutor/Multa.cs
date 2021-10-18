using Dominio.Shared;

namespace Dominio.Entities.PessoaModule.Condutor
{
    public class Multa : Entidade
    {
        public string Resumo { get; init; }
        public override string Validar()
        {
            return Resumo != string.Empty ? "" : "Resumo é um campo obrigatório";
        }
    }
}