using Dominio.ParceiroModule;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;
using WindowsApp.WindowsApp.ParceiroModule;

namespace WindowsApp.WindowsApp.CupomModule.ParceiroModule
{
    public partial class GerenciamentoParceiro : GerenciamentoEntidade<Parceiro>
    {
        public GerenciamentoParceiro(string titulo = "Gerenciamento de Parceiros", TipoTela tipo = TipoTela.CadastroBasico) : base(titulo, tipo)
        {
        }

        protected override CadastroEntidade<Parceiro> Cadastro => new CadastroParceiro();

        public override DataGridViewColumn[] ConfigurarColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"}
            };
        }
        public override object[] ObterCamposLinha(Parceiro parceiro)
        {
            List<object> linha = new List<object>()
            {
                parceiro.nome
            };
            return linha.ToArray();
        }

        protected override IVisualizavel Visualizar(Parceiro entidade)
        {
            return new VisualizarParceiro();
        }
    }
}
