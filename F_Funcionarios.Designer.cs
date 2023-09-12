namespace mysql_conection
{
    partial class F_Funcionarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_deletar_item = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tab_Funcionarios = new System.Windows.Forms.TabPage();
            this.dtg_funcionarios = new System.Windows.Forms.DataGridView();
            this.tb_busca = new System.Windows.Forms.TextBox();
            this.tab_funcionario = new System.Windows.Forms.TabControl();
            this.tabNovoFuncionario = new System.Windows.Forms.TabPage();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.dt_dataAdmissao = new System.Windows.Forms.DateTimePicker();
            this.dt_dataNasc = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.cbx_cargo = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.mask_cep = new System.Windows.Forms.MaskedTextBox();
            this.mask_salario = new System.Windows.Forms.MaskedTextBox();
            this.mask_telefone = new System.Windows.Forms.MaskedTextBox();
            this.mask_cpf = new System.Windows.Forms.MaskedTextBox();
            this.cbx_uf = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_cidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nomeFunc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_cod_func = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_totalFunc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tab_Funcionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_funcionarios)).BeginInit();
            this.tab_funcionario.SuspendLayout();
            this.tabNovoFuncionario.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_deletar_item
            // 
            this.btn_deletar_item.BackColor = System.Drawing.Color.Crimson;
            this.btn_deletar_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar_item.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deletar_item.Location = new System.Drawing.Point(345, 481);
            this.btn_deletar_item.Name = "btn_deletar_item";
            this.btn_deletar_item.Size = new System.Drawing.Size(151, 35);
            this.btn_deletar_item.TabIndex = 15;
            this.btn_deletar_item.Text = "Deletar ";
            this.btn_deletar_item.UseVisualStyleBackColor = false;
            this.btn_deletar_item.Click += new System.EventHandler(this.btn_deletar_item_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.Green;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_adicionar.Location = new System.Drawing.Point(187, 481);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(151, 35);
            this.btn_adicionar.TabIndex = 14;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tab_Funcionarios
            // 
            this.tab_Funcionarios.Controls.Add(this.btn_deletar_item);
            this.tab_Funcionarios.Controls.Add(this.btn_adicionar);
            this.tab_Funcionarios.Controls.Add(this.dtg_funcionarios);
            this.tab_Funcionarios.Controls.Add(this.tb_busca);
            this.tab_Funcionarios.Location = new System.Drawing.Point(4, 22);
            this.tab_Funcionarios.Name = "tab_Funcionarios";
            this.tab_Funcionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Funcionarios.Size = new System.Drawing.Size(667, 523);
            this.tab_Funcionarios.TabIndex = 0;
            this.tab_Funcionarios.Text = "Funcionarios";
            this.tab_Funcionarios.UseVisualStyleBackColor = true;
            // 
            // dtg_funcionarios
            // 
            this.dtg_funcionarios.AllowUserToAddRows = false;
            this.dtg_funcionarios.AllowUserToDeleteRows = false;
            this.dtg_funcionarios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_funcionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_funcionarios.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_funcionarios.EnableHeadersVisualStyles = false;
            this.dtg_funcionarios.Location = new System.Drawing.Point(6, 42);
            this.dtg_funcionarios.MultiSelect = false;
            this.dtg_funcionarios.Name = "dtg_funcionarios";
            this.dtg_funcionarios.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_funcionarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_funcionarios.RowHeadersVisible = false;
            this.dtg_funcionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_funcionarios.Size = new System.Drawing.Size(655, 433);
            this.dtg_funcionarios.TabIndex = 7;
            this.dtg_funcionarios.DoubleClick += new System.EventHandler(this.dtg_funcionarios_DoubleClick);
            // 
            // tb_busca
            // 
            this.tb_busca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_busca.Location = new System.Drawing.Point(6, 6);
            this.tb_busca.Name = "tb_busca";
            this.tb_busca.Size = new System.Drawing.Size(655, 27);
            this.tb_busca.TabIndex = 10;
            this.tb_busca.TextChanged += new System.EventHandler(this.tb_busca_TextChanged);
            // 
            // tab_funcionario
            // 
            this.tab_funcionario.Controls.Add(this.tab_Funcionarios);
            this.tab_funcionario.Controls.Add(this.tabNovoFuncionario);
            this.tab_funcionario.Location = new System.Drawing.Point(12, 48);
            this.tab_funcionario.Name = "tab_funcionario";
            this.tab_funcionario.SelectedIndex = 0;
            this.tab_funcionario.Size = new System.Drawing.Size(675, 549);
            this.tab_funcionario.TabIndex = 17;
            // 
            // tabNovoFuncionario
            // 
            this.tabNovoFuncionario.Controls.Add(this.btn_limpar);
            this.tabNovoFuncionario.Controls.Add(this.dt_dataAdmissao);
            this.tabNovoFuncionario.Controls.Add(this.dt_dataNasc);
            this.tabNovoFuncionario.Controls.Add(this.label14);
            this.tabNovoFuncionario.Controls.Add(this.cbx_cargo);
            this.tabNovoFuncionario.Controls.Add(this.btn_delete);
            this.tabNovoFuncionario.Controls.Add(this.btn_salvar);
            this.tabNovoFuncionario.Controls.Add(this.mask_cep);
            this.tabNovoFuncionario.Controls.Add(this.mask_salario);
            this.tabNovoFuncionario.Controls.Add(this.mask_telefone);
            this.tabNovoFuncionario.Controls.Add(this.mask_cpf);
            this.tabNovoFuncionario.Controls.Add(this.cbx_uf);
            this.tabNovoFuncionario.Controls.Add(this.label24);
            this.tabNovoFuncionario.Controls.Add(this.label25);
            this.tabNovoFuncionario.Controls.Add(this.tb_email);
            this.tabNovoFuncionario.Controls.Add(this.label19);
            this.tabNovoFuncionario.Controls.Add(this.label15);
            this.tabNovoFuncionario.Controls.Add(this.label17);
            this.tabNovoFuncionario.Controls.Add(this.label13);
            this.tabNovoFuncionario.Controls.Add(this.label12);
            this.tabNovoFuncionario.Controls.Add(this.label10);
            this.tabNovoFuncionario.Controls.Add(this.tb_cidade);
            this.tabNovoFuncionario.Controls.Add(this.label11);
            this.tabNovoFuncionario.Controls.Add(this.tb_bairro);
            this.tabNovoFuncionario.Controls.Add(this.label9);
            this.tabNovoFuncionario.Controls.Add(this.tb_numero);
            this.tabNovoFuncionario.Controls.Add(this.label7);
            this.tabNovoFuncionario.Controls.Add(this.tb_endereco);
            this.tabNovoFuncionario.Controls.Add(this.label6);
            this.tabNovoFuncionario.Controls.Add(this.label5);
            this.tabNovoFuncionario.Controls.Add(this.tb_nomeFunc);
            this.tabNovoFuncionario.Controls.Add(this.label4);
            this.tabNovoFuncionario.Controls.Add(this.tb_cod_func);
            this.tabNovoFuncionario.Location = new System.Drawing.Point(4, 22);
            this.tabNovoFuncionario.Name = "tabNovoFuncionario";
            this.tabNovoFuncionario.Padding = new System.Windows.Forms.Padding(3);
            this.tabNovoFuncionario.Size = new System.Drawing.Size(667, 523);
            this.tabNovoFuncionario.TabIndex = 1;
            this.tabNovoFuncionario.Text = "Novo Funcionario";
            this.tabNovoFuncionario.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_limpar.Location = new System.Drawing.Point(409, 482);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(151, 35);
            this.btn_limpar.TabIndex = 124;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // dt_dataAdmissao
            // 
            this.dt_dataAdmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_dataAdmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dataAdmissao.Location = new System.Drawing.Point(438, 172);
            this.dt_dataAdmissao.Name = "dt_dataAdmissao";
            this.dt_dataAdmissao.Size = new System.Drawing.Size(124, 26);
            this.dt_dataAdmissao.TabIndex = 123;
            // 
            // dt_dataNasc
            // 
            this.dt_dataNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_dataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_dataNasc.Location = new System.Drawing.Point(526, 26);
            this.dt_dataNasc.Name = "dt_dataNasc";
            this.dt_dataNasc.Size = new System.Drawing.Size(130, 26);
            this.dt_dataNasc.TabIndex = 122;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(435, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 120;
            this.label14.Text = "Data Admissão";
            // 
            // cbx_cargo
            // 
            this.cbx_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_cargo.FormattingEnabled = true;
            this.cbx_cargo.Location = new System.Drawing.Point(334, 224);
            this.cbx_cargo.Name = "cbx_cargo";
            this.cbx_cargo.Size = new System.Drawing.Size(322, 26);
            this.cbx_cargo.TabIndex = 116;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Crimson;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_delete.Location = new System.Drawing.Point(252, 482);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(151, 35);
            this.btn_delete.TabIndex = 114;
            this.btn_delete.Text = "Deletar";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Green;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_salvar.Location = new System.Drawing.Point(95, 482);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(151, 35);
            this.btn_salvar.TabIndex = 113;
            this.btn_salvar.Text = "Salvar ";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // mask_cep
            // 
            this.mask_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_cep.Location = new System.Drawing.Point(13, 75);
            this.mask_cep.Mask = "00000-999";
            this.mask_cep.Name = "mask_cep";
            this.mask_cep.Size = new System.Drawing.Size(154, 24);
            this.mask_cep.TabIndex = 112;
            this.mask_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mask_salario
            // 
            this.mask_salario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_salario.Location = new System.Drawing.Point(334, 173);
            this.mask_salario.Mask = "00000";
            this.mask_salario.Name = "mask_salario";
            this.mask_salario.Size = new System.Drawing.Size(98, 24);
            this.mask_salario.TabIndex = 110;
            this.mask_salario.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mask_salario.ValidatingType = typeof(int);
            // 
            // mask_telefone
            // 
            this.mask_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_telefone.Location = new System.Drawing.Point(174, 172);
            this.mask_telefone.Mask = "(00)0 0000-0000";
            this.mask_telefone.Name = "mask_telefone";
            this.mask_telefone.Size = new System.Drawing.Size(153, 24);
            this.mask_telefone.TabIndex = 109;
            this.mask_telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mask_cpf
            // 
            this.mask_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mask_cpf.Location = new System.Drawing.Point(13, 172);
            this.mask_cpf.Mask = "000.000.000-00";
            this.mask_cpf.Name = "mask_cpf";
            this.mask_cpf.Size = new System.Drawing.Size(154, 24);
            this.mask_cpf.TabIndex = 107;
            this.mask_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cbx_uf
            // 
            this.cbx_uf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbx_uf.Location = new System.Drawing.Point(502, 124);
            this.cbx_uf.Name = "cbx_uf";
            this.cbx_uf.Size = new System.Drawing.Size(60, 26);
            this.cbx_uf.TabIndex = 106;
            this.cbx_uf.Text = "RO";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(331, 206);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 13);
            this.label24.TabIndex = 101;
            this.label24.Text = "Cargo";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 206);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(36, 13);
            this.label25.TabIndex = 99;
            this.label25.Text = "E-Mail";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(12, 223);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(316, 26);
            this.tb_email.TabIndex = 98;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(331, 156);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 96;
            this.label19.Text = "Salario";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(171, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 95;
            this.label15.Text = "Celular (DDD)*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 156);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 93;
            this.label17.Text = "CPF*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(499, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 92;
            this.label13.Text = "UF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 91;
            this.label12.Text = "Cep";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 90;
            this.label10.Text = "Cidade";
            // 
            // tb_cidade
            // 
            this.tb_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cidade.Location = new System.Drawing.Point(174, 124);
            this.tb_cidade.Name = "tb_cidade";
            this.tb_cidade.Size = new System.Drawing.Size(322, 26);
            this.tb_cidade.TabIndex = 89;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 88;
            this.label11.Text = "Bairro";
            // 
            // tb_bairro
            // 
            this.tb_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_bairro.Location = new System.Drawing.Point(12, 123);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(156, 26);
            this.tb_bairro.TabIndex = 87;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(555, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 86;
            this.label9.Text = "Número";
            // 
            // tb_numero
            // 
            this.tb_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_numero.Location = new System.Drawing.Point(557, 75);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(100, 26);
            this.tb_numero.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 84;
            this.label7.Text = "Endereço";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_endereco.Location = new System.Drawing.Point(174, 75);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(377, 26);
            this.tb_endereco.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 80;
            this.label6.Text = "Data Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "Nome Funcionario*";
            // 
            // tb_nomeFunc
            // 
            this.tb_nomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nomeFunc.Location = new System.Drawing.Point(117, 26);
            this.tb_nomeFunc.Name = "tb_nomeFunc";
            this.tb_nomeFunc.Size = new System.Drawing.Size(403, 26);
            this.tb_nomeFunc.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Cód Funcionario";
            // 
            // tb_cod_func
            // 
            this.tb_cod_func.Enabled = false;
            this.tb_cod_func.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_cod_func.Location = new System.Drawing.Point(11, 26);
            this.tb_cod_func.Name = "tb_cod_func";
            this.tb_cod_func.Size = new System.Drawing.Size(100, 26);
            this.tb_cod_func.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Funcionarios";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.lb_totalFunc);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 603);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 26);
            this.panel2.TabIndex = 16;
            // 
            // lb_totalFunc
            // 
            this.lb_totalFunc.AutoSize = true;
            this.lb_totalFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalFunc.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_totalFunc.Location = new System.Drawing.Point(137, 6);
            this.lb_totalFunc.Name = "lb_totalFunc";
            this.lb_totalFunc.Size = new System.Drawing.Size(15, 15);
            this.lb_totalFunc.TabIndex = 3;
            this.lb_totalFunc.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Funcionario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(105, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
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
            this.panel1.TabIndex = 15;
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
            // F_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 629);
            this.Controls.Add(this.tab_funcionario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Funcionarios";
            this.Load += new System.EventHandler(this.F_Funcionarios_Load);
            this.tab_Funcionarios.ResumeLayout(false);
            this.tab_Funcionarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_funcionarios)).EndInit();
            this.tab_funcionario.ResumeLayout(false);
            this.tabNovoFuncionario.ResumeLayout(false);
            this.tabNovoFuncionario.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_deletar_item;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TabPage tab_Funcionarios;
        private System.Windows.Forms.DataGridView dtg_funcionarios;
        private System.Windows.Forms.TextBox tb_busca;
        private System.Windows.Forms.TabControl tab_funcionario;
        private System.Windows.Forms.TabPage tabNovoFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mask_cep;
        private System.Windows.Forms.MaskedTextBox mask_salario;
        private System.Windows.Forms.MaskedTextBox mask_telefone;
        private System.Windows.Forms.MaskedTextBox mask_cpf;
        private System.Windows.Forms.ComboBox cbx_uf;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_cidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nomeFunc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_cod_func;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.ComboBox cbx_cargo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dt_dataNasc;
        private System.Windows.Forms.DateTimePicker dt_dataAdmissao;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label lb_totalFunc;
    }
}