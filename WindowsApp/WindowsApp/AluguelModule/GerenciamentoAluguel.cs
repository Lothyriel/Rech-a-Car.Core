using Dominio.AluguelModule;
using Dominio.PessoaModule.ClienteModule;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.AluguelModule
{
    public partial class GerenciamentoAluguel : GerenciamentoEntidade<Aluguel>
    {
        public GerenciamentoAluguel(string titulo = "Gerenciamento de Aluguel", TipoTela tipo = TipoTela.CadastroBasico) : base(titulo, tipo)
        {
            InitializeComponent();
        }
        protected override CadastroEntidade<Aluguel> Cadastro => new ResumoAluguel();

        public override DataGridViewColumn[] ConfigurarColunas()
        {
            return new DataGridViewColumn[]
            {
            new DataGridViewTextBoxColumn { DataPropertyName = "Veiculo", HeaderText = "Veículo"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Cliente", HeaderText = "Cliente"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Condutor", HeaderText = "Condutor"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Plano", HeaderText = "Plano"},
            new DataGridViewTextBoxColumn { DataPropertyName = "DataDevolucao", HeaderText = "Devolução"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Funcionario", HeaderText = "Funcionário"},
            };
        }
        public override object[] ObterCamposLinha(Aluguel aluguel)
        {
            return new object[]
            {
                aluguel.Veiculo,
                aluguel.Cliente,
                aluguel.Condutor is ClientePF ? "-----" : aluguel.Condutor.Nome,
                aluguel.TipoPlano,
                aluguel.DataDevolucao.ToString("d"),
                aluguel.Funcionario
            };
        }
        protected override IVisualizavel Visualizar(Aluguel entidade)
        {
            return new FechamentoAluguel(GetEntidadeSelecionado());
        }
    }
}