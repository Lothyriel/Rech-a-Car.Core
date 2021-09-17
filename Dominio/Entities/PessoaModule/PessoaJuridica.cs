namespace Dominio.PessoaModule
{
    public abstract class PessoaJuridica : Pessoa
    {
        protected override string ValidaDocumento()
        {
            string validador = string.Empty;
            if (Documento.Length != 14)
                validador += "O cliente necessita de um CNPJ válido.\n";

            return validador;
        }
    }
}
