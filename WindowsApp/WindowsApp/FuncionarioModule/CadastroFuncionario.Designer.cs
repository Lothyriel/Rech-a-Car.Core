
using WindowsApp.Shared;

namespace WindowsApp.FuncionarioModule
{
    partial class CadastroFuncionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbCPF = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.ofdImagem = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_foto = new WindowsApp.Shared.BotaoComImagem();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_cargo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(279, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Funcionários";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(232, 145);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(66, 28);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(311, 142);
            this.tbNome.Margin = new System.Windows.Forms.Padding(4);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(311, 34);
            this.tbNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(213, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(204, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Endereço";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndereco.Location = new System.Drawing.Point(311, 226);
            this.tbEndereco.Margin = new System.Windows.Forms.Padding(4);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(311, 34);
            this.tbEndereco.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(253, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "CPF";
            // 
            // btAdicionar
            // 
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Image = global::WindowsApp.Properties.Resources.check;
            this.btAdicionar.Location = new System.Drawing.Point(775, 534);
            this.btAdicionar.Margin = new System.Windows.Forms.Padding(4);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(100, 94);
            this.btAdicionar.TabIndex = 8;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // tbTelefone
            // 
            this.tbTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefone.Location = new System.Drawing.Point(311, 185);
            this.tbTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefone.Mask = "(99) 00000-0000";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(311, 34);
            this.tbTelefone.TabIndex = 2;
            this.tbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbCPF
            // 
            this.tbCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPF.Location = new System.Drawing.Point(311, 270);
            this.tbCPF.Margin = new System.Windows.Forms.Padding(4);
            this.tbCPF.Mask = "000.000.000-00";
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(311, 34);
            this.tbCPF.TabIndex = 4;
            this.tbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(248, 482);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 28);
            this.label15.TabIndex = 18;
            this.label15.Text = "Foto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(217, 359);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Usuário";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(311, 356);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(311, 34);
            this.tbUsuario.TabIndex = 5;
            // 
            // ofdImagem
            // 
            this.ofdImagem.FileName = "ofdImagem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(232, 402);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 28);
            this.label6.TabIndex = 1;
            this.label6.Text = "Senha";
            // 
            // bt_foto
            // 
            this.bt_foto.FlatAppearance.BorderSize = 0;
            this.bt_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_foto.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_foto.Location = new System.Drawing.Point(339, 454);
            this.bt_foto.Name = "bt_foto";
            this.bt_foto.Size = new System.Drawing.Size(98, 90);
            this.bt_foto.TabIndex = 7;
            this.bt_foto.UseVisualStyleBackColor = true;
            this.bt_foto.Click += new System.EventHandler(this.bt_foto_Click);
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSenha.Location = new System.Drawing.Point(311, 399);
            this.tbSenha.Margin = new System.Windows.Forms.Padding(4);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.Size = new System.Drawing.Size(311, 34);
            this.tbSenha.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(233, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Cargo";
            // 
            // cb_cargo
            // 
            this.cb_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cargo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cb_cargo.FormattingEnabled = true;
            this.cb_cargo.Items.AddRange(new object[] {
            "SysAdmin",
            "Vendedor"});
            this.cb_cargo.Location = new System.Drawing.Point(311, 316);
            this.cb_cargo.Margin = new System.Windows.Forms.Padding(4);
            this.cb_cargo.Name = "cb_cargo";
            this.cb_cargo.Size = new System.Drawing.Size(311, 29);
            this.cb_cargo.TabIndex = 19;
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(891, 642);
            this.Controls.Add(this.cb_cargo);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.bt_foto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadastroFuncionario";
            this.Text = "CadastroFuncionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
        private System.Windows.Forms.MaskedTextBox tbCPF;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.OpenFileDialog ofdImagem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSenha;
        private Shared.BotaoComImagem bt_foto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_cargo;
    }
}