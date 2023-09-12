namespace mysql_conection
{
    partial class F_Cliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.lb_totalCliente = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tb_busca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtg_usuarios = new System.Windows.Forms.DataGridView();
            this.cbx_filterBusca = new System.Windows.Forms.ComboBox();
            this.tab_users = new System.Windows.Forms.TabControl();
            this.tab_Clientes = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_deletar_item = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tabNovoCliente = new System.Windows.Forms.TabPage();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.mask_Cnpj = new System.Windows.Forms.MaskedTextBox();
            this.num_Numero = new System.Windows.Forms.NumericUpDown();
            this.cbx_uf = new System.Windows.Forms.ComboBox();
            this.mask_cep = new System.Windows.Forms.MaskedTextBox();
            this.mask_prazo = new System.Windows.Forms.MaskedTextBox();
            this.mask_limite = new System.Windows.Forms.MaskedTextBox();
            this.mask_celular = new System.Windows.Forms.MaskedTextBox();
            this.mask_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdb_juridica = new System.Windows.Forms.RadioButton();
            this.rdb_fisica = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_inativo = new System.Windows.Forms.RadioButton();
            this.rdb_ativo = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_observacao = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_site = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_apelido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_codCliente = new System.Windows.Forms.TextBox();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.tabExtrato = new System.Windows.Forms.TabPage();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_usuarios)).BeginInit();
            this.tab_users.SuspendLayout();
            this.tab_Clientes.SuspendLayout();
            this.tabNovoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Numero)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Clientes:";
            // 
            // lb_totalCliente
            // 
            this.lb_totalCliente.AutoSize = true;
            this.lb_totalCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_totalCliente.Location = new System.Drawing.Point(105, 6);
            this.lb_totalCliente.Name = "lb_totalCliente";
            this.lb_totalCliente.Size = new System.Drawing.Size(15, 15);
            this.lb_totalCliente.TabIndex = 1;
            this.lb_totalCliente.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lb_totalCliente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 610);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(673, 26);
            this.panel2.TabIndex = 8;
            // 
            // tb_busca
            // 
            this.tb_busca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_busca.Location = new System.Drawing.Point(181, 6);
            this.tb_busca.Name = "tb_busca";
            this.tb_busca.Size = new System.Drawing.Size(458, 27);
            this.tb_busca.TabIndex = 10;
            this.tb_busca.TextChanged += new System.EventHandler(this.tb_busca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Clientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 42);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::mysql_conection.Properties.Resources.close__1_;
            this.pictureBox1.Location = new System.Drawing.Point(638, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dtg_usuarios
            // 
            this.dtg_usuarios.AllowUserToAddRows = false;
            this.dtg_usuarios.AllowUserToDeleteRows = false;
            this.dtg_usuarios.AllowUserToResizeColumns = false;
            this.dtg_usuarios.AllowUserToResizeRows = false;
            this.dtg_usuarios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtg_usuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_usuarios.EnableHeadersVisualStyles = false;
            this.dtg_usuarios.Location = new System.Drawing.Point(6, 41);
            this.dtg_usuarios.MultiSelect = false;
            this.dtg_usuarios.Name = "dtg_usuarios";
            this.dtg_usuarios.ReadOnly = true;
            this.dtg_usuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_usuarios.RowHeadersVisible = false;
            this.dtg_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_usuarios.Size = new System.Drawing.Size(633, 433);
            this.dtg_usuarios.TabIndex = 7;
            this.dtg_usuarios.DoubleClick += new System.EventHandler(this.dtg_usuarios_DoubleClick);
            // 
            // cbx_filterBusca
            // 
            this.cbx_filterBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_filterBusca.FormattingEnabled = true;
            this.cbx_filterBusca.Items.AddRange(new object[] {
            "Código",
            "Nome",
            "Telefone",
            "Celular",
            "Email"});
            this.cbx_filterBusca.Location = new System.Drawing.Point(6, 6);
            this.cbx_filterBusca.Name = "cbx_filterBusca";
            this.cbx_filterBusca.Size = new System.Drawing.Size(169, 26);
            this.cbx_filterBusca.TabIndex = 13;
            this.cbx_filterBusca.Text = "Nome";
            // 
            // tab_users
            // 
            this.tab_users.Controls.Add(this.tab_Clientes);
            this.tab_users.Controls.Add(this.tabNovoCliente);
            this.tab_users.Controls.Add(this.tabExtrato);
            this.tab_users.Location = new System.Drawing.Point(11, 48);
            this.tab_users.Name = "tab_users";
            this.tab_users.SelectedIndex = 0;
            this.tab_users.Size = new System.Drawing.Size(653, 553);
            this.tab_users.TabIndex = 14;
            // 
            // tab_Clientes
            // 
            this.tab_Clientes.Controls.Add(this.button1);
            this.tab_Clientes.Controls.Add(this.btn_deletar_item);
            this.tab_Clientes.Controls.Add(this.btn_adicionar);
            this.tab_Clientes.Controls.Add(this.dtg_usuarios);
            this.tab_Clientes.Controls.Add(this.cbx_filterBusca);
            this.tab_Clientes.Controls.Add(this.tb_busca);
            this.tab_Clientes.Location = new System.Drawing.Point(4, 22);
            this.tab_Clientes.Name = "tab_Clientes";
            this.tab_Clientes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Clientes.Size = new System.Drawing.Size(645, 527);
            this.tab_Clientes.TabIndex = 0;
            this.tab_Clientes.Text = "Clientes";
            this.tab_Clientes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(407, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Extrato";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btn_deletar_item
            // 
            this.btn_deletar_item.BackColor = System.Drawing.Color.Crimson;
            this.btn_deletar_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar_item.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deletar_item.Location = new System.Drawing.Point(245, 486);
            this.btn_deletar_item.Name = "btn_deletar_item";
            this.btn_deletar_item.Size = new System.Drawing.Size(151, 35);
            this.btn_deletar_item.TabIndex = 15;
            this.btn_deletar_item.Text = "Deletar Cliente";
            this.btn_deletar_item.UseVisualStyleBackColor = false;
            this.btn_deletar_item.Click += new System.EventHandler(this.btn_deletar_item_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.Green;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_adicionar.Location = new System.Drawing.Point(84, 486);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(151, 35);
            this.btn_adicionar.TabIndex = 14;
            this.btn_adicionar.Text = "Adicionar Novo";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tabNovoCliente
            // 
            this.tabNovoCliente.Controls.Add(this.btn_limpar);
            this.tabNovoCliente.Controls.Add(this.mask_Cnpj);
            this.tabNovoCliente.Controls.Add(this.num_Numero);
            this.tabNovoCliente.Controls.Add(this.cbx_uf);
            this.tabNovoCliente.Controls.Add(this.mask_cep);
            this.tabNovoCliente.Controls.Add(this.mask_prazo);
            this.tabNovoCliente.Controls.Add(this.mask_limite);
            this.tabNovoCliente.Controls.Add(this.mask_celular);
            this.tabNovoCliente.Controls.Add(this.mask_telefone);
            this.tabNovoCliente.Controls.Add(this.mask_cpf);
            this.tabNovoCliente.Controls.Add(this.groupBox2);
            this.tabNovoCliente.Controls.Add(this.groupBox1);
            this.tabNovoCliente.Controls.Add(this.label23);
            this.tabNovoCliente.Controls.Add(this.tb_observacao);
            this.tabNovoCliente.Controls.Add(this.label24);
            this.tabNovoCliente.Controls.Add(this.tb_site);
            this.tabNovoCliente.Controls.Add(this.label25);
            this.tabNovoCliente.Controls.Add(this.tb_email);
            this.tabNovoCliente.Controls.Add(this.label18);
            this.tabNovoCliente.Controls.Add(this.label19);
            this.tabNovoCliente.Controls.Add(this.label15);
            this.tabNovoCliente.Controls.Add(this.label16);
            this.tabNovoCliente.Controls.Add(this.label17);
            this.tabNovoCliente.Controls.Add(this.label13);
            this.tabNovoCliente.Controls.Add(this.label12);
            this.tabNovoCliente.Controls.Add(this.label10);
            this.tabNovoCliente.Controls.Add(this.tb_cidade);
            this.tabNovoCliente.Controls.Add(this.label11);
            this.tabNovoCliente.Controls.Add(this.tb_bairro);
            this.tabNovoCliente.Controls.Add(this.label9);
            this.tabNovoCliente.Controls.Add(this.label7);
            this.tabNovoCliente.Controls.Add(this.tb_endereco);
            this.tabNovoCliente.Controls.Add(this.label8);
            this.tabNovoCliente.Controls.Add(this.tb_apelido);
            this.tabNovoCliente.Controls.Add(this.label6);
            this.tabNovoCliente.Controls.Add(this.dtp_data);
            this.tabNovoCliente.Controls.Add(this.label5);
            this.tabNovoCliente.Controls.Add(this.tb_nome);
            this.tabNovoCliente.Controls.Add(this.label4);
            this.tabNovoCliente.Controls.Add(this.tb_codCliente);
            this.tabNovoCliente.Controls.Add(this.btn_Deletar);
            this.tabNovoCliente.Controls.Add(this.btn_salvar);
            this.tabNovoCliente.Location = new System.Drawing.Point(4, 22);
            this.tabNovoCliente.Name = "tabNovoCliente";
            this.tabNovoCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabNovoCliente.Size = new System.Drawing.Size(645, 527);
            this.tabNovoCliente.TabIndex = 1;
            this.tabNovoCliente.Text = "Novo Cliente";
            this.tabNovoCliente.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_limpar.Location = new System.Drawing.Point(407, 486);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(151, 35);
            this.btn_limpar.TabIndex = 10003;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // mask_Cnpj
            // 
            this.mask_Cnpj.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mask_Cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_Cnpj.Location = new System.Drawing.Point(12, 174);
            this.mask_Cnpj.Mask = "00.000.000/0000-00";
            this.mask_Cnpj.Name = "mask_Cnpj";
            this.mask_Cnpj.Size = new System.Drawing.Size(154, 24);
            this.mask_Cnpj.TabIndex = 10002;
            this.mask_Cnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // num_Numero
            // 
            this.num_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Numero.Location = new System.Drawing.Point(533, 77);
            this.num_Numero.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_Numero.Name = "num_Numero";
            this.num_Numero.Size = new System.Drawing.Size(99, 26);
            this.num_Numero.TabIndex = 10000;
            // 
            // cbx_uf
            // 
            this.cbx_uf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_uf.FormattingEnabled = true;
            this.cbx_uf.Items.AddRange(new object[] {
            "RO",
            "AC",
            "AM",
            "RR",
            "PA",
            "AP",
            "TO",
            "MA",
            "PI",
            "CE",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "BA",
            "MG",
            "ES",
            "RJ",
            "SP",
            "PR",
            "SC",
            "RS",
            "MS",
            "MT",
            "GO",
            "DF"});
            this.cbx_uf.Location = new System.Drawing.Point(578, 126);
            this.cbx_uf.Name = "cbx_uf";
            this.cbx_uf.Size = new System.Drawing.Size(54, 24);
            this.cbx_uf.TabIndex = 108;
            this.cbx_uf.Text = "RO";
            // 
            // mask_cep
            // 
            this.mask_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_cep.Location = new System.Drawing.Point(486, 127);
            this.mask_cep.Mask = "00000-9999";
            this.mask_cep.Name = "mask_cep";
            this.mask_cep.Size = new System.Drawing.Size(88, 24);
            this.mask_cep.TabIndex = 74;
            this.mask_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mask_prazo
            // 
            this.mask_prazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_prazo.Location = new System.Drawing.Point(554, 177);
            this.mask_prazo.Mask = "00";
            this.mask_prazo.Name = "mask_prazo";
            this.mask_prazo.Size = new System.Drawing.Size(70, 24);
            this.mask_prazo.TabIndex = 73;
            this.mask_prazo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mask_prazo.ValidatingType = typeof(int);
            // 
            // mask_limite
            // 
            this.mask_limite.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mask_limite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_limite.Location = new System.Drawing.Point(461, 177);
            this.mask_limite.Mask = "00000";
            this.mask_limite.Name = "mask_limite";
            this.mask_limite.Size = new System.Drawing.Size(86, 24);
            this.mask_limite.TabIndex = 72;
            this.mask_limite.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mask_limite.ValidatingType = typeof(int);
            // 
            // mask_celular
            // 
            this.mask_celular.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mask_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_celular.Location = new System.Drawing.Point(321, 176);
            this.mask_celular.Mask = "(00)0 0000-0000";
            this.mask_celular.Name = "mask_celular";
            this.mask_celular.Size = new System.Drawing.Size(134, 24);
            this.mask_celular.TabIndex = 71;
            this.mask_celular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mask_telefone
            // 
            this.mask_telefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mask_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_telefone.Location = new System.Drawing.Point(172, 175);
            this.mask_telefone.Mask = "(99) 000-0000";
            this.mask_telefone.Name = "mask_telefone";
            this.mask_telefone.Size = new System.Drawing.Size(143, 24);
            this.mask_telefone.TabIndex = 70;
            this.mask_telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mask_cpf
            // 
            this.mask_cpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mask_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_cpf.Location = new System.Drawing.Point(11, 174);
            this.mask_cpf.Mask = "000.000.000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(154, 24);
            this.mask_cpf.TabIndex = 69;
            this.mask_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdb_juridica);
            this.groupBox2.Controls.Add(this.rdb_fisica);
            this.groupBox2.Location = new System.Drawing.Point(142, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 46);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Cliente";
            // 
            // rdb_juridica
            // 
            this.rdb_juridica.AutoSize = true;
            this.rdb_juridica.Location = new System.Drawing.Point(63, 19);
            this.rdb_juridica.Name = "rdb_juridica";
            this.rdb_juridica.Size = new System.Drawing.Size(61, 17);
            this.rdb_juridica.TabIndex = 1;
            this.rdb_juridica.TabStop = true;
            this.rdb_juridica.Text = "Juridica";
            this.rdb_juridica.UseVisualStyleBackColor = true;
            this.rdb_juridica.CheckedChanged += new System.EventHandler(this.rdb_juridica_CheckedChanged);
            // 
            // rdb_fisica
            // 
            this.rdb_fisica.AutoSize = true;
            this.rdb_fisica.Checked = true;
            this.rdb_fisica.Location = new System.Drawing.Point(7, 20);
            this.rdb_fisica.Name = "rdb_fisica";
            this.rdb_fisica.Size = new System.Drawing.Size(54, 17);
            this.rdb_fisica.TabIndex = 0;
            this.rdb_fisica.TabStop = true;
            this.rdb_fisica.Text = "Física";
            this.rdb_fisica.UseVisualStyleBackColor = true;
            this.rdb_fisica.CheckedChanged += new System.EventHandler(this.rdb_fisica_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_inativo);
            this.groupBox1.Controls.Add(this.rdb_ativo);
            this.groupBox1.Location = new System.Drawing.Point(12, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 46);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status do Cliente";
            // 
            // rdb_inativo
            // 
            this.rdb_inativo.AutoSize = true;
            this.rdb_inativo.Location = new System.Drawing.Point(63, 19);
            this.rdb_inativo.Name = "rdb_inativo";
            this.rdb_inativo.Size = new System.Drawing.Size(57, 17);
            this.rdb_inativo.TabIndex = 1;
            this.rdb_inativo.Text = "Inativo";
            this.rdb_inativo.UseVisualStyleBackColor = true;
            // 
            // rdb_ativo
            // 
            this.rdb_ativo.AutoSize = true;
            this.rdb_ativo.Checked = true;
            this.rdb_ativo.Location = new System.Drawing.Point(7, 20);
            this.rdb_ativo.Name = "rdb_ativo";
            this.rdb_ativo.Size = new System.Drawing.Size(49, 17);
            this.rdb_ativo.TabIndex = 0;
            this.rdb_ativo.TabStop = true;
            this.rdb_ativo.Text = "Ativo";
            this.rdb_ativo.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 258);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 13);
            this.label23.TabIndex = 65;
            this.label23.Text = "Observação";
            // 
            // tb_observacao
            // 
            this.tb_observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_observacao.Location = new System.Drawing.Point(11, 274);
            this.tb_observacao.Multiline = true;
            this.tb_observacao.Name = "tb_observacao";
            this.tb_observacao.Size = new System.Drawing.Size(621, 61);
            this.tb_observacao.TabIndex = 64;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(329, 208);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(25, 13);
            this.label24.TabIndex = 61;
            this.label24.Text = "Site";
            // 
            // tb_site
            // 
            this.tb_site.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_site.Location = new System.Drawing.Point(332, 225);
            this.tb_site.Name = "tb_site";
            this.tb_site.Size = new System.Drawing.Size(300, 26);
            this.tb_site.TabIndex = 60;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 208);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(36, 13);
            this.label25.TabIndex = 59;
            this.label25.Text = "E-Mail";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(12, 225);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(317, 26);
            this.tb_email.TabIndex = 58;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(550, 160);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 57;
            this.label18.Text = "Prazo (Dias)*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(458, 160);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 13);
            this.label19.TabIndex = 55;
            this.label19.Text = "Limite de Credito*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(318, 159);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 47;
            this.label15.Text = "Celular (DDD)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(170, 159);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Telefone(DDD)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 158);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "CPF / CNPJ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(575, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "UF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(482, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Cep";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Cidade";
            // 
            // tb_cidade
            // 
            this.tb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidade.Location = new System.Drawing.Point(172, 126);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(308, 26);
            this.tb_cidade.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Bairro";
            // 
            // tb_bairro
            // 
            this.tb_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bairro.Location = new System.Drawing.Point(10, 125);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(156, 26);
            this.tb_bairro.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(531, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Número";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Endereço";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endereco.Location = new System.Drawing.Point(172, 77);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(352, 26);
            this.tb_endereco.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Apelido";
            // 
            // tb_apelido
            // 
            this.tb_apelido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_apelido.Location = new System.Drawing.Point(9, 76);
            this.tb_apelido.Name = "tb_apelido";
            this.tb_apelido.Size = new System.Drawing.Size(156, 26);
            this.tb_apelido.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Data Nascimento";
            // 
            // dtp_data
            // 
            this.dtp_data.CustomFormat = "MM/dd/yyyy";
            this.dtp_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_data.Location = new System.Drawing.Point(530, 28);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(102, 26);
            this.dtp_data.TabIndex = 26;
            this.dtp_data.Value = new System.DateTime(2023, 8, 22, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nome Cliente *";
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(115, 28);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(409, 26);
            this.tb_nome.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cód Cliente";
            // 
            // tb_codCliente
            // 
            this.tb_codCliente.Enabled = false;
            this.tb_codCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codCliente.Location = new System.Drawing.Point(9, 28);
            this.tb_codCliente.Name = "tb_codCliente";
            this.tb_codCliente.Size = new System.Drawing.Size(100, 26);
            this.tb_codCliente.TabIndex = 22;
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.Crimson;
            this.btn_Deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deletar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Deletar.Location = new System.Drawing.Point(246, 486);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(151, 35);
            this.btn_Deletar.TabIndex = 19;
            this.btn_Deletar.Text = "Deletar Cliente";
            this.btn_Deletar.UseVisualStyleBackColor = false;
            this.btn_Deletar.Click += new System.EventHandler(this.btn_Deletar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Green;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_salvar.Location = new System.Drawing.Point(87, 486);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(151, 35);
            this.btn_salvar.TabIndex = 18;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // tabExtrato
            // 
            this.tabExtrato.Location = new System.Drawing.Point(4, 22);
            this.tabExtrato.Name = "tabExtrato";
            this.tabExtrato.Padding = new System.Windows.Forms.Padding(3);
            this.tabExtrato.Size = new System.Drawing.Size(645, 527);
            this.tabExtrato.TabIndex = 2;
            this.tabExtrato.Text = "Extrato";
            this.tabExtrato.UseVisualStyleBackColor = true;
            // 
            // F_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 636);
            this.Controls.Add(this.tab_users);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Cliente";
            this.Load += new System.EventHandler(this.F_Cliente_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_usuarios)).EndInit();
            this.tab_users.ResumeLayout(false);
            this.tab_Clientes.ResumeLayout(false);
            this.tab_Clientes.PerformLayout();
            this.tabNovoCliente.ResumeLayout(false);
            this.tabNovoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Numero)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_totalCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_busca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtg_usuarios;
        private System.Windows.Forms.ComboBox cbx_filterBusca;
        private System.Windows.Forms.TabControl tab_users;
        private System.Windows.Forms.TabPage tab_Clientes;
        private System.Windows.Forms.TabPage tabNovoCliente;
        private System.Windows.Forms.Button btn_deletar_item;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabExtrato;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_codCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_apelido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tb_site;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_observacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_inativo;
        private System.Windows.Forms.RadioButton rdb_ativo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdb_juridica;
        private System.Windows.Forms.RadioButton rdb_fisica;
        private System.Windows.Forms.MaskedTextBox mask_telefone;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.MaskedTextBox mask_prazo;
        private System.Windows.Forms.MaskedTextBox mask_limite;
        private System.Windows.Forms.MaskedTextBox mask_celular;
        private System.Windows.Forms.MaskedTextBox mask_cep;
        private System.Windows.Forms.ComboBox cbx_uf;
        private System.Windows.Forms.NumericUpDown num_Numero;
        private System.Windows.Forms.MaskedTextBox mask_Cnpj;
        private System.Windows.Forms.Button btn_limpar;
    }
}