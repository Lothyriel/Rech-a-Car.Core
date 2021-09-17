
namespace WindowsApp.ClienteModule
{
    partial class CadastroMotorista
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
            this.label8 = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoCNH = new System.Windows.Forms.ComboBox();
            this.tbCNH = new System.Windows.Forms.MaskedTextBox();
            this.tbCPF = new System.Windows.Forms.MaskedTextBox();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btAdicionarMotorista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(227, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(210, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "Cadastro de Motorista";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndereco.Location = new System.Drawing.Point(253, 229);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(208, 29);
            this.tbEndereco.TabIndex = 3;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(253, 130);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(208, 29);
            this.tbNome.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(201, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 27;
            this.label5.Text = "CNH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(180, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "Telefone";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.ForeColor = System.Drawing.Color.White;
            this.lbCPF.Location = new System.Drawing.Point(207, 281);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(37, 21);
            this.lbCPF.TabIndex = 29;
            this.lbCPF.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(173, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 30;
            this.label3.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(194, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nome";
            // 
            // cbTipoCNH
            // 
            this.cbTipoCNH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCNH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoCNH.FormattingEnabled = true;
            this.cbTipoCNH.Items.AddRange(new object[] {
            "A",
            "B",
            "AB",
            "C",
            "D",
            "E"});
            this.cbTipoCNH.Location = new System.Drawing.Point(405, 326);
            this.cbTipoCNH.Name = "cbTipoCNH";
            this.cbTipoCNH.Size = new System.Drawing.Size(56, 29);
            this.cbTipoCNH.TabIndex = 6;
            // 
            // tbCNH
            // 
            this.tbCNH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCNH.Location = new System.Drawing.Point(253, 326);
            this.tbCNH.Mask = "00000000000";
            this.tbCNH.Name = "tbCNH";
            this.tbCNH.Size = new System.Drawing.Size(146, 29);
            this.tbCNH.TabIndex = 5;
            this.tbCNH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCNH.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.tbCNH.ValidatingType = typeof(int);
            // 
            // tbCPF
            // 
            this.tbCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPF.Location = new System.Drawing.Point(253, 278);
            this.tbCPF.Mask = "000.000.000-00";
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(208, 29);
            this.tbCPF.TabIndex = 4;
            this.tbCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefone.Location = new System.Drawing.Point(253, 180);
            this.tbTelefone.Mask = "(99) 00000-0000";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(208, 29);
            this.tbTelefone.TabIndex = 2;
            this.tbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btAdicionarMotorista
            // 
            this.btAdicionarMotorista.FlatAppearance.BorderSize = 0;
            this.btAdicionarMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionarMotorista.Image = global::WindowsApp.Properties.Resources.check;
            this.btAdicionarMotorista.Location = new System.Drawing.Point(581, 437);
            this.btAdicionarMotorista.Name = "btAdicionarMotorista";
            this.btAdicionarMotorista.Size = new System.Drawing.Size(75, 73);
            this.btAdicionarMotorista.TabIndex = 7;
            this.btAdicionarMotorista.UseVisualStyleBackColor = true;
            this.btAdicionarMotorista.Click += new System.EventHandler(this.btAdicionarMotorista_Click);
            // 
            // CadastroMotorista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.tbCNH);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.cbTipoCNH);
            this.Controls.Add(this.btAdicionarMotorista);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "CadastroMotorista";
            this.Text = "CadastroMotorista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAdicionarMotorista;
        private System.Windows.Forms.ComboBox cbTipoCNH;
        private System.Windows.Forms.MaskedTextBox tbCNH;
        private System.Windows.Forms.MaskedTextBox tbCPF;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
    }
}