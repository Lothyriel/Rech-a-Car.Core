using ConfigurationManager;
using Dominio.PessoaModule;
using Dominio.Repositories;
using Infra.DAO.PessoaModule;
using System;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Login : Form
    {
        private IFuncionarioRepository FuncionarioDAO = ConfigServices.Services.FuncionarioServices.Repositorio;

        private ISenhaRepository SenhaRepo = ConfigServices.Services.FuncionarioServices.RepositorioSenha;

        private Funcionario funcionario;

        public Login()
        {
            InitializeComponent();
            bt_entrar.Enabled = false;
        }

        private ResultadoLogin LoginUsuario()
        {
            var usuario = tbUsuario.Text;
            var senha = tbSenha.Text;


            if (EhSuperAdm(usuario, senha))
                return ResultadoLogin.Sucesso;

            if (!FuncionarioDAO.ExisteUsuario(usuario))
                return ResultadoLogin.UsuarioNaoCadastrado;

            funcionario = FuncionarioDAO.GetByUserName(tbUsuario.Text);

            if (!SenhaRepo.SenhaCorreta(funcionario.Id, senha))
                return ResultadoLogin.SenhaErrada;

            return ResultadoLogin.Sucesso;
        }
        private bool EhSuperAdm(string usuario, string senha)
        {
            var config = Config.AppConfig;
            var userAdmin = config["userAdmin"];
            var senhaAdmin = config["senhaAdmin"];

            if (userAdmin != usuario)
                return false;
            if (senhaAdmin != senha)
                return false;

            SetSuperAdm(userAdmin, senhaAdmin);
            return true;
        }
        private void SetSuperAdm(string userAdmin, string senhaAdmin)
        {
            if (!FuncionarioDAO.ExisteUsuario("admin"))
                FuncionarioDAO.Inserir(new Funcionario("Alexandre Rech", "99999999999", "Rua do Flamengo", "999999", Cargo.SysAdmin, Properties.Resources.rech, userAdmin, senhaAdmin));
            funcionario = FuncionarioDAO.GetByUserName(userAdmin);
        }
        private string mostraResultado(ResultadoLogin resultado)
        {
            switch (resultado)
            {
                case ResultadoLogin.SenhaErrada: return "Senha incorreta!";
                case ResultadoLogin.UsuarioNaoCadastrado: return "Usuário não está cadastrado!";
                case ResultadoLogin.Sucesso: return "Sucesso!";
                default: return "Error";
            }
        }
        private void EnterPressionado(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Logar();
            }
        }
        private void BloquearBotaoLogin()
        {
            if (LoginInvalido())
                bt_entrar.Enabled = false;
            else
                bt_entrar.Enabled = true;
        }
        private bool LoginInvalido()
        {
            return tbSenha.Text.Length < 8 || tbUsuario.Text.Length < 5;
        }
        private void Logar()
        {
            var resultadoLogin = LoginUsuario();
            if (resultadoLogin != ResultadoLogin.Sucesso)
            {
                MessageBox.Show(this, mostraResultado(resultadoLogin), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new TelaPrincipal(funcionario).Show();
            Close();
        }
        public enum ResultadoLogin { Sucesso, SenhaErrada, UsuarioNaoCadastrado }

        private void bt_entrar_Click(object sender, EventArgs e)
        {
            Logar();
        }
        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            BloquearBotaoLogin();
        }
        private void tbSenha_TextChanged(object sender, EventArgs e)
        {
            BloquearBotaoLogin();
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (TelaPrincipal.Instancia == null)
                Application.Exit();
        }
    }
}