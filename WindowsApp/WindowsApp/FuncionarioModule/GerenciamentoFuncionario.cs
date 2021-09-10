using Dominio.PessoaModule;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.FuncionarioModule
{
    public class GerenciamentoFuncionario : GerenciamentoEntidade<Funcionario>
    {
        public GerenciamentoFuncionario(string titulo = "Gerenciamento de Funcionário", TipoTela tipo = TipoTela.CadastroBasico) : base(titulo, tipo)
        {
        }

        protected override CadastroEntidade<Funcionario> Cadastro => new CadastroFuncionario();
        public override DataGridViewColumn[] ConfigurarColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Endereco", HeaderText = "Endereco"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Documento", HeaderText = "Documento"},
            };
        }
        public override object[] ObterCamposLinha(Funcionario funcionario)
        {
            List<object> linha = new List<object>()
            {
                funcionario.Nome,
                funcionario.Telefone,
                funcionario.Endereco,
                funcionario.Documento,
            };
            return linha.ToArray();
        }

        protected override IVisualizavel Visualizar(Funcionario entidade)
        {
            return new VisualizarFuncionario();
        }
    }
}
