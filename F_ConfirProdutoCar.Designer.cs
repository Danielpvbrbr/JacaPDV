namespace mysql_conection
{
    partial class F_ConfirProdutoCar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_quantidade = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_coditem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_precoUnitario = new System.Windows.Forms.TextBox();
            this.tb_precoAtacado = new System.Windows.Forms.TextBox();
            this.tb_precoPromocao = new System.Windows.Forms.TextBox();
            this.tb_subTotal = new System.Windows.Forms.TextBox();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.tb_desconto = new System.Windows.Forms.TextBox();
            this.tb_subTotalDesconto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(461, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Preço Promocional";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(316, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Preço Atacado";
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.BackColor = System.Drawing.Color.Green;
            this.Btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Confirmar.ForeColor = System.Drawing.SystemColors.Control;
            this.Btn_Confirmar.Location = new System.Drawing.Point(319, 316);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(149, 32);
            this.Btn_Confirmar.TabIndex = 49;
            this.Btn_Confirmar.Text = "Confirmar";
            this.Btn_Confirmar.UseVisualStyleBackColor = false;
            this.Btn_Confirmar.Click += new System.EventHandler(this.Btn_Confirmar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Crimson;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cancelar.Location = new System.Drawing.Point(159, 316);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(149, 32);
            this.btn_cancelar.TabIndex = 37;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(171, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "SubTotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(25, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Desconto R$ ou %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(170, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Valor Unitário";
            // 
            // lb_quantidade
            // 
            this.lb_quantidade.AutoSize = true;
            this.lb_quantidade.BackColor = System.Drawing.Color.Transparent;
            this.lb_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quantidade.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_quantidade.Location = new System.Drawing.Point(22, 120);
            this.lb_quantidade.Name = "lb_quantidade";
            this.lb_quantidade.Size = new System.Drawing.Size(100, 17);
            this.lb_quantidade.TabIndex = 41;
            this.lb_quantidade.Text = "Quantidade(0)";
            // 
            // tb_descricao
            // 
            this.tb_descricao.BackColor = System.Drawing.Color.Navy;
            this.tb_descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_descricao.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_descricao.Location = new System.Drawing.Point(174, 69);
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.ReadOnly = true;
            this.tb_descricao.Size = new System.Drawing.Size(425, 37);
            this.tb_descricao.TabIndex = 40;
            this.tb_descricao.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(176, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Descrição do item";
            // 
            // tb_coditem
            // 
            this.tb_coditem.BackColor = System.Drawing.Color.Navy;
            this.tb_coditem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_coditem.Enabled = false;
            this.tb_coditem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_coditem.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_coditem.Location = new System.Drawing.Point(25, 69);
            this.tb_coditem.Multiline = true;
            this.tb_coditem.Name = "tb_coditem";
            this.tb_coditem.ReadOnly = true;
            this.tb_coditem.Size = new System.Drawing.Size(134, 37);
            this.tb_coditem.TabIndex = 38;
            this.tb_coditem.TabStop = false;
            this.tb_coditem.Text = "1";
            this.tb_coditem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(22, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Cód. Item";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(8, 8);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(200, 17);
            this.title.TabIndex = 0;
            this.title.Text = "ADICIONAR ITEM A LISTA ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 35);
            this.panel1.TabIndex = 0;
            // 
            // tb_precoUnitario
            // 
            this.tb_precoUnitario.BackColor = System.Drawing.Color.Navy;
            this.tb_precoUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_precoUnitario.Enabled = false;
            this.tb_precoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precoUnitario.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_precoUnitario.Location = new System.Drawing.Point(174, 140);
            this.tb_precoUnitario.Multiline = true;
            this.tb_precoUnitario.Name = "tb_precoUnitario";
            this.tb_precoUnitario.ReadOnly = true;
            this.tb_precoUnitario.Size = new System.Drawing.Size(134, 37);
            this.tb_precoUnitario.TabIndex = 54;
            this.tb_precoUnitario.TabStop = false;
            this.tb_precoUnitario.Text = "0";
            this.tb_precoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_precoAtacado
            // 
            this.tb_precoAtacado.BackColor = System.Drawing.Color.Navy;
            this.tb_precoAtacado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_precoAtacado.Enabled = false;
            this.tb_precoAtacado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precoAtacado.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_precoAtacado.Location = new System.Drawing.Point(319, 141);
            this.tb_precoAtacado.Multiline = true;
            this.tb_precoAtacado.Name = "tb_precoAtacado";
            this.tb_precoAtacado.ReadOnly = true;
            this.tb_precoAtacado.Size = new System.Drawing.Size(134, 37);
            this.tb_precoAtacado.TabIndex = 55;
            this.tb_precoAtacado.TabStop = false;
            this.tb_precoAtacado.Text = "0";
            this.tb_precoAtacado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_precoPromocao
            // 
            this.tb_precoPromocao.BackColor = System.Drawing.Color.Navy;
            this.tb_precoPromocao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_precoPromocao.Enabled = false;
            this.tb_precoPromocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precoPromocao.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_precoPromocao.Location = new System.Drawing.Point(464, 141);
            this.tb_precoPromocao.Multiline = true;
            this.tb_precoPromocao.Name = "tb_precoPromocao";
            this.tb_precoPromocao.ReadOnly = true;
            this.tb_precoPromocao.Size = new System.Drawing.Size(134, 37);
            this.tb_precoPromocao.TabIndex = 56;
            this.tb_precoPromocao.TabStop = false;
            this.tb_precoPromocao.Text = "0";
            this.tb_precoPromocao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_subTotal
            // 
            this.tb_subTotal.BackColor = System.Drawing.Color.Navy;
            this.tb_subTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_subTotal.Enabled = false;
            this.tb_subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_subTotal.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_subTotal.Location = new System.Drawing.Point(173, 212);
            this.tb_subTotal.Multiline = true;
            this.tb_subTotal.Name = "tb_subTotal";
            this.tb_subTotal.ReadOnly = true;
            this.tb_subTotal.Size = new System.Drawing.Size(134, 37);
            this.tb_subTotal.TabIndex = 57;
            this.tb_subTotal.TabStop = false;
            this.tb_subTotal.Text = "0";
            this.tb_subTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.BackColor = System.Drawing.Color.Navy;
            this.tb_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quantidade.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_quantidade.Location = new System.Drawing.Point(25, 140);
            this.tb_quantidade.Multiline = true;
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(134, 37);
            this.tb_quantidade.TabIndex = 58;
            this.tb_quantidade.TabStop = false;
            this.tb_quantidade.Text = "1";
            this.tb_quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_quantidade.TextChanged += new System.EventHandler(this.tb_quantidade_TextChanged);
            // 
            // tb_desconto
            // 
            this.tb_desconto.BackColor = System.Drawing.Color.Navy;
            this.tb_desconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_desconto.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_desconto.Location = new System.Drawing.Point(28, 212);
            this.tb_desconto.Multiline = true;
            this.tb_desconto.Name = "tb_desconto";
            this.tb_desconto.Size = new System.Drawing.Size(134, 37);
            this.tb_desconto.TabIndex = 59;
            this.tb_desconto.TabStop = false;
            this.tb_desconto.Text = "0";
            this.tb_desconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_desconto.TextChanged += new System.EventHandler(this.tb_desconto_TextChanged);
            // 
            // tb_subTotalDesconto
            // 
            this.tb_subTotalDesconto.BackColor = System.Drawing.Color.Navy;
            this.tb_subTotalDesconto.Enabled = false;
            this.tb_subTotalDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_subTotalDesconto.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_subTotalDesconto.Location = new System.Drawing.Point(445, 212);
            this.tb_subTotalDesconto.Multiline = true;
            this.tb_subTotalDesconto.Name = "tb_subTotalDesconto";
            this.tb_subTotalDesconto.ReadOnly = true;
            this.tb_subTotalDesconto.Size = new System.Drawing.Size(154, 47);
            this.tb_subTotalDesconto.TabIndex = 61;
            this.tb_subTotalDesconto.TabStop = false;
            this.tb_subTotalDesconto.Text = "0";
            this.tb_subTotalDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(442, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Total com desconto";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // F_ConfirProdutoCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(625, 373);
            this.Controls.Add(this.tb_subTotalDesconto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_desconto);
            this.Controls.Add(this.tb_quantidade);
            this.Controls.Add(this.tb_subTotal);
            this.Controls.Add(this.tb_precoPromocao);
            this.Controls.Add(this.tb_precoAtacado);
            this.Controls.Add(this.tb_precoUnitario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btn_Confirmar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_quantidade);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_coditem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_ConfirProdutoCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirma o Item";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_ConfirProdutoCar_FormClosed);
            this.Load += new System.EventHandler(this.F_ConfirProdutoCar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Confirmar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_quantidade;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_coditem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_precoUnitario;
        private System.Windows.Forms.TextBox tb_precoAtacado;
        private System.Windows.Forms.TextBox tb_precoPromocao;
        private System.Windows.Forms.TextBox tb_subTotal;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.TextBox tb_desconto;
        private System.Windows.Forms.TextBox tb_subTotalDesconto;
        private System.Windows.Forms.Label label7;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}