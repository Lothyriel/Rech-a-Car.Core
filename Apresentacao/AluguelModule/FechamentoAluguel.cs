﻿using Aplicacao.AluguelModule;
using ConfigurationManager;
using Dominio.AluguelModule;
using Dominio.ServicoModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.AluguelModule
{
    public partial class FechamentoAluguel : CadastroEntidade<AluguelFechado>, IVisualizavel //Form//
    {
        public readonly Aluguel aluguel;

        public override AluguelFechadoAppServices Services { get; }

        public FechamentoAluguel(Aluguel aluguel)
        {
            Services = new AluguelFechadoAppServices();
            this.aluguel = aluguel;
            InitializeComponent();
            tb_OdometroInicial.Text = aluguel.Veiculo.Quilometragem.ToString();
            tb_TanqueInicial.Text = aluguel.Veiculo.CapacidadeTanque.ToString();
        }
        public IVisualizavel Visualizar()
        {
            return this;
        }
        private void CalcularPrecoTotal()
        {
            var aluguelFechado = GetNovaEntidade();
            var configs = ConfigsAluguel.Configs;
            lbValorFinal.Text = aluguelFechado.CalcularTotal(configs).ToString();
        }
        private int KmRodados()
        {
            if (int.TryParse(tb_OdometroFinal.Text, out int odometroFinal) && odometroFinal >= aluguel.Veiculo.Quilometragem)
                return odometroFinal - aluguel.Veiculo.Quilometragem;

            return 0;
        }
        private double TanqueUtilizado()
        {
            if (int.TryParse(tb_TanqueAtual.Text, out int tanqueFinal) && int.TryParse(tb_TanqueInicial.Text, out int tanqueInicial))
                return tanqueInicial - tanqueFinal;

            return 0;
        }
        public override AluguelFechado GetNovaEntidade()
        {
            var servicos = new List<Servico>();

            foreach (var item in listDespesas.Items)
                servicos.Add((Servico)item);

            return aluguel.Fechar(KmRodados(), TanqueUtilizado(), servicos);
        }
        protected override IEditavel Editar()
        {
            throw new NotImplementedException();
        }
        private void validaCampoNumerico(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        #region eventos
        private void bt_AddDespesa_Click(object sender, EventArgs e)
        {
            if (tb_NomeDespesa.Text != "" && mtb_PrecoDespesa.Text != "" && double.TryParse(mtb_PrecoDespesa.Text, out double precoDespesa))
                listDespesas.Items.Add(new Servico(tb_NomeDespesa.Text, precoDespesa, aluguel));

            CalcularPrecoTotal();
        }
        private void bt_RemoveDespesa_Click(object sender, EventArgs e)
        {
            listDespesas.Items.Remove(listDespesas.SelectedItem);
            CalcularPrecoTotal();
        }
        private void tb_KmFinal_TextChanged(object sender, EventArgs e)
        {
            entidade = GetNovaEntidade();
            CalcularPrecoTotal();
        }
        private void btFecharAluguel_Click(object sender, EventArgs e)
        {
            entidade = GetNovaEntidade();
            entidade.Id = aluguel.Id;

            if (!Salva())
                return;

            TelaPrincipal.Instancia.FormAtivo = new GerenciamentoAluguel();
        }
        private void tb_TanqueAtual_TextChanged(object sender, EventArgs e)
        {
            entidade = GetNovaEntidade();
            CalcularPrecoTotal();
        }
        private void tb_OdometroFinal_TextChanged(object sender, EventArgs e)
        {
            entidade = GetNovaEntidade();
            CalcularPrecoTotal();
        }
        private void FechamentoAluguel_Load(object sender, EventArgs e)
        {
            entidade = GetNovaEntidade();
            CalcularPrecoTotal();
        }
        private void listDespesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listDespesas.SelectedIndex != -1)
                bt_RemoveDespesa.Enabled = true;
            else
                bt_RemoveDespesa.Enabled = false;
        }
        #endregion
    }
}
