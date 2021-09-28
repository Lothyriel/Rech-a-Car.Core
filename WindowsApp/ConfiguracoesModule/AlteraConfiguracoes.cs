using ConfigurationManager;
using System.Windows.Forms;

namespace WindowsApp.ConfiguracoesModule
{
    public partial class AlterarConfiguracoes : Form
    {
        public AlterarConfiguracoes()
        {
            InitializeComponent();

            CarregarDados();
        }

        private void CarregarDados()
        {
            var dados = ConfigAluguel.Configs;

            tb_etanol.Text = dados.ValorEtanol.ToString();
            tb_diesel.Text = dados.ValorDiesel.ToString();
            tb_gasolina.Text = dados.ValorGasolina.ToString();

            tb_caucao.Text = dados.ValorCaucao.ToString();
        }
        private void SalvarDados()
        {
            var mensagem = "Sucesso";

            if (!ConfigAluguel.SalvaValores(tb_etanol.Text, tb_diesel.Text, tb_gasolina.Text, tb_caucao.Text))
                mensagem = "Insira Dados Válidos";

            MessageBox.Show(mensagem);
        }
        private void bt_salva_Click(object sender, System.EventArgs e)
        {
            SalvarDados();
        }
    }
}
