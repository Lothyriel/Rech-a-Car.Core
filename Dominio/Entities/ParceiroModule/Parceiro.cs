using Dominio.Shared;

namespace Dominio.ParceiroModule
{
    public class Parceiro : Entidade
    {
        public Parceiro(string parceiro)
        {
            this.Nome = parceiro;
        }
        public Parceiro()
        {
        }

        public string Nome { get; set; }
        public override string Validar()
        {
            string resultadoValidacao = "";
            if (string.IsNullOrEmpty(Nome))
                resultadoValidacao = "O Nome do Parceiro é obrigatório.";

            return resultadoValidacao;
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
