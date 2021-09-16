
using Controladores.Shared;
using Dominio.AluguelModule;
using WindowsApp.Shared;

namespace WindowsApp.AluguelModule
{
    partial class ResumoAluguel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new PanelColorido();
            this.label12 = new System.Windows.Forms.Label();
            this.panelEsconderCliente = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDocumento = new System.Windows.Forms.TextBox();
            this.cb_motoristas = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbEndereço = new System.Windows.Forms.TextBox();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new PanelColorido();
            this.label13 = new System.Windows.Forms.Label();
            this.panelEsconderVeiculo = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.tbTipoCnh = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new PanelColorido();
            this.cbPlano = new System.Windows.Forms.ComboBox();
            this.tbDt_Devolucao = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbDt_Emprestimo = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelColorido1 = new PanelColorido();
            this.bt_alterna_listas = new System.Windows.Forms.Button();
            this.bt_RemoveServico = new System.Windows.Forms.Button();
            this.bt_AddServico = new System.Windows.Forms.Button();
            this.listServicos = new System.Windows.Forms.ListBox();
            this.lb_lista_opcionais = new System.Windows.Forms.Label();
            this.panelColorido2 = new PanelColorido();
            this.tipAluguel = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btFecharAluguel = new System.Windows.Forms.Button();
            this.tb_Cupom = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.bt_Aplicar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelEsconderCliente.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelEsconderVeiculo.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelColorido1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(276, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resumo do Aluguel";
            // 
            // panel1
            // 
            this.panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.panelEsconderCliente);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbDocumento);
            this.panel1.Controls.Add(this.cb_motoristas);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbTelefone);
            this.panel1.Controls.Add(this.tbEndereço);
            this.panel1.Controls.Add(this.tbCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(36, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 195);
            this.panel1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(-6, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "Informações do Cliente";
            // 
            // panelEsconderCliente
            // 
            this.panelEsconderCliente.Controls.Add(this.label18);
            this.panelEsconderCliente.Location = new System.Drawing.Point(11, 10);
            this.panelEsconderCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEsconderCliente.Name = "panelEsconderCliente";
            this.panelEsconderCliente.Size = new System.Drawing.Size(692, 180);
            this.panelEsconderCliente.TabIndex = 14;
            this.panelEsconderCliente.DoubleClick += new System.EventHandler(this.panelEsconderCliente_DoubleClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(130, 75);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(380, 25);
            this.label18.TabIndex = 15;
            this.label18.Text = "Clique duas vezes para selecionar um cliente.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(294, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Documento";
            // 
            // tbDocumento
            // 
            this.tbDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDocumento.Location = new System.Drawing.Point(298, 74);
            this.tbDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDocumento.Name = "tbDocumento";
            this.tbDocumento.ReadOnly = true;
            this.tbDocumento.Size = new System.Drawing.Size(178, 29);
            this.tbDocumento.TabIndex = 3;
            // 
            // cb_motoristas
            // 
            this.cb_motoristas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_motoristas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_motoristas.FormattingEnabled = true;
            this.cb_motoristas.Location = new System.Drawing.Point(497, 74);
            this.cb_motoristas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_motoristas.Name = "cb_motoristas";
            this.cb_motoristas.Size = new System.Drawing.Size(196, 29);
            this.cb_motoristas.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(493, 46);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 21);
            this.label17.TabIndex = 9;
            this.label17.Text = "Condutor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(493, 118);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 118);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cliente";
            // 
            // tbTelefone
            // 
            this.tbTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTelefone.Location = new System.Drawing.Point(497, 146);
            this.tbTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.ReadOnly = true;
            this.tbTelefone.Size = new System.Drawing.Size(196, 29);
            this.tbTelefone.TabIndex = 5;
            // 
            // tbEndereço
            // 
            this.tbEndereço.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEndereço.Location = new System.Drawing.Point(17, 146);
            this.tbEndereço.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEndereço.Name = "tbEndereço";
            this.tbEndereço.ReadOnly = true;
            this.tbEndereço.Size = new System.Drawing.Size(460, 29);
            this.tbEndereço.TabIndex = 2;
            // 
            // tbCliente
            // 
            this.tbCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCliente.Location = new System.Drawing.Point(17, 74);
            this.tbCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.ReadOnly = true;
            this.tbCliente.Size = new System.Drawing.Size(263, 29);
            this.tbCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(154, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.panelEsconderVeiculo);
            this.panel2.Controls.Add(this.tbTipoCnh);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.tbPlaca);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.tbModelo);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tbMarca);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(36, 279);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 118);
            this.panel2.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(-6, -4);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(213, 25);
            this.label13.TabIndex = 8;
            this.label13.Text = "Informações do Veículo";
            // 
            // panelEsconderVeiculo
            // 
            this.panelEsconderVeiculo.Controls.Add(this.label19);
            this.panelEsconderVeiculo.Location = new System.Drawing.Point(13, 8);
            this.panelEsconderVeiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEsconderVeiculo.Name = "panelEsconderVeiculo";
            this.panelEsconderVeiculo.Size = new System.Drawing.Size(692, 101);
            this.panelEsconderVeiculo.TabIndex = 16;
            this.panelEsconderVeiculo.DoubleClick += new System.EventHandler(this.panelEsconderVeiculo_DoubleClick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(130, 40);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(384, 25);
            this.label19.TabIndex = 15;
            this.label19.Text = "Clique duas vezes para selecionar um veículo.";
            // 
            // tbTipoCnh
            // 
            this.tbTipoCnh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTipoCnh.Location = new System.Drawing.Point(560, 66);
            this.tbTipoCnh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTipoCnh.Name = "tbTipoCnh";
            this.tbTipoCnh.ReadOnly = true;
            this.tbTipoCnh.Size = new System.Drawing.Size(124, 29);
            this.tbTipoCnh.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(556, 38);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 21);
            this.label20.TabIndex = 7;
            this.label20.Text = "Carteira";
            // 
            // tbPlaca
            // 
            this.tbPlaca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPlaca.Location = new System.Drawing.Point(400, 66);
            this.tbPlaca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.ReadOnly = true;
            this.tbPlaca.Size = new System.Drawing.Size(140, 29);
            this.tbPlaca.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(396, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 21);
            this.label11.TabIndex = 7;
            this.label11.Text = "Placa";
            // 
            // tbModelo
            // 
            this.tbModelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbModelo.Location = new System.Drawing.Point(214, 66);
            this.tbModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.ReadOnly = true;
            this.tbModelo.Size = new System.Drawing.Size(168, 29);
            this.tbModelo.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(210, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "Modelo";
            // 
            // tbMarca
            // 
            this.tbMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMarca.Location = new System.Drawing.Point(31, 66);
            this.tbMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.ReadOnly = true;
            this.tbMarca.Size = new System.Drawing.Size(166, 29);
            this.tbMarca.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(25, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Marca";
            // 
            // panel3
            // 
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.cbPlano);
            this.panel3.Controls.Add(this.tbDt_Devolucao);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.tbDt_Emprestimo);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(298, 405);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 184);
            this.panel3.TabIndex = 3;
            // 
            // cbPlano
            // 
            this.cbPlano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlano.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPlano.FormattingEnabled = true;
            this.cbPlano.Items.AddRange(new object[] {
            "Diário",
            "Controlado",
            "Livre"});
            this.cbPlano.Location = new System.Drawing.Point(18, 32);
            this.cbPlano.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPlano.Name = "cbPlano";
            this.cbPlano.Size = new System.Drawing.Size(166, 25);
            this.cbPlano.TabIndex = 10;
            this.cbPlano.SelectedIndexChanged += new System.EventHandler(this.cbPlano_SelectedIndexChanged);
            // 
            // tbDt_Devolucao
            // 
            this.tbDt_Devolucao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDt_Devolucao.Location = new System.Drawing.Point(18, 142);
            this.tbDt_Devolucao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDt_Devolucao.Mask = "00/00/0000";
            this.tbDt_Devolucao.Name = "tbDt_Devolucao";
            this.tbDt_Devolucao.Size = new System.Drawing.Size(166, 25);
            this.tbDt_Devolucao.TabIndex = 12;
            this.tbDt_Devolucao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDt_Devolucao.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.tbDt_Devolucao.ValidatingType = typeof(System.DateTime);
            this.tbDt_Devolucao.TextChanged += new System.EventHandler(this.tbDt_Devolucao_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(15, 118);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 17);
            this.label16.TabIndex = 7;
            this.label16.Text = "Data de Devolução";
            // 
            // tbDt_Emprestimo
            // 
            this.tbDt_Emprestimo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDt_Emprestimo.Location = new System.Drawing.Point(18, 86);
            this.tbDt_Emprestimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDt_Emprestimo.Mask = "00/00/0000";
            this.tbDt_Emprestimo.Name = "tbDt_Emprestimo";
            this.tbDt_Emprestimo.Size = new System.Drawing.Size(166, 25);
            this.tbDt_Emprestimo.TabIndex = 11;
            this.tbDt_Emprestimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbDt_Emprestimo.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.tbDt_Emprestimo.ValidatingType = typeof(System.DateTime);
            this.tbDt_Emprestimo.TextChanged += new System.EventHandler(this.tbDt_Emprestimo_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(15, 64);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Data de Empréstimo";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(15, 8);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 17);
            this.label14.TabIndex = 7;
            this.label14.Text = "Tipo do Aluguel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(522, 517);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total parcial:";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbValor.ForeColor = System.Drawing.Color.White;
            this.lbValor.Location = new System.Drawing.Point(566, 554);
            this.lbValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(50, 25);
            this.lbValor.TabIndex = 5;
            this.lbValor.Text = "0.00";
            this.lbValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(522, 554);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "R$";
            // 
            // panelColorido1
            // 
            this.panelColorido1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panelColorido1.Controls.Add(this.bt_alterna_listas);
            this.panelColorido1.Controls.Add(this.bt_RemoveServico);
            this.panelColorido1.Controls.Add(this.bt_AddServico);
            this.panelColorido1.Controls.Add(this.listServicos);
            this.panelColorido1.Controls.Add(this.lb_lista_opcionais);
            this.panelColorido1.Location = new System.Drawing.Point(36, 405);
            this.panelColorido1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelColorido1.Name = "panelColorido1";
            this.panelColorido1.Size = new System.Drawing.Size(251, 184);
            this.panelColorido1.TabIndex = 8;
            // 
            // bt_alterna_listas
            // 
            this.bt_alterna_listas.FlatAppearance.BorderSize = 0;
            this.bt_alterna_listas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_alterna_listas.Image = global::WindowsApp.Properties.Resources.trocar;
            this.bt_alterna_listas.Location = new System.Drawing.Point(196, 8);
            this.bt_alterna_listas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_alterna_listas.Name = "bt_alterna_listas";
            this.bt_alterna_listas.Size = new System.Drawing.Size(42, 38);
            this.bt_alterna_listas.TabIndex = 17;
            this.bt_alterna_listas.UseVisualStyleBackColor = true;
            this.bt_alterna_listas.Click += new System.EventHandler(this.bt_alterna_listas_Click);
            // 
            // bt_RemoveServico
            // 
            this.bt_RemoveServico.FlatAppearance.BorderSize = 0;
            this.bt_RemoveServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_RemoveServico.Image = global::WindowsApp.Properties.Resources.removemini;
            this.bt_RemoveServico.Location = new System.Drawing.Point(196, 112);
            this.bt_RemoveServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_RemoveServico.Name = "bt_RemoveServico";
            this.bt_RemoveServico.Size = new System.Drawing.Size(42, 40);
            this.bt_RemoveServico.TabIndex = 16;
            this.bt_RemoveServico.UseVisualStyleBackColor = true;
            this.bt_RemoveServico.Click += new System.EventHandler(this.bt_RemoveServico_Click);
            // 
            // bt_AddServico
            // 
            this.bt_AddServico.FlatAppearance.BorderSize = 0;
            this.bt_AddServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_AddServico.Image = global::WindowsApp.Properties.Resources.addmini;
            this.bt_AddServico.Location = new System.Drawing.Point(196, 64);
            this.bt_AddServico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_AddServico.Name = "bt_AddServico";
            this.bt_AddServico.Size = new System.Drawing.Size(42, 41);
            this.bt_AddServico.TabIndex = 15;
            this.bt_AddServico.UseVisualStyleBackColor = true;
            this.bt_AddServico.Click += new System.EventHandler(this.bt_AddServico_Click);
            // 
            // listServicos
            // 
            this.listServicos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listServicos.FormattingEnabled = true;
            this.listServicos.ItemHeight = 17;
            this.listServicos.Location = new System.Drawing.Point(11, 49);
            this.listServicos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listServicos.Name = "listServicos";
            this.listServicos.Size = new System.Drawing.Size(176, 106);
            this.listServicos.TabIndex = 11;
            this.listServicos.SelectedValueChanged += new System.EventHandler(this.listServicos_SelectedValueChanged);
            // 
            // lb_lista_opcionais
            // 
            this.lb_lista_opcionais.AutoSize = true;
            this.lb_lista_opcionais.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_lista_opcionais.ForeColor = System.Drawing.Color.White;
            this.lb_lista_opcionais.Location = new System.Drawing.Point(-6, -4);
            this.lb_lista_opcionais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lista_opcionais.Name = "lb_lista_opcionais";
            this.lb_lista_opcionais.Size = new System.Drawing.Size(96, 25);
            this.lb_lista_opcionais.TabIndex = 9;
            this.lb_lista_opcionais.Text = "Opcionais";
            // 
            // panelColorido2
            // 
            this.panelColorido2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(7)))), ((int)(((byte)(49)))));
            this.panelColorido2.Location = new System.Drawing.Point(669, 506);
            this.panelColorido2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelColorido2.Name = "panelColorido2";
            this.panelColorido2.Size = new System.Drawing.Size(1, 83);
            this.panelColorido2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsApp.Properties.Resources.help;
            this.pictureBox1.Location = new System.Drawing.Point(727, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 40);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // btFecharAluguel
            // 
            this.btFecharAluguel.FlatAppearance.BorderSize = 0;
            this.btFecharAluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFecharAluguel.Image = global::WindowsApp.Properties.Resources.check;
            this.btFecharAluguel.Location = new System.Drawing.Point(678, 506);
            this.btFecharAluguel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btFecharAluguel.Name = "btFecharAluguel";
            this.btFecharAluguel.Size = new System.Drawing.Size(88, 83);
            this.btFecharAluguel.TabIndex = 13;
            this.btFecharAluguel.UseVisualStyleBackColor = true;
            this.btFecharAluguel.Click += new System.EventHandler(this.btFecharAluguel_Click);
            // 
            // tb_Cupom
            // 
            this.tb_Cupom.Location = new System.Drawing.Point(513, 437);
            this.tb_Cupom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Cupom.Name = "tb_Cupom";
            this.tb_Cupom.Size = new System.Drawing.Size(148, 23);
            this.tb_Cupom.TabIndex = 15;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(513, 409);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 17);
            this.label21.TabIndex = 13;
            this.label21.Text = "Cupom";
            // 
            // bt_Aplicar
            // 
            this.bt_Aplicar.Location = new System.Drawing.Point(667, 439);
            this.bt_Aplicar.Name = "bt_Aplicar";
            this.bt_Aplicar.Size = new System.Drawing.Size(75, 23);
            this.bt_Aplicar.TabIndex = 16;
            this.bt_Aplicar.Text = "Aplicar";
            this.bt_Aplicar.UseVisualStyleBackColor = true;
            this.bt_Aplicar.Click += new System.EventHandler(this.bt_Aplicar_Click);
            // 
            // ResumoAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(780, 602);
            this.Controls.Add(this.bt_Aplicar);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tb_Cupom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelColorido2);
            this.Controls.Add(this.panelColorido1);
            this.Controls.Add(this.btFecharAluguel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ResumoAluguel";
            this.Text = "CadastrarAluguel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelEsconderCliente.ResumeLayout(false);
            this.panelEsconderCliente.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelEsconderVeiculo.ResumeLayout(false);
            this.panelEsconderVeiculo.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelColorido1.ResumeLayout(false);
            this.panelColorido1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private Shared.PanelColorido panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbDocumento;
        private System.Windows.Forms.TextBox tbEndereço;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Label label2;
        private Shared.PanelColorido panel2;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label label9;
        private Shared.PanelColorido panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btFecharAluguel;
        private System.Windows.Forms.MaskedTextBox tbDt_Emprestimo;
        private System.Windows.Forms.Label label15;
        private Shared.PanelColorido panelColorido1;
        private System.Windows.Forms.Label lb_lista_opcionais;
        private System.Windows.Forms.ListBox listServicos;
        private System.Windows.Forms.Label label17;
        private Shared.PanelColorido panelColorido2;
        private System.Windows.Forms.ComboBox cbPlano;
        private System.Windows.Forms.MaskedTextBox tbDt_Devolucao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_motoristas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip tipAluguel;
        private System.Windows.Forms.Button bt_RemoveServico;
        private System.Windows.Forms.Button bt_AddServico;
        private System.Windows.Forms.Button bt_alterna_listas;
        private System.Windows.Forms.Panel panelEsconderCliente;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panelEsconderVeiculo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbTipoCnh;
        private System.Windows.Forms.TextBox tb_Cupom;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button bt_Aplicar;
    }
}