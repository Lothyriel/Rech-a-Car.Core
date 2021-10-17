using Aplicacao.ClienteModule;
using Dominio.Entities.PessoaModule.Condutor;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.PessoaModule.Condutor;
using System;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.ClienteModule
{
    public partial class CadastroMotorista : CadastroEntidade<Motorista>
    {
        public override MotoristaAppServices Services { get; }

        private ClientePJ Empresa;
        public CadastroMotorista(ClientePJ empresa)
        {
            Empresa = empresa;
            InitializeComponent();
            cbTipoCNH.SelectedIndex = 2;
            Services = new MotoristaAppServices();
        }

        protected override IEditavel Editar()
        {
            tbNome.Text = entidade.Nome;
            tbTelefone.Text = entidade.Telefone;
            tbEndereco.Text = entidade.Endereco;
            tbCPF.Text = entidade.TipoPessoa.Documento;
            tbCNH.Text = entidade.DadosCondutor.Cnh.NumeroCnh;
            cbTipoCNH.SelectedIndex = (int)entidade.DadosCondutor.Cnh.TipoCnh;
            return this;
        }
        protected override void AdicionarDependencias(Motorista motorista)
        {
            motorista.DadosCondutor.Id = entidade.DadosCondutor.Id;
        }
        public override Motorista GetNovaEntidade()
        {
            var nome = tbNome.Text;
            var telefone = tbTelefone.Text;
            var endereco = tbEndereco.Text;
            var documento = tbCPF.Text;
            return new Motorista(nome, telefone, endereco, documento, new DadosCondutor(GetCNH()), Empresa);
        }
        public CNH GetCNH()
        {
            var numero = tbCNH.Text;
            var tipo = cbTipoCNH.SelectedIndex;

            return new CNH(numero, (TipoCNH)tipo);
        }
        private void btAdicionarMotorista_Click(object sender, EventArgs e)
        {
            if (!Salva())
                return;

            TelaPrincipal.Instancia.FormAtivo = (Form)new CadastroClientePJ().ConfigurarEditar(entidade.Empresa);
        }
    }
}