using Aplicacao.CupomModule;
using Dominio.ParceiroModule;
using Dominio.Shared;
using System;
using WindowsApp.Shared;

namespace WindowsApp.WindowsApp.CupomModule.ParceiroModule
{
    public partial class CadastroParceiro : CadastroEntidade<Parceiro>
    { 

        public override ParceiroAppServices Services { get; }

        public CadastroParceiro(IEntidadeRepository<Parceiro> repositorio)
        {
            InitializeComponent();
            Services = new ParceiroAppServices(repositorio);
        }

        protected override IEditavel Editar()
        {
            tbNome.Text = entidade.nome;

            return this;
        }

        public override Parceiro GetNovaEntidade()
        {
            var nome = tbNome.Text;

            return new Parceiro(nome);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (!Salva(mostraSucesso: false))
                return;

            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoParceiro();
        }
    }
}
