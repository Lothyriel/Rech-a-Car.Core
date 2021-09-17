using Aplicacao.FuncionarioModule;
using Dominio.PessoaModule;
using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsApp.Properties;
using WindowsApp.Shared;

namespace WindowsApp.FuncionarioModule
{
    public partial class CadastroFuncionario : CadastroEntidade<Funcionario> //Form//
    { 

        public override FuncionarioAppServices Services { get; }

        public CadastroFuncionario()
        {
            InitializeComponent();
            bt_foto.Image = new Bitmap(Resources.user);
            cb_cargo.SelectedIndex = 1;
            Services = ConfigServices.Services.FuncionarioServices;
        }
        protected override IEditavel Editar()
        {
            tbNome.Text = entidade.Nome;
            tbTelefone.Text = entidade.Telefone;
            tbEndereco.Text = entidade.Endereco;
            tbCPF.Text = entidade.Documento;
            cb_cargo.SelectedIndex = (int)entidade.Cargo;
            tbUsuario.Text = entidade.NomeUsuario;
            bt_foto.Image = entidade.Foto;

            return this;
        }
        public override Funcionario GetNovaEntidade()
        {
            var nome = tbNome.Text;
            var telefone = tbTelefone.Text;
            var endereco = tbEndereco.Text;
            var cpf = tbCPF.Text;
            var cargo = cb_cargo.SelectedIndex;
            var usuario = tbUsuario.Text;
            var imagem = (Bitmap)bt_foto.Image;
            var senha = tbSenha.Text;

            return new Funcionario(nome, telefone, endereco, cpf, (Cargo)cargo, imagem, usuario, senha);
        }
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (!Salva())
                return;

            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoFuncionario();
        }
        private void bt_foto_Click(object sender, EventArgs e)
        {
            try
            {
                var open = new OpenFileDialog
                {
                    Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg"
                };
                if (ofdImagem.ShowDialog() == DialogResult.OK)
                {
                    var imagemSelecionada = ofdImagem.FileName;
                    bt_foto.Image = new Bitmap(imagemSelecionada);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Formato incorreto. Por favor, selecione um arquivo de imagem.", "Erro", 0, MessageBoxIcon.Exclamation);
            }
        }
    }
}
