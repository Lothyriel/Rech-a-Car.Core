using Dominio.Shared;

namespace Dominio.PessoaModule
{
    public abstract class TipoPessoa : Entidade
    {
        public TipoPessoa()
        {

        }

        public static CPF PessoaFisica = new CPF();
        public static CNPJ PessoaJuridica = new CNPJ();

        public string Documento { get; set; }
    }
    public class CPF : TipoPessoa
    {
        public CPF()
        {

        }
        public override string Validar()
        {
            string validador = string.Empty;
            if (Documento.Length != 11)
                validador += "O cliente necessita de um CPF válido.\n";

            return validador;
        }
    }
    public class CNPJ : TipoPessoa
    {
        public CNPJ()
        {

        }
        public override string Validar()
        {
            string validador = string.Empty;
            if (Documento.Length != 14)
                validador += "O cliente necessita de um CNPJ válido.\n";

            return validador;
        }
    }
}