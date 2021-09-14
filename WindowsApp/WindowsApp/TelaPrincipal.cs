using Dominio.PessoaModule;
using System;
using System.Windows.Forms;
using WindowsApp.AluguelModule;
using WindowsApp.ClienteModule;
using WindowsApp.ConfiguracoesModule;
using WindowsApp.FuncionarioModule;
using WindowsApp.ServicoModule;
using WindowsApp.VeiculoModule;
using WindowsApp.VeiculoModule.CategoriaModule;
using WindowsApp.WindowsApp.CupomModule;
using WindowsApp.WindowsApp.CupomModule.ParceiroModule;

namespace WindowsApp
{
    public partial class TelaPrincipal : Form
    {
        public static TelaPrincipal Instancia;
        public Funcionario FuncionarioLogado { get; }
        private Form formAtivo;
        public TelaPrincipal(Funcionario funcionario)
        {
            FuncionarioLogado = funcionario;
            Instancia = this;
            InitializeComponent();
            EsconderSubMenu();
            lbUsuario.Text = funcionario.Nome;
            lbCargo.Text = funcionario.Cargo.ToString();
            foto_perfil.Image = funcionario.Foto;
            FuncionarioLogado = funcionario;
            if (funcionario.Cargo != Cargo.SysAdmin)
                bt_funcionarios.Visible = false;
        }

        public Form FormAtivo { set { AbrirFormPanel(value); } }

        private void EsconderSubMenu()
        {
            panelSubMenuClientes.Visible = false;
            panelSubMenuVeiculos.Visible = false;
            panelSubMenuCupons.Visible = false;
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            subMenu.Visible = !subMenu.Visible;
        }
        private void AbrirFormPanel(Form panelForm)
        {
            formAtivo?.Close();

            formAtivo = panelForm;
            formAtivo.TopLevel = false;
            formAtivo.FormBorderStyle = FormBorderStyle.None;
            formAtivo.Dock = DockStyle.Fill;

            panelFormFilho.Controls.Add(formAtivo);

            formAtivo.BringToFront();
            formAtivo.Show();
        }

        #region Eventos

        private void bt_Aluguel_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new GerenciamentoAluguel();
        }
        private void bt_GerenciarAlugueis_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new GerenciamentoAluguel();
        }
        private void bt_Veiculos_Click(object sender, EventArgs e)
        {
            panelSubMenuClientes.Visible = false;
            panelSubMenuCupons.Visible = false;
            MostrarSubMenu(panelSubMenuVeiculos);
        }
        private void bt_Servicos_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new GerenciamentoServico();
        }
        private void bt_funcionarios_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new GerenciamentoFuncionario();
        }
        private void bt_clientes_Click(object sender, EventArgs e)
        {
            panelSubMenuVeiculos.Visible = false;
            panelSubMenuCupons.Visible = false;
            MostrarSubMenu(panelSubMenuClientes);
            FormAtivo = new GerenciamentoCliente();
        }
        private void btPessoaFisica_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new CadastroClientePF();
        }

        private void btPessoaJuridica_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new CadastroClientePJ();
        }
        private void bt_sair_Click(object sender, EventArgs e)
        {
            Close();
            new Login().Show();
        }
        private void btVeiculosSubMenu_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new GerenciamentoVeiculo();
        }

        private void btGrupos_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new GerenciamentoCategoria();
        }
        private void btConfiguracoes_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new AlterarConfiguracoes();
        }
        private void btCupom_Click(object sender, EventArgs e)
        {
            panelSubMenuClientes.Visible = false;
            panelSubMenuVeiculos.Visible = false;
            MostrarSubMenu(panelSubMenuCupons);
        }
        private void btCupons_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new GerenciamentoCupom();
        }
        private void btParceiros_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
            FormAtivo = new GerenciamentoParceiro();
        }

        private void TelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(sender as Form).ActiveControl.Text.Contains("Sair"))
                Application.Exit();
            else
                Instancia = null;
        }

        #endregion
    }
}
