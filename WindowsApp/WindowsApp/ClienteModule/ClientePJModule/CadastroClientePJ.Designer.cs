
namespace WindowsApp.ClienteModule
{
    partial class CadastroClientePJ
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tipMotoristas = new System.Windows.Forms.ToolTip(this.components);
            this.bt_add_motorista = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_remover_motorista = new System.Windows.Forms.Button();
            this.bt_editar_motorista = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.dgvMotoristas = new System.Windows.Forms.DataGridView();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotoristas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCNPJ.ForeColor = System.Drawing.Color.White;
            this.lbCNPJ.Location = new System.Drawing.Point(57, 357);
            this.lbCNPJ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(56, 28);
            this.lbCNPJ.TabIndex = 9;
            this.lbCNPJ.Text = "CNPJ";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefone.ForeColor = System.Drawing.Color.White;
            this.lbTelefone.Location = new System.Drawing.Point(29, 238);
            this.lbTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(84, 28);
            this.lbTelefone.TabIndex = 12;
            this.lbTelefone.Text = "Telefone";
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEndereco.ForeColor = System.Drawing.Color.White;
            this.lbEndereco.Location = new System.Drawing.Point(20, 300);
            this.lbEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(93, 28);
            this.lbEndereco.TabIndex = 13;
            this.lbEndereco.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(287, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cadastro de Cliente (PJ)";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(48, 181);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(66, 28);
            this.lbNome.TabIndex = 15;
            this.lbNome.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(127, 177);
            this.tbNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(276, 34);
            this.tbNome.TabIndex = 1;
            // 
            // tbEndereco
            // 
            this.tbEndereco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEndereco.Location = new System.Drawing.Point(127, 297);
            this.tbEndereco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(276, 34);
            this.tbEndereco.TabIndex = 3;
            // 
            // tbCNPJ
            // 
            this.tbCNPJ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCNPJ.Location = new System.Drawing.Point(127, 353);
            this.tbCNPJ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCNPJ.Mask = "00.000.000 /0000-00";
            this.tbCNPJ.Name = "tbCNPJ";
            this.tbCNPJ.Size = new System.Drawing.Size(276, 34);
            this.tbCNPJ.TabIndex = 4;
            this.tbCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefone.Location = new System.Drawing.Point(127, 234);
            this.tbTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTelefone.Mask = "(99) 00000-0000";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(276, 34);
            this.tbTelefone.TabIndex = 2;
            this.tbTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // bt_add_motorista
            // 
            this.bt_add_motorista.FlatAppearance.BorderSize = 0;
            this.bt_add_motorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add_motorista.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add_motorista.ForeColor = System.Drawing.Color.White;
            this.bt_add_motorista.Image = global::WindowsApp.Properties.Resources.add;
            this.bt_add_motorista.Location = new System.Drawing.Point(713, 396);
            this.bt_add_motorista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_add_motorista.Name = "bt_add_motorista";
            this.bt_add_motorista.Size = new System.Drawing.Size(89, 86);
            this.bt_add_motorista.TabIndex = 19;
            this.tipMotoristas.SetToolTip(this.bt_add_motorista, "Cadastrar Motoristas");
            this.bt_add_motorista.UseVisualStyleBackColor = false;
            this.bt_add_motorista.Click += new System.EventHandler(this.bt_add_motorista_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(588, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Motoristas";
            // 
            // bt_remover_motorista
            // 
            this.bt_remover_motorista.FlatAppearance.BorderSize = 0;
            this.bt_remover_motorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_remover_motorista.Image = global::WindowsApp.Properties.Resources.remove;
            this.bt_remover_motorista.Location = new System.Drawing.Point(485, 396);
            this.bt_remover_motorista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_remover_motorista.Name = "bt_remover_motorista";
            this.bt_remover_motorista.Size = new System.Drawing.Size(100, 86);
            this.bt_remover_motorista.TabIndex = 22;
            this.bt_remover_motorista.UseVisualStyleBackColor = true;
            this.bt_remover_motorista.Click += new System.EventHandler(this.bt_remover_motorista_Click);
            // 
            // bt_editar_motorista
            // 
            this.bt_editar_motorista.FlatAppearance.BorderSize = 0;
            this.bt_editar_motorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar_motorista.Image = global::WindowsApp.Properties.Resources.edit;
            this.bt_editar_motorista.Location = new System.Drawing.Point(593, 396);
            this.bt_editar_motorista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_editar_motorista.Name = "bt_editar_motorista";
            this.bt_editar_motorista.Size = new System.Drawing.Size(100, 86);
            this.bt_editar_motorista.TabIndex = 21;
            this.bt_editar_motorista.UseVisualStyleBackColor = true;
            this.bt_editar_motorista.Click += new System.EventHandler(this.bt_editar_motorista_Click);
            // 
            // btAdicionar
            // 
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Image = global::WindowsApp.Properties.Resources.check;
            this.btAdicionar.Location = new System.Drawing.Point(775, 530);
            this.btAdicionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(100, 97);
            this.btAdicionar.TabIndex = 18;
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // dgvMotoristas
            // 
            this.dgvMotoristas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMotoristas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMotoristas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMotoristas.ColumnHeadersVisible = false;
            this.dgvMotoristas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.dgvMotoristas.Location = new System.Drawing.Point(437, 177);
            this.dgvMotoristas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMotoristas.Name = "dgvMotoristas";
            this.dgvMotoristas.RowHeadersVisible = false;
            this.dgvMotoristas.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.dgvMotoristas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMotoristas.Size = new System.Drawing.Size(413, 212);
            this.dgvMotoristas.TabIndex = 23;
            this.dgvMotoristas.SelectionChanged += new System.EventHandler(this.dgvMotoristas_SelectionChanged);
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(127, 409);
            this.tb_email.Margin = new System.Windows.Forms.Padding(4);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(276, 34);
            this.tb_email.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 412);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email";
            // 
            // CadastroClientePJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(891, 642);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMotoristas);
            this.Controls.Add(this.bt_remover_motorista);
            this.Controls.Add(this.bt_editar_motorista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCNPJ);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.bt_add_motorista);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.lbCNPJ);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CadastroClientePJ";
            this.Text = "CadastrarClientePJ";
            this.Load += new System.EventHandler(this.CadastroClientePJ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMotoristas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Label lbCNPJ;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.Button bt_add_motorista;
        private System.Windows.Forms.MaskedTextBox tbCNPJ;
        private System.Windows.Forms.MaskedTextBox tbTelefone;
        private System.Windows.Forms.ToolTip tipMotoristas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_editar_motorista;
        private System.Windows.Forms.Button bt_remover_motorista;
        private System.Windows.Forms.DataGridView dgvMotoristas;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label3;
    }
}