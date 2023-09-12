namespace mysql_conection
{
    partial class F_Fornecedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtg_fornecedores = new System.Windows.Forms.DataGridView();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_busca = new System.Windows.Forms.TextBox();
            this.btn_deletar_item = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_emailRepres = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_repres = new System.Windows.Forms.TextBox();
            this.cbx_uf = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.mask_celular = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.mask_telefone2 = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mask_telefone1 = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mask_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.mask_cep = new System.Windows.Forms.MaskedTextBox();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.num_numero = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_observacao = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_site = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nomeFornecedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_codItem = new System.Windows.Forms.TextBox();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.tab_fornecedores = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_totalForn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_fornecedores)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_numero)).BeginInit();
            this.tab_fornecedores.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtg_fornecedores);
            this.tabPage1.Controls.Add(this.btn_adicionar);
            this.tabPage1.Controls.Add(this.tb_busca);
            this.tabPage1.Controls.Add(this.btn_deletar_item);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(672, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista de Fornecedores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtg_fornecedores
            // 
            this.dtg_fornecedores.AllowUserToAddRows = false;
            this.dtg_fornecedores.AllowUserToDeleteRows = false;
            this.dtg_fornecedores.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_fornecedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_fornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_fornecedores.EnableHeadersVisualStyles = false;
            this.dtg_fornecedores.Location = new System.Drawing.Point(5, 42);
            this.dtg_fornecedores.MultiSelect = false;
            this.dtg_fornecedores.Name = "dtg_fornecedores";
            this.dtg_fornecedores.ReadOnly = true;
            this.dtg_fornecedores.RowHeadersVisible = false;
            this.dtg_fornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_fornecedores.Size = new System.Drawing.Size(661, 441);
            this.dtg_fornecedores.TabIndex = 1;
            this.dtg_fornecedores.DoubleClick += new System.EventHandler(this.dtg_fornecedores_DoubleClick);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.Green;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_adicionar.Location = new System.Drawing.Point(176, 489);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(151, 35);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.Text = "Adicionar Novo";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            // 
            // tb_busca
            // 
            this.tb_busca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_busca.Location = new System.Drawing.Point(5, 12);
            this.tb_busca.Name = "tb_busca";
            this.tb_busca.Size = new System.Drawing.Size(661, 27);
            this.tb_busca.TabIndex = 3;
            // 
            // btn_deletar_item
            // 
            this.btn_deletar_item.BackColor = System.Drawing.Color.Crimson;
            this.btn_deletar_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar_item.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deletar_item.Location = new System.Drawing.Point(333, 489);
            this.btn_deletar_item.Name = "btn_deletar_item";
            this.btn_deletar_item.Size = new System.Drawing.Size(151, 35);
            this.btn_deletar_item.TabIndex = 4;
            this.btn_deletar_item.Text = "Deletar ";
            this.btn_deletar_item.UseVisualStyleBackColor = false;
            this.btn_deletar_item.Click += new System.EventHandler(this.btn_deletar_item_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_limpar);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.tb_emailRepres);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.tb_repres);
            this.tabPage2.Controls.Add(this.cbx_uf);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.mask_celular);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.mask_telefone2);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.mask_telefone1);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.mask_CNPJ);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tb_cidade);
            this.tabPage2.Controls.Add(this.mask_cep);
            this.tabPage2.Controls.Add(this.tb_bairro);
            this.tabPage2.Controls.Add(this.num_numero);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tb_endereco);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.tb_observacao);
            this.tabPage2.Controls.Add(this.label24);
            this.tabPage2.Controls.Add(this.tb_site);
            this.tabPage2.Controls.Add(this.label25);
            this.tabPage2.Controls.Add(this.tb_email);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tb_nomeFornecedor);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tb_codItem);
            this.tabPage2.Controls.Add(this.btn_deletar);
            this.tabPage2.Controls.Add(this.btn_salvar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Novo Fornecedor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(335, 256);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 13);
            this.label17.TabIndex = 144;
            this.label17.Text = "E-Mail do Representante";
            // 
            // tb_emailRepres
            // 
            this.tb_emailRepres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_emailRepres.Location = new System.Drawing.Point(338, 273);
            this.tb_emailRepres.MaxLength = 70;
            this.tb_emailRepres.Name = "tb_emailRepres";
            this.tb_emailRepres.Size = new System.Drawing.Size(322, 26);
            this.tb_emailRepres.TabIndex = 143;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 256);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(136, 13);
            this.label18.TabIndex = 142;
            this.label18.Text = "Representante da Empresa";
            // 
            // tb_repres
            // 
            this.tb_repres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_repres.Location = new System.Drawing.Point(15, 273);
            this.tb_repres.MaxLength = 50;
            this.tb_repres.Name = "tb_repres";
            this.tb_repres.Size = new System.Drawing.Size(317, 26);
            this.tb_repres.TabIndex = 141;
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
            this.cbx_uf.Location = new System.Drawing.Point(599, 126);
            this.cbx_uf.Name = "cbx_uf";
            this.cbx_uf.Size = new System.Drawing.Size(60, 24);
            this.cbx_uf.TabIndex = 140;
            this.cbx_uf.Text = "RO";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(596, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 139;
            this.label16.Text = "UF";
            // 
            // mask_celular
            // 
            this.mask_celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_celular.Location = new System.Drawing.Point(443, 175);
            this.mask_celular.Mask = "(00)0 00000000";
            this.mask_celular.Name = "mask_celular";
            this.mask_celular.Size = new System.Drawing.Size(125, 26);
            this.mask_celular.TabIndex = 138;
            this.mask_celular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(440, 158);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 13);
            this.label15.TabIndex = 137;
            this.label15.Text = "Celular (WhatsApp)";
            // 
            // mask_telefone2
            // 
            this.mask_telefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_telefone2.Location = new System.Drawing.Point(309, 175);
            this.mask_telefone2.Mask = "(99) 000-0000";
            this.mask_telefone2.Name = "mask_telefone2";
            this.mask_telefone2.Size = new System.Drawing.Size(125, 26);
            this.mask_telefone2.TabIndex = 136;
            this.mask_telefone2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(306, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 135;
            this.label13.Text = "Telefone 2";
            // 
            // mask_telefone1
            // 
            this.mask_telefone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_telefone1.Location = new System.Drawing.Point(178, 175);
            this.mask_telefone1.Mask = "(99) 000-0000";
            this.mask_telefone1.Name = "mask_telefone1";
            this.mask_telefone1.Size = new System.Drawing.Size(125, 26);
            this.mask_telefone1.TabIndex = 134;
            this.mask_telefone1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(175, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 133;
            this.label14.Text = "Telefone 1";
            // 
            // mask_CNPJ
            // 
            this.mask_CNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_CNPJ.Location = new System.Drawing.Point(14, 175);
            this.mask_CNPJ.Mask = "00.000.000/0000-00";
            this.mask_CNPJ.Name = "mask_CNPJ";
            this.mask_CNPJ.Size = new System.Drawing.Size(157, 26);
            this.mask_CNPJ.TabIndex = 131;
            this.mask_CNPJ.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 130;
            this.label12.Text = "CNPJ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 129;
            this.label9.Text = "Cidade";
            // 
            // tb_cidade
            // 
            this.tb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidade.Location = new System.Drawing.Point(442, 125);
            this.tb_cidade.MaxLength = 40;
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(152, 26);
            this.tb_cidade.TabIndex = 128;
            // 
            // mask_cep
            // 
            this.mask_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_cep.Location = new System.Drawing.Point(311, 125);
            this.mask_cep.Mask = "00000-999";
            this.mask_cep.Name = "mask_cep";
            this.mask_cep.Size = new System.Drawing.Size(125, 26);
            this.mask_cep.TabIndex = 127;
            this.mask_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // tb_bairro
            // 
            this.tb_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bairro.Location = new System.Drawing.Point(14, 125);
            this.tb_bairro.MaxLength = 30;
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(288, 26);
            this.tb_bairro.TabIndex = 126;
            // 
            // num_numero
            // 
            this.num_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_numero.Location = new System.Drawing.Point(535, 76);
            this.num_numero.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_numero.Name = "num_numero";
            this.num_numero.Size = new System.Drawing.Size(124, 26);
            this.num_numero.TabIndex = 125;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(533, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 124;
            this.label8.Text = "Número";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endereco.Location = new System.Drawing.Point(15, 76);
            this.tb_endereco.MaxLength = 50;
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(514, 26);
            this.tb_endereco.TabIndex = 123;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 305);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 13);
            this.label23.TabIndex = 105;
            this.label23.Text = "Observação";
            // 
            // tb_observacao
            // 
            this.tb_observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_observacao.Location = new System.Drawing.Point(15, 321);
            this.tb_observacao.MaxLength = 500;
            this.tb_observacao.Multiline = true;
            this.tb_observacao.Name = "tb_observacao";
            this.tb_observacao.Size = new System.Drawing.Size(644, 61);
            this.tb_observacao.TabIndex = 104;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(334, 207);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(25, 13);
            this.label24.TabIndex = 103;
            this.label24.Text = "Site";
            // 
            // tb_site
            // 
            this.tb_site.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_site.Location = new System.Drawing.Point(337, 224);
            this.tb_site.MaxLength = 150;
            this.tb_site.Name = "tb_site";
            this.tb_site.Size = new System.Drawing.Size(322, 26);
            this.tb_site.TabIndex = 102;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(12, 207);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(36, 13);
            this.label25.TabIndex = 101;
            this.label25.Text = "E-Mail";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(14, 224);
            this.tb_email.MaxLength = 70;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(317, 26);
            this.tb_email.TabIndex = 100;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 92;
            this.label10.Text = "Cep";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 90;
            this.label11.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Endereço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Fornecedor (Empresa)*";
            // 
            // tb_nomeFornecedor
            // 
            this.tb_nomeFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nomeFornecedor.Location = new System.Drawing.Point(120, 27);
            this.tb_nomeFornecedor.MaxLength = 50;
            this.tb_nomeFornecedor.Name = "tb_nomeFornecedor";
            this.tb_nomeFornecedor.Size = new System.Drawing.Size(539, 26);
            this.tb_nomeFornecedor.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Cód item";
            // 
            // tb_codItem
            // 
            this.tb_codItem.Enabled = false;
            this.tb_codItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codItem.Location = new System.Drawing.Point(14, 27);
            this.tb_codItem.Name = "tb_codItem";
            this.tb_codItem.Size = new System.Drawing.Size(100, 26);
            this.tb_codItem.TabIndex = 77;
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.Crimson;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deletar.Location = new System.Drawing.Point(260, 489);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(151, 35);
            this.btn_deletar.TabIndex = 76;
            this.btn_deletar.Text = "Deletar ";
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Green;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_salvar.Location = new System.Drawing.Point(103, 489);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(151, 35);
            this.btn_salvar.TabIndex = 75;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // tab_fornecedores
            // 
            this.tab_fornecedores.Controls.Add(this.tabPage1);
            this.tab_fornecedores.Controls.Add(this.tabPage2);
            this.tab_fornecedores.Location = new System.Drawing.Point(10, 48);
            this.tab_fornecedores.Name = "tab_fornecedores";
            this.tab_fornecedores.SelectedIndex = 0;
            this.tab_fornecedores.Size = new System.Drawing.Size(680, 556);
            this.tab_fornecedores.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 42);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Fornecedores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::mysql_conection.Properties.Resources.close__1_;
            this.pictureBox1.Location = new System.Drawing.Point(662, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_totalForn
            // 
            this.lb_totalForn.AutoSize = true;
            this.lb_totalForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalForn.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_totalForn.Location = new System.Drawing.Point(105, 6);
            this.lb_totalForn.Name = "lb_totalForn";
            this.lb_totalForn.Size = new System.Drawing.Size(15, 15);
            this.lb_totalForn.TabIndex = 1;
            this.lb_totalForn.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Produto:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lb_totalForn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 610);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 26);
            this.panel2.TabIndex = 9;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_limpar.Location = new System.Drawing.Point(417, 489);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(151, 35);
            this.btn_limpar.TabIndex = 145;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // F_Fornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 636);
            this.Controls.Add(this.tab_fornecedores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Fornecedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Fornecedores";
            this.Load += new System.EventHandler(this.F_Fornecedores_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_fornecedores)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_numero)).EndInit();
            this.tab_fornecedores.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtg_fornecedores;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tb_busca;
        private System.Windows.Forms.Button btn_deletar_item;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_observacao;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tb_site;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nomeFornecedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_codItem;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TabControl tab_fornecedores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_totalForn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown num_numero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.MaskedTextBox mask_CNPJ;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.MaskedTextBox mask_cep;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox mask_celular;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox mask_telefone2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mask_telefone1;
        private System.Windows.Forms.ComboBox cbx_uf;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_emailRepres;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_repres;
        private System.Windows.Forms.Button btn_limpar;
    }
}