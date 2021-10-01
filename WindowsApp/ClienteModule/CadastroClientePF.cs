using Aplicacao.ClienteModule;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using System;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.ClienteModule
{
    public partial class CadastroClientePF : CadastroEntidade<ClientePF> //Form //
    {
        public override ClientePFAppServices Services { get; }

        public CadastroClientePF()
        {
            Services = ConfigServices.Services.ClientePFServices;
            InitializeComponent();
            cbTipoCNH.SelectedIndex = 2;
        }

        protected override IEditavel Editar()
        {
            tbCPF.Text = entidade.Documento;
            tbNome.Text = entidade.Nome;
            tbTelefone.Text = entidade.Telefone;
            tbEndereco.Text = entidade.Endereco;
            mtbNascimento.Text = entidade.DataNascimento.ToString();

            tbCNH.Text = entidade.Cnh.NumeroCnh;
            cbTipoCNH.SelectedIndex = (int)entidade.Cnh.TipoCnh;

            return this;
        }

        public override ClientePF GetNovaEntidade()
        {
            var nome = tbNome.Text;
            var telefone = tbTelefone.Text;
            var endereco = tbEndereco.Text;
            var documento = tbCPF.Text;
            var email = tb_email.Text;
            var cnh = GetCNH();
            DateTime.TryParse(mtbNascimento.Text, out DateTime dataNascimento);
            return new ClientePF(nome, telefone, endereco, documento, cnh, dataNascimento, email);
        }
        public CNH GetCNH()
        {
            var numero = tbCNH.Text;
            var tipo = cbTipoCNH.SelectedIndex;

            return new CNH(numero, (TipoCNH)tipo);
        }
        protected override void AdicionarDependencias(ClientePF cliente)
        {
            cliente.Cnh.Id = entidade.Cnh.Id;
        }
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (Salva())
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoCliente();
        }
    }
}
