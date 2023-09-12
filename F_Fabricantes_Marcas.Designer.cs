namespace mysql_conection
{
    partial class F_Fabricantes_Marcas
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.tb_fabricante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_fabricantes = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbx_fabricantes = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_busca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_deletarLinha = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.tabPage4.SuspendLayout();
            this.tab_fabricantes.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btn_deletarLinha);
            this.tabPage4.Controls.Add(this.btn_limpar);
            this.tabPage4.Controls.Add(this.tb_id);
            this.tabPage4.Controls.Add(this.btn_salvar);
            this.tabPage4.Controls.Add(this.tb_fabricante);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(299, 369);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Novo Fabrigantes / Marcas";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Green;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_salvar.Location = new System.Drawing.Point(18, 264);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(265, 29);
            this.btn_salvar.TabIndex = 5;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // tb_fabricante
            // 
            this.tb_fabricante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fabricante.Location = new System.Drawing.Point(18, 31);
            this.tb_fabricante.Name = "tb_fabricante";
            this.tb_fabricante.Size = new System.Drawing.Size(265, 24);
            this.tb_fabricante.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do Fabricantes / Marcas";
            // 
            // tab_fabricantes
            // 
            this.tab_fabricantes.Controls.Add(this.tabPage3);
            this.tab_fabricantes.Controls.Add(this.tabPage4);
            this.tab_fabricantes.Location = new System.Drawing.Point(6, 11);
            this.tab_fabricantes.Name = "tab_fabricantes";
            this.tab_fabricantes.SelectedIndex = 0;
            this.tab_fabricantes.Size = new System.Drawing.Size(307, 395);
            this.tab_fabricantes.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbx_fabricantes);
            this.tabPage3.Controls.Add(this.tabControl1);
            this.tabPage3.Controls.Add(this.tb_busca);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btn_adicionar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(299, 369);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Listar de Fabricantes / Marcas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lbx_fabricantes
            // 
            this.lbx_fabricantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_fabricantes.FormattingEnabled = true;
            this.lbx_fabricantes.ItemHeight = 18;
            this.lbx_fabricantes.Location = new System.Drawing.Point(16, 53);
            this.lbx_fabricantes.Name = "lbx_fabricantes";
            this.lbx_fabricantes.Size = new System.Drawing.Size(265, 274);
            this.lbx_fabricantes.TabIndex = 0;
            this.lbx_fabricantes.SelectedIndexChanged += new System.EventHandler(this.lbx_fabricantes_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(46, 88);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(222, 207);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(214, 181);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(214, 181);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_busca
            // 
            this.tb_busca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_busca.Location = new System.Drawing.Point(16, 25);
            this.tb_busca.Name = "tb_busca";
            this.tb_busca.Size = new System.Drawing.Size(265, 24);
            this.tb_busca.TabIndex = 1;
            this.tb_busca.TextChanged += new System.EventHandler(this.tb_busca_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar Fabricantes / Marcas";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.Green;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adicionar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_adicionar.Location = new System.Drawing.Point(16, 333);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(265, 29);
            this.btn_adicionar.TabIndex = 3;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(226, 31);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(57, 24);
            this.tb_id.TabIndex = 6;
            // 
            // btn_deletarLinha
            // 
            this.btn_deletarLinha.BackColor = System.Drawing.Color.Crimson;
            this.btn_deletarLinha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletarLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletarLinha.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deletarLinha.Location = new System.Drawing.Point(18, 299);
            this.btn_deletarLinha.Name = "btn_deletarLinha";
            this.btn_deletarLinha.Size = new System.Drawing.Size(265, 29);
            this.btn_deletarLinha.TabIndex = 14;
            this.btn_deletarLinha.Text = "Deletar";
            this.btn_deletarLinha.UseVisualStyleBackColor = false;
            this.btn_deletarLinha.Click += new System.EventHandler(this.btn_deletarLinha_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_limpar.Location = new System.Drawing.Point(18, 334);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(265, 29);
            this.btn_limpar.TabIndex = 13;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // F_Fabricantes_Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 409);
            this.Controls.Add(this.tab_fabricantes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Fabricantes_Marcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fabricantes / Marcas";
            this.Load += new System.EventHandler(this.F_Fabricantes_Marcas_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tab_fabricantes.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox tb_fabricante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tab_fabricantes;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lbx_fabricantes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_busca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button btn_deletarLinha;
        private System.Windows.Forms.Button btn_limpar;
    }
}