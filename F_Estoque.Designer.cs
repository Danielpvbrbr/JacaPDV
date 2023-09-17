namespace mysql_conection
{
    partial class F_Estoque
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_busca = new System.Windows.Forms.TextBox();
            this.dgv_produtos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_quantTotal = new System.Windows.Forms.Label();
            this.btn_listarTodos = new System.Windows.Forms.Button();
            this.tabEstoque = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_limparCampo = new System.Windows.Forms.Button();
            this.num_precoPromocao = new System.Windows.Forms.NumericUpDown();
            this.num_precoAtacado = new System.Windows.Forms.NumericUpDown();
            this.num_precoVenda = new System.Windows.Forms.NumericUpDown();
            this.num_precoCusto = new System.Windows.Forms.NumericUpDown();
            this.numb_estoque = new System.Windows.Forms.NumericUpDown();
            this.cbx_fornecedor = new System.Windows.Forms.ComboBox();
            this.cbx_setor = new System.Windows.Forms.ComboBox();
            this.cbx_fabricante = new System.Windows.Forms.ComboBox();
            this.cbx_typeUnidade = new System.Windows.Forms.ComboBox();
            this.tb_codInterno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_indisponivel = new System.Windows.Forms.RadioButton();
            this.rd_disponivel = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_observacao = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_codBarras = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_descricaoProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabEstoque.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_precoPromocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_precoAtacado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_precoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_precoCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numb_estoque)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de Produtos";
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
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.Green;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_adicionar.Location = new System.Drawing.Point(188, 489);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(151, 35);
            this.btn_adicionar.TabIndex = 2;
            this.btn_adicionar.Text = "Adicionar Novo";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_busca
            // 
            this.tb_busca.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_busca.Location = new System.Drawing.Point(5, 12);
            this.tb_busca.Name = "tb_busca";
            this.tb_busca.Size = new System.Drawing.Size(661, 27);
            this.tb_busca.TabIndex = 3;
            this.tb_busca.TextChanged += new System.EventHandler(this.tb_busca_TextChanged);
            this.tb_busca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // dgv_produtos
            // 
            this.dgv_produtos.AllowUserToAddRows = false;
            this.dgv_produtos.AllowUserToDeleteRows = false;
            this.dgv_produtos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_produtos.EnableHeadersVisualStyles = false;
            this.dgv_produtos.Location = new System.Drawing.Point(5, 42);
            this.dgv_produtos.MultiSelect = false;
            this.dgv_produtos.Name = "dgv_produtos";
            this.dgv_produtos.ReadOnly = true;
            this.dgv_produtos.RowHeadersVisible = false;
            this.dgv_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_produtos.Size = new System.Drawing.Size(661, 441);
            this.dgv_produtos.TabIndex = 1;
            this.dgv_produtos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_produtos_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lb_quantTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 610);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 26);
            this.panel2.TabIndex = 2;
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
            // lb_quantTotal
            // 
            this.lb_quantTotal.AutoSize = true;
            this.lb_quantTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_quantTotal.Location = new System.Drawing.Point(105, 6);
            this.lb_quantTotal.Name = "lb_quantTotal";
            this.lb_quantTotal.Size = new System.Drawing.Size(15, 15);
            this.lb_quantTotal.TabIndex = 1;
            this.lb_quantTotal.Text = "0";
            // 
            // btn_listarTodos
            // 
            this.btn_listarTodos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_listarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listarTodos.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_listarTodos.Location = new System.Drawing.Point(345, 489);
            this.btn_listarTodos.Name = "btn_listarTodos";
            this.btn_listarTodos.Size = new System.Drawing.Size(151, 35);
            this.btn_listarTodos.TabIndex = 5;
            this.btn_listarTodos.Text = "Listar Todos";
            this.btn_listarTodos.UseVisualStyleBackColor = false;
            // 
            // tabEstoque
            // 
            this.tabEstoque.Controls.Add(this.tabPage1);
            this.tabEstoque.Controls.Add(this.tabPage2);
            this.tabEstoque.Location = new System.Drawing.Point(5, 48);
            this.tabEstoque.Name = "tabEstoque";
            this.tabEstoque.SelectedIndex = 0;
            this.tabEstoque.Size = new System.Drawing.Size(680, 556);
            this.tabEstoque.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_listarTodos);
            this.tabPage1.Controls.Add(this.dgv_produtos);
            this.tabPage1.Controls.Add(this.btn_adicionar);
            this.tabPage1.Controls.Add(this.tb_busca);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(672, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista de Produtos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_limparCampo);
            this.tabPage2.Controls.Add(this.num_precoPromocao);
            this.tabPage2.Controls.Add(this.num_precoAtacado);
            this.tabPage2.Controls.Add(this.num_precoVenda);
            this.tabPage2.Controls.Add(this.num_precoCusto);
            this.tabPage2.Controls.Add(this.numb_estoque);
            this.tabPage2.Controls.Add(this.cbx_fornecedor);
            this.tabPage2.Controls.Add(this.cbx_setor);
            this.tabPage2.Controls.Add(this.cbx_fabricante);
            this.tabPage2.Controls.Add(this.cbx_typeUnidade);
            this.tabPage2.Controls.Add(this.tb_codInterno);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.tb_observacao);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tb_codBarras);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tb_descricaoProduto);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tb_id);
            this.tabPage2.Controls.Add(this.btn_delete);
            this.tabPage2.Controls.Add(this.btn_salvar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Novo Produto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_limparCampo
            // 
            this.btn_limparCampo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_limparCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limparCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparCampo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_limparCampo.Location = new System.Drawing.Point(416, 489);
            this.btn_limparCampo.Name = "btn_limparCampo";
            this.btn_limparCampo.Size = new System.Drawing.Size(151, 35);
            this.btn_limparCampo.TabIndex = 125;
            this.btn_limparCampo.Text = "Limpar";
            this.btn_limparCampo.UseVisualStyleBackColor = false;
            this.btn_limparCampo.Click += new System.EventHandler(this.btn_limparCampo_Click);
            // 
            // num_precoPromocao
            // 
            this.num_precoPromocao.DecimalPlaces = 2;
            this.num_precoPromocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_precoPromocao.Location = new System.Drawing.Point(441, 174);
            this.num_precoPromocao.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_precoPromocao.Name = "num_precoPromocao";
            this.num_precoPromocao.Size = new System.Drawing.Size(99, 24);
            this.num_precoPromocao.TabIndex = 124;
            // 
            // num_precoAtacado
            // 
            this.num_precoAtacado.DecimalPlaces = 2;
            this.num_precoAtacado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_precoAtacado.Location = new System.Drawing.Point(309, 172);
            this.num_precoAtacado.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_precoAtacado.Name = "num_precoAtacado";
            this.num_precoAtacado.Size = new System.Drawing.Size(104, 24);
            this.num_precoAtacado.TabIndex = 123;
            // 
            // num_precoVenda
            // 
            this.num_precoVenda.DecimalPlaces = 2;
            this.num_precoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_precoVenda.Location = new System.Drawing.Point(178, 174);
            this.num_precoVenda.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_precoVenda.Name = "num_precoVenda";
            this.num_precoVenda.Size = new System.Drawing.Size(105, 24);
            this.num_precoVenda.TabIndex = 122;
            // 
            // num_precoCusto
            // 
            this.num_precoCusto.DecimalPlaces = 2;
            this.num_precoCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_precoCusto.Location = new System.Drawing.Point(14, 173);
            this.num_precoCusto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_precoCusto.Name = "num_precoCusto";
            this.num_precoCusto.Size = new System.Drawing.Size(112, 24);
            this.num_precoCusto.TabIndex = 121;
            // 
            // numb_estoque
            // 
            this.numb_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numb_estoque.Location = new System.Drawing.Point(572, 173);
            this.numb_estoque.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numb_estoque.Name = "numb_estoque";
            this.numb_estoque.Size = new System.Drawing.Size(87, 24);
            this.numb_estoque.TabIndex = 120;
            this.numb_estoque.ValueChanged += new System.EventHandler(this.numb_estoque_ValueChanged);
            // 
            // cbx_fornecedor
            // 
            this.cbx_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_fornecedor.FormattingEnabled = true;
            this.cbx_fornecedor.Location = new System.Drawing.Point(178, 76);
            this.cbx_fornecedor.Name = "cbx_fornecedor";
            this.cbx_fornecedor.Size = new System.Drawing.Size(480, 26);
            this.cbx_fornecedor.TabIndex = 119;
            // 
            // cbx_setor
            // 
            this.cbx_setor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_setor.FormattingEnabled = true;
            this.cbx_setor.Location = new System.Drawing.Point(503, 125);
            this.cbx_setor.Name = "cbx_setor";
            this.cbx_setor.Size = new System.Drawing.Size(156, 26);
            this.cbx_setor.TabIndex = 118;
            // 
            // cbx_fabricante
            // 
            this.cbx_fabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_fabricante.FormattingEnabled = true;
            this.cbx_fabricante.Location = new System.Drawing.Point(15, 125);
            this.cbx_fabricante.Name = "cbx_fabricante";
            this.cbx_fabricante.Size = new System.Drawing.Size(156, 26);
            this.cbx_fabricante.TabIndex = 117;
            // 
            // cbx_typeUnidade
            // 
            this.cbx_typeUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_typeUnidade.FormattingEnabled = true;
            this.cbx_typeUnidade.Items.AddRange(new object[] {
            "UN",
            "BD",
            "CM",
            "CX",
            "DZ",
            "FD",
            "GL",
            "GR",
            "KG",
            "LT",
            "M2",
            "M3",
            "MG",
            "ML",
            "PC",
            "MM"});
            this.cbx_typeUnidade.Location = new System.Drawing.Point(14, 76);
            this.cbx_typeUnidade.Name = "cbx_typeUnidade";
            this.cbx_typeUnidade.Size = new System.Drawing.Size(156, 26);
            this.cbx_typeUnidade.TabIndex = 116;
            this.cbx_typeUnidade.Text = "UN";
            // 
            // tb_codInterno
            // 
            this.tb_codInterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codInterno.Location = new System.Drawing.Point(535, 27);
            this.tb_codInterno.Name = "tb_codInterno";
            this.tb_codInterno.Size = new System.Drawing.Size(124, 26);
            this.tb_codInterno.TabIndex = 115;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_indisponivel);
            this.groupBox1.Controls.Add(this.rd_disponivel);
            this.groupBox1.Location = new System.Drawing.Point(16, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 46);
            this.groupBox1.TabIndex = 106;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disponibilidade *";
            // 
            // rd_indisponivel
            // 
            this.rd_indisponivel.AutoSize = true;
            this.rd_indisponivel.Location = new System.Drawing.Point(101, 19);
            this.rd_indisponivel.Name = "rd_indisponivel";
            this.rd_indisponivel.Size = new System.Drawing.Size(81, 17);
            this.rd_indisponivel.TabIndex = 1;
            this.rd_indisponivel.TabStop = true;
            this.rd_indisponivel.Text = "Indisponivel";
            this.rd_indisponivel.UseVisualStyleBackColor = true;
            // 
            // rd_disponivel
            // 
            this.rd_disponivel.AutoSize = true;
            this.rd_disponivel.Location = new System.Drawing.Point(7, 20);
            this.rd_disponivel.Name = "rd_disponivel";
            this.rd_disponivel.Size = new System.Drawing.Size(74, 17);
            this.rd_disponivel.TabIndex = 0;
            this.rd_disponivel.TabStop = true;
            this.rd_disponivel.Text = "Disponivel";
            this.rd_disponivel.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 211);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(190, 13);
            this.label23.TabIndex = 105;
            this.label23.Text = "Observação de localização do produto";
            // 
            // tb_observacao
            // 
            this.tb_observacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_observacao.Location = new System.Drawing.Point(15, 227);
            this.tb_observacao.Multiline = true;
            this.tb_observacao.Name = "tb_observacao";
            this.tb_observacao.Size = new System.Drawing.Size(644, 61);
            this.tb_observacao.TabIndex = 104;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(569, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 13);
            this.label18.TabIndex = 99;
            this.label18.Text = "Estoque Atual *";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(438, 156);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 13);
            this.label19.TabIndex = 98;
            this.label19.Text = "Preço de Promoção";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(306, 156);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 97;
            this.label15.Text = "Preço de Atacado";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(175, 158);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 96;
            this.label16.Text = "Preço de Venda";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 95;
            this.label17.Text = "Preço de Custo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(501, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 93;
            this.label12.Text = "Setor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(175, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 92;
            this.label10.Text = "Cód de Barras";
            // 
            // tb_codBarras
            // 
            this.tb_codBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codBarras.Location = new System.Drawing.Point(177, 125);
            this.tb_codBarras.Name = "tb_codBarras";
            this.tb_codBarras.Size = new System.Drawing.Size(322, 26);
            this.tb_codBarras.TabIndex = 91;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 90;
            this.label11.Text = "Fabricante / Marca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Fornecedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 84;
            this.label8.Text = "Unidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(533, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 82;
            this.label6.Text = "Cód interno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 80;
            this.label5.Text = "Descrição do Produto *";
            // 
            // tb_descricaoProduto
            // 
            this.tb_descricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_descricaoProduto.Location = new System.Drawing.Point(120, 27);
            this.tb_descricaoProduto.Name = "tb_descricaoProduto";
            this.tb_descricaoProduto.Size = new System.Drawing.Size(409, 26);
            this.tb_descricaoProduto.TabIndex = 79;
            this.tb_descricaoProduto.TextChanged += new System.EventHandler(this.tb_descricaoProduto_TextChanged);
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
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(14, 27);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 26);
            this.tb_id.TabIndex = 77;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Crimson;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_delete.Location = new System.Drawing.Point(259, 489);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(151, 35);
            this.btn_delete.TabIndex = 76;
            this.btn_delete.Text = "Deletar Produto";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Green;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_salvar.Location = new System.Drawing.Point(102, 489);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(151, 35);
            this.btn_salvar.TabIndex = 75;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.button5_Click);
            // 
            // F_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(697, 636);
            this.Controls.Add(this.tabEstoque);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Estoque";
            this.Load += new System.EventHandler(this.F_Estoque_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_produtos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabEstoque.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_precoPromocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_precoAtacado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_precoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_precoCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numb_estoque)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tb_busca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_produtos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_quantTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_listarTodos;
        private System.Windows.Forms.TabControl tabEstoque;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd_indisponivel;
        private System.Windows.Forms.RadioButton rd_disponivel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_observacao;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_codBarras;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_descricaoProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.ComboBox cbx_typeUnidade;
        private System.Windows.Forms.TextBox tb_codInterno;
        private System.Windows.Forms.ComboBox cbx_fabricante;
        private System.Windows.Forms.ComboBox cbx_setor;
        private System.Windows.Forms.ComboBox cbx_fornecedor;
        private System.Windows.Forms.NumericUpDown numb_estoque;
        private System.Windows.Forms.NumericUpDown num_precoPromocao;
        private System.Windows.Forms.NumericUpDown num_precoAtacado;
        private System.Windows.Forms.NumericUpDown num_precoVenda;
        private System.Windows.Forms.NumericUpDown num_precoCusto;
        private System.Windows.Forms.Button btn_limparCampo;
    }
}