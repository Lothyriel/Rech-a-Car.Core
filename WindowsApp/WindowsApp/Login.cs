using Controladores.PessoaModule;
using Dominio.PessoaModule;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using ConfigurationManager;

namespace WindowsApp
{
    public partial class Login : Form
    {
        public static Login Instancia;
        private ControladorFuncionario ControladorFuncionario = new ControladorFuncionario();
        private Funcionario funcionario;

        public Login()
        {
            Instancia = this;
            InitializeComponent();
            bt_entrar.Enabled = false;
        }

        private ResultadoLogin LoginUsuario()
        {
            var usuario = tbUsuario.Text;
            var senha = tbSenha.Text;


            if (EhSuperAdm(usuario, senha))
                return ResultadoLogin.Sucesso;

            if (!ExisteUsuario(usuario))
                return ResultadoLogin.UsuarioNaoCadastrado;

            GetFuncionario();

            if (!Logar(funcionario.Id, senha))
                return ResultadoLogin.SenhaErrada;

            return ResultadoLogin.Sucesso;
        }

        private bool EhSuperAdm(string usuario, string senha)
        {
            var config = JsonManager.InitConfiguration();
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
            var Controlador = new ControladorFuncionario();
            if (!Controlador.ExisteUsuario("admin"))
                Controlador.Inserir(new Funcionario("Alexandre Rech", "99999999999", "Rua do Flamengo", "999999", Cargo.SysAdmin, Properties.Resources.rech, userAdmin, senhaAdmin));
            funcionario = Controlador.GetByUserName(userAdmin);
        }

        private bool Logar(int id_funcionario, string senha)
        {
            return ControladorSenha.SenhaCorreta(id_funcionario, senha);
        }
        private bool ExisteUsuario(string usuario)
        {
            return ControladorFuncionario.ExisteUsuario(usuario);
        }
        private void GetFuncionario()
        {
            funcionario = ControladorFuncionario.GetByUserName(tbUsuario.Text);
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
        private void bt_entrar_Click(object sender, EventArgs e)
        {
            Logar();
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

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            BloquearBotaoLogin();
        }
        private void tbSenha_TextChanged(object sender, EventArgs e)
        {
            BloquearBotaoLogin();
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
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (TelaPrincipal.Instancia == null)
                Application.Exit();
        }

        private void EnterPressionado(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Logar();
            }
        }
        public enum ResultadoLogin { Sucesso, SenhaErrada, UsuarioNaoCadastrado }
    }
}