
namespace WindowsApp.ClienteModule
{
    partial class CadastroClientePF
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
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbNascimento = new System.Windows.Forms.Label();
            this.lbCNH = new System.Windows.Forms.Label();
            this.mtbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.cbTipoCNH = new System.Windows.Forms.ComboBox();
            this.tbCPF = new System.Windows.Forms.MaskedTextBox();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbCNH = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(252, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Cliente (PF)";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(56, 208);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(53, 21);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNome.Location = new System.Drawing.Point(125, 204);
            this.tbNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(237, 29);
            this.tbNome.TabIndex = 1;
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTelefone.ForeColor = System.Drawing.Color.White;
            this.lbTelefone.Location = new System.Drawing.Point(40, 261);
            this.lbTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(67, 21);
            this.lbTelefone.TabIndex = 1;
            this.lbTelefone.Text = "Telefone";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEndereco.ForeColor = System.Drawing.Color.White;
            this.lbEndereco.Location = new System.Drawing.Point(31, 314);
            this.lbEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(74, 21);
            this.lbEndereco.TabIndex = 1;
            this.lbEndereco.Text = "Endereço";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEndereco.Location = new System.Drawing.Point(125, 310);
            this.tbEndereco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(237, 29);
            this.tbEndereco.TabIndex = 3;
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCPF.ForeColor = System.Drawing.Color.White;
            this.lbCPF.Location = new System.Drawing.Point(447, 208);
            this.lbCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(37, 21);
            this.lbCPF.TabIndex = 1;
            this.lbCPF.Text = "CPF";
            // 
            // lbNascimento
            // 
            this.lbNascimento.AutoSize = true;
            this.lbNascimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNascimento.ForeColor = System.Drawing.Color.White;
            this.lbNascimento.Location = new System.Drawing.Point(382, 314);
            this.lbNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNascimento.Name = "lbNascimento";
            this.lbNascimento.Size = new System.Drawing.Size(93, 21);
            this.lbNascimento.TabIndex = 1;
            this.lbNascimento.Text = "Nascimento";
            // 
            // lbCNH
            // 
            this.lbCNH.AutoSize = true;
            this.lbCNH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCNH.ForeColor = System.Drawing.Color.White;
            this.lbCNH.Location = new System.Drawing.Point(440, 261);
            this.lbCNH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCNH.Name = "lbCNH";
            this.lbCNH.Size = new System.Drawing.Size(43, 21);
            this.lbCNH.TabIndex = 1;
            this.lbCNH.Text = "CNH";
            // 
            // mtbNascimento
            // 
            this.mtbNascimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mtbNascimento.Location = new System.Drawing.Point(497, 310);
            this.mtbNascimento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbNascimento.Mask = "00 / 00 / 0000";
            this.mtbNascimento.Name = "mtbNascimento";
            this.mtbNascimento.Size = new System.Drawing.Size(245, 29);
            this.mtbNascimento.TabIndex = 8;
            this.mtbNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // btAdicionar
            // 
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Image = global::WindowsApp.Properties.Resources.check;
            this.btAdicionar.Location = new System.Drawing.Point(678, 496);
            this.btAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(88, 92);
            this.btAdicionar.TabIndex = 9;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // cbTipoCNH
            // 
            this.cbTipoCNH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCNH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTipoCNH.FormattingEnabled = true;
            this.cbTipoCNH.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "C",
            "D",
            "E"});
            this.cbTipoCNH.Location = new System.Drawing.Point(678, 257);
            this.cbTipoCNH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTipoCNH.Name = "cbTipoCNH";
            this.cbTipoCNH.Size = new System.Drawing.Size(65, 29);
            this.cbTipoCNH.TabIndex = 7;
            // 
            // tbCPF
            // 
            this.tbCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCPF.Location = new System.Drawing.Point(497, 204);
            this.tbCPF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCPF.Mask = "000.000.000-00";
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(245, 29);
            this.tbCPF.TabIndex = 5;
            this.tbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTelefone.Location = new System.Drawing.Point(125, 257);
            this.tbTelefone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbTelefone.Mask = "(99) 00000-0000";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(237, 29);
            this.tbTelefone.TabIndex = 2;
            this.tbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbCNH
            // 
            this.tbCNH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCNH.Location = new System.Drawing.Point(497, 257);
            this.tbCNH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCNH.Mask = "00000000000";
            this.tbCNH.Name = "tbCNH";
            this.tbCNH.Size = new System.Drawing.Size(173, 29);
            this.tbCNH.TabIndex = 6;
            this.tbCNH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCNH.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbCNH.ValidatingType = typeof(int);
            // 
            // tb_email
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(125, 365);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbEmail.Name = "tb_email";
            this.tbEmail.Size = new System.Drawing.Size(237, 29);
            this.tbEmail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 368);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email";
            // 
            // CadastroClientePF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(779, 602);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCNH);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.cbTipoCNH);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.mtbNascimento);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.lbCNH);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.lbNascimento);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CadastroClientePF";
            this.Text = "CadastrarClientePF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lbNascimento;
        private System.Windows.Forms.Label lbCNH;
        private System.Windows.Forms.MaskedTextBox mtbNascimento;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.ComboBox cbTipoCNH;
        private System.Windows.Forms.MaskedTextBox tbCPF;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
        private System.Windows.Forms.MaskedTextBox tbCNH;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
    }
}