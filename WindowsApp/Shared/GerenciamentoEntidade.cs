using Dominio.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsApp.Shared
{
    public abstract partial class GerenciamentoEntidade<T> : Form, IVisualizavel where T : IEntidade
    {
        protected abstract CadastroEntidade<T> Cadastro { get; }
        public GerenciamentoEntidade(string titulo, TipoTela tipo = TipoTela.CadastroBasico)
        {
            InitializeComponent();
            AtualizarRegistros(Cadastro.Services.Repositorio.Registros);
            lbTitulo.Text = titulo;
            AtualizarBotoes(tipo);
            AlternarBotoes(false);
        }

        public abstract object[] ObterCamposLinha(T item);
        public abstract DataGridViewColumn[] ConfigurarColunas();
        public void AtualizarRegistros(List<T> registros)
        {
            dgvEntidade.ConfigurarGrid(ConfigurarColunas());

            dgvEntidade.Rows.Clear();

            foreach (var item in registros)
                dgvEntidade.Rows.Add(GetDadosLinha(item));
        }
        private object[] GetDadosLinha(T item)
        {
            var dadosLinha = new object[] { item.Id }.ToList();
            dadosLinha.AddRange(ObterCamposLinha(item));
            return dadosLinha.ToArray();
        }
        private void AlternarBotoes(bool estado)
        {
            bt_editar.Enabled = estado;
            bt_remover.Enabled = estado;
            bt_check.Enabled = estado;
        }
        private void AtualizarBotoes(TipoTela tipo)
        {
            if (tipo is TipoTela.SemBotoes)
                RemoveTodos();

            if (tipo is TipoTela.SemCadastrar)
            {
                MudaConfirma(false);
                RemoveCadastrar();
            }
            if (tipo is TipoTela.ApenasConfirma)
            {
                RemoveTodos();
                MudaConfirma(true);
            }

            if (tipo is TipoTela.CadastroBasico)
                MudaConfirma(false);


            void RemoveCadastrar()
            {
                bt_adicionar.Visible = false;
                tbFiltro.Width += 50;
                picLupa.Left += 50;
                btFiltro.Left += 50;
                bt_editar.Left += 50;
                bt_remover.Left += 50;
            }

            void RemoveTodos()
            {
                bt_adicionar.Visible = false;
                bt_editar.Visible = false;
                bt_remover.Visible = false;
                tbFiltro.Width += 180;
                picLupa.Left += 180;
                btFiltro.Left += 180;
            }

            void MudaConfirma(bool estado)
            {
                bt_check.Visible = estado;
            }
        }
        protected virtual Type GetTipoEntidade()
        {
            return typeof(T);
        }
        protected T GetEntidadeSelecionado()
        {
            return Cadastro.Services.GetById(dgvEntidade.GetIdSelecionado(), GetTipoEntidade());
        }
        protected virtual void SalvarAluguel()
        {
            return;
        }
        protected abstract IVisualizavel Visualizar(T entidade);

        #region Eventos
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = Cadastro.Inserir();
            AtualizarRegistros(Cadastro.Services.Repositorio.FiltroGenerico(tbFiltro.Text));
        }
        private void bt_editar_Click(object sender, EventArgs e)
        {
            var entidade = Cadastro.Services.GetById(dgvEntidade.GetIdSelecionado(), GetTipoEntidade());
            TelaPrincipal.Instancia.FormAtivo = (Form)Cadastro.ConfigurarEditar(entidade);
            AlternarBotoes(false);
            AtualizarRegistros(Cadastro.Services.Repositorio.FiltroGenerico(tbFiltro.Text));
        }
        private void bt_remover_Click(object sender, EventArgs e)
        {
            var opcao = MessageBox.Show("Tem certeza que deseja excluir?", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcao == DialogResult.Cancel)
                return;

            Cadastro.Services.Excluir(dgvEntidade.GetIdSelecionado(), GetTipoEntidade());
            AlternarBotoes(false);
            AtualizarRegistros(Cadastro.Services.Repositorio.FiltroGenerico(tbFiltro.Text));
        }
        private void btFiltro_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void GerenciamentoEntidade_Load(object sender, EventArgs e)
        {
            dgvEntidade.ClearSelection();
        }
        private void bt_check_Click(object sender, EventArgs e)
        {
            SalvarAluguel();
        }
        private void tbFiltro_TextChanged(object sender, EventArgs e)
        {
            AtualizarRegistros(Cadastro.Services.FiltroGenerico(tbFiltro.Text));
        }
        private void dgvEntidade_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = (Form)Visualizar(GetEntidadeSelecionado());
        }
        private void dgvEntidade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEntidade.SelectedRows.Count > 0)
                AlternarBotoes(true);
        }
        #endregion

    }
    public enum TipoTela
    {
        SemBotoes,
        SemCadastrar,
        ApenasConfirma,
        CadastroBasico,
    }
}
