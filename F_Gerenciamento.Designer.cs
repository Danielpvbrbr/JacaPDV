namespace mysql_conection
{
    partial class F_Gerenciamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_totalVendas = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_totaLucros = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_totalDescontos = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_totalCancelados = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_totalRecebidos = new System.Windows.Forms.TextBox();
            this.dtg_ordenVenda = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.impressãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baixarPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtp_periodo1 = new System.Windows.Forms.DateTimePicker();
            this.dtp_periodo2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cbx_tipo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ordenVenda)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 569);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 84);
            this.panel1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tb_totalVendas);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(845, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 63);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Total de Vendas";
            // 
            // tb_totalVendas
            // 
            this.tb_totalVendas.BackColor = System.Drawing.Color.RoyalBlue;
            this.tb_totalVendas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_totalVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalVendas.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_totalVendas.Location = new System.Drawing.Point(44, 24);
            this.tb_totalVendas.Name = "tb_totalVendas";
            this.tb_totalVendas.Size = new System.Drawing.Size(100, 23);
            this.tb_totalVendas.TabIndex = 0;
            this.tb_totalVendas.Text = "R$ 0,00";
            this.tb_totalVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_totaLucros);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(637, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 63);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total de Lucros";
            // 
            // tb_totaLucros
            // 
            this.tb_totaLucros.BackColor = System.Drawing.Color.RoyalBlue;
            this.tb_totaLucros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_totaLucros.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totaLucros.ForeColor = System.Drawing.Color.Lime;
            this.tb_totaLucros.Location = new System.Drawing.Point(46, 24);
            this.tb_totaLucros.Name = "tb_totaLucros";
            this.tb_totaLucros.Size = new System.Drawing.Size(100, 23);
            this.tb_totaLucros.TabIndex = 1;
            this.tb_totaLucros.Text = "R$ 0,00";
            this.tb_totaLucros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_totalDescontos);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(429, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 63);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total de Descontos";
            // 
            // tb_totalDescontos
            // 
            this.tb_totalDescontos.BackColor = System.Drawing.Color.RoyalBlue;
            this.tb_totalDescontos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_totalDescontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalDescontos.ForeColor = System.Drawing.Color.White;
            this.tb_totalDescontos.Location = new System.Drawing.Point(45, 24);
            this.tb_totalDescontos.Name = "tb_totalDescontos";
            this.tb_totalDescontos.Size = new System.Drawing.Size(100, 23);
            this.tb_totalDescontos.TabIndex = 1;
            this.tb_totalDescontos.Text = "R$ 0,00";
            this.tb_totalDescontos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_totalCancelados);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(222, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total de Cancelados";
            // 
            // tb_totalCancelados
            // 
            this.tb_totalCancelados.BackColor = System.Drawing.Color.RoyalBlue;
            this.tb_totalCancelados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_totalCancelados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalCancelados.ForeColor = System.Drawing.Color.Crimson;
            this.tb_totalCancelados.Location = new System.Drawing.Point(45, 24);
            this.tb_totalCancelados.Name = "tb_totalCancelados";
            this.tb_totalCancelados.Size = new System.Drawing.Size(100, 23);
            this.tb_totalCancelados.TabIndex = 1;
            this.tb_totalCancelados.Text = "R$ 0,00";
            this.tb_totalCancelados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_totalRecebidos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(15, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 63);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total de Recebimentos";
            // 
            // tb_totalRecebidos
            // 
            this.tb_totalRecebidos.BackColor = System.Drawing.Color.RoyalBlue;
            this.tb_totalRecebidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_totalRecebidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalRecebidos.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_totalRecebidos.Location = new System.Drawing.Point(46, 24);
            this.tb_totalRecebidos.Name = "tb_totalRecebidos";
            this.tb_totalRecebidos.Size = new System.Drawing.Size(100, 23);
            this.tb_totalRecebidos.TabIndex = 1;
            this.tb_totalRecebidos.Text = "0,00";
            this.tb_totalRecebidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtg_ordenVenda
            // 
            this.dtg_ordenVenda.AllowUserToAddRows = false;
            this.dtg_ordenVenda.AllowUserToDeleteRows = false;
            this.dtg_ordenVenda.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_ordenVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_ordenVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ordenVenda.EnableHeadersVisualStyles = false;
            this.dtg_ordenVenda.Location = new System.Drawing.Point(13, 78);
            this.dtg_ordenVenda.MultiSelect = false;
            this.dtg_ordenVenda.Name = "dtg_ordenVenda";
            this.dtg_ordenVenda.ReadOnly = true;
            this.dtg_ordenVenda.RowHeadersVisible = false;
            this.dtg_ordenVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_ordenVenda.Size = new System.Drawing.Size(1032, 473);
            this.dtg_ordenVenda.TabIndex = 2;
            this.dtg_ordenVenda.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtg_ordenVenda_RowsAdded);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1059, 37);
            this.panel2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(440, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Gerencimento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::mysql_conection.Properties.Resources.close__1_;
            this.pictureBox1.Location = new System.Drawing.Point(1028, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impressãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // impressãoToolStripMenuItem
            // 
            this.impressãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirToolStripMenuItem,
            this.baixarPDFToolStripMenuItem});
            this.impressãoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.impressãoToolStripMenuItem.Name = "impressãoToolStripMenuItem";
            this.impressãoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.impressãoToolStripMenuItem.Text = "Arquivo";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // baixarPDFToolStripMenuItem
            // 
            this.baixarPDFToolStripMenuItem.Name = "baixarPDFToolStripMenuItem";
            this.baixarPDFToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.baixarPDFToolStripMenuItem.Text = "Baixar PDF";
            // 
            // dtp_periodo1
            // 
            this.dtp_periodo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_periodo1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_periodo1.Location = new System.Drawing.Point(13, 47);
            this.dtp_periodo1.Name = "dtp_periodo1";
            this.dtp_periodo1.Size = new System.Drawing.Size(88, 23);
            this.dtp_periodo1.TabIndex = 4;
            // 
            // dtp_periodo2
            // 
            this.dtp_periodo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_periodo2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_periodo2.Location = new System.Drawing.Point(124, 47);
            this.dtp_periodo2.Name = "dtp_periodo2";
            this.dtp_periodo2.Size = new System.Drawing.Size(88, 23);
            this.dtp_periodo2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "a";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_buscar.Location = new System.Drawing.Point(940, 46);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(106, 24);
            this.btn_buscar.TabIndex = 7;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // cbx_tipo
            // 
            this.cbx_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_tipo.FormattingEnabled = true;
            this.cbx_tipo.Items.AddRange(new object[] {
            "Vendas Avista",
            "Venda a Prazo",
            "Recebimento a Prazo",
            "Vendas Canceladas"});
            this.cbx_tipo.Location = new System.Drawing.Point(765, 46);
            this.cbx_tipo.Name = "cbx_tipo";
            this.cbx_tipo.Size = new System.Drawing.Size(169, 24);
            this.cbx_tipo.TabIndex = 8;
            this.cbx_tipo.Text = "Vendas";
            this.cbx_tipo.SelectedIndexChanged += new System.EventHandler(this.cbx_tipo_SelectedIndexChanged);
            // 
            // F_Gerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1059, 653);
            this.Controls.Add(this.cbx_tipo);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp_periodo2);
            this.Controls.Add(this.dtp_periodo1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtg_ordenVenda);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Gerenciamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Gerenciamento";
            this.Load += new System.EventHandler(this.F_Gerenciamento_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ordenVenda)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_ordenVenda;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem impressãoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtp_periodo1;
        private System.Windows.Forms.DateTimePicker dtp_periodo2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baixarPDFToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbx_tipo;
        private System.Windows.Forms.TextBox tb_totalVendas;
        private System.Windows.Forms.TextBox tb_totaLucros;
        private System.Windows.Forms.TextBox tb_totalDescontos;
        private System.Windows.Forms.TextBox tb_totalCancelados;
        private System.Windows.Forms.TextBox tb_totalRecebidos;
    }
}