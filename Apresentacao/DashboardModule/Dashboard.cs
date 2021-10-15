using Aplicacao.AluguelModule;
using Aplicacao.ClienteModule;
using Aplicacao.CupomModule;
using Aplicacao.VeiculoModule;
using Dominio.CupomModule;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsApp.DashboardModule
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            PopularCampos();
            timer.Start();
            lbDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy   HH:mm");
        }

        private void PopularCampos()
        {
            lbAlugueisAbertos.Text = $"{new AluguelAppServices().Registros.Count}";

            lbClientesCadastrados.Text = $"{new ClienteAppServices().Registros.Count}";
            lbVeiculosCadastrados.Text = $"{new VeiculoAppServices().Registros.Count}";

            var cupom = new CupomAppServices().Registros.FirstOrDefault() ?? Cupom.Invalido;
            lbCupom.Text = $"{cupom.Nome}";
            lbUsos.Text = $"{cupom.Usos}";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy   HH:mm");
        }
    }
}
