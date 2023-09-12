namespace mysql_conection
{
    partial class F_Venda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_topo = new System.Windows.Forms.Panel();
            this.lb_caixaLive = new System.Windows.Forms.Label();
            this.dt_cart_item = new System.Windows.Forms.DataGridView();
            this.panel_SubCentral = new System.Windows.Forms.Panel();
            this.panel_tabela = new System.Windows.Forms.Panel();
            this.dt_tabelaDeProdutos = new System.Windows.Forms.DataGridView();
            this.tb_buscaProduto = new System.Windows.Forms.TextBox();
            this.tb_mostraNomeItem = new System.Windows.Forms.TextBox();
            this.painel_bottomPreco = new System.Windows.Forms.Panel();
            this.tb_codBarras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_subTotal = new System.Windows.Forms.TextBox();
            this.tb_precoUnitario = new System.Windows.Forms.TextBox();
            this.tb_quant = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_tititulo_preco = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_precoTotal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_totalDesconto = new System.Windows.Forms.TextBox();
            this.tb_valorTotal = new System.Windows.Forms.TextBox();
            this.lb_totalPreco = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lb_hoje = new System.Windows.Forms.Label();
            this.panel_LateralDireito = new System.Windows.Forms.Panel();
            this.Esc = new System.Windows.Forms.Label();
            this.f7 = new System.Windows.Forms.Label();
            this.f6 = new System.Windows.Forms.Label();
            this.f5 = new System.Windows.Forms.Label();
            this.f3 = new System.Windows.Forms.Label();
            this.f2 = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.Label();
            this.btn_Localizar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_cancelarItem = new System.Windows.Forms.Button();
            this.btn_finalizarVenda = new System.Windows.Forms.Button();
            this.btn_cancelarVenda = new System.Windows.Forms.Button();
            this.btn_contaCliente = new System.Windows.Forms.Button();
            this.btn_orcamento = new System.Windows.Forms.Button();
            this.btn_sairPdv = new System.Windows.Forms.Button();
            this.lb_dataHora = new System.Windows.Forms.Label();
            this.time_DataHora = new System.Windows.Forms.Timer(this.components);
            this.panel_topo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_cart_item)).BeginInit();
            this.panel_SubCentral.SuspendLayout();
            this.panel_tabela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_tabelaDeProdutos)).BeginInit();
            this.painel_bottomPreco.SuspendLayout();
            this.panel_precoTotal.SuspendLayout();
            this.panel_LateralDireito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_topo
            // 
            this.panel_topo.BackColor = System.Drawing.Color.Transparent;
            this.panel_topo.Controls.Add(this.lb_caixaLive);
            this.panel_topo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_topo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topo.Location = new System.Drawing.Point(0, 0);
            this.panel_topo.Name = "panel_topo";
            this.panel_topo.Size = new System.Drawing.Size(1239, 52);
            this.panel_topo.TabIndex = 1;
            // 
            // lb_caixaLive
            // 
            this.lb_caixaLive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_caixaLive.AutoSize = true;
            this.lb_caixaLive.BackColor = System.Drawing.Color.White;
            this.lb_caixaLive.Font = new System.Drawing.Font("Montserrat Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_caixaLive.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_caixaLive.Location = new System.Drawing.Point(549, 0);
            this.lb_caixaLive.Name = "lb_caixaLive";
            this.lb_caixaLive.Size = new System.Drawing.Size(262, 48);
            this.lb_caixaLive.TabIndex = 3;
            this.lb_caixaLive.Text = "CAIXA LIVRE";
            // 
            // dt_cart_item
            // 
            this.dt_cart_item.AllowUserToAddRows = false;
            this.dt_cart_item.AllowUserToDeleteRows = false;
            this.dt_cart_item.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_cart_item.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_cart_item.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_cart_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_cart_item.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt_cart_item.EnableHeadersVisualStyles = false;
            this.dt_cart_item.Location = new System.Drawing.Point(11, 32);
            this.dt_cart_item.MultiSelect = false;
            this.dt_cart_item.Name = "dt_cart_item";
            this.dt_cart_item.ReadOnly = true;
            this.dt_cart_item.RowHeadersVisible = false;
            this.dt_cart_item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_cart_item.Size = new System.Drawing.Size(743, 397);
            this.dt_cart_item.TabIndex = 0;
            this.dt_cart_item.SelectionChanged += new System.EventHandler(this.dt_cart_item_SelectionChanged);
            // 
            // panel_SubCentral
            // 
            this.panel_SubCentral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_SubCentral.BackColor = System.Drawing.Color.AliceBlue;
            this.panel_SubCentral.Controls.Add(this.panel_tabela);
            this.panel_SubCentral.Controls.Add(this.painel_bottomPreco);
            this.panel_SubCentral.Controls.Add(this.lb_hoje);
            this.panel_SubCentral.Controls.Add(this.panel_LateralDireito);
            this.panel_SubCentral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_SubCentral.Location = new System.Drawing.Point(98, 84);
            this.panel_SubCentral.Name = "panel_SubCentral";
            this.panel_SubCentral.Size = new System.Drawing.Size(1062, 612);
            this.panel_SubCentral.TabIndex = 3;
            // 
            // panel_tabela
            // 
            this.panel_tabela.BackColor = System.Drawing.SystemColors.Control;
            this.panel_tabela.Controls.Add(this.dt_tabelaDeProdutos);
            this.panel_tabela.Controls.Add(this.tb_buscaProduto);
            this.panel_tabela.Controls.Add(this.dt_cart_item);
            this.panel_tabela.Controls.Add(this.tb_mostraNomeItem);
            this.panel_tabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_tabela.Location = new System.Drawing.Point(0, 0);
            this.panel_tabela.Name = "panel_tabela";
            this.panel_tabela.Size = new System.Drawing.Size(764, 467);
            this.panel_tabela.TabIndex = 12;
            // 
            // dt_tabelaDeProdutos
            // 
            this.dt_tabelaDeProdutos.AllowUserToAddRows = false;
            this.dt_tabelaDeProdutos.AllowUserToDeleteRows = false;
            this.dt_tabelaDeProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_tabelaDeProdutos.BackgroundColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_tabelaDeProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dt_tabelaDeProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_tabelaDeProdutos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dt_tabelaDeProdutos.EnableHeadersVisualStyles = false;
            this.dt_tabelaDeProdutos.Location = new System.Drawing.Point(11, 32);
            this.dt_tabelaDeProdutos.MultiSelect = false;
            this.dt_tabelaDeProdutos.Name = "dt_tabelaDeProdutos";
            this.dt_tabelaDeProdutos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_tabelaDeProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dt_tabelaDeProdutos.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Navy;
            this.dt_tabelaDeProdutos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dt_tabelaDeProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_tabelaDeProdutos.Size = new System.Drawing.Size(743, 396);
            this.dt_tabelaDeProdutos.TabIndex = 5;
            this.dt_tabelaDeProdutos.Visible = false;
            this.dt_tabelaDeProdutos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dt_tabelaDeProdutos_MouseDoubleClick);
            // 
            // tb_buscaProduto
            // 
            this.tb_buscaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_buscaProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_buscaProduto.Location = new System.Drawing.Point(11, 5);
            this.tb_buscaProduto.Name = "tb_buscaProduto";
            this.tb_buscaProduto.Size = new System.Drawing.Size(743, 23);
            this.tb_buscaProduto.TabIndex = 4;
            this.tb_buscaProduto.TextChanged += new System.EventHandler(this.tb_buscaProduto_TextChanged);
            this.tb_buscaProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_buscaProduto_KeyDown);
            // 
            // tb_mostraNomeItem
            // 
            this.tb_mostraNomeItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_mostraNomeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mostraNomeItem.Location = new System.Drawing.Point(11, 435);
            this.tb_mostraNomeItem.Name = "tb_mostraNomeItem";
            this.tb_mostraNomeItem.ReadOnly = true;
            this.tb_mostraNomeItem.Size = new System.Drawing.Size(743, 26);
            this.tb_mostraNomeItem.TabIndex = 3;
            this.tb_mostraNomeItem.TabStop = false;
            // 
            // painel_bottomPreco
            // 
            this.painel_bottomPreco.BackColor = System.Drawing.Color.MediumBlue;
            this.painel_bottomPreco.Controls.Add(this.tb_codBarras);
            this.painel_bottomPreco.Controls.Add(this.label4);
            this.painel_bottomPreco.Controls.Add(this.tb_subTotal);
            this.painel_bottomPreco.Controls.Add(this.tb_precoUnitario);
            this.painel_bottomPreco.Controls.Add(this.tb_quant);
            this.painel_bottomPreco.Controls.Add(this.label9);
            this.painel_bottomPreco.Controls.Add(this.label8);
            this.painel_bottomPreco.Controls.Add(this.lb_tititulo_preco);
            this.painel_bottomPreco.Controls.Add(this.label6);
            this.painel_bottomPreco.Controls.Add(this.panel_precoTotal);
            this.painel_bottomPreco.Controls.Add(this.button3);
            this.painel_bottomPreco.Controls.Add(this.button4);
            this.painel_bottomPreco.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.painel_bottomPreco.Location = new System.Drawing.Point(0, 467);
            this.painel_bottomPreco.Name = "painel_bottomPreco";
            this.painel_bottomPreco.Size = new System.Drawing.Size(764, 145);
            this.painel_bottomPreco.TabIndex = 3;
            // 
            // tb_codBarras
            // 
            this.tb_codBarras.BackColor = System.Drawing.Color.Navy;
            this.tb_codBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_codBarras.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_codBarras.Location = new System.Drawing.Point(210, 29);
            this.tb_codBarras.Multiline = true;
            this.tb_codBarras.Name = "tb_codBarras";
            this.tb_codBarras.ReadOnly = true;
            this.tb_codBarras.Size = new System.Drawing.Size(172, 37);
            this.tb_codBarras.TabIndex = 14;
            this.tb_codBarras.TabStop = false;
            this.tb_codBarras.Text = "00000000";
            this.tb_codBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(207, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Código de Barras";
            // 
            // tb_subTotal
            // 
            this.tb_subTotal.BackColor = System.Drawing.Color.Navy;
            this.tb_subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_subTotal.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_subTotal.Location = new System.Drawing.Point(210, 97);
            this.tb_subTotal.Multiline = true;
            this.tb_subTotal.Name = "tb_subTotal";
            this.tb_subTotal.ReadOnly = true;
            this.tb_subTotal.Size = new System.Drawing.Size(172, 37);
            this.tb_subTotal.TabIndex = 12;
            this.tb_subTotal.TabStop = false;
            this.tb_subTotal.Text = "0,00";
            this.tb_subTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_precoUnitario
            // 
            this.tb_precoUnitario.BackColor = System.Drawing.Color.Navy;
            this.tb_precoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precoUnitario.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_precoUnitario.Location = new System.Drawing.Point(11, 98);
            this.tb_precoUnitario.Multiline = true;
            this.tb_precoUnitario.Name = "tb_precoUnitario";
            this.tb_precoUnitario.ReadOnly = true;
            this.tb_precoUnitario.Size = new System.Drawing.Size(172, 37);
            this.tb_precoUnitario.TabIndex = 11;
            this.tb_precoUnitario.TabStop = false;
            this.tb_precoUnitario.Text = " 0,00";
            this.tb_precoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_quant
            // 
            this.tb_quant.BackColor = System.Drawing.Color.Navy;
            this.tb_quant.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quant.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_quant.HideSelection = false;
            this.tb_quant.Location = new System.Drawing.Point(11, 29);
            this.tb_quant.Multiline = true;
            this.tb_quant.Name = "tb_quant";
            this.tb_quant.ReadOnly = true;
            this.tb_quant.Size = new System.Drawing.Size(172, 37);
            this.tb_quant.TabIndex = 10;
            this.tb_quant.TabStop = false;
            this.tb_quant.Text = "0";
            this.tb_quant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(206, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Sub Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(8, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Quantidade";
            // 
            // lb_tititulo_preco
            // 
            this.lb_tititulo_preco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_tititulo_preco.AutoSize = true;
            this.lb_tititulo_preco.BackColor = System.Drawing.Color.Transparent;
            this.lb_tititulo_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tititulo_preco.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_tititulo_preco.Location = new System.Drawing.Point(608, 13);
            this.lb_tititulo_preco.Name = "lb_tititulo_preco";
            this.lb_tititulo_preco.Size = new System.Drawing.Size(85, 20);
            this.lb_tititulo_preco.TabIndex = 8;
            this.lb_tititulo_preco.Text = "Valor Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(8, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Valor Unitário";
            // 
            // panel_precoTotal
            // 
            this.panel_precoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_precoTotal.BackColor = System.Drawing.Color.Navy;
            this.panel_precoTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_precoTotal.Controls.Add(this.label1);
            this.panel_precoTotal.Controls.Add(this.tb_totalDesconto);
            this.panel_precoTotal.Controls.Add(this.tb_valorTotal);
            this.panel_precoTotal.Controls.Add(this.lb_totalPreco);
            this.panel_precoTotal.Location = new System.Drawing.Point(554, 34);
            this.panel_precoTotal.Name = "panel_precoTotal";
            this.panel_precoTotal.Size = new System.Drawing.Size(200, 95);
            this.panel_precoTotal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(-1, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Total de Desconto";
            // 
            // tb_totalDesconto
            // 
            this.tb_totalDesconto.BackColor = System.Drawing.Color.Navy;
            this.tb_totalDesconto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_totalDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalDesconto.ForeColor = System.Drawing.Color.White;
            this.tb_totalDesconto.Location = new System.Drawing.Point(123, 75);
            this.tb_totalDesconto.Name = "tb_totalDesconto";
            this.tb_totalDesconto.ReadOnly = true;
            this.tb_totalDesconto.Size = new System.Drawing.Size(70, 16);
            this.tb_totalDesconto.TabIndex = 16;
            this.tb_totalDesconto.TabStop = false;
            this.tb_totalDesconto.Text = "0,00";
            this.tb_totalDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_valorTotal
            // 
            this.tb_valorTotal.BackColor = System.Drawing.Color.Navy;
            this.tb_valorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_valorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valorTotal.ForeColor = System.Drawing.Color.White;
            this.tb_valorTotal.Location = new System.Drawing.Point(37, 30);
            this.tb_valorTotal.Name = "tb_valorTotal";
            this.tb_valorTotal.ReadOnly = true;
            this.tb_valorTotal.Size = new System.Drawing.Size(134, 41);
            this.tb_valorTotal.TabIndex = 15;
            this.tb_valorTotal.TabStop = false;
            this.tb_valorTotal.Text = "0,00";
            this.tb_valorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_totalPreco
            // 
            this.lb_totalPreco.AutoSize = true;
            this.lb_totalPreco.BackColor = System.Drawing.Color.Transparent;
            this.lb_totalPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalPreco.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_totalPreco.Location = new System.Drawing.Point(3, 1);
            this.lb_totalPreco.Name = "lb_totalPreco";
            this.lb_totalPreco.Size = new System.Drawing.Size(59, 31);
            this.lb_totalPreco.TabIndex = 0;
            this.lb_totalPreco.Text = "R$ ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(78, 467);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 51);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(78, 536);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 51);
            this.button4.TabIndex = 0;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lb_hoje
            // 
            this.lb_hoje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_hoje.AutoSize = true;
            this.lb_hoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hoje.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_hoje.Location = new System.Drawing.Point(16, 472);
            this.lb_hoje.Name = "lb_hoje";
            this.lb_hoje.Size = new System.Drawing.Size(105, 20);
            this.lb_hoje.TabIndex = 8;
            this.lb_hoje.Text = "Valor Unitario";
            // 
            // panel_LateralDireito
            // 
            this.panel_LateralDireito.BackColor = System.Drawing.Color.MediumBlue;
            this.panel_LateralDireito.Controls.Add(this.Esc);
            this.panel_LateralDireito.Controls.Add(this.f7);
            this.panel_LateralDireito.Controls.Add(this.f6);
            this.panel_LateralDireito.Controls.Add(this.f5);
            this.panel_LateralDireito.Controls.Add(this.f3);
            this.panel_LateralDireito.Controls.Add(this.f2);
            this.panel_LateralDireito.Controls.Add(this.f1);
            this.panel_LateralDireito.Controls.Add(this.btn_Localizar);
            this.panel_LateralDireito.Controls.Add(this.pictureBox2);
            this.panel_LateralDireito.Controls.Add(this.btn_cancelarItem);
            this.panel_LateralDireito.Controls.Add(this.btn_finalizarVenda);
            this.panel_LateralDireito.Controls.Add(this.btn_cancelarVenda);
            this.panel_LateralDireito.Controls.Add(this.btn_contaCliente);
            this.panel_LateralDireito.Controls.Add(this.btn_orcamento);
            this.panel_LateralDireito.Controls.Add(this.btn_sairPdv);
            this.panel_LateralDireito.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_LateralDireito.ForeColor = System.Drawing.SystemColors.Control;
            this.panel_LateralDireito.Location = new System.Drawing.Point(764, 0);
            this.panel_LateralDireito.Name = "panel_LateralDireito";
            this.panel_LateralDireito.Size = new System.Drawing.Size(298, 612);
            this.panel_LateralDireito.TabIndex = 2;
            // 
            // Esc
            // 
            this.Esc.AutoSize = true;
            this.Esc.BackColor = System.Drawing.Color.Transparent;
            this.Esc.Font = new System.Drawing.Font("Open Sans ExtraBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Esc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Esc.Location = new System.Drawing.Point(53, 557);
            this.Esc.Name = "Esc";
            this.Esc.Size = new System.Drawing.Size(27, 17);
            this.Esc.TabIndex = 14;
            this.Esc.Text = "Esc";
            // 
            // f7
            // 
            this.f7.AutoSize = true;
            this.f7.BackColor = System.Drawing.Color.Transparent;
            this.f7.Font = new System.Drawing.Font("Open Sans ExtraBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.f7.Location = new System.Drawing.Point(53, 508);
            this.f7.Name = "f7";
            this.f7.Size = new System.Drawing.Size(21, 17);
            this.f7.TabIndex = 13;
            this.f7.Text = "F7";
            // 
            // f6
            // 
            this.f6.AutoSize = true;
            this.f6.BackColor = System.Drawing.Color.Transparent;
            this.f6.Font = new System.Drawing.Font("Open Sans ExtraBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.f6.Location = new System.Drawing.Point(53, 459);
            this.f6.Name = "f6";
            this.f6.Size = new System.Drawing.Size(21, 17);
            this.f6.TabIndex = 12;
            this.f6.Text = "F6";
            // 
            // f5
            // 
            this.f5.AutoSize = true;
            this.f5.BackColor = System.Drawing.Color.Transparent;
            this.f5.Font = new System.Drawing.Font("Open Sans ExtraBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.f5.Location = new System.Drawing.Point(53, 411);
            this.f5.Name = "f5";
            this.f5.Size = new System.Drawing.Size(21, 17);
            this.f5.TabIndex = 11;
            this.f5.Text = "F5";
            // 
            // f3
            // 
            this.f3.AutoSize = true;
            this.f3.BackColor = System.Drawing.Color.Transparent;
            this.f3.Font = new System.Drawing.Font("Open Sans ExtraBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.f3.Location = new System.Drawing.Point(53, 362);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(21, 17);
            this.f3.TabIndex = 9;
            this.f3.Text = "F3";
            // 
            // f2
            // 
            this.f2.AutoSize = true;
            this.f2.BackColor = System.Drawing.Color.Transparent;
            this.f2.Font = new System.Drawing.Font("Open Sans ExtraBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.f2.Location = new System.Drawing.Point(53, 312);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(21, 17);
            this.f2.TabIndex = 8;
            this.f2.Text = "F2";
            // 
            // f1
            // 
            this.f1.AutoSize = true;
            this.f1.BackColor = System.Drawing.Color.Transparent;
            this.f1.Font = new System.Drawing.Font("Open Sans ExtraBold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.f1.Location = new System.Drawing.Point(53, 262);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(21, 17);
            this.f1.TabIndex = 7;
            this.f1.Text = "F1";
            // 
            // btn_Localizar
            // 
            this.btn_Localizar.BackColor = System.Drawing.Color.Navy;
            this.btn_Localizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Localizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Localizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Localizar.Location = new System.Drawing.Point(45, 347);
            this.btn_Localizar.Name = "btn_Localizar";
            this.btn_Localizar.Size = new System.Drawing.Size(213, 40);
            this.btn_Localizar.TabIndex = 6;
            this.btn_Localizar.Text = "Localizar Produto";
            this.btn_Localizar.UseVisualStyleBackColor = false;
            this.btn_Localizar.Click += new System.EventHandler(this.btn_Localizar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::mysql_conection.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(28, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(247, 177);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btn_cancelarItem
            // 
            this.btn_cancelarItem.BackColor = System.Drawing.Color.Navy;
            this.btn_cancelarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarItem.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancelarItem.Location = new System.Drawing.Point(45, 398);
            this.btn_cancelarItem.Name = "btn_cancelarItem";
            this.btn_cancelarItem.Size = new System.Drawing.Size(213, 40);
            this.btn_cancelarItem.TabIndex = 3;
            this.btn_cancelarItem.Text = "Cancelar Item";
            this.btn_cancelarItem.UseVisualStyleBackColor = false;
            this.btn_cancelarItem.Click += new System.EventHandler(this.btn_cancelarItem_Click);
            // 
            // btn_finalizarVenda
            // 
            this.btn_finalizarVenda.BackColor = System.Drawing.Color.Green;
            this.btn_finalizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_finalizarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizarVenda.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_finalizarVenda.Location = new System.Drawing.Point(45, 248);
            this.btn_finalizarVenda.Name = "btn_finalizarVenda";
            this.btn_finalizarVenda.Size = new System.Drawing.Size(213, 40);
            this.btn_finalizarVenda.TabIndex = 3;
            this.btn_finalizarVenda.Text = "Finalizar Venda";
            this.btn_finalizarVenda.UseVisualStyleBackColor = false;
            this.btn_finalizarVenda.Click += new System.EventHandler(this.btn_finalizarVenda_Click);
            // 
            // btn_cancelarVenda
            // 
            this.btn_cancelarVenda.BackColor = System.Drawing.Color.Crimson;
            this.btn_cancelarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarVenda.ForeColor = System.Drawing.Color.White;
            this.btn_cancelarVenda.Location = new System.Drawing.Point(45, 299);
            this.btn_cancelarVenda.Name = "btn_cancelarVenda";
            this.btn_cancelarVenda.Size = new System.Drawing.Size(213, 40);
            this.btn_cancelarVenda.TabIndex = 1;
            this.btn_cancelarVenda.Text = "Cancelar Venda";
            this.btn_cancelarVenda.UseVisualStyleBackColor = false;
            this.btn_cancelarVenda.Click += new System.EventHandler(this.btn_cancelarVenda_Click);
            // 
            // btn_contaCliente
            // 
            this.btn_contaCliente.BackColor = System.Drawing.Color.Navy;
            this.btn_contaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_contaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_contaCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_contaCliente.Location = new System.Drawing.Point(45, 446);
            this.btn_contaCliente.Name = "btn_contaCliente";
            this.btn_contaCliente.Size = new System.Drawing.Size(213, 40);
            this.btn_contaCliente.TabIndex = 2;
            this.btn_contaCliente.Text = "Conta de Cliente";
            this.btn_contaCliente.UseVisualStyleBackColor = false;
            this.btn_contaCliente.Click += new System.EventHandler(this.btn_contaCliente_Click);
            // 
            // btn_orcamento
            // 
            this.btn_orcamento.BackColor = System.Drawing.Color.Navy;
            this.btn_orcamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_orcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orcamento.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_orcamento.Location = new System.Drawing.Point(45, 495);
            this.btn_orcamento.Name = "btn_orcamento";
            this.btn_orcamento.Size = new System.Drawing.Size(213, 40);
            this.btn_orcamento.TabIndex = 1;
            this.btn_orcamento.Text = "Orçamento";
            this.btn_orcamento.UseVisualStyleBackColor = false;
            this.btn_orcamento.Click += new System.EventHandler(this.btn_orcamento_Click);
            // 
            // btn_sairPdv
            // 
            this.btn_sairPdv.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_sairPdv.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btn_sairPdv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sairPdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sairPdv.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_sairPdv.Location = new System.Drawing.Point(45, 544);
            this.btn_sairPdv.Name = "btn_sairPdv";
            this.btn_sairPdv.Size = new System.Drawing.Size(213, 40);
            this.btn_sairPdv.TabIndex = 0;
            this.btn_sairPdv.Text = "Sair do PDV";
            this.btn_sairPdv.UseVisualStyleBackColor = false;
            this.btn_sairPdv.Click += new System.EventHandler(this.button1_Click);
            this.btn_sairPdv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_sairPdv_KeyDown);
            // 
            // lb_dataHora
            // 
            this.lb_dataHora.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lb_dataHora.AutoSize = true;
            this.lb_dataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_dataHora.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_dataHora.Location = new System.Drawing.Point(485, 738);
            this.lb_dataHora.Name = "lb_dataHora";
            this.lb_dataHora.Size = new System.Drawing.Size(263, 31);
            this.lb_dataHora.TabIndex = 16;
            this.lb_dataHora.Text = "10/06/2023 10:23:24";
            // 
            // time_DataHora
            // 
            this.time_DataHora.Interval = 1000;
            this.time_DataHora.Tick += new System.EventHandler(this.time_DataHora_Tick);
            // 
            // F_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1239, 801);
            this.Controls.Add(this.lb_dataHora);
            this.Controls.Add(this.panel_SubCentral);
            this.Controls.Add(this.panel_topo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Venda";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.F_Venda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.F_Venda_KeyDown);
            this.panel_topo.ResumeLayout(false);
            this.panel_topo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_cart_item)).EndInit();
            this.panel_SubCentral.ResumeLayout(false);
            this.panel_SubCentral.PerformLayout();
            this.panel_tabela.ResumeLayout(false);
            this.panel_tabela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_tabelaDeProdutos)).EndInit();
            this.painel_bottomPreco.ResumeLayout(false);
            this.painel_bottomPreco.PerformLayout();
            this.panel_precoTotal.ResumeLayout(false);
            this.panel_precoTotal.PerformLayout();
            this.panel_LateralDireito.ResumeLayout(false);
            this.panel_LateralDireito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_topo;
        private System.Windows.Forms.Panel panel_SubCentral;
        private System.Windows.Forms.Panel panel_LateralDireito;
        private System.Windows.Forms.TextBox tb_mostraNomeItem;
        private System.Windows.Forms.Label lb_hoje;
        private System.Windows.Forms.Panel painel_bottomPreco;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel_tabela;
        private System.Windows.Forms.Button btn_cancelarVenda;
        private System.Windows.Forms.Button btn_orcamento;
        private System.Windows.Forms.Button btn_sairPdv;
        private System.Windows.Forms.Button btn_finalizarVenda;
        private System.Windows.Forms.Button btn_cancelarItem;
        private System.Windows.Forms.Button btn_contaCliente;
        private System.Windows.Forms.Panel panel_precoTotal;
        private System.Windows.Forms.Label lb_totalPreco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_tititulo_preco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_subTotal;
        private System.Windows.Forms.TextBox tb_precoUnitario;
        private System.Windows.Forms.TextBox tb_codBarras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Localizar;
        private System.Windows.Forms.Label f1;
        private System.Windows.Forms.Label Esc;
        private System.Windows.Forms.Label f7;
        private System.Windows.Forms.Label f6;
        private System.Windows.Forms.Label f5;
        private System.Windows.Forms.Label f3;
        private System.Windows.Forms.Label f2;
        public System.Windows.Forms.DataGridView dt_tabelaDeProdutos;
        public System.Windows.Forms.DataGridView dt_cart_item;
        public System.Windows.Forms.TextBox tb_buscaProduto;
        public System.Windows.Forms.Label lb_caixaLive;
        public System.Windows.Forms.TextBox tb_quant;
        public System.Windows.Forms.TextBox tb_valorTotal;
        private System.Windows.Forms.Timer time_DataHora;
        public System.Windows.Forms.Label lb_dataHora;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_totalDesconto;
    }
}