using Applicacao.VeiculoModule;
using Dominio.PessoaModule;
using Dominio.VeiculoModule;
using System;
using System.Linq;
using WindowsApp.Shared;
using Applicacao.ServicosModule;

namespace WindowsApp.VeiculoModule.CategoriaModule
{
    public partial class CadastroCategoria : CadastroEntidade<Categoria>//Form//
    {
        public override CategoriaAppServices Services { get; }

        public CadastroCategoria()
        {
            Services = new CategoriaAppServices();
            InitializeComponent();
            PreencherCbCnh();
            cbCNH.SelectedIndex = 1;
        }

        private void PreencherCbCnh()
        {
            var tipos = ((TipoCNH[])Enum.GetValues(typeof(TipoCNH))).ToList();
            tipos.Remove(TipoCNH.AB);

            foreach (var item in tipos)
                cbCNH.Items.Add(item);
        }

        protected override IEditavel Editar()
        {
            tbNome.Text = entidade.Nome;
            tbDiaria.Text = entidade.PrecoDiaria.ToString();
            tbKm.Text = entidade.PrecoKm.ToString();
            tbFranquia.Text = entidade.QuilometragemFranquia.ToString();
            tbLivre.Text = entidade.PrecoLivre.ToString();
            cbCNH.SelectedItem = entidade.TipoDeCnh;

            return this;
        }
        public override Categoria GetNovaEntidade()
        {
            var nome = tbNome.Text;
            Double.TryParse(tbDiaria.Text, out double diaria);
            Double.TryParse(tbKm.Text, out double km);
            Int32.TryParse(tbFranquia.Text, out int franquia);
            Double.TryParse(tbLivre.Text, out double livre);
            var tipocnh = cbCNH.SelectedItem;

            return new Categoria(nome, diaria, km, franquia, livre, (TipoCNH)tipocnh);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (Salva())
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoCategoria();
        }
    }
}