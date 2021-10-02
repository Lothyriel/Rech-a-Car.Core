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
        }

        private void PopularCampos()
        {
            var services = ConfigServices.Services;
            lbAlugueisAbertos.Text = $"{services.AluguelServices.Registros.Count}";

            lbClientesCadastrados.Text = $"{services.ClienteServices.Registros.Count}";
            lbVeiculosCadastrados.Text = $"{services.VeiculoServices.Registros.Count}";

            var cupom = services.CupomServices.Registros.First();
            lbCupom.Text = $"{cupom.Nome}";
            lbUsos.Text = $"{cupom.Usos}";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy   HH:mm");
        }
    }
}
