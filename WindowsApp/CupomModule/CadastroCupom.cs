using Controladores.CupomModule;
using Controladores.ParceiroModule;
using Controladores.Shared;
using Dominio.CupomModule;
using Dominio.ParceiroModule;
using System;
using WindowsApp.Shared;

namespace WindowsApp.WindowsApp.CupomModule
{
    public partial class CadastroCupom : CadastroEntidade<Cupom>
    {
        public override Controlador<Cupom> Controlador { get => new ControladorCupom(); }

        public CadastroCupom()
        {
            InitializeComponent();
            cbParceiro.DataSource = new ControladorParceiro().Registros;
        }

        protected override IEditavel Editar()
        {
            tbNome.Text = entidade.Nome;
            tbValorPercentual.Text = entidade.ValorPercentual.ToString();
            tbValorFixo.Text = entidade.ValorFixo.ToString();
            tbData.Text = entidade.DataValidade.ToString();
            cbParceiro.SelectedItem = entidade.Parceiro;
            tbValorMinimo.Text = entidade.ValorMinimo.ToString();

            return this;
        }

        public override Cupom GetNovaEntidade()
        {
            var nome = tbNome.Text;
            var parceiro = (Parceiro)cbParceiro.SelectedItem;
            Int32.TryParse(tbValorPercentual.Text, out int valorPercentual);
            Double.TryParse(tbValorFixo.Text, out double valorFixo);
            DateTime.TryParse(tbData.Text, out DateTime data);
            Double.TryParse(tbValorMinimo.Text, out double valorMinimo);

            return new Cupom(nome, valorPercentual, valorFixo, data, parceiro, valorMinimo);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (!Salva(mostraSucesso: false))
                return;

            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoCupom();
        }
    }
}
