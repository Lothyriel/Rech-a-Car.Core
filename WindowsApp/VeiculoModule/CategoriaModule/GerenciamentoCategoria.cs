using Dominio.VeiculoModule;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.VeiculoModule.CategoriaModule
{
    public partial class GerenciamentoCategoria : GerenciamentoEntidade<Categoria>
    {
        public GerenciamentoCategoria() : base("Gerenciamento de Grupos")
        {
        }

        protected override CadastroEntidade<Categoria> Cadastro => new CadastroCategoria();

        public override DataGridViewColumn[] ConfigurarColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},
                new DataGridViewTextBoxColumn { DataPropertyName = "PrecoDiaria", HeaderText = "Diária"},
                new DataGridViewTextBoxColumn { DataPropertyName = "PrecoKm", HeaderText = "Preço/Km"},
                new DataGridViewTextBoxColumn { DataPropertyName = "PrecoLivre", HeaderText = "Preco Livre"},
                new DataGridViewTextBoxColumn { DataPropertyName = "QuilometragemFranquia", HeaderText = "Franquia(Km)"},
                new DataGridViewTextBoxColumn { DataPropertyName = "TipoDeCnh", HeaderText = "Tipo CNH"}
            };
        }
        public override object[] ObterCamposLinha(Categoria categoria)
        {
            return new List<object>()
            {
                categoria.Nome,
                categoria.PrecoDiaria,
                categoria.PrecoKm,
                categoria.PrecoLivre,
                categoria.QuilometragemFranquia,
                categoria.TipoDeCnh
            }.ToArray();
        }

        protected override IVisualizavel Visualizar(Categoria entidade)
        {
            return new VisualizarCategoria();
        }
    }
}
