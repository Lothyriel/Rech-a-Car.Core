namespace Dominio.PessoaModule
{
    public abstract class Condutor : PessoaFisica
    {
        public virtual CNH Cnh { get; set; }

        public override string Validar()
        {
            string validacao = base.Validar();

            validacao += Cnh.Validar();

            return validacao;
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
