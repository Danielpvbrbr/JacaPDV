namespace mysql_conection
{
    partial class F_ContasAreceber
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
            this.dtg_contasAreceber = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_contasAreceber = new System.Windows.Forms.TabControl();
            this.tab_visual = new System.Windows.Forms.TabPage();
            this.title = new System.Windows.Forms.Label();
            this.tb_busca = new System.Windows.Forms.TextBox();
            this.tab_novo = new System.Windows.Forms.TabPage();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_vencimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.cbx_clientes = new System.Windows.Forms.ComboBox();
            this.cbx_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_contasAreceber)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tab_contasAreceber.SuspendLayout();
            this.tab_visual.SuspendLayout();
            this.tab_novo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_contasAreceber
            // 
            this.dtg_contasAreceber.AllowUserToAddRows = false;
            this.dtg_contasAreceber.AllowUserToDeleteRows = false;
            this.dtg_contasAreceber.BackgroundColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_contasAreceber.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_contasAreceber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_contasAreceber.EnableHeadersVisualStyles = false;
            this.dtg_contasAreceber.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtg_contasAreceber.Location = new System.Drawing.Point(4, 57);
            this.dtg_contasAreceber.Name = "dtg_contasAreceber";
            this.dtg_contasAreceber.ReadOnly = true;
            this.dtg_contasAreceber.RowHeadersVisible = false;
            this.dtg_contasAreceber.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_contasAreceber.Size = new System.Drawing.Size(621, 414);
            this.dtg_contasAreceber.TabIndex = 0;
            this.dtg_contasAreceber.DoubleClick += new System.EventHandler(this.dtg_contasAreceber_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(659, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impressãoToolStripMenuItem,
            this.salvarPDFToolStripMenuItem});
            this.arquivoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // impressãoToolStripMenuItem
            // 
            this.impressãoToolStripMenuItem.Name = "impressãoToolStripMenuItem";
            this.impressãoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.impressãoToolStripMenuItem.Text = "Impressão";
            // 
            // salvarPDFToolStripMenuItem
            // 
            this.salvarPDFToolStripMenuItem.Name = "salvarPDFToolStripMenuItem";
            this.salvarPDFToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.salvarPDFToolStripMenuItem.Text = "Salvar PDF";
            // 
            // tab_contasAreceber
            // 
            this.tab_contasAreceber.Controls.Add(this.tab_visual);
            this.tab_contasAreceber.Controls.Add(this.tab_novo);
            this.tab_contasAreceber.Location = new System.Drawing.Point(10, 31);
            this.tab_contasAreceber.Name = "tab_contasAreceber";
            this.tab_contasAreceber.SelectedIndex = 0;
            this.tab_contasAreceber.Size = new System.Drawing.Size(639, 500);
            this.tab_contasAreceber.TabIndex = 2;
            this.tab_contasAreceber.SelectedIndexChanged += new System.EventHandler(this.tab_contasAreceber_SelectedIndexChanged);
            // 
            // tab_visual
            // 
            this.tab_visual.Controls.Add(this.title);
            this.tab_visual.Controls.Add(this.tb_busca);
            this.tab_visual.Controls.Add(this.dtg_contasAreceber);
            this.tab_visual.Location = new System.Drawing.Point(4, 22);
            this.tab_visual.Name = "tab_visual";
            this.tab_visual.Padding = new System.Windows.Forms.Padding(3);
            this.tab_visual.Size = new System.Drawing.Size(631, 474);
            this.tab_visual.TabIndex = 0;
            this.tab_visual.Text = "Lista de Contas a Receber";
            this.tab_visual.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(4, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(75, 13);
            this.title.TabIndex = 2;
            this.title.Text = "Buscar Cliente";
            // 
            // tb_busca
            // 
            this.tb_busca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_busca.Location = new System.Drawing.Point(4, 28);
            this.tb_busca.Name = "tb_busca";
            this.tb_busca.Size = new System.Drawing.Size(621, 23);
            this.tb_busca.TabIndex = 1;
            this.tb_busca.TextChanged += new System.EventHandler(this.tb_busca_TextChanged);
            // 
            // tab_novo
            // 
            this.tab_novo.Controls.Add(this.label5);
            this.tab_novo.Controls.Add(this.cbx_status);
            this.tab_novo.Controls.Add(this.tb_valor);
            this.tab_novo.Controls.Add(this.btn_deletar);
            this.tab_novo.Controls.Add(this.btn_salvar);
            this.tab_novo.Controls.Add(this.label4);
            this.tab_novo.Controls.Add(this.dtp_vencimento);
            this.tab_novo.Controls.Add(this.label3);
            this.tab_novo.Controls.Add(this.label2);
            this.tab_novo.Controls.Add(this.label1);
            this.tab_novo.Controls.Add(this.tb_descricao);
            this.tab_novo.Controls.Add(this.cbx_clientes);
            this.tab_novo.Location = new System.Drawing.Point(4, 22);
            this.tab_novo.Name = "tab_novo";
            this.tab_novo.Padding = new System.Windows.Forms.Padding(3);
            this.tab_novo.Size = new System.Drawing.Size(631, 474);
            this.tab_novo.TabIndex = 1;
            this.tab_novo.Text = "Novo Conta a Receber";
            this.tab_novo.UseVisualStyleBackColor = true;
            // 
            // tb_valor
            // 
            this.tb_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valor.Location = new System.Drawing.Point(18, 192);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(121, 24);
            this.tb_valor.TabIndex = 11;
            this.tb_valor.Text = "0,00";
            this.tb_valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_valor_KeyPress);
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.Crimson;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deletar.Location = new System.Drawing.Point(319, 430);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(164, 31);
            this.btn_deletar.TabIndex = 10;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Green;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_salvar.Location = new System.Drawing.Point(149, 430);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(164, 31);
            this.btn_salvar.TabIndex = 9;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vencimento";
            // 
            // dtp_vencimento
            // 
            this.dtp_vencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_vencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_vencimento.Location = new System.Drawing.Point(145, 192);
            this.dtp_vencimento.Name = "dtp_vencimento";
            this.dtp_vencimento.Size = new System.Drawing.Size(115, 24);
            this.dtp_vencimento.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Descrição da Conta";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(17, 80);
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(598, 90);
            this.tb_descricao.TabIndex = 1;
            // 
            // cbx_clientes
            // 
            this.cbx_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_clientes.FormattingEnabled = true;
            this.cbx_clientes.Location = new System.Drawing.Point(17, 29);
            this.cbx_clientes.Name = "cbx_clientes";
            this.cbx_clientes.Size = new System.Drawing.Size(598, 26);
            this.cbx_clientes.TabIndex = 0;
            this.cbx_clientes.Text = "Selecionar Cliente";
            // 
            // cbx_status
            // 
            this.cbx_status.FormattingEnabled = true;
            this.cbx_status.Items.AddRange(new object[] {
            "Pendente",
            "Pago",
            "Vencido"});
            this.cbx_status.Location = new System.Drawing.Point(271, 195);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(115, 21);
            this.cbx_status.TabIndex = 12;
            this.cbx_status.Text = "Pendente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Status ";
            // 
            // F_ContasAreceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(659, 539);
            this.Controls.Add(this.tab_contasAreceber);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ContasAreceber";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber";
            this.Load += new System.EventHandler(this.F_ContasAreceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_contasAreceber)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tab_contasAreceber.ResumeLayout(false);
            this.tab_visual.ResumeLayout(false);
            this.tab_visual.PerformLayout();
            this.tab_novo.ResumeLayout(false);
            this.tab_novo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_contasAreceber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impressãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarPDFToolStripMenuItem;
        private System.Windows.Forms.TabPage tab_visual;
        private System.Windows.Forms.TabPage tab_novo;
        private System.Windows.Forms.TextBox tb_busca;
        private System.Windows.Forms.ComboBox cbx_clientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_vencimento;
        private System.Windows.Forms.TextBox tb_valor;
        public System.Windows.Forms.TabControl tab_contasAreceber;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox cbx_status;
        private System.Windows.Forms.Label label5;
    }
}