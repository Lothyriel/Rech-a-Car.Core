using Controladores.ParceiroModule;
using Controladores.Shared;
using Dominio.ParceiroModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.WindowsApp.CupomModule.ParceiroModule
{
    public partial class CadastroParceiro : CadastroEntidade<Parceiro>
    {
        public override Controlador<Parceiro> Controlador { get => new ControladorParceiro(); }

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
