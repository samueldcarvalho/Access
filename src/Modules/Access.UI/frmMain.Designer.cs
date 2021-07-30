
namespace frm_Main
{
    public partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_favoritos = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.pnl_busca = new System.Windows.Forms.Panel();
            this.ckbox_busca_rede = new System.Windows.Forms.CheckBox();
            this.rdbtn_busca_filial = new System.Windows.Forms.RadioButton();
            this.rdbtn_busca_central = new System.Windows.Forms.RadioButton();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.pnl_informacoes = new System.Windows.Forms.Panel();
            this.btn_versao = new System.Windows.Forms.Button();
            this.btn_configuracoes = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.panel_Logo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_buscar = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_senha_acesso = new System.Windows.Forms.TextBox();
            this.separatorControl6 = new DevExpress.XtraEditors.SeparatorControl();
            this.txt_tipo_acesso = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.separatorControl5 = new DevExpress.XtraEditors.SeparatorControl();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_id_acesso = new System.Windows.Forms.TextBox();
            this.separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            this.ckbox_Central = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nome_filial = new System.Windows.Forms.TextBox();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.lbl_filicodigo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome_rede = new System.Windows.Forms.TextBox();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.gridControl_Busca = new DevExpress.XtraGrid.GridControl();
            this.gridView_Buscar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn_key = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_Codigo_Filial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_nome_filial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_rede = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn_tipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnl_busca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.pnl_informacoes.SuspendLayout();
            this.panel_Logo.SuspendLayout();
            this.pnl_buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Busca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Buscar)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.btn_favoritos);
            this.panel1.Controls.Add(this.btn_adicionar);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.pnl_busca);
            this.panel1.Controls.Add(this.pnl_informacoes);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.panel_Logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 559);
            this.panel1.TabIndex = 0;
            // 
            // btn_favoritos
            // 
            this.btn_favoritos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_favoritos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_favoritos.FlatAppearance.BorderSize = 0;
            this.btn_favoritos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_favoritos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_favoritos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_favoritos.Location = new System.Drawing.Point(0, 253);
            this.btn_favoritos.Name = "btn_favoritos";
            this.btn_favoritos.Size = new System.Drawing.Size(250, 35);
            this.btn_favoritos.TabIndex = 14;
            this.btn_favoritos.Text = "Favoritos";
            this.btn_favoritos.UseVisualStyleBackColor = false;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_adicionar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_adicionar.FlatAppearance.BorderSize = 0;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_adicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_adicionar.Location = new System.Drawing.Point(0, 218);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(250, 35);
            this.btn_adicionar.TabIndex = 13;
            this.btn_adicionar.Text = "Adicionar Acesso";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_buscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_buscar.Location = new System.Drawing.Point(0, 183);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(250, 35);
            this.btn_buscar.TabIndex = 12;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // pnl_busca
            // 
            this.pnl_busca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.pnl_busca.Controls.Add(this.ckbox_busca_rede);
            this.pnl_busca.Controls.Add(this.rdbtn_busca_filial);
            this.pnl_busca.Controls.Add(this.rdbtn_busca_central);
            this.pnl_busca.Controls.Add(this.txt_buscar);
            this.pnl_busca.Controls.Add(this.separatorControl1);
            this.pnl_busca.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_busca.Location = new System.Drawing.Point(0, 56);
            this.pnl_busca.Name = "pnl_busca";
            this.pnl_busca.Size = new System.Drawing.Size(250, 127);
            this.pnl_busca.TabIndex = 11;
            this.pnl_busca.Visible = false;
            // 
            // ckbox_busca_rede
            // 
            this.ckbox_busca_rede.AutoSize = true;
            this.ckbox_busca_rede.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckbox_busca_rede.ForeColor = System.Drawing.SystemColors.Control;
            this.ckbox_busca_rede.Location = new System.Drawing.Point(27, 40);
            this.ckbox_busca_rede.Name = "ckbox_busca_rede";
            this.ckbox_busca_rede.Size = new System.Drawing.Size(123, 21);
            this.ckbox_busca_rede.TabIndex = 5;
            this.ckbox_busca_rede.Text = "Buscar por Rede";
            this.ckbox_busca_rede.UseVisualStyleBackColor = true;
            // 
            // rdbtn_busca_filial
            // 
            this.rdbtn_busca_filial.AutoSize = true;
            this.rdbtn_busca_filial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbtn_busca_filial.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbtn_busca_filial.Location = new System.Drawing.Point(27, 93);
            this.rdbtn_busca_filial.Name = "rdbtn_busca_filial";
            this.rdbtn_busca_filial.Size = new System.Drawing.Size(164, 21);
            this.rdbtn_busca_filial.TabIndex = 4;
            this.rdbtn_busca_filial.TabStop = true;
            this.rdbtn_busca_filial.Text = "Buscar apenas por Filial";
            this.rdbtn_busca_filial.UseVisualStyleBackColor = true;
            // 
            // rdbtn_busca_central
            // 
            this.rdbtn_busca_central.AutoSize = true;
            this.rdbtn_busca_central.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdbtn_busca_central.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbtn_busca_central.Location = new System.Drawing.Point(27, 66);
            this.rdbtn_busca_central.Name = "rdbtn_busca_central";
            this.rdbtn_busca_central.Size = new System.Drawing.Size(182, 21);
            this.rdbtn_busca_central.TabIndex = 3;
            this.rdbtn_busca_central.TabStop = true;
            this.rdbtn_busca_central.Text = "Buscar apenas por Central";
            this.rdbtn_busca_central.UseVisualStyleBackColor = true;
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_buscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_buscar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_buscar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_buscar.Location = new System.Drawing.Point(0, 0);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(250, 16);
            this.txt_buscar.TabIndex = 0;
            this.txt_buscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // separatorControl1
            // 
            this.separatorControl1.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.separatorControl1.Location = new System.Drawing.Point(37, 10);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(172, 23);
            this.separatorControl1.TabIndex = 1;
            // 
            // pnl_informacoes
            // 
            this.pnl_informacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.pnl_informacoes.Controls.Add(this.btn_versao);
            this.pnl_informacoes.Controls.Add(this.btn_configuracoes);
            this.pnl_informacoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_informacoes.Location = new System.Drawing.Point(0, 448);
            this.pnl_informacoes.Name = "pnl_informacoes";
            this.pnl_informacoes.Size = new System.Drawing.Size(250, 76);
            this.pnl_informacoes.TabIndex = 10;
            // 
            // btn_versao
            // 
            this.btn_versao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btn_versao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_versao.FlatAppearance.BorderSize = 0;
            this.btn_versao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_versao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_versao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_versao.Location = new System.Drawing.Point(0, -2);
            this.btn_versao.Name = "btn_versao";
            this.btn_versao.Size = new System.Drawing.Size(250, 39);
            this.btn_versao.TabIndex = 10;
            this.btn_versao.Text = "Versão";
            this.btn_versao.UseVisualStyleBackColor = false;
            // 
            // btn_configuracoes
            // 
            this.btn_configuracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btn_configuracoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_configuracoes.FlatAppearance.BorderSize = 0;
            this.btn_configuracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_configuracoes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_configuracoes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_configuracoes.Location = new System.Drawing.Point(0, 37);
            this.btn_configuracoes.Name = "btn_configuracoes";
            this.btn_configuracoes.Size = new System.Drawing.Size(250, 39);
            this.btn_configuracoes.TabIndex = 9;
            this.btn_configuracoes.Text = "Configurações";
            this.btn_configuracoes.UseVisualStyleBackColor = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(74)))), ((int)(((byte)(82)))));
            this.btn_sair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sair.Location = new System.Drawing.Point(0, 524);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(250, 35);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair do Access";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // panel_Logo
            // 
            this.panel_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.panel_Logo.Controls.Add(this.label2);
            this.panel_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Logo.Location = new System.Drawing.Point(0, 0);
            this.panel_Logo.Name = "panel_Logo";
            this.panel_Logo.Size = new System.Drawing.Size(250, 56);
            this.panel_Logo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(71, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Access";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_buscar
            // 
            this.pnl_buscar.Controls.Add(this.label9);
            this.pnl_buscar.Controls.Add(this.txt_senha_acesso);
            this.pnl_buscar.Controls.Add(this.separatorControl6);
            this.pnl_buscar.Controls.Add(this.txt_tipo_acesso);
            this.pnl_buscar.Controls.Add(this.label8);
            this.pnl_buscar.Controls.Add(this.separatorControl5);
            this.pnl_buscar.Controls.Add(this.label7);
            this.pnl_buscar.Controls.Add(this.txt_id_acesso);
            this.pnl_buscar.Controls.Add(this.separatorControl4);
            this.pnl_buscar.Controls.Add(this.ckbox_Central);
            this.pnl_buscar.Controls.Add(this.label6);
            this.pnl_buscar.Controls.Add(this.txt_nome_filial);
            this.pnl_buscar.Controls.Add(this.separatorControl3);
            this.pnl_buscar.Controls.Add(this.lbl_filicodigo);
            this.pnl_buscar.Controls.Add(this.label4);
            this.pnl_buscar.Controls.Add(this.label3);
            this.pnl_buscar.Controls.Add(this.txt_nome_rede);
            this.pnl_buscar.Controls.Add(this.separatorControl2);
            this.pnl_buscar.Controls.Add(this.gridControl_Busca);
            this.pnl_buscar.Controls.Add(this.panel3);
            this.pnl_buscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_buscar.Location = new System.Drawing.Point(250, 0);
            this.pnl_buscar.Name = "pnl_buscar";
            this.pnl_buscar.Size = new System.Drawing.Size(501, 559);
            this.pnl_buscar.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(50, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Senha";
            // 
            // txt_senha_acesso
            // 
            this.txt_senha_acesso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.txt_senha_acesso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_senha_acesso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_senha_acesso.Location = new System.Drawing.Point(76, 450);
            this.txt_senha_acesso.Name = "txt_senha_acesso";
            this.txt_senha_acesso.ReadOnly = true;
            this.txt_senha_acesso.Size = new System.Drawing.Size(343, 15);
            this.txt_senha_acesso.TabIndex = 20;
            this.txt_senha_acesso.Text = "$up0rte@";
            // 
            // separatorControl6
            // 
            this.separatorControl6.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.separatorControl6.Location = new System.Drawing.Point(50, 456);
            this.separatorControl6.Name = "separatorControl6";
            this.separatorControl6.Size = new System.Drawing.Size(400, 23);
            this.separatorControl6.TabIndex = 21;
            // 
            // txt_tipo_acesso
            // 
            this.txt_tipo_acesso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.txt_tipo_acesso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tipo_acesso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tipo_acesso.Location = new System.Drawing.Point(374, 400);
            this.txt_tipo_acesso.Name = "txt_tipo_acesso";
            this.txt_tipo_acesso.ReadOnly = true;
            this.txt_tipo_acesso.Size = new System.Drawing.Size(75, 15);
            this.txt_tipo_acesso.TabIndex = 19;
            this.txt_tipo_acesso.Text = "TeamViewer";
            this.txt_tipo_acesso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(373, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tipo:";
            // 
            // separatorControl5
            // 
            this.separatorControl5.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.separatorControl5.Location = new System.Drawing.Point(370, 407);
            this.separatorControl5.Name = "separatorControl5";
            this.separatorControl5.Size = new System.Drawing.Size(80, 23);
            this.separatorControl5.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(50, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "ID:";
            // 
            // txt_id_acesso
            // 
            this.txt_id_acesso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.txt_id_acesso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id_acesso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_id_acesso.Location = new System.Drawing.Point(76, 401);
            this.txt_id_acesso.Name = "txt_id_acesso";
            this.txt_id_acesso.ReadOnly = true;
            this.txt_id_acesso.Size = new System.Drawing.Size(251, 15);
            this.txt_id_acesso.TabIndex = 14;
            this.txt_id_acesso.Text = "1123456789/server-1s21sd/administrator";
            // 
            // separatorControl4
            // 
            this.separatorControl4.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.separatorControl4.Location = new System.Drawing.Point(50, 407);
            this.separatorControl4.Name = "separatorControl4";
            this.separatorControl4.Size = new System.Drawing.Size(312, 23);
            this.separatorControl4.TabIndex = 15;
            // 
            // ckbox_Central
            // 
            this.ckbox_Central.AutoCheck = false;
            this.ckbox_Central.AutoSize = true;
            this.ckbox_Central.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.ckbox_Central.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbox_Central.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ckbox_Central.Location = new System.Drawing.Point(370, 347);
            this.ckbox_Central.Name = "ckbox_Central";
            this.ckbox_Central.Size = new System.Drawing.Size(74, 20);
            this.ckbox_Central.TabIndex = 6;
            this.ckbox_Central.Text = "Central";
            this.ckbox_Central.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(50, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Filial:";
            // 
            // txt_nome_filial
            // 
            this.txt_nome_filial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.txt_nome_filial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome_filial.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nome_filial.Location = new System.Drawing.Point(76, 352);
            this.txt_nome_filial.Name = "txt_nome_filial";
            this.txt_nome_filial.ReadOnly = true;
            this.txt_nome_filial.Size = new System.Drawing.Size(265, 15);
            this.txt_nome_filial.TabIndex = 11;
            this.txt_nome_filial.Text = "MINAS MAIS";
            // 
            // separatorControl3
            // 
            this.separatorControl3.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.separatorControl3.Location = new System.Drawing.Point(50, 358);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(312, 23);
            this.separatorControl3.TabIndex = 12;
            // 
            // lbl_filicodigo
            // 
            this.lbl_filicodigo.AutoSize = true;
            this.lbl_filicodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_filicodigo.Location = new System.Drawing.Point(431, 482);
            this.lbl_filicodigo.Name = "lbl_filicodigo";
            this.lbl_filicodigo.Size = new System.Drawing.Size(14, 16);
            this.lbl_filicodigo.TabIndex = 10;
            this.lbl_filicodigo.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(352, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filicodigo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rede:";
            // 
            // txt_nome_rede
            // 
            this.txt_nome_rede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.txt_nome_rede.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nome_rede.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nome_rede.Location = new System.Drawing.Point(76, 304);
            this.txt_nome_rede.Name = "txt_nome_rede";
            this.txt_nome_rede.ReadOnly = true;
            this.txt_nome_rede.Size = new System.Drawing.Size(343, 15);
            this.txt_nome_rede.TabIndex = 3;
            this.txt_nome_rede.Text = "MINAS MAIS";
            // 
            // separatorControl2
            // 
            this.separatorControl2.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.separatorControl2.Location = new System.Drawing.Point(50, 310);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(400, 23);
            this.separatorControl2.TabIndex = 6;
            // 
            // gridControl_Busca
            // 
            this.gridControl_Busca.Location = new System.Drawing.Point(50, 96);
            this.gridControl_Busca.MainView = this.gridView_Buscar;
            this.gridControl_Busca.Name = "gridControl_Busca";
            this.gridControl_Busca.Size = new System.Drawing.Size(400, 169);
            this.gridControl_Busca.TabIndex = 2;
            this.gridControl_Busca.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Buscar});
            // 
            // gridView_Buscar
            // 
            this.gridView_Buscar.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.gridView_Buscar.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView_Buscar.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView_Buscar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.gridView_Buscar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn_key,
            this.gridColumn_Codigo_Filial,
            this.gridColumn_nome_filial,
            this.gridColumn_rede,
            this.gridColumn_tipo});
            this.gridView_Buscar.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView_Buscar.GridControl = this.gridControl_Busca;
            this.gridView_Buscar.Name = "gridView_Buscar";
            this.gridView_Buscar.OptionsBehavior.Editable = false;
            this.gridView_Buscar.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView_Buscar.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView_Buscar.OptionsView.ShowGroupPanel = false;
            this.gridView_Buscar.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView_Buscar_SelectionChanged);
            // 
            // gridColumn_key
            // 
            this.gridColumn_key.Caption = "Key";
            this.gridColumn_key.FieldName = "codigo";
            this.gridColumn_key.Name = "gridColumn_key";
            this.gridColumn_key.OptionsColumn.AllowEdit = false;
            this.gridColumn_key.Visible = true;
            this.gridColumn_key.VisibleIndex = 0;
            this.gridColumn_key.Width = 37;
            // 
            // gridColumn_Codigo_Filial
            // 
            this.gridColumn_Codigo_Filial.Caption = "Filicodigo";
            this.gridColumn_Codigo_Filial.FieldName = "codigo_filial_automatiza";
            this.gridColumn_Codigo_Filial.Name = "gridColumn_Codigo_Filial";
            this.gridColumn_Codigo_Filial.Visible = true;
            this.gridColumn_Codigo_Filial.VisibleIndex = 2;
            this.gridColumn_Codigo_Filial.Width = 50;
            // 
            // gridColumn_nome_filial
            // 
            this.gridColumn_nome_filial.Caption = "Nome da Filial";
            this.gridColumn_nome_filial.FieldName = "filial_nome";
            this.gridColumn_nome_filial.Name = "gridColumn_nome_filial";
            this.gridColumn_nome_filial.Visible = true;
            this.gridColumn_nome_filial.VisibleIndex = 3;
            this.gridColumn_nome_filial.Width = 87;
            // 
            // gridColumn_rede
            // 
            this.gridColumn_rede.Caption = "Nome da Rede";
            this.gridColumn_rede.FieldName = "rede_nome";
            this.gridColumn_rede.Name = "gridColumn_rede";
            this.gridColumn_rede.Visible = true;
            this.gridColumn_rede.VisibleIndex = 1;
            this.gridColumn_rede.Width = 120;
            // 
            // gridColumn_tipo
            // 
            this.gridColumn_tipo.Caption = "Tipo";
            this.gridColumn_tipo.FieldName = "filial_tipo_acesso";
            this.gridColumn_tipo.Name = "gridColumn_tipo";
            this.gridColumn_tipo.Visible = true;
            this.gridColumn_tipo.VisibleIndex = 4;
            this.gridColumn_tipo.Width = 81;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 56);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(221)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(751, 559);
            this.Controls.Add(this.pnl_buscar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutomatizaAccess";
            this.panel1.ResumeLayout(false);
            this.pnl_busca.ResumeLayout(false);
            this.pnl_busca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.pnl_informacoes.ResumeLayout(false);
            this.panel_Logo.ResumeLayout(false);
            this.panel_Logo.PerformLayout();
            this.pnl_buscar.ResumeLayout(false);
            this.pnl_buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Busca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Buscar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Logo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_configuracoes;
        private System.Windows.Forms.TextBox txt_id_acesso;
        private System.Windows.Forms.Panel pnl_informacoes;
        private System.Windows.Forms.Panel pnl_busca;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.RadioButton rdbtn_busca_filial;
        private System.Windows.Forms.RadioButton rdbtn_busca_central;
        private System.Windows.Forms.CheckBox ckbox_busca_rede;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_versao;
        private System.Windows.Forms.Panel pnl_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl_Busca;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Buscar;
        private System.Windows.Forms.TextBox txt_nome_rede;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_filicodigo;
        private System.Windows.Forms.CheckBox ckbox_Central;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nome_filial;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SeparatorControl separatorControl4;
        private System.Windows.Forms.TextBox txt_tipo_acesso;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SeparatorControl separatorControl5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_senha_acesso;
        private DevExpress.XtraEditors.SeparatorControl separatorControl6;
        private System.Windows.Forms.Button btn_favoritos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_Codigo_Filial;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_rede;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_nome_filial;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_tipo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn_key;
    }
}

