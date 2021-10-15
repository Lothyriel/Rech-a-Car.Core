using Applicacao.VeiculoModule;
using Dominio.VeiculoModule;
using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsApp.Properties;
using WindowsApp.Shared;

namespace WindowsApp.VeiculoModule
{
    public partial class CadastroVeiculo : CadastroEntidade<Veiculo>//Form//
    {
        public override VeiculoAppServices Services { get; }
        private Bitmap imagem;

        public CadastroVeiculo()
        {
            Services = new VeiculoAppServices();
            InitializeComponent();
            cb_cambio.SelectedIndex = 0;
            cb_capacidade.SelectedIndex = 1;
            cb_portaMalas.SelectedIndex = 1;
            cb_portas.SelectedIndex = 0;
            cb_tipoCombustivel.SelectedIndex = 4;
            cb_categoria.DataSource = Services.RepositorioCategoria.Registros;
            bt_foto.Image = new Bitmap(Resources.inserir_icone_de_imagem);
        }

        protected override IEditavel Editar()
        {
            tb_modelo.Text = entidade.Modelo;
            tb_marca.Text = entidade.Marca;
            tb_placa.Text = entidade.Placa;
            cb_portaMalas.SelectedItem = entidade.PortaMalaToString();
            tb_chassi.Text = entidade.Chassi;
            cb_capacidade.Text = entidade.Capacidade.ToString();
            tb_ano.Text = entidade.Ano.ToString();
            cb_portas.SelectedItem = entidade.Portas.ToString();
            cb_cambio.SelectedItem = entidade.CambioToString();
            cb_categoria.SelectedItem = entidade.Categoria;
            AtualizarIcone((Bitmap)entidade.Foto);

            return this;
        }
        public override Veiculo GetNovaEntidade()
        {
            var modelo = tb_modelo.Text;
            var marca = tb_marca.Text;
            var placa = tb_placa.Text;
            var portaMalas = cb_portaMalas.SelectedIndex;
            var chassi = tb_chassi.Text;
            var capacidade = cb_capacidade.SelectedIndex;

            int.TryParse(tb_ano.Text, out int ano);
            int.TryParse(cb_portas.SelectedItem.ToString(), out int portas);
            int.TryParse(cb_tipoCombustivel?.ToString(), out int tipoCombustivel);
            int.TryParse(tb_tanque.Text, out int capacidadeTanque);
            int.TryParse(tb_quilometragem.Text, out int quilometragem);

            var cambio = cb_cambio.SelectedItem.ToString() == "Automático";
            imagem = (Bitmap)bt_foto.Image;

            var categoria = (Categoria)cb_categoria.SelectedItem;
            return new Veiculo(modelo, marca, ano, placa, quilometragem, capacidade, portas, chassi, portaMalas, capacidadeTanque, imagem, cambio, categoria, (TipoCombustivel)tipoCombustivel);
        }
        private void AtualizarIcone(Bitmap imagem)
        {
            bt_foto.Image = new Bitmap(imagem);
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            if (Salva())
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoVeiculo();
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
                    imagem = new Bitmap(imagemSelecionada);
                    AtualizarIcone(imagem);
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Formato incorreto. Por favor, selecione um arquivo de imagem.", "Erro", 0, MessageBoxIcon.Exclamation);
            }
        }
    }
}