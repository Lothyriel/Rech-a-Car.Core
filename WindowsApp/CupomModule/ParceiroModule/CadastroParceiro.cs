using Controladores.ParceiroModule;
using Controladores.Shared;
using Dominio.ParceiroModule;
using System;
using WindowsApp.Shared;

namespace WindowsApp.WindowsApp.CupomModule.ParceiroModule
{
    public partial class CadastroParceiro : CadastroEntidade<Parceiro>
    {
        public override Controlador<Parceiro> Services { get => new ControladorParceiro(); }

        public CadastroParceiro()
        {
            InitializeComponent();
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
