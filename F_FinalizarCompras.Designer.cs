namespace mysql_conection
{
    partial class F_FinalizarCompras
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
            this.Rtb_notaFiscal = new System.Windows.Forms.RichTextBox();
            this.btn_dinheiro = new System.Windows.Forms.Button();
            this.btn_cartao = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_retonar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_prazo = new System.Windows.Forms.Button();
            this.tb_totalApagar = new System.Windows.Forms.TextBox();
            this.tb_troco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpb_entradaTroco = new System.Windows.Forms.GroupBox();
            this.tb_valorPago = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpb_tipoDeCartao = new System.Windows.Forms.GroupBox();
            this.rdb_debito = new System.Windows.Forms.RadioButton();
            this.rdb_credito = new System.Windows.Forms.RadioButton();
            this.rdb_naoImprimir = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rdb_imp_comum = new System.Windows.Forms.RadioButton();
            this.rdb_imp_termica = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.gpb_infoCliente = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_clientes = new System.Windows.Forms.ComboBox();
            this.tb_limite = new System.Windows.Forms.TextBox();
            this.tb_limiteRest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpb_entradaTroco.SuspendLayout();
            this.gpb_tipoDeCartao.SuspendLayout();
            this.rdb_naoImprimir.SuspendLayout();
            this.gpb_infoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rtb_notaFiscal
            // 
            this.Rtb_notaFiscal.BackColor = System.Drawing.SystemColors.Info;
            this.Rtb_notaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtb_notaFiscal.Location = new System.Drawing.Point(207, 44);
            this.Rtb_notaFiscal.Name = "Rtb_notaFiscal";
            this.Rtb_notaFiscal.Size = new System.Drawing.Size(356, 515);
            this.Rtb_notaFiscal.TabIndex = 0;
            this.Rtb_notaFiscal.Text = "";
            // 
            // btn_dinheiro
            // 
            this.btn_dinheiro.BackColor = System.Drawing.Color.Green;
            this.btn_dinheiro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dinheiro.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_dinheiro.Location = new System.Drawing.Point(6, 19);
            this.btn_dinheiro.Name = "btn_dinheiro";
            this.btn_dinheiro.Size = new System.Drawing.Size(174, 34);
            this.btn_dinheiro.TabIndex = 15;
            this.btn_dinheiro.Text = "Dinheiro";
            this.btn_dinheiro.UseVisualStyleBackColor = false;
            this.btn_dinheiro.Click += new System.EventHandler(this.btn_dinheiro_Click);
            // 
            // btn_cartao
            // 
            this.btn_cartao.BackColor = System.Drawing.Color.Gray;
            this.btn_cartao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cartao.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cartao.Location = new System.Drawing.Point(6, 60);
            this.btn_cartao.Name = "btn_cartao";
            this.btn_cartao.Size = new System.Drawing.Size(174, 34);
            this.btn_cartao.TabIndex = 16;
            this.btn_cartao.Text = "Cartão";
            this.btn_cartao.UseVisualStyleBackColor = false;
            this.btn_cartao.Click += new System.EventHandler(this.btn_cartao_Click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.BackColor = System.Drawing.Color.Green;
            this.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_finalizar.Location = new System.Drawing.Point(11, 523);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(186, 40);
            this.btn_finalizar.TabIndex = 17;
            this.btn_finalizar.Text = "Finalizar Venda";
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_retonar
            // 
            this.btn_retonar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_retonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retonar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retonar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_retonar.Location = new System.Drawing.Point(11, 570);
            this.btn_retonar.Name = "btn_retonar";
            this.btn_retonar.Size = new System.Drawing.Size(186, 40);
            this.btn_retonar.TabIndex = 18;
            this.btn_retonar.Text = "Retornar";
            this.btn_retonar.UseVisualStyleBackColor = false;
            this.btn_retonar.Click += new System.EventHandler(this.btn_retonar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 35);
            this.panel1.TabIndex = 19;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(8, 8);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(247, 17);
            this.title.TabIndex = 0;
            this.title.Text = "CONFIRMAÇÃO DE PAGAMENTO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_prazo);
            this.groupBox1.Controls.Add(this.btn_cartao);
            this.groupBox1.Controls.Add(this.btn_dinheiro);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 145);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de Pagamento";
            // 
            // btn_prazo
            // 
            this.btn_prazo.BackColor = System.Drawing.Color.Gray;
            this.btn_prazo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_prazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prazo.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_prazo.Location = new System.Drawing.Point(6, 100);
            this.btn_prazo.Name = "btn_prazo";
            this.btn_prazo.Size = new System.Drawing.Size(174, 34);
            this.btn_prazo.TabIndex = 17;
            this.btn_prazo.Text = "Prazo";
            this.btn_prazo.UseVisualStyleBackColor = false;
            this.btn_prazo.Click += new System.EventHandler(this.btn_prazo_Click);
            // 
            // tb_totalApagar
            // 
            this.tb_totalApagar.BackColor = System.Drawing.Color.Navy;
            this.tb_totalApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalApagar.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_totalApagar.Location = new System.Drawing.Point(12, 72);
            this.tb_totalApagar.Multiline = true;
            this.tb_totalApagar.Name = "tb_totalApagar";
            this.tb_totalApagar.ReadOnly = true;
            this.tb_totalApagar.Size = new System.Drawing.Size(185, 37);
            this.tb_totalApagar.TabIndex = 60;
            this.tb_totalApagar.TabStop = false;
            this.tb_totalApagar.Text = "0,00";
            this.tb_totalApagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_troco
            // 
            this.tb_troco.BackColor = System.Drawing.Color.Navy;
            this.tb_troco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_troco.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_troco.Location = new System.Drawing.Point(6, 105);
            this.tb_troco.Multiline = true;
            this.tb_troco.Name = "tb_troco";
            this.tb_troco.Size = new System.Drawing.Size(174, 37);
            this.tb_troco.TabIndex = 61;
            this.tb_troco.TabStop = false;
            this.tb_troco.Text = "0,00";
            this.tb_troco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Total a Pagar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(34, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "Troco do Cliente";
            // 
            // gpb_entradaTroco
            // 
            this.gpb_entradaTroco.Controls.Add(this.tb_valorPago);
            this.gpb_entradaTroco.Controls.Add(this.label3);
            this.gpb_entradaTroco.Controls.Add(this.tb_troco);
            this.gpb_entradaTroco.Controls.Add(this.label2);
            this.gpb_entradaTroco.ForeColor = System.Drawing.SystemColors.Control;
            this.gpb_entradaTroco.Location = new System.Drawing.Point(12, 169);
            this.gpb_entradaTroco.Name = "gpb_entradaTroco";
            this.gpb_entradaTroco.Size = new System.Drawing.Size(186, 149);
            this.gpb_entradaTroco.TabIndex = 21;
            this.gpb_entradaTroco.TabStop = false;
            this.gpb_entradaTroco.Text = "Entrada / Troco ";
            // 
            // tb_valorPago
            // 
            this.tb_valorPago.BackColor = System.Drawing.Color.Navy;
            this.tb_valorPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valorPago.ForeColor = System.Drawing.SystemColors.Info;
            this.tb_valorPago.Location = new System.Drawing.Point(6, 40);
            this.tb_valorPago.Multiline = true;
            this.tb_valorPago.Name = "tb_valorPago";
            this.tb_valorPago.Size = new System.Drawing.Size(174, 37);
            this.tb_valorPago.TabIndex = 64;
            this.tb_valorPago.TabStop = false;
            this.tb_valorPago.Text = "0,00";
            this.tb_valorPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_valorPago.TextChanged += new System.EventHandler(this.tb_valorPago_TextChanged);
            this.tb_valorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_valorPago_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(54, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Valor Pago";
            // 
            // gpb_tipoDeCartao
            // 
            this.gpb_tipoDeCartao.BackColor = System.Drawing.Color.Transparent;
            this.gpb_tipoDeCartao.Controls.Add(this.rdb_debito);
            this.gpb_tipoDeCartao.Controls.Add(this.rdb_credito);
            this.gpb_tipoDeCartao.ForeColor = System.Drawing.SystemColors.Control;
            this.gpb_tipoDeCartao.Location = new System.Drawing.Point(12, 233);
            this.gpb_tipoDeCartao.Name = "gpb_tipoDeCartao";
            this.gpb_tipoDeCartao.Size = new System.Drawing.Size(186, 84);
            this.gpb_tipoDeCartao.TabIndex = 66;
            this.gpb_tipoDeCartao.TabStop = false;
            this.gpb_tipoDeCartao.Text = "Tipo de Cartão";
            // 
            // rdb_debito
            // 
            this.rdb_debito.AutoSize = true;
            this.rdb_debito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_debito.Location = new System.Drawing.Point(7, 52);
            this.rdb_debito.Name = "rdb_debito";
            this.rdb_debito.Size = new System.Drawing.Size(74, 24);
            this.rdb_debito.TabIndex = 3;
            this.rdb_debito.Text = "Débito";
            this.rdb_debito.UseVisualStyleBackColor = true;
            // 
            // rdb_credito
            // 
            this.rdb_credito.AutoSize = true;
            this.rdb_credito.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_credito.Location = new System.Drawing.Point(7, 22);
            this.rdb_credito.Name = "rdb_credito";
            this.rdb_credito.Size = new System.Drawing.Size(78, 24);
            this.rdb_credito.TabIndex = 2;
            this.rdb_credito.Text = "Crédito";
            this.rdb_credito.UseVisualStyleBackColor = true;
            // 
            // rdb_naoImprimir
            // 
            this.rdb_naoImprimir.Controls.Add(this.radioButton3);
            this.rdb_naoImprimir.Controls.Add(this.rdb_imp_comum);
            this.rdb_naoImprimir.Controls.Add(this.rdb_imp_termica);
            this.rdb_naoImprimir.ForeColor = System.Drawing.SystemColors.Control;
            this.rdb_naoImprimir.Location = new System.Drawing.Point(207, 565);
            this.rdb_naoImprimir.Name = "rdb_naoImprimir";
            this.rdb_naoImprimir.Size = new System.Drawing.Size(356, 46);
            this.rdb_naoImprimir.TabIndex = 66;
            this.rdb_naoImprimir.TabStop = false;
            this.rdb_naoImprimir.Text = "Tipo de Impressão";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(268, 18);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(82, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Não imprimir";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rdb_imp_comum
            // 
            this.rdb_imp_comum.AutoSize = true;
            this.rdb_imp_comum.Location = new System.Drawing.Point(137, 18);
            this.rdb_imp_comum.Name = "rdb_imp_comum";
            this.rdb_imp_comum.Size = new System.Drawing.Size(114, 17);
            this.rdb_imp_comum.TabIndex = 1;
            this.rdb_imp_comum.Text = "Impressora Comum";
            this.rdb_imp_comum.UseVisualStyleBackColor = true;
            // 
            // rdb_imp_termica
            // 
            this.rdb_imp_termica.AutoSize = true;
            this.rdb_imp_termica.Location = new System.Drawing.Point(8, 18);
            this.rdb_imp_termica.Name = "rdb_imp_termica";
            this.rdb_imp_termica.Size = new System.Drawing.Size(120, 17);
            this.rdb_imp_termica.TabIndex = 0;
            this.rdb_imp_termica.Text = "Impressora Térmica ";
            this.rdb_imp_termica.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 40);
            this.button1.TabIndex = 67;
            this.button1.Text = "Salvar Orçamento";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // gpb_infoCliente
            // 
            this.gpb_infoCliente.BackColor = System.Drawing.Color.Transparent;
            this.gpb_infoCliente.Controls.Add(this.tb_limiteRest);
            this.gpb_infoCliente.Controls.Add(this.label5);
            this.gpb_infoCliente.Controls.Add(this.tb_limite);
            this.gpb_infoCliente.Controls.Add(this.label4);
            this.gpb_infoCliente.Controls.Add(this.cbx_clientes);
            this.gpb_infoCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.gpb_infoCliente.Location = new System.Drawing.Point(12, 115);
            this.gpb_infoCliente.Name = "gpb_infoCliente";
            this.gpb_infoCliente.Size = new System.Drawing.Size(186, 88);
            this.gpb_infoCliente.TabIndex = 67;
            this.gpb_infoCliente.TabStop = false;
            this.gpb_infoCliente.Text = "Informações de Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Limite de Credito";
            // 
            // cbx_clientes
            // 
            this.cbx_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_clientes.FormattingEnabled = true;
            this.cbx_clientes.Location = new System.Drawing.Point(6, 36);
            this.cbx_clientes.Name = "cbx_clientes";
            this.cbx_clientes.Size = new System.Drawing.Size(173, 28);
            this.cbx_clientes.TabIndex = 0;
            this.cbx_clientes.Text = "Selecionar Cliente";
            this.cbx_clientes.SelectedIndexChanged += new System.EventHandler(this.cbx_clientes_SelectedIndexChanged);
            // 
            // tb_limite
            // 
            this.tb_limite.BackColor = System.Drawing.Color.Navy;
            this.tb_limite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_limite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_limite.ForeColor = System.Drawing.Color.White;
            this.tb_limite.Location = new System.Drawing.Point(116, 19);
            this.tb_limite.Name = "tb_limite";
            this.tb_limite.ReadOnly = true;
            this.tb_limite.Size = new System.Drawing.Size(61, 13);
            this.tb_limite.TabIndex = 68;
            this.tb_limite.TabStop = false;
            this.tb_limite.Text = "0,00";
            this.tb_limite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_limiteRest
            // 
            this.tb_limiteRest.BackColor = System.Drawing.Color.Navy;
            this.tb_limiteRest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_limiteRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_limiteRest.ForeColor = System.Drawing.Color.White;
            this.tb_limiteRest.Location = new System.Drawing.Point(118, 69);
            this.tb_limiteRest.Name = "tb_limiteRest";
            this.tb_limiteRest.ReadOnly = true;
            this.tb_limiteRest.Size = new System.Drawing.Size(61, 13);
            this.tb_limiteRest.TabIndex = 70;
            this.tb_limiteRest.TabStop = false;
            this.tb_limiteRest.Text = "0,00";
            this.tb_limiteRest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Limite Após a Compra";
            // 
            // F_FinalizarCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(572, 620);
            this.Controls.Add(this.gpb_infoCliente);
            this.Controls.Add(this.gpb_tipoDeCartao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdb_naoImprimir);
            this.Controls.Add(this.gpb_entradaTroco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_totalApagar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_retonar);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.Rtb_notaFiscal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_FinalizarCompras";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizar Compra";
            this.Load += new System.EventHandler(this.F_FinalizarCompras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gpb_entradaTroco.ResumeLayout(false);
            this.gpb_entradaTroco.PerformLayout();
            this.gpb_tipoDeCartao.ResumeLayout(false);
            this.gpb_tipoDeCartao.PerformLayout();
            this.rdb_naoImprimir.ResumeLayout(false);
            this.rdb_naoImprimir.PerformLayout();
            this.gpb_infoCliente.ResumeLayout(false);
            this.gpb_infoCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Rtb_notaFiscal;
        private System.Windows.Forms.Button btn_dinheiro;
        private System.Windows.Forms.Button btn_cartao;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Button btn_retonar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_totalApagar;
        private System.Windows.Forms.TextBox tb_troco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpb_entradaTroco;
        private System.Windows.Forms.TextBox tb_valorPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox rdb_naoImprimir;
        private System.Windows.Forms.Button btn_prazo;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rdb_imp_comum;
        private System.Windows.Forms.RadioButton rdb_imp_termica;
        private System.Windows.Forms.GroupBox gpb_tipoDeCartao;
        private System.Windows.Forms.RadioButton rdb_debito;
        private System.Windows.Forms.RadioButton rdb_credito;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gpb_infoCliente;
        private System.Windows.Forms.ComboBox cbx_clientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_limite;
        private System.Windows.Forms.TextBox tb_limiteRest;
        private System.Windows.Forms.Label label5;
    }
}