
using WindowsApp.Shared;

namespace WindowsApp.VeiculoModule
{
    partial class CadastroVeiculo
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
            this.tb_modelo = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_placa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_cambio = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_portas = new System.Windows.Forms.ComboBox();
            this.ofdImagem = new System.Windows.Forms.OpenFileDialog();
            this.bt_foto = new WindowsApp.Shared.BotaoComImagem();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_marca = new System.Windows.Forms.TextBox();
            this.cb_capacidade = new System.Windows.Forms.ComboBox();
            this.cb_portaMalas = new System.Windows.Forms.ComboBox();
            this.tb_quilometragem = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.MaskedTextBox();
            this.tb_chassi = new System.Windows.Forms.MaskedTextBox();
            this.cb_tipoCombustivel = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.tb_tanque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_modelo
            // 
            this.tb_modelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_modelo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_modelo.Location = new System.Drawing.Point(156, 170);
            this.tb_modelo.Margin = new System.Windows.Forms.Padding(4);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.Size = new System.Drawing.Size(205, 29);
            this.tb_modelo.TabIndex = 2;
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(288, 11);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(230, 32);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Cadastro de Veículo";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 174);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Modelo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 231);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ano";
            // 
            // tb_placa
            // 
            this.tb_placa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_placa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_placa.Location = new System.Drawing.Point(156, 347);
            this.tb_placa.Margin = new System.Windows.Forms.Padding(4);
            this.tb_placa.Name = "tb_placa";
            this.tb_placa.Size = new System.Drawing.Size(205, 29);
            this.tb_placa.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(88, 414);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Chassi";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(97, 351);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Placa";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(77, 473);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Câmbio";
            // 
            // cb_cambio
            // 
            this.cb_cambio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_cambio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cambio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cambio.FormattingEnabled = true;
            this.cb_cambio.Items.AddRange(new object[] {
            "Manual",
            "Automático"});
            this.cb_cambio.Location = new System.Drawing.Point(156, 469);
            this.cb_cambio.Margin = new System.Windows.Forms.Padding(4);
            this.cb_cambio.Name = "cb_cambio";
            this.cb_cambio.Size = new System.Drawing.Size(205, 29);
            this.cb_cambio.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(460, 292);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Quilometragem";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(488, 174);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Porta-malas";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(489, 231);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 23);
            this.label9.TabIndex = 14;
            this.label9.Text = "Capacidade";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(531, 113);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 23);
            this.label11.TabIndex = 14;
            this.label11.Text = "Portas";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(538, 498);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 23);
            this.label15.TabIndex = 16;
            this.label15.Text = "Foto";
            // 
            // cb_portas
            // 
            this.cb_portas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_portas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_portas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_portas.FormattingEnabled = true;
            this.cb_portas.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "6"});
            this.cb_portas.Location = new System.Drawing.Point(599, 110);
            this.cb_portas.Margin = new System.Windows.Forms.Padding(4);
            this.cb_portas.Name = "cb_portas";
            this.cb_portas.Size = new System.Drawing.Size(205, 29);
            this.cb_portas.TabIndex = 8;
            // 
            // ofdImagem
            // 
            this.ofdImagem.FileName = "seleciona_arquivo";
            // 
            // bt_foto
            // 
            this.bt_foto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_foto.FlatAppearance.BorderSize = 0;
            this.bt_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_foto.Location = new System.Drawing.Point(611, 451);
            this.bt_foto.Margin = new System.Windows.Forms.Padding(4);
            this.bt_foto.Name = "bt_foto";
            this.bt_foto.Size = new System.Drawing.Size(140, 117);
            this.bt_foto.TabIndex = 13;
            this.bt_foto.UseVisualStyleBackColor = true;
            this.bt_foto.Click += new System.EventHandler(this.bt_foto_Click);
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_adicionar.FlatAppearance.BorderSize = 0;
            this.bt_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_adicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.bt_adicionar.Image = global::WindowsApp.Properties.Resources.check;
            this.bt_adicionar.Location = new System.Drawing.Point(769, 529);
            this.bt_adicionar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(105, 98);
            this.bt_adicionar.TabIndex = 14;
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.bt_adicionar_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(88, 116);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Marca";
            // 
            // tb_marca
            // 
            this.tb_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_marca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_marca.Location = new System.Drawing.Point(156, 113);
            this.tb_marca.Margin = new System.Windows.Forms.Padding(4);
            this.tb_marca.Name = "tb_marca";
            this.tb_marca.Size = new System.Drawing.Size(205, 29);
            this.tb_marca.TabIndex = 1;
            // 
            // cb_capacidade
            // 
            this.cb_capacidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_capacidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_capacidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_capacidade.FormattingEnabled = true;
            this.cb_capacidade.Items.AddRange(new object[] {
            "2",
            "5",
            "8"});
            this.cb_capacidade.Location = new System.Drawing.Point(599, 228);
            this.cb_capacidade.Margin = new System.Windows.Forms.Padding(4);
            this.cb_capacidade.Name = "cb_capacidade";
            this.cb_capacidade.Size = new System.Drawing.Size(205, 29);
            this.cb_capacidade.TabIndex = 10;
            // 
            // cb_portaMalas
            // 
            this.cb_portaMalas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_portaMalas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_portaMalas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_portaMalas.FormattingEnabled = true;
            this.cb_portaMalas.Items.AddRange(new object[] {
            "Pequeno",
            "Médio",
            "Grande"});
            this.cb_portaMalas.Location = new System.Drawing.Point(599, 170);
            this.cb_portaMalas.Margin = new System.Windows.Forms.Padding(4);
            this.cb_portaMalas.Name = "cb_portaMalas";
            this.cb_portaMalas.Size = new System.Drawing.Size(205, 29);
            this.cb_portaMalas.TabIndex = 9;
            // 
            // tb_quilometragem
            // 
            this.tb_quilometragem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_quilometragem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tb_quilometragem.Location = new System.Drawing.Point(599, 288);
            this.tb_quilometragem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_quilometragem.Name = "tb_quilometragem";
            this.tb_quilometragem.Size = new System.Drawing.Size(205, 29);
            this.tb_quilometragem.TabIndex = 11;
            this.tb_quilometragem.Text = "0";
            // 
            // tb_ano
            // 
            this.tb_ano.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_ano.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tb_ano.Location = new System.Drawing.Point(156, 228);
            this.tb_ano.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_ano.Mask = "0000";
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(205, 29);
            this.tb_ano.TabIndex = 3;
            this.tb_ano.ValidatingType = typeof(int);
            // 
            // tb_chassi
            // 
            this.tb_chassi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_chassi.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tb_chassi.Location = new System.Drawing.Point(156, 407);
            this.tb_chassi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_chassi.Mask = "&&&&&&&&&&&&&&&&&";
            this.tb_chassi.Name = "tb_chassi";
            this.tb_chassi.Size = new System.Drawing.Size(205, 29);
            this.tb_chassi.TabIndex = 6;
            this.tb_chassi.ValidatingType = typeof(int);
            // 
            // cb_tipoCombustivel
            // 
            this.cb_tipoCombustivel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_tipoCombustivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipoCombustivel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipoCombustivel.FormattingEnabled = true;
            this.cb_tipoCombustivel.Items.AddRange(new object[] {
            "Alcool",
            "Diesel",
            "Etanol",
            "Flex",
            "Gasolina"});
            this.cb_tipoCombustivel.Location = new System.Drawing.Point(600, 347);
            this.cb_tipoCombustivel.Margin = new System.Windows.Forms.Padding(4);
            this.cb_tipoCombustivel.Name = "cb_tipoCombustivel";
            this.cb_tipoCombustivel.Size = new System.Drawing.Size(205, 29);
            this.cb_tipoCombustivel.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(447, 351);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 23);
            this.label14.TabIndex = 21;
            this.label14.Text = "Tipo Combustível";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(61, 292);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 23);
            this.label16.TabIndex = 23;
            this.label16.Text = "Categoria";
            // 
            // cb_categoria
            // 
            this.cb_categoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Items.AddRange(new object[] {
            "2",
            "5",
            "8"});
            this.cb_categoria.Location = new System.Drawing.Point(156, 288);
            this.cb_categoria.Margin = new System.Windows.Forms.Padding(4);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(205, 29);
            this.cb_categoria.TabIndex = 4;
            // 
            // tb_tanque
            // 
            this.tb_tanque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_tanque.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tb_tanque.Location = new System.Drawing.Point(599, 396);
            this.tb_tanque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tanque.Name = "tb_tanque";
            this.tb_tanque.Size = new System.Drawing.Size(205, 29);
            this.tb_tanque.TabIndex = 24;
            this.tb_tanque.Text = "50";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(433, 399);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 23);
            this.label3.TabIndex = 25;
            this.label3.Text = "Capacidade Tanque";
            // 
            // CadastroVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(891, 642);
            this.Controls.Add(this.tb_tanque);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cb_tipoCombustivel);
            this.Controls.Add(this.tb_chassi);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_quilometragem);
            this.Controls.Add(this.cb_portaMalas);
            this.Controls.Add(this.cb_capacidade);
            this.Controls.Add(this.tb_marca);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bt_foto);
            this.Controls.Add(this.cb_portas);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_cambio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_adicionar);
            this.Controls.Add(this.tb_placa);
            this.Controls.Add(this.tb_modelo);
            this.Controls.Add(this.lbTitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroVeiculo";
            this.Text = "FormCadastrarVeiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_modelo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_placa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_cambio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_portas;
        private System.Windows.Forms.OpenFileDialog ofdImagem;
        private Shared.BotaoComImagem bt_foto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_marca;
        private System.Windows.Forms.ComboBox cb_capacidade;
        private System.Windows.Forms.ComboBox cb_portaMalas;
        private System.Windows.Forms.TextBox tb_quilometragem;
        private System.Windows.Forms.MaskedTextBox tb_ano;
        private System.Windows.Forms.MaskedTextBox tb_chassi;
        private System.Windows.Forms.ComboBox cb_tipoCombustivel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.TextBox tb_tanque;
        private System.Windows.Forms.Label label3;
    }
}