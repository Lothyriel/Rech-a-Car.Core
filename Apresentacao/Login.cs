﻿using Aplicacao.FuncionarioModule;
using ConfigurationManager;
using Dominio.PessoaModule;
using Infra.NLogger;
using System;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Login : Form
    {
        private FuncionarioAppServices FuncionarioAppServices = new FuncionarioAppServices();
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

            if (!FuncionarioAppServices.ExisteUsuario(usuario))
                return ResultadoLogin.UsuarioNaoCadastrado;

            funcionario = FuncionarioAppServices.GetByUserName(tbUsuario.Text);

            if (!FuncionarioAppServices.SenhaCorreta(funcionario.Id, senha))
                return ResultadoLogin.SenhaErrada;

            return ResultadoLogin.Sucesso;
        }
        private bool EhSuperAdm(string usuario, string senha)
        {
            var dados = AppConfigManager.AppConfig["DadosSuperAdmin"];
            var userAdmin = dados["userAdmin"].ToString();
            var senhaAdmin = dados["senhaAdmin"].ToString();

            if (userAdmin != usuario)
                return false;
            if (senhaAdmin != senha)
                return false;

            SetSuperAdm(userAdmin, senhaAdmin);
            return true;
        }
        private void SetSuperAdm(string userAdmin, string senhaAdmin)
        {
            if (!FuncionarioAppServices.ExisteUsuario("admin"))
                FuncionarioAppServices.Inserir(new Funcionario("Alexandre Rech", "99999999999", "Rua do Flamengo", "12345678900", Cargo.SysAdmin, Properties.Resources.rech, userAdmin, senhaAdmin));
            funcionario = FuncionarioAppServices.GetByUserName(userAdmin);
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
            NLogger.Logger.Aqui().Info("Funcionário: {nomeFuncionario} | ID: {idFuncionario} logado", funcionario.Nome, funcionario.Id);
            Close();
        }
        private enum ResultadoLogin { Sucesso, SenhaErrada, UsuarioNaoCadastrado }

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