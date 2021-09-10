
namespace WindowsApp
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.PanelMenuLateral = new System.Windows.Forms.Panel();
            this.btConfiguracoes = new System.Windows.Forms.Button();
            this.bt_servicos = new System.Windows.Forms.Button();
            this.bt_funcionarios = new System.Windows.Forms.Button();
            this.panelSubMenuVeiculos = new System.Windows.Forms.Panel();
            this.btGrupos = new System.Windows.Forms.Button();
            this.btVeiculosSubMenu = new System.Windows.Forms.Button();
            this.bt_veiculos = new System.Windows.Forms.Button();
            this.panelSubMenuClientes = new System.Windows.Forms.Panel();
            this.btPessoaJuridica = new System.Windows.Forms.Button();
            this.btPessoaFisica = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_sair = new System.Windows.Forms.Button();
            this.bt_clientes = new System.Windows.Forms.Button();
            this.bt_aluguel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.panelFormFilho = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCargo = new System.Windows.Forms.Label();
            this.foto_perfil = new PictureBoxRedondo();
            this.PanelMenuLateral.SuspendLayout();
            this.panelSubMenuVeiculos.SuspendLayout();
            this.panelSubMenuClientes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelFormFilho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto_perfil)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenuLateral
            // 
            this.PanelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.PanelMenuLateral.Controls.Add(this.btConfiguracoes);
            this.PanelMenuLateral.Controls.Add(this.bt_servicos);
            this.PanelMenuLateral.Controls.Add(this.bt_funcionarios);
            this.PanelMenuLateral.Controls.Add(this.panelSubMenuVeiculos);
            this.PanelMenuLateral.Controls.Add(this.bt_veiculos);
            this.PanelMenuLateral.Controls.Add(this.panelSubMenuClientes);
            this.PanelMenuLateral.Controls.Add(this.panel3);
            this.PanelMenuLateral.Controls.Add(this.bt_clientes);
            this.PanelMenuLateral.Controls.Add(this.bt_aluguel);
            this.PanelMenuLateral.Controls.Add(this.panel1);
            this.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuLateral.Name = "PanelMenuLateral";
            this.PanelMenuLateral.Size = new System.Drawing.Size(250, 561);
            this.PanelMenuLateral.TabIndex = 0;
            // 
            // btConfiguracoes
            // 
            this.btConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfiguracoes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.btConfiguracoes.Image = global::WindowsApp.Properties.Resources.settings;
            this.btConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConfiguracoes.Location = new System.Drawing.Point(0, 550);
            this.btConfiguracoes.Name = "btConfiguracoes";
            this.btConfiguracoes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btConfiguracoes.Size = new System.Drawing.Size(250, 50);
            this.btConfiguracoes.TabIndex = 19;
            this.btConfiguracoes.Text = " Configurações";
            this.btConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btConfiguracoes.UseVisualStyleBackColor = true;
            this.btConfiguracoes.Click += new System.EventHandler(this.btConfiguracoes_Click);
            // 
            // bt_servicos
            // 
            this.bt_servicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_servicos.FlatAppearance.BorderSize = 0;
            this.bt_servicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_servicos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_servicos.ForeColor = System.Drawing.Color.White;
            this.bt_servicos.Image = global::WindowsApp.Properties.Resources.servicos;
            this.bt_servicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_servicos.Location = new System.Drawing.Point(0, 500);
            this.bt_servicos.Name = "bt_servicos";
            this.bt_servicos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bt_servicos.Size = new System.Drawing.Size(250, 50);
            this.bt_servicos.TabIndex = 18;
            this.bt_servicos.Text = " Serviços";
            this.bt_servicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_servicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_servicos.UseVisualStyleBackColor = true;
            this.bt_servicos.Click += new System.EventHandler(this.bt_Servicos_Click);
            // 
            // bt_funcionarios
            // 
            this.bt_funcionarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_funcionarios.FlatAppearance.BorderSize = 0;
            this.bt_funcionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_funcionarios.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_funcionarios.ForeColor = System.Drawing.Color.White;
            this.bt_funcionarios.Image = global::WindowsApp.Properties.Resources.funcionarios;
            this.bt_funcionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_funcionarios.Location = new System.Drawing.Point(0, 450);
            this.bt_funcionarios.Name = "bt_funcionarios";
            this.bt_funcionarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bt_funcionarios.Size = new System.Drawing.Size(250, 50);
            this.bt_funcionarios.TabIndex = 17;
            this.bt_funcionarios.Text = " Funcionários";
            this.bt_funcionarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_funcionarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_funcionarios.UseVisualStyleBackColor = true;
            this.bt_funcionarios.Click += new System.EventHandler(this.bt_funcionarios_Click);
            // 
            // panelSubMenuVeiculos
            // 
            this.panelSubMenuVeiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.panelSubMenuVeiculos.Controls.Add(this.btGrupos);
            this.panelSubMenuVeiculos.Controls.Add(this.btVeiculosSubMenu);
            this.panelSubMenuVeiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuVeiculos.Location = new System.Drawing.Point(0, 350);
            this.panelSubMenuVeiculos.Name = "panelSubMenuVeiculos";
            this.panelSubMenuVeiculos.Size = new System.Drawing.Size(250, 100);
            this.panelSubMenuVeiculos.TabIndex = 16;
            // 
            // btGrupos
            // 
            this.btGrupos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btGrupos.FlatAppearance.BorderSize = 0;
            this.btGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGrupos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGrupos.ForeColor = System.Drawing.Color.White;
            this.btGrupos.Location = new System.Drawing.Point(0, 50);
            this.btGrupos.Name = "btGrupos";
            this.btGrupos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btGrupos.Size = new System.Drawing.Size(250, 50);
            this.btGrupos.TabIndex = 3;
            this.btGrupos.Text = "Grupos";
            this.btGrupos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGrupos.UseVisualStyleBackColor = true;
            this.btGrupos.Click += new System.EventHandler(this.btGrupos_Click);
            // 
            // btVeiculosSubMenu
            // 
            this.btVeiculosSubMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btVeiculosSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btVeiculosSubMenu.FlatAppearance.BorderSize = 0;
            this.btVeiculosSubMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVeiculosSubMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVeiculosSubMenu.ForeColor = System.Drawing.Color.White;
            this.btVeiculosSubMenu.Location = new System.Drawing.Point(0, 0);
            this.btVeiculosSubMenu.Name = "btVeiculosSubMenu";
            this.btVeiculosSubMenu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btVeiculosSubMenu.Size = new System.Drawing.Size(250, 50);
            this.btVeiculosSubMenu.TabIndex = 2;
            this.btVeiculosSubMenu.Text = "Veículos";
            this.btVeiculosSubMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVeiculosSubMenu.UseVisualStyleBackColor = true;
            this.btVeiculosSubMenu.Click += new System.EventHandler(this.btVeiculosSubMenu_Click);
            // 
            // bt_veiculos
            // 
            this.bt_veiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_veiculos.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_veiculos.FlatAppearance.BorderSize = 0;
            this.bt_veiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_veiculos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_veiculos.ForeColor = System.Drawing.Color.White;
            this.bt_veiculos.Image = global::WindowsApp.Properties.Resources.veiculos;
            this.bt_veiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_veiculos.Location = new System.Drawing.Point(0, 300);
            this.bt_veiculos.Name = "bt_veiculos";
            this.bt_veiculos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bt_veiculos.Size = new System.Drawing.Size(250, 50);
            this.bt_veiculos.TabIndex = 9;
            this.bt_veiculos.Text = " Veículos";
            this.bt_veiculos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_veiculos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_veiculos.UseVisualStyleBackColor = true;
            this.bt_veiculos.Click += new System.EventHandler(this.bt_Veiculos_Click);
            // 
            // panelSubMenuClientes
            // 
            this.panelSubMenuClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.panelSubMenuClientes.Controls.Add(this.btPessoaJuridica);
            this.panelSubMenuClientes.Controls.Add(this.btPessoaFisica);
            this.panelSubMenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuClientes.Location = new System.Drawing.Point(0, 200);
            this.panelSubMenuClientes.Name = "panelSubMenuClientes";
            this.panelSubMenuClientes.Size = new System.Drawing.Size(250, 100);
            this.panelSubMenuClientes.TabIndex = 8;
            // 
            // btPessoaJuridica
            // 
            this.btPessoaJuridica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPessoaJuridica.FlatAppearance.BorderSize = 0;
            this.btPessoaJuridica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPessoaJuridica.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPessoaJuridica.ForeColor = System.Drawing.Color.White;
            this.btPessoaJuridica.Location = new System.Drawing.Point(0, 50);
            this.btPessoaJuridica.Name = "btPessoaJuridica";
            this.btPessoaJuridica.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btPessoaJuridica.Size = new System.Drawing.Size(250, 50);
            this.btPessoaJuridica.TabIndex = 3;
            this.btPessoaJuridica.Text = "Pessoa Jurídica";
            this.btPessoaJuridica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPessoaJuridica.UseVisualStyleBackColor = true;
            this.btPessoaJuridica.Click += new System.EventHandler(this.btPessoaJuridica_Click);
            // 
            // btPessoaFisica
            // 
            this.btPessoaFisica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPessoaFisica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPessoaFisica.FlatAppearance.BorderSize = 0;
            this.btPessoaFisica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPessoaFisica.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPessoaFisica.ForeColor = System.Drawing.Color.White;
            this.btPessoaFisica.Location = new System.Drawing.Point(0, 0);
            this.btPessoaFisica.Name = "btPessoaFisica";
            this.btPessoaFisica.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btPessoaFisica.Size = new System.Drawing.Size(250, 50);
            this.btPessoaFisica.TabIndex = 2;
            this.btPessoaFisica.Text = "Pessoa Física";
            this.btPessoaFisica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPessoaFisica.UseVisualStyleBackColor = true;
            this.btPessoaFisica.Click += new System.EventHandler(this.btPessoaFisica_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_sair);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 507);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 54);
            this.panel3.TabIndex = 7;
            // 
            // bt_sair
            // 
            this.bt_sair.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_sair.FlatAppearance.BorderSize = 0;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sair.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sair.ForeColor = System.Drawing.Color.White;
            this.bt_sair.Image = global::WindowsApp.Properties.Resources.sair;
            this.bt_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sair.Location = new System.Drawing.Point(0, 0);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bt_sair.Size = new System.Drawing.Size(250, 51);
            this.bt_sair.TabIndex = 9;
            this.bt_sair.Text = " Sair";
            this.bt_sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // bt_clientes
            // 
            this.bt_clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_clientes.FlatAppearance.BorderSize = 0;
            this.bt_clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_clientes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clientes.ForeColor = System.Drawing.Color.White;
            this.bt_clientes.Image = global::WindowsApp.Properties.Resources.clientes;
            this.bt_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_clientes.Location = new System.Drawing.Point(0, 150);
            this.bt_clientes.Name = "bt_clientes";
            this.bt_clientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bt_clientes.Size = new System.Drawing.Size(250, 50);
            this.bt_clientes.TabIndex = 3;
            this.bt_clientes.Text = " Clientes";
            this.bt_clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_clientes.UseVisualStyleBackColor = true;
            this.bt_clientes.Click += new System.EventHandler(this.bt_clientes_Click);
            // 
            // bt_aluguel
            // 
            this.bt_aluguel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_aluguel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_aluguel.FlatAppearance.BorderSize = 0;
            this.bt_aluguel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_aluguel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_aluguel.ForeColor = System.Drawing.Color.White;
            this.bt_aluguel.Image = global::WindowsApp.Properties.Resources.aluguel;
            this.bt_aluguel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_aluguel.Location = new System.Drawing.Point(0, 100);
            this.bt_aluguel.Name = "bt_aluguel";
            this.bt_aluguel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bt_aluguel.Size = new System.Drawing.Size(250, 50);
            this.bt_aluguel.TabIndex = 1;
            this.bt_aluguel.Text = " Aluguel de Veículos";
            this.bt_aluguel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_aluguel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_aluguel.UseVisualStyleBackColor = true;
            this.bt_aluguel.Click += new System.EventHandler(this.bt_Aluguel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.lbCargo);
            this.panel1.Controls.Add(this.foto_perfil);
            this.panel1.Controls.Add(this.lbUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.Color.White;
            this.lbUsuario.Location = new System.Drawing.Point(95, 32);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(95, 21);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "Funcionário";
            // 
            // panelFormFilho
            // 
            this.panelFormFilho.Controls.Add(this.label3);
            this.panelFormFilho.Controls.Add(this.labelTitulo);
            this.panelFormFilho.Controls.Add(this.pictureBox1);
            this.panelFormFilho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormFilho.Location = new System.Drawing.Point(250, 0);
            this.panelFormFilho.Name = "panelFormFilho";
            this.panelFormFilho.Size = new System.Drawing.Size(684, 561);
            this.panelFormFilho.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(646, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "V1.0.0";
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("LEMON MILK Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(100, 374);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(485, 91);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Rech-a-Car";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 273);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCargo.ForeColor = System.Drawing.Color.White;
            this.lbCargo.Location = new System.Drawing.Point(96, 53);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(44, 17);
            this.lbCargo.TabIndex = 3;
            this.lbCargo.Text = "Cargo";
            // 
            // foto_perfil
            // 
            this.foto_perfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foto_perfil.BackColor = System.Drawing.Color.DarkGray;
            this.foto_perfil.Image = ((System.Drawing.Image)(resources.GetObject("foto_perfil.Image")));
            this.foto_perfil.Location = new System.Drawing.Point(29, 21);
            this.foto_perfil.Name = "foto_perfil";
            this.foto_perfil.Size = new System.Drawing.Size(60, 60);
            this.foto_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto_perfil.TabIndex = 2;
            this.foto_perfil.TabStop = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelFormFilho);
            this.Controls.Add(this.PanelMenuLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 596);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rech-a-Car";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaPrincipal_FormClosing);
            this.PanelMenuLateral.ResumeLayout(false);
            this.panelSubMenuVeiculos.ResumeLayout(false);
            this.panelSubMenuClientes.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFormFilho.ResumeLayout(false);
            this.panelFormFilho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foto_perfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenuLateral;
        private System.Windows.Forms.Button bt_aluguel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Panel panelFormFilho;
        private System.Windows.Forms.PictureBox pictureBox1;
        private PictureBoxRedondo foto_perfil;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_veiculos;
        private System.Windows.Forms.Panel panelSubMenuClientes;
        private System.Windows.Forms.Button bt_clientes;
        private System.Windows.Forms.Button btPessoaFisica;
        private System.Windows.Forms.Button btPessoaJuridica;
        private System.Windows.Forms.Button btConfiguracoes;
        private System.Windows.Forms.Button bt_servicos;
        private System.Windows.Forms.Button bt_funcionarios;
        private System.Windows.Forms.Panel panelSubMenuVeiculos;
        private System.Windows.Forms.Button btGrupos;
        private System.Windows.Forms.Button btVeiculosSubMenu;
        private System.Windows.Forms.Label lbCargo;
    }
}

