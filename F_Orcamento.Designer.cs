namespace mysql_conection
{
    partial class F_Orcamento
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_total_item = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_orcamento = new System.Windows.Forms.TabControl();
            this.tab_ListadeOrcamento = new System.Windows.Forms.TabPage();
            this.dtg_orcamento = new System.Windows.Forms.DataGridView();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_busca = new System.Windows.Forms.TextBox();
            this.btn_deletar_item = new System.Windows.Forms.Button();
            this.tab_NovoOrcamento = new System.Windows.Forms.TabPage();
            this.btn_deletarTudo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_totalDesconto = new System.Windows.Forms.TextBox();
            this.dtg_produtos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.tb_valorTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_clientes = new System.Windows.Forms.ComboBox();
            this.tb_buscaProdutos = new System.Windows.Forms.TextBox();
            this.dtg_carinho = new System.Windows.Forms.DataGridView();
            this.btn_deletarSelect = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.tab_orcamento.SuspendLayout();
            this.tab_ListadeOrcamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_orcamento)).BeginInit();
            this.tab_NovoOrcamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_carinho)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.lb_total_item);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 621);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 26);
            this.panel2.TabIndex = 12;
            // 
            // lb_total_item
            // 
            this.lb_total_item.AutoSize = true;
            this.lb_total_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_item.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_total_item.Location = new System.Drawing.Point(126, 6);
            this.lb_total_item.Name = "lb_total_item";
            this.lb_total_item.Size = new System.Drawing.Size(15, 15);
            this.lb_total_item.TabIndex = 3;
            this.lb_total_item.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Orçamento:";
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
            // tab_orcamento
            // 
            this.tab_orcamento.Controls.Add(this.tab_ListadeOrcamento);
            this.tab_orcamento.Controls.Add(this.tab_NovoOrcamento);
            this.tab_orcamento.Location = new System.Drawing.Point(9, 48);
            this.tab_orcamento.Name = "tab_orcamento";
            this.tab_orcamento.SelectedIndex = 0;
            this.tab_orcamento.Size = new System.Drawing.Size(680, 571);
            this.tab_orcamento.TabIndex = 13;
            this.tab_orcamento.TabStop = false;
            this.tab_orcamento.SelectedIndexChanged += new System.EventHandler(this.tab_orcamento_SelectedIndexChanged);
            // 
            // tab_ListadeOrcamento
            // 
            this.tab_ListadeOrcamento.Controls.Add(this.dtg_orcamento);
            this.tab_ListadeOrcamento.Controls.Add(this.btn_adicionar);
            this.tab_ListadeOrcamento.Controls.Add(this.tb_busca);
            this.tab_ListadeOrcamento.Controls.Add(this.btn_deletar_item);
            this.tab_ListadeOrcamento.Location = new System.Drawing.Point(4, 22);
            this.tab_ListadeOrcamento.Name = "tab_ListadeOrcamento";
            this.tab_ListadeOrcamento.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ListadeOrcamento.Size = new System.Drawing.Size(672, 545);
            this.tab_ListadeOrcamento.TabIndex = 0;
            this.tab_ListadeOrcamento.Text = "Lista de Orçamento";
            this.tab_ListadeOrcamento.UseVisualStyleBackColor = true;
            // 
            // dtg_orcamento
            // 
            this.dtg_orcamento.AllowUserToAddRows = false;
            this.dtg_orcamento.AllowUserToDeleteRows = false;
            this.dtg_orcamento.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_orcamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_orcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_orcamento.EnableHeadersVisualStyles = false;
            this.dtg_orcamento.Location = new System.Drawing.Point(5, 42);
            this.dtg_orcamento.MultiSelect = false;
            this.dtg_orcamento.Name = "dtg_orcamento";
            this.dtg_orcamento.ReadOnly = true;
            this.dtg_orcamento.RowHeadersVisible = false;
            this.dtg_orcamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_orcamento.Size = new System.Drawing.Size(661, 441);
            this.dtg_orcamento.TabIndex = 1;
            this.dtg_orcamento.DoubleClick += new System.EventHandler(this.dtg_orcamento_DoubleClick);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.Green;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_adicionar.Location = new System.Drawing.Point(178, 489);
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
            this.tb_busca.TextChanged += new System.EventHandler(this.tb_busca_TextChanged);
            this.tb_busca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_busca_KeyDown);
            // 
            // btn_deletar_item
            // 
            this.btn_deletar_item.BackColor = System.Drawing.Color.Crimson;
            this.btn_deletar_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar_item.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deletar_item.Location = new System.Drawing.Point(335, 489);
            this.btn_deletar_item.Name = "btn_deletar_item";
            this.btn_deletar_item.Size = new System.Drawing.Size(151, 35);
            this.btn_deletar_item.TabIndex = 4;
            this.btn_deletar_item.Text = "Deletar ";
            this.btn_deletar_item.UseVisualStyleBackColor = false;
            // 
            // tab_NovoOrcamento
            // 
            this.tab_NovoOrcamento.Controls.Add(this.btn_deletarTudo);
            this.tab_NovoOrcamento.Controls.Add(this.label10);
            this.tab_NovoOrcamento.Controls.Add(this.tb_totalDesconto);
            this.tab_NovoOrcamento.Controls.Add(this.dtg_produtos);
            this.tab_NovoOrcamento.Controls.Add(this.label7);
            this.tab_NovoOrcamento.Controls.Add(this.label6);
            this.tab_NovoOrcamento.Controls.Add(this.tb_quantidade);
            this.tab_NovoOrcamento.Controls.Add(this.tb_valorTotal);
            this.tab_NovoOrcamento.Controls.Add(this.label5);
            this.tab_NovoOrcamento.Controls.Add(this.label4);
            this.tab_NovoOrcamento.Controls.Add(this.cbx_clientes);
            this.tab_NovoOrcamento.Controls.Add(this.tb_buscaProdutos);
            this.tab_NovoOrcamento.Controls.Add(this.dtg_carinho);
            this.tab_NovoOrcamento.Controls.Add(this.btn_deletarSelect);
            this.tab_NovoOrcamento.Controls.Add(this.btn_salvar);
            this.tab_NovoOrcamento.Location = new System.Drawing.Point(4, 22);
            this.tab_NovoOrcamento.Name = "tab_NovoOrcamento";
            this.tab_NovoOrcamento.Padding = new System.Windows.Forms.Padding(3);
            this.tab_NovoOrcamento.Size = new System.Drawing.Size(672, 545);
            this.tab_NovoOrcamento.TabIndex = 1;
            this.tab_NovoOrcamento.Text = "Novo Orçamento";
            this.tab_NovoOrcamento.UseVisualStyleBackColor = true;
            // 
            // btn_deletarTudo
            // 
            this.btn_deletarTudo.BackColor = System.Drawing.Color.Red;
            this.btn_deletarTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletarTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletarTudo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deletarTudo.Location = new System.Drawing.Point(425, 500);
            this.btn_deletarTudo.Name = "btn_deletarTudo";
            this.btn_deletarTudo.Size = new System.Drawing.Size(149, 35);
            this.btn_deletarTudo.TabIndex = 94;
            this.btn_deletarTudo.Text = "Deletar Tudo";
            this.btn_deletarTudo.UseVisualStyleBackColor = false;
            this.btn_deletarTudo.Click += new System.EventHandler(this.btn_deletarTudo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(428, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 88;
            this.label10.Text = "Desconto";
            // 
            // tb_totalDesconto
            // 
            this.tb_totalDesconto.BackColor = System.Drawing.Color.Navy;
            this.tb_totalDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalDesconto.ForeColor = System.Drawing.Color.White;
            this.tb_totalDesconto.Location = new System.Drawing.Point(408, 463);
            this.tb_totalDesconto.Name = "tb_totalDesconto";
            this.tb_totalDesconto.Size = new System.Drawing.Size(113, 27);
            this.tb_totalDesconto.TabIndex = 87;
            this.tb_totalDesconto.Text = "0";
            this.tb_totalDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtg_produtos
            // 
            this.dtg_produtos.AllowUserToAddRows = false;
            this.dtg_produtos.AllowUserToDeleteRows = false;
            this.dtg_produtos.BackgroundColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_produtos.EnableHeadersVisualStyles = false;
            this.dtg_produtos.Location = new System.Drawing.Point(6, 66);
            this.dtg_produtos.MultiSelect = false;
            this.dtg_produtos.Name = "dtg_produtos";
            this.dtg_produtos.ReadOnly = true;
            this.dtg_produtos.RowHeadersVisible = false;
            this.dtg_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_produtos.Size = new System.Drawing.Size(661, 348);
            this.dtg_produtos.TabIndex = 86;
            this.dtg_produtos.DoubleClick += new System.EventHandler(this.dtg_produtos_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(203, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 85;
            this.label7.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(302, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 15);
            this.label6.TabIndex = 84;
            this.label6.Text = "Quantidade";
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.BackColor = System.Drawing.Color.RoyalBlue;
            this.tb_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quantidade.ForeColor = System.Drawing.Color.White;
            this.tb_quantidade.Location = new System.Drawing.Point(289, 463);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(113, 27);
            this.tb_quantidade.TabIndex = 83;
            this.tb_quantidade.Text = "0";
            this.tb_quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_valorTotal
            // 
            this.tb_valorTotal.BackColor = System.Drawing.Color.RoyalBlue;
            this.tb_valorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valorTotal.ForeColor = System.Drawing.Color.White;
            this.tb_valorTotal.Location = new System.Drawing.Point(170, 463);
            this.tb_valorTotal.Name = "tb_valorTotal";
            this.tb_valorTotal.Size = new System.Drawing.Size(113, 27);
            this.tb_valorTotal.TabIndex = 82;
            this.tb_valorTotal.Text = "0,00";
            this.tb_valorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Pesquisar Produto";
            // 
            // cbx_clientes
            // 
            this.cbx_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_clientes.FormattingEnabled = true;
            this.cbx_clientes.Location = new System.Drawing.Point(364, 33);
            this.cbx_clientes.Name = "cbx_clientes";
            this.cbx_clientes.Size = new System.Drawing.Size(302, 28);
            this.cbx_clientes.TabIndex = 79;
            this.cbx_clientes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tb_buscaProdutos
            // 
            this.tb_buscaProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_buscaProdutos.Location = new System.Drawing.Point(6, 33);
            this.tb_buscaProdutos.Name = "tb_buscaProdutos";
            this.tb_buscaProdutos.Size = new System.Drawing.Size(322, 27);
            this.tb_buscaProdutos.TabIndex = 78;
            this.tb_buscaProdutos.TextChanged += new System.EventHandler(this.tb_buscaProdutos_TextChanged);
            // 
            // dtg_carinho
            // 
            this.dtg_carinho.AllowUserToAddRows = false;
            this.dtg_carinho.AllowUserToDeleteRows = false;
            this.dtg_carinho.BackgroundColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_carinho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_carinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_carinho.EnableHeadersVisualStyles = false;
            this.dtg_carinho.Location = new System.Drawing.Point(6, 67);
            this.dtg_carinho.MultiSelect = false;
            this.dtg_carinho.Name = "dtg_carinho";
            this.dtg_carinho.RowHeadersVisible = false;
            this.dtg_carinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_carinho.Size = new System.Drawing.Size(661, 371);
            this.dtg_carinho.TabIndex = 77;
            // 
            // btn_deletarSelect
            // 
            this.btn_deletarSelect.BackColor = System.Drawing.Color.Crimson;
            this.btn_deletarSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletarSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletarSelect.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deletarSelect.Location = new System.Drawing.Point(262, 500);
            this.btn_deletarSelect.Name = "btn_deletarSelect";
            this.btn_deletarSelect.Size = new System.Drawing.Size(149, 35);
            this.btn_deletarSelect.TabIndex = 76;
            this.btn_deletarSelect.Text = "Deletar Produto";
            this.btn_deletarSelect.UseVisualStyleBackColor = false;
            this.btn_deletarSelect.Click += new System.EventHandler(this.btn_deletarSelect_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Green;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_salvar.Location = new System.Drawing.Point(101, 500);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(149, 35);
            this.btn_salvar.TabIndex = 75;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
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
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orçamento";
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
            // F_Orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 647);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tab_orcamento);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Orcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Orcamento";
            this.Load += new System.EventHandler(this.F_Orcamento_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tab_orcamento.ResumeLayout(false);
            this.tab_ListadeOrcamento.ResumeLayout(false);
            this.tab_ListadeOrcamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_orcamento)).EndInit();
            this.tab_NovoOrcamento.ResumeLayout(false);
            this.tab_NovoOrcamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_carinho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tab_ListadeOrcamento;
        private System.Windows.Forms.DataGridView dtg_orcamento;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tb_busca;
        private System.Windows.Forms.Button btn_deletar_item;
        private System.Windows.Forms.TabPage tab_NovoOrcamento;
        private System.Windows.Forms.Button btn_deletarSelect;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_clientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.TextBox tb_valorTotal;
        public System.Windows.Forms.TabControl tab_orcamento;
        private System.Windows.Forms.Label lb_total_item;
        public System.Windows.Forms.DataGridView dtg_carinho;
        public System.Windows.Forms.DataGridView dtg_produtos;
        public System.Windows.Forms.TextBox tb_buscaProdutos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_totalDesconto;
        private System.Windows.Forms.Button btn_deletarTudo;
    }
}