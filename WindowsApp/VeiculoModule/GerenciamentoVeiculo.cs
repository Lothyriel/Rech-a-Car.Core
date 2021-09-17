using Dominio.AluguelModule;
using Dominio.VeiculoModule;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.AluguelModule;
using WindowsApp.Shared;

namespace WindowsApp.VeiculoModule
{
    public class GerenciamentoVeiculo : GerenciamentoEntidade<Veiculo>
    {
        private Aluguel Aluguel { get; }
        public GerenciamentoVeiculo(string titulo = "Gerenciamento de Veículo", TipoTela tipo = TipoTela.CadastroBasico, Aluguel aluguel = null) : base(titulo, tipo)
        {
            Aluguel = aluguel;
            if (tipo == TipoTela.ApenasConfirma)
                AtualizarRegistros(Cadastro.Services.Repositorio.GetDisponiveis());      //da pra melhorar isso aq, e os overrides, pq o programa acaba dando muitas voltas e instanciando coisas q nem vai usar
        }
        protected override CadastroVeiculo Cadastro => new CadastroVeiculo();
        protected override void SalvarAluguel()
        {
            Aluguel.Veiculo = GetEntidadeSelecionado();
            TelaPrincipal.Instancia.FormAtivo = new ResumoAluguel(Aluguel);
        }
        public override DataGridViewColumn[] ConfigurarColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Marca", HeaderText = "Marca"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Modelo", HeaderText = "Modelo"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Ano", HeaderText = "Ano"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Categoria", HeaderText = "Categoria"},
                new DataGridViewTextBoxColumn { DataPropertyName = "Diária", HeaderText = "Diária"},
                new DataGridViewTextBoxColumn { DataPropertyName = "PrecoKm", HeaderText = "Preço/Km"}
            };
        }
        public override object[] ObterCamposLinha(Veiculo veiculo)
        {
            List<object> linha = new List<object>()
            {
                veiculo.Marca,
                veiculo.Modelo,
                veiculo.Ano,
                veiculo.Categoria,
                veiculo.Categoria.PrecoDiaria,
                veiculo.Categoria.PrecoKm
            };
            return linha.ToArray();
        }

        protected override IVisualizavel Visualizar(Veiculo entidade)
        {
            return new VisualizarVeiculo();
        }
    }
}
