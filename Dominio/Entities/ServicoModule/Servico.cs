using Dominio.Shared;

namespace Dominio.ServicoModule
{
    public class Servico : Entidade
    {
        public Servico(string nome, double taxa)
        {
            Nome = nome;
            Taxa = taxa;
        }
        public Servico()
        {
        }

        public string Nome { get; set; }
        public double Taxa { get; set; }
        public override string Validar()
        {
            string resultadoValidacao = "";

            if (string.IsNullOrEmpty(Nome))
                resultadoValidacao = "O Campo Nome é Obrigatorio\n";

            if (Taxa <= 0)
                resultadoValidacao += "O Campo Taxa está inválido";

            return resultadoValidacao;
        }
        public override string ToString()
        {
            return $"{Nome} | R${Taxa}";
        }
    }
}