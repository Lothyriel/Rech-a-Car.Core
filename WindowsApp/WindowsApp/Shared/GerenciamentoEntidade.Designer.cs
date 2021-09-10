
namespace WindowsApp.Shared
{
    partial class GerenciamentoEntidade <T>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEntidade = new System.Windows.Forms.DataGridView();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panelFormFilho = new System.Windows.Forms.Panel();
            this.bt_check = new System.Windows.Forms.Button();
            this.picLupa = new System.Windows.Forms.PictureBox();
            this.bt_remover = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_adicionar = new System.Windows.Forms.Button();
            this.btFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidade)).BeginInit();
            this.panelFormFilho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEntidade
            // 
            this.dgvEntidade.AllowUserToAddRows = false;
            this.dgvEntidade.AllowUserToDeleteRows = false;
            this.dgvEntidade.AllowUserToResizeColumns = false;
            this.dgvEntidade.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.dgvEntidade.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEntidade.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.dgvEntidade.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(4)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(4)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntidade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEntidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntidade.Cursor = System.Windows.Forms.Cursors.Cross;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntidade.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEntidade.EnableHeadersVisualStyles = false;
            this.dgvEntidade.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.dgvEntidade.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvEntidade.Location = new System.Drawing.Point(35, 178);
            this.dgvEntidade.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEntidade.MultiSelect = false;
            this.dgvEntidade.Name = "dgvEntidade";
            this.dgvEntidade.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(4)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(4)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntidade.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEntidade.RowHeadersVisible = false;
            this.dgvEntidade.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.dgvEntidade.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEntidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntidade.Size = new System.Drawing.Size(821, 436);
            this.dgvEntidade.TabIndex = 9;
            this.dgvEntidade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntidade_CellClick);
            this.dgvEntidade.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntidade_CellDoubleClick);
            // 
            // tbFiltro
            // 
            this.tbFiltro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltro.Location = new System.Drawing.Point(35, 107);
            this.tbFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(379, 39);
            this.tbFiltro.TabIndex = 6;
            this.tbFiltro.TextChanged += new System.EventHandler(this.tbFiltro_TextChanged);
            // 
            // lbTitulo
            // 
            this.lbTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(275, 9);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(318, 32);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Gerenciamento de Entidade";
            // 
            // panelFormFilho
            // 
            this.panelFormFilho.Controls.Add(this.bt_check);
            this.panelFormFilho.Controls.Add(this.picLupa);
            this.panelFormFilho.Controls.Add(this.bt_remover);
            this.panelFormFilho.Controls.Add(this.bt_editar);
            this.panelFormFilho.Controls.Add(this.bt_adicionar);
            this.panelFormFilho.Controls.Add(this.btFiltro);
            this.panelFormFilho.Controls.Add(this.lbTitulo);
            this.panelFormFilho.Controls.Add(this.dgvEntidade);
            this.panelFormFilho.Location = new System.Drawing.Point(0, 0);
            this.panelFormFilho.Margin = new System.Windows.Forms.Padding(4);
            this.panelFormFilho.Name = "panelFormFilho";
            this.panelFormFilho.Size = new System.Drawing.Size(893, 641);
            this.panelFormFilho.TabIndex = 13;
            // 
            // bt_check
            // 
            this.bt_check.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_check.Enabled = false;
            this.bt_check.FlatAppearance.BorderSize = 0;
            this.bt_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.bt_check.Image = global::WindowsApp.Properties.Resources.confirmar1;
            this.bt_check.Location = new System.Drawing.Point(784, 84);
            this.bt_check.Margin = new System.Windows.Forms.Padding(4);
            this.bt_check.Name = "bt_check";
            this.bt_check.Size = new System.Drawing.Size(80, 74);
            this.bt_check.TabIndex = 15;
            this.bt_check.UseVisualStyleBackColor = true;
            this.bt_check.Click += new System.EventHandler(this.bt_check_Click);
            // 
            // picLupa
            // 
            this.picLupa.Image = global::WindowsApp.Properties.Resources.pesquisa;
            this.picLupa.Location = new System.Drawing.Point(423, 107);
            this.picLupa.Margin = new System.Windows.Forms.Padding(4);
            this.picLupa.Name = "picLupa";
            this.picLupa.Size = new System.Drawing.Size(44, 41);
            this.picLupa.TabIndex = 7;
            this.picLupa.TabStop = false;
            // 
            // bt_remover
            // 
            this.bt_remover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_remover.Enabled = false;
            this.bt_remover.FlatAppearance.BorderSize = 0;
            this.bt_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_remover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.bt_remover.Image = global::WindowsApp.Properties.Resources.remover;
            this.bt_remover.Location = new System.Drawing.Point(549, 84);
            this.bt_remover.Margin = new System.Windows.Forms.Padding(4);
            this.bt_remover.Name = "bt_remover";
            this.bt_remover.Size = new System.Drawing.Size(80, 74);
            this.bt_remover.TabIndex = 8;
            this.bt_remover.UseVisualStyleBackColor = true;
            this.bt_remover.Click += new System.EventHandler(this.bt_remover_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_editar.Enabled = false;
            this.bt_editar.FlatAppearance.BorderSize = 0;
            this.bt_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_editar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.bt_editar.Image = global::WindowsApp.Properties.Resources.editar1;
            this.bt_editar.Location = new System.Drawing.Point(633, 84);
            this.bt_editar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(80, 74);
            this.bt_editar.TabIndex = 11;
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_adicionar
            // 
            this.bt_adicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_adicionar.FlatAppearance.BorderSize = 0;
            this.bt_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_adicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.bt_adicionar.Image = global::WindowsApp.Properties.Resources.adicionar;
            this.bt_adicionar.Location = new System.Drawing.Point(717, 84);
            this.bt_adicionar.Margin = new System.Windows.Forms.Padding(4);
            this.bt_adicionar.Name = "bt_adicionar";
            this.bt_adicionar.Size = new System.Drawing.Size(80, 74);
            this.bt_adicionar.TabIndex = 12;
            this.bt_adicionar.UseVisualStyleBackColor = true;
            this.bt_adicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btFiltro
            // 
            this.btFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btFiltro.FlatAppearance.BorderSize = 0;
            this.btFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.btFiltro.Image = global::WindowsApp.Properties.Resources.filtro1;
            this.btFiltro.Location = new System.Drawing.Point(468, 89);
            this.btFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(88, 69);
            this.btFiltro.TabIndex = 11;
            this.btFiltro.UseVisualStyleBackColor = true;
            this.btFiltro.Click += new System.EventHandler(this.btFiltro_Click);
            // 
            // GerenciamentoEntidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(891, 642);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.panelFormFilho);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GerenciamentoEntidade";
            this.Text = "FormGerenciamento";
            this.Load += new System.EventHandler(this.GerenciamentoEntidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidade)).EndInit();
            this.panelFormFilho.ResumeLayout(false);
            this.panelFormFilho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DataGridView dgvEntidade;
        private System.Windows.Forms.Button bt_remover;
        private System.Windows.Forms.PictureBox picLupa;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_adicionar;
        private System.Windows.Forms.Panel panelFormFilho;
        private System.Windows.Forms.Button btFiltro;
        private System.Windows.Forms.Button bt_check;
    }
}