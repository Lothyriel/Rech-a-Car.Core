using Dominio.CupomModule;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.WindowsApp.CupomModule
{
    public partial class GerenciamentoCupom : GerenciamentoEntidade<Cupom>
    {
        public GerenciamentoCupom(string titulo = "Gerenciamento de Cupons", TipoTela tipo = TipoTela.CadastroBasico) : base(titulo, tipo)
        {
        }

        protected override CadastroEntidade<Cupom> Cadastro => new CadastroCupom();

        public override DataGridViewColumn[] ConfigurarColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},
                new DataGridViewTextBoxColumn { DataPropertyName = "ValorPercentual", HeaderText = "Percentual"},
                new DataGridViewTextBoxColumn { DataPropertyName = "ValorFixo", HeaderText = "Valor Fixo"},
                new DataGridViewTextBoxColumn { DataPropertyName = "DataValidade", HeaderText = "Data Validade"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Parceiro", HeaderText = "Parceiro"},
                new DataGridViewTextBoxColumn { DataPropertyName = "ValorMinimo", HeaderText = "Valor Mínimo"}
            };
        }
        public override object[] ObterCamposLinha(Cupom cupom)
        {
            List<object> linha = new List<object>()
            {
                cupom.Nome,
                cupom.ValorPercentual,
                cupom.ValorFixo,
                cupom.DataValidade,
                cupom.Parceiro,
                cupom.ValorMinimo
            };
            return linha.ToArray();
        }

        protected override IVisualizavel Visualizar(Cupom entidade)
        {
            return new VisualizarCupom();
        }
    }
}
