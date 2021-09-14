using Controladores.AluguelModule;
using Controladores.Shared;
using Dominio.AluguelModule;
using WindowsApp.Shared;
using WindowsApp.ClienteModule;
using WindowsApp.VeiculoModule;
using System;
using Dominio.PessoaModule.ClienteModule;
using Dominio.PessoaModule;
using Dominio.ServicoModule;
using Controladores.ServicoModule;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using Dominio.VeiculoModule;
using EmailAluguelPDF;
using System.Threading.Tasks;

namespace WindowsApp.AluguelModule
{
    public partial class ResumoAluguel : CadastroEntidade<Aluguel>// Form // 
    {
        private Aluguel Aluguel;
        public ResumoAluguel(Aluguel aluguel = null)
        {
            Aluguel = aluguel ?? new Aluguel();

            InitializeComponent();

            PopulaServicos(GetServicosDiponiveis());
            PopulaDatas();

            cbPlano.SelectedIndex = 0;
            bt_RemoveServico.Enabled = false;
            bt_AddServico.Enabled = false;

            if (Aluguel?.Veiculo != null)
            {
                PopulaVeiculo(Aluguel.Veiculo);
            }

            if (Aluguel?.Cliente != null)
            {
                PopulaCliente(aluguel.Cliente);
            }
        }

        public override Controlador<Aluguel> Controlador => new ControladorAluguel();
        public override Aluguel GetNovaEntidade()
        {
            DateTime.TryParse(tbDt_Emprestimo.Text, out DateTime dataAluguel);
            DateTime.TryParse(tbDt_Devolucao.Text, out DateTime dataDevolucao);

            Aluguel.Condutor = cb_motoristas.SelectedItem is null ? (Condutor)Aluguel.Cliente : (Condutor)cb_motoristas.SelectedItem;
            Aluguel.TipoPlano = (Plano)cbPlano.SelectedIndex;
            Aluguel.Funcionario = TelaPrincipal.Instancia.FuncionarioLogado;
            Aluguel.DataAluguel = dataAluguel;
            Aluguel.DataDevolucao = dataDevolucao;

            return Aluguel;
        }
        protected override IEditavel Editar()
        {
            tbCliente.Text = entidade.Cliente.Nome;
            tbDocumento.Text = entidade.Cliente.Documento;
            tbEndereço.Text = entidade.Cliente.Endereco;
            tbTelefone.Text = entidade.Cliente.Telefone;
            tbMarca.Text = entidade.Veiculo.Marca;
            tbModelo.Text = entidade.Veiculo.Modelo;
            tbPlaca.Text = entidade.Veiculo.Placa;
            tbTipoCnh.Text = entidade.Veiculo.Categoria.TipoDeCnh.ToString();
            cbPlano.SelectedItem = entidade.TipoPlano.ToString();

            SetCondutor();

            tbDt_Emprestimo.Text = entidade.DataAluguel.ToString("d");
            tbDt_Devolucao.Text = entidade.DataDevolucao.ToString("d");
            PopulaServicos(GetServicosDiponiveis());
            EsconderPanel(panelEsconderCliente);
            EsconderPanel(panelEsconderVeiculo);

            return this;
        }
        protected override string ValidacaoCampos()
        {
            var validacao = string.Empty;
            if (Aluguel.Veiculo == null)
                validacao += "O aluguel precisa de um veículo\n";
            if (Aluguel.Cliente == null)
                validacao += "O aluguel precisa de um cliente";
            if (Aluguel.Cliente is ClientePJ && cb_motoristas.SelectedItem == null)
                validacao += "Selecione um motorista para o aluguel";

            return validacao;
        }
        private void PopulaDatas()
        {
            tbDt_Emprestimo.Text = DateTime.Today.ToShortDateString();
            tbDt_Devolucao.Text = DateTime.Today.AddDays(1).ToShortDateString();
        }
        private List<Servico> GetServicosDiponiveis()
        {
            return new ControladorServico().ServicosDisponiveis().Except(Aluguel.Servicos).ToList();
        }
        private void SetCondutor()
        {
            if (Aluguel.Cliente is ClientePJ)
                PopulaMotoristas();
            else
                cb_motoristas.Enabled = false;
        }
        private void PopulaVeiculo(Veiculo veiculo)
        {
            EsconderPanel(panelEsconderVeiculo);
            Aluguel.Veiculo = veiculo;
            tbMarca.Text = Aluguel.Veiculo.Marca;
            tbModelo.Text = Aluguel.Veiculo.Modelo;
            tbPlaca.Text = Aluguel.Veiculo.Placa;
            tbTipoCnh.Text = Aluguel.Veiculo.Categoria.TipoDeCnh.ToString();
        }
        private void PopulaCliente(ICliente cliente)
        {
            EsconderPanel(panelEsconderCliente);
            Aluguel.Cliente = cliente;
            tbCliente.Text = Aluguel.Cliente.Nome;
            tbDocumento.Text = Aluguel.Cliente.Documento;
            tbEndereço.Text = Aluguel.Cliente.Endereco;
            tbTelefone.Text = Aluguel.Cliente.Telefone;

            SetCondutor();
        }
        private void PopulaMotoristas()
        {
            cb_motoristas.Items.AddRange(((ClientePJ)Aluguel.Cliente).Motoristas.ToArray());
        }
        private void PopulaServicos(List<Servico> servicos)
        {
            listServicos.Items.Clear();
            listServicos.Items.AddRange(servicos.ToArray());
        }
        private void AdicionarServico()
        {
            Aluguel.Servicos.Add((Servico)listServicos.SelectedItem);
            listServicos.Items.Remove(listServicos.SelectedItem);
            CalcularPrecoParcial();
        }
        private void RemoverServico()
        {
            Aluguel.Servicos.Remove((Servico)listServicos.SelectedItem);
            listServicos.Items.Remove(listServicos.SelectedItem);
            CalcularPrecoParcial();
        }
        private void EsconderPanel(Panel panel)
        {
            panel.Visible = false;
        }
        private void CalcularPrecoParcial()
        {
            DateTime.TryParse(tbDt_Emprestimo.Text, out DateTime dtEmprestimo);
            DateTime.TryParse(tbDt_Devolucao.Text, out DateTime dtDevolucao);

            Aluguel.DataAluguel = dtEmprestimo;
            Aluguel.DataDevolucao = dtDevolucao;

            if (cbPlano.SelectedItem != null)
                Aluguel.TipoPlano = (Plano)Enum.Parse(typeof(Plano), cbPlano.SelectedItem.ToString());

            lbValor.Text = Aluguel.CalcularTotal().ToString();
        }
        private void AtualizaOpcoesListServicos()
        {
            if (lb_lista_opcionais.Text == "Opcionais")
            {
                PopulaServicos(Aluguel.Servicos);
                lb_lista_opcionais.Text = "Alugados";
            }
            else
            {
                PopulaServicos(GetServicosDiponiveis());
                lb_lista_opcionais.Text = "Opcionais";
            }
        }
        private void GetNovaSelecao(int selecionado)
        {
            int quantidade = listServicos.Items.Count;
            if (quantidade == 0)
                listServicos.SelectedIndex = -1;
            else if (quantidade == selecionado)
                listServicos.SelectedIndex = selecionado - 1;
            else
                listServicos.SelectedIndex = selecionado;
        }

        #region Eventos
        private void btFecharAluguel_Click(object sender, EventArgs e)
        {
            if (!Salva())
                return;

            //Task.Run(() => new CriaPDFAluguel(Aluguel));
            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoAluguel();
        }
        private void panelEsconderCliente_DoubleClick(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoCliente("Selecione um Cliente", TipoTela.ApenasConfirma, Aluguel);
        }
        private void panelEsconderVeiculo_DoubleClick(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoVeiculo("Selecione um Veículo", TipoTela.ApenasConfirma, Aluguel);
        }
        private void bt_AddServico_Click(object sender, EventArgs e)
        {
            var selecionado = listServicos.SelectedIndex;
            AdicionarServico();
            GetNovaSelecao(selecionado);
        }
        private void bt_RemoveServico_Click(object sender, EventArgs e)
        {
            var selecionado = listServicos.SelectedIndex;
            RemoverServico();
            GetNovaSelecao(selecionado);
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            tipAluguel.SetToolTip(pictureBox1, "Clique duas vezes nos painéis para adicionar as informações necessárias.");
        }
        private void tbDt_Emprestimo_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecoParcial();
        }
        private void tbDt_Devolucao_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecoParcial();
        }
        private void cbPlano_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPrecoParcial();
        }
        private void bt_alterna_listas_Click(object sender, EventArgs e)
        {
            AtualizaOpcoesListServicos();
        }
        private void listServicos_SelectedValueChanged(object sender, EventArgs e)
        {
            var NaotemZero = listServicos.Items.Count != 0;

            if (lb_lista_opcionais.Text == "Opcionais")
                bt_AddServico.Enabled = NaotemZero;
            else
                bt_RemoveServico.Enabled = NaotemZero;
        }
        #endregion
    }
}