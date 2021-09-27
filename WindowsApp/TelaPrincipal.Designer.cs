using WindowsApp.Shared;

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
            this.panelSubMenuCupons = new System.Windows.Forms.Panel();
            this.btParceiros = new System.Windows.Forms.Button();
            this.btCupons = new System.Windows.Forms.Button();
            this.btCupom = new System.Windows.Forms.Button();
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
            this.lbCargo = new System.Windows.Forms.Label();
            this.foto_perfil = new PictureBoxRedondo();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.panelFormFilho = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelMenuLateral.SuspendLayout();
            this.panelSubMenuCupons.SuspendLayout();
            this.panelSubMenuVeiculos.SuspendLayout();
            this.panelSubMenuClientes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_perfil)).BeginInit();
            this.panelFormFilho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenuLateral
            // 
            this.PanelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.PanelMenuLateral.Controls.Add(this.btConfiguracoes);
            this.PanelMenuLateral.Controls.Add(this.panelSubMenuCupons);
            this.PanelMenuLateral.Controls.Add(this.btCupom);
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
            this.PanelMenuLateral.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.PanelMenuLateral.Name = "PanelMenuLateral";
            this.PanelMenuLateral.Size = new System.Drawing.Size(334, 847);
            this.PanelMenuLateral.TabIndex = 0;
            // 
            // btConfiguracoes
            // 
            this.btConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfiguracoes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.btConfiguracoes.Image = global::WindowsApp.Properties.Resources.settings;
            this.btConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConfiguracoes.Location = new System.Drawing.Point(0, 1074);
            this.btConfiguracoes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btConfiguracoes.Name = "btConfiguracoes";
            this.btConfiguracoes.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btConfiguracoes.Size = new System.Drawing.Size(334, 77);
            this.btConfiguracoes.TabIndex = 23;
            this.btConfiguracoes.Text = " Configurações";
            this.btConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btConfiguracoes.UseVisualStyleBackColor = true;
            this.btConfiguracoes.Click += new System.EventHandler(this.btConfiguracoes_Click);
            // 
            // panelSubMenuCupons
            // 
            this.panelSubMenuCupons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.panelSubMenuCupons.Controls.Add(this.btParceiros);
            this.panelSubMenuCupons.Controls.Add(this.btCupons);
            this.panelSubMenuCupons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCupons.Location = new System.Drawing.Point(0, 921);
            this.panelSubMenuCupons.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelSubMenuCupons.Name = "panelSubMenuCupons";
            this.panelSubMenuCupons.Size = new System.Drawing.Size(334, 153);
            this.panelSubMenuCupons.TabIndex = 21;
            // 
            // btParceiros
            // 
            this.btParceiros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btParceiros.FlatAppearance.BorderSize = 0;
            this.btParceiros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btParceiros.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btParceiros.ForeColor = System.Drawing.Color.White;
            this.btParceiros.Location = new System.Drawing.Point(0, 77);
            this.btParceiros.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btParceiros.Name = "btParceiros";
            this.btParceiros.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btParceiros.Size = new System.Drawing.Size(334, 77);
            this.btParceiros.TabIndex = 3;
            this.btParceiros.Text = "Parceiros";
            this.btParceiros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btParceiros.UseVisualStyleBackColor = true;
            this.btParceiros.Click += new System.EventHandler(this.btParceiros_Click);
            // 
            // btCupons
            // 
            this.btCupons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCupons.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCupons.FlatAppearance.BorderSize = 0;
            this.btCupons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCupons.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCupons.ForeColor = System.Drawing.Color.White;
            this.btCupons.Location = new System.Drawing.Point(0, 0);
            this.btCupons.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btCupons.Name = "btCupons";
            this.btCupons.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btCupons.Size = new System.Drawing.Size(334, 77);
            this.btCupons.TabIndex = 2;
            this.btCupons.Text = "Cupons";
            this.btCupons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCupons.UseVisualStyleBackColor = true;
            this.btCupons.Click += new System.EventHandler(this.btCupons_Click);
            // 
            // btCupom
            // 
            this.btCupom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCupom.FlatAppearance.BorderSize = 0;
            this.btCupom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCupom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCupom.ForeColor = System.Drawing.Color.White;
            this.btCupom.Image = global::WindowsApp.Properties.Resources.cupom;
            this.btCupom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCupom.Location = new System.Drawing.Point(0, 844);
            this.btCupom.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btCupom.Name = "btCupom";
            this.btCupom.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btCupom.Size = new System.Drawing.Size(334, 77);
            this.btCupom.TabIndex = 20;
            this.btCupom.Text = " Cupons";
            this.btCupom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCupom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCupom.UseVisualStyleBackColor = true;
            this.btCupom.Click += new System.EventHandler(this.btCupom_Click);
            // 
            // bt_servicos
            // 
            this.bt_servicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_servicos.FlatAppearance.BorderSize = 0;
            this.bt_servicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_servicos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_servicos.ForeColor = System.Drawing.Color.White;
            this.bt_servicos.Image = global::WindowsApp.Properties.Resources.servicos;
            this.bt_servicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_servicos.Location = new System.Drawing.Point(0, 767);
            this.bt_servicos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_servicos.Name = "bt_servicos";
            this.bt_servicos.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.bt_servicos.Size = new System.Drawing.Size(334, 77);
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
            this.bt_funcionarios.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_funcionarios.ForeColor = System.Drawing.Color.White;
            this.bt_funcionarios.Image = global::WindowsApp.Properties.Resources.funcionarios;
            this.bt_funcionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_funcionarios.Location = new System.Drawing.Point(0, 690);
            this.bt_funcionarios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_funcionarios.Name = "bt_funcionarios";
            this.bt_funcionarios.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.bt_funcionarios.Size = new System.Drawing.Size(334, 77);
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
            this.panelSubMenuVeiculos.Location = new System.Drawing.Point(0, 537);
            this.panelSubMenuVeiculos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelSubMenuVeiculos.Name = "panelSubMenuVeiculos";
            this.panelSubMenuVeiculos.Size = new System.Drawing.Size(334, 153);
            this.panelSubMenuVeiculos.TabIndex = 16;
            // 
            // btGrupos
            // 
            this.btGrupos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btGrupos.FlatAppearance.BorderSize = 0;
            this.btGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGrupos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btGrupos.ForeColor = System.Drawing.Color.White;
            this.btGrupos.Location = new System.Drawing.Point(0, 77);
            this.btGrupos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btGrupos.Name = "btGrupos";
            this.btGrupos.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btGrupos.Size = new System.Drawing.Size(334, 77);
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
            this.btVeiculosSubMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btVeiculosSubMenu.ForeColor = System.Drawing.Color.White;
            this.btVeiculosSubMenu.Location = new System.Drawing.Point(0, 0);
            this.btVeiculosSubMenu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btVeiculosSubMenu.Name = "btVeiculosSubMenu";
            this.btVeiculosSubMenu.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btVeiculosSubMenu.Size = new System.Drawing.Size(334, 77);
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
            this.bt_veiculos.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_veiculos.ForeColor = System.Drawing.Color.White;
            this.bt_veiculos.Image = global::WindowsApp.Properties.Resources.veiculos;
            this.bt_veiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_veiculos.Location = new System.Drawing.Point(0, 460);
            this.bt_veiculos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_veiculos.Name = "bt_veiculos";
            this.bt_veiculos.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.bt_veiculos.Size = new System.Drawing.Size(334, 77);
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
            this.panelSubMenuClientes.Location = new System.Drawing.Point(0, 307);
            this.panelSubMenuClientes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelSubMenuClientes.Name = "panelSubMenuClientes";
            this.panelSubMenuClientes.Size = new System.Drawing.Size(334, 153);
            this.panelSubMenuClientes.TabIndex = 8;
            // 
            // btPessoaJuridica
            // 
            this.btPessoaJuridica.Dock = System.Windows.Forms.DockStyle.Top;
            this.btPessoaJuridica.FlatAppearance.BorderSize = 0;
            this.btPessoaJuridica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPessoaJuridica.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPessoaJuridica.ForeColor = System.Drawing.Color.White;
            this.btPessoaJuridica.Location = new System.Drawing.Point(0, 77);
            this.btPessoaJuridica.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btPessoaJuridica.Name = "btPessoaJuridica";
            this.btPessoaJuridica.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btPessoaJuridica.Size = new System.Drawing.Size(334, 77);
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
            this.btPessoaFisica.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPessoaFisica.ForeColor = System.Drawing.Color.White;
            this.btPessoaFisica.Location = new System.Drawing.Point(0, 0);
            this.btPessoaFisica.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btPessoaFisica.Name = "btPessoaFisica";
            this.btPessoaFisica.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            this.btPessoaFisica.Size = new System.Drawing.Size(334, 77);
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
            this.panel3.Location = new System.Drawing.Point(0, 764);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 83);
            this.panel3.TabIndex = 7;
            // 
            // bt_sair
            // 
            this.bt_sair.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_sair.FlatAppearance.BorderSize = 0;
            this.bt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sair.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_sair.ForeColor = System.Drawing.Color.White;
            this.bt_sair.Image = global::WindowsApp.Properties.Resources.sair;
            this.bt_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_sair.Location = new System.Drawing.Point(0, 0);
            this.bt_sair.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.bt_sair.Size = new System.Drawing.Size(334, 79);
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
            this.bt_clientes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_clientes.ForeColor = System.Drawing.Color.White;
            this.bt_clientes.Image = global::WindowsApp.Properties.Resources.clientes;
            this.bt_clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_clientes.Location = new System.Drawing.Point(0, 230);
            this.bt_clientes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_clientes.Name = "bt_clientes";
            this.bt_clientes.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.bt_clientes.Size = new System.Drawing.Size(334, 77);
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
            this.bt_aluguel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_aluguel.ForeColor = System.Drawing.Color.White;
            this.bt_aluguel.Image = global::WindowsApp.Properties.Resources.aluguel;
            this.bt_aluguel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_aluguel.Location = new System.Drawing.Point(0, 153);
            this.bt_aluguel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bt_aluguel.Name = "bt_aluguel";
            this.bt_aluguel.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.bt_aluguel.Size = new System.Drawing.Size(334, 77);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 153);
            this.panel1.TabIndex = 0;
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCargo.ForeColor = System.Drawing.Color.White;
            this.lbCargo.Location = new System.Drawing.Point(128, 81);
            this.lbCargo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(56, 23);
            this.lbCargo.TabIndex = 3;
            this.lbCargo.Text = "Cargo";
            // 
            // foto_perfil
            // 
            this.foto_perfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.foto_perfil.BackColor = System.Drawing.Color.DarkGray;
            this.foto_perfil.Image = ((System.Drawing.Image)(resources.GetObject("foto_perfil.Image")));
            this.foto_perfil.Location = new System.Drawing.Point(39, 32);
            this.foto_perfil.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.foto_perfil.Name = "foto_perfil";
            this.foto_perfil.Size = new System.Drawing.Size(80, 92);
            this.foto_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foto_perfil.TabIndex = 2;
            this.foto_perfil.TabStop = false;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUsuario.ForeColor = System.Drawing.Color.White;
            this.lbUsuario.Location = new System.Drawing.Point(127, 49);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(118, 28);
            this.lbUsuario.TabIndex = 1;
            this.lbUsuario.Text = "Funcionário";
            // 
            // panelFormFilho
            // 
            this.panelFormFilho.Controls.Add(this.label3);
            this.panelFormFilho.Controls.Add(this.labelTitulo);
            this.panelFormFilho.Controls.Add(this.pictureBox1);
            this.panelFormFilho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormFilho.Location = new System.Drawing.Point(334, 0);
            this.panelFormFilho.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelFormFilho.Name = "panelFormFilho";
            this.panelFormFilho.Size = new System.Drawing.Size(912, 847);
            this.panelFormFilho.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(862, 825);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "V1.0.0";
            // 
            // labelTitulo
            // 
            this.labelTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("LEMON MILK Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(134, 568);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(605, 114);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Rech-a-Car";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(129, 148);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 420);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(1246, 847);
            this.Controls.Add(this.panelFormFilho);
            this.Controls.Add(this.PanelMenuLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(1261, 894);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rech-a-Car";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaPrincipal_FormClosing);
            this.PanelMenuLateral.ResumeLayout(false);
            this.panelSubMenuCupons.ResumeLayout(false);
            this.panelSubMenuVeiculos.ResumeLayout(false);
            this.panelSubMenuClientes.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foto_perfil)).EndInit();
            this.panelFormFilho.ResumeLayout(false);
            this.panelFormFilho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button bt_servicos;
        private System.Windows.Forms.Button bt_funcionarios;
        private System.Windows.Forms.Panel panelSubMenuVeiculos;
        private System.Windows.Forms.Button btGrupos;
        private System.Windows.Forms.Button btVeiculosSubMenu;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.Button btCupom;
        private System.Windows.Forms.Button btConfiguracoes;
        private System.Windows.Forms.Panel panelSubMenuCupons;
        private System.Windows.Forms.Button btParceiros;
        private System.Windows.Forms.Button btCupons;
    }
}

