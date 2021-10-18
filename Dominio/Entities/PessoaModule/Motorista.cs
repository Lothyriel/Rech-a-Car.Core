using Dominio.Entities.PessoaModule.Condutor;
using Dominio.PessoaModule.ClienteModule;

namespace Dominio.PessoaModule
{
    public class Motorista : Pessoa, ICondutor
    {
        public Motorista(string nome, string telefone, string endereco, string documento, DadosCondutor dadosCondutor, ClientePJ empresa)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Documento = documento;
            DadosCondutor = dadosCondutor;
            Empresa = empresa;
            TipoPessoa = new CPF(documento);
        }
        public Motorista()
        {

        }
        public virtual ClientePJ Empresa { get; set; }

        public override TipoPessoa TipoPessoa { get; init; }
        public virtual DadosCondutor DadosCondutor { get; init; }

        public override string Validar()
        {
            var validacao = base.Validar();

            return validacao += DadosCondutor.Cnh.Validar();
        }

        public override string ToString()
        {
            return $"{Nome} | {Telefone}";
        }
    }
}
