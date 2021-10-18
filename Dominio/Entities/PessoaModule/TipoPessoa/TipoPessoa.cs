namespace Dominio.PessoaModule
{
    public abstract class TipoPessoa
    {
        public TipoPessoa(string documento)
        {
            Documento = documento;
        }

        public string Documento { get; set; }

        public abstract string ValidarDocumento();
    }
    public class CPF : TipoPessoa
    {
        public CPF(string documento) : base(documento)
        {
        }

        public override string ValidarDocumento()
        {
            string validador = string.Empty;
            if (Documento.Length != 11)
                validador += "O cliente necessita de um CPF válido.\n";

            return validador;
        }
    }
    public class CNPJ : TipoPessoa
    {
        public CNPJ(string documento) : base(documento)
        {
        }

        public override string ValidarDocumento()
        {
            string validador = string.Empty;
            if (Documento.Length != 14)
                validador += "O cliente necessita de um CNPJ válido.\n";

            return validador;
        }
    }
}