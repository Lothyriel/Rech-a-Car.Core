
using Aplicacao.ClienteModule;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using Dominio.Shared;
using System;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.ClienteModule
{
    public partial class CadastroMotorista : CadastroEntidade<Motorista>
    {
        public override MotoristaAppServices Services { get; }

        public ClientePJ clientePJ;
        public CadastroMotorista(IEntidadeRepository<Motorista> repositorio)
        {
            InitializeComponent();
            cbTipoCNH.SelectedIndex = 2;
            Services = new MotoristaAppServices(repositorio);
        }

        protected override IEditavel Editar()
        {
            tbNome.Text = entidade.Nome;
            tbTelefone.Text = entidade.Telefone;
            tbEndereco.Text = entidade.Endereco;
            tbCPF.Text = entidade.Documento;
            tbCNH.Text = entidade.Cnh.NumeroCnh;
            cbTipoCNH.SelectedIndex = (int)entidade.Cnh.TipoCnh;
            return this;
        }
        protected override void AdicionarDependencias(Motorista motorista)
        {
            motorista.Cnh.Id = entidade.Cnh.Id;
        }
        public override Motorista GetNovaEntidade()
        {
            var nome = tbNome.Text;
            var telefone = tbTelefone.Text;
            var endereco = tbEndereco.Text;
            var documento = tbCPF.Text;
            return new Motorista(nome, telefone, endereco, documento, GetCNH(), clientePJ);
        }
        public CNH GetCNH()
        {
            var numero = tbCNH.Text;
            var tipo = cbTipoCNH.SelectedIndex;

            return new CNH(numero, (TipoCNH)tipo);
        }
        private void btAdicionarMotorista_Click(object sender, EventArgs e)
        {
            if (Salva())
                TelaPrincipal.Instancia.FormAtivo = (Form)new CadastroClientePJ(repositorioMotorista).ConfigurarEditar(new ControladorClientePJ().GetById(clientePJ.Id));
        }
    }
}
