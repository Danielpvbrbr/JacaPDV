namespace mysql_conection
{
    partial class F_usuarios
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
            this.tb_nomeFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_usuarioFuncionario = new System.Windows.Forms.TextBox();
            this.cbx_previlegios = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CkB_status = new System.Windows.Forms.CheckBox();
            this.CkB_usuarios = new System.Windows.Forms.CheckBox();
            this.CkB_funcionarios = new System.Windows.Forms.CheckBox();
            this.CkB_clientes = new System.Windows.Forms.CheckBox();
            this.CkB_contasAreceber = new System.Windows.Forms.CheckBox();
            this.CkB_gerenciamento = new System.Windows.Forms.CheckBox();
            this.CkB_pdv = new System.Windows.Forms.CheckBox();
            this.CkB_estoque = new System.Windows.Forms.CheckBox();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.tb_senhaFuncionario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_Usuarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_totalUsers = new System.Windows.Forms.Label();
            this.tab_novoUsers = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_busca = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Usuarios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tab_novoUsers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_nomeFuncionario
            // 
            this.tb_nomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nomeFuncionario.Location = new System.Drawing.Point(11, 37);
            this.tb_nomeFuncionario.MaxLength = 100;
            this.tb_nomeFuncionario.Name = "tb_nomeFuncionario";
            this.tb_nomeFuncionario.Size = new System.Drawing.Size(262, 24);
            this.tb_nomeFuncionario.TabIndex = 0;
            this.tb_nomeFuncionario.TextChanged += new System.EventHandler(this.tb_nomeFuncionario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Do Funcionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario de acesso";
            // 
            // tb_usuarioFuncionario
            // 
            this.tb_usuarioFuncionario.Enabled = false;
            this.tb_usuarioFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_usuarioFuncionario.Location = new System.Drawing.Point(11, 89);
            this.tb_usuarioFuncionario.MaxLength = 20;
            this.tb_usuarioFuncionario.Name = "tb_usuarioFuncionario";
            this.tb_usuarioFuncionario.Size = new System.Drawing.Size(262, 24);
            this.tb_usuarioFuncionario.TabIndex = 2;
            // 
            // cbx_previlegios
            // 
            this.cbx_previlegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_previlegios.FormattingEnabled = true;
            this.cbx_previlegios.Items.AddRange(new object[] {
            "Operador",
            "Supervisor",
            "Administrador"});
            this.cbx_previlegios.Location = new System.Drawing.Point(11, 181);
            this.cbx_previlegios.Name = "cbx_previlegios";
            this.cbx_previlegios.Size = new System.Drawing.Size(262, 26);
            this.cbx_previlegios.TabIndex = 123;
            this.cbx_previlegios.Text = "Operador";
            this.cbx_previlegios.SelectedIndexChanged += new System.EventHandler(this.cbx_previlegios_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 122;
            this.label16.Text = "Privilégio";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CkB_status);
            this.groupBox3.Controls.Add(this.CkB_usuarios);
            this.groupBox3.Controls.Add(this.CkB_funcionarios);
            this.groupBox3.Controls.Add(this.CkB_clientes);
            this.groupBox3.Controls.Add(this.CkB_contasAreceber);
            this.groupBox3.Controls.Add(this.CkB_gerenciamento);
            this.groupBox3.Controls.Add(this.CkB_pdv);
            this.groupBox3.Controls.Add(this.CkB_estoque);
            this.groupBox3.Location = new System.Drawing.Point(299, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 226);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Permissões";
            // 
            // CkB_status
            // 
            this.CkB_status.AutoSize = true;
            this.CkB_status.ForeColor = System.Drawing.Color.OrangeRed;
            this.CkB_status.Location = new System.Drawing.Point(7, 21);
            this.CkB_status.Name = "CkB_status";
            this.CkB_status.Size = new System.Drawing.Size(119, 17);
            this.CkB_status.TabIndex = 125;
            this.CkB_status.Text = "Acesso ao Sistema ";
            this.CkB_status.UseVisualStyleBackColor = true;
            // 
            // CkB_usuarios
            // 
            this.CkB_usuarios.AutoSize = true;
            this.CkB_usuarios.Location = new System.Drawing.Point(7, 89);
            this.CkB_usuarios.Name = "CkB_usuarios";
            this.CkB_usuarios.Size = new System.Drawing.Size(67, 17);
            this.CkB_usuarios.TabIndex = 6;
            this.CkB_usuarios.Text = "Usuários";
            this.CkB_usuarios.UseVisualStyleBackColor = true;
            // 
            // CkB_funcionarios
            // 
            this.CkB_funcionarios.AutoSize = true;
            this.CkB_funcionarios.Location = new System.Drawing.Point(7, 158);
            this.CkB_funcionarios.Name = "CkB_funcionarios";
            this.CkB_funcionarios.Size = new System.Drawing.Size(89, 17);
            this.CkB_funcionarios.TabIndex = 5;
            this.CkB_funcionarios.Text = "Funcionários ";
            this.CkB_funcionarios.UseVisualStyleBackColor = true;
            // 
            // CkB_clientes
            // 
            this.CkB_clientes.AutoSize = true;
            this.CkB_clientes.Location = new System.Drawing.Point(7, 112);
            this.CkB_clientes.Name = "CkB_clientes";
            this.CkB_clientes.Size = new System.Drawing.Size(66, 17);
            this.CkB_clientes.TabIndex = 4;
            this.CkB_clientes.Text = "Clientes ";
            this.CkB_clientes.UseVisualStyleBackColor = true;
            // 
            // CkB_contasAreceber
            // 
            this.CkB_contasAreceber.AutoSize = true;
            this.CkB_contasAreceber.Location = new System.Drawing.Point(7, 66);
            this.CkB_contasAreceber.Name = "CkB_contasAreceber";
            this.CkB_contasAreceber.Size = new System.Drawing.Size(112, 17);
            this.CkB_contasAreceber.TabIndex = 3;
            this.CkB_contasAreceber.Text = "Contas a Receber";
            this.CkB_contasAreceber.UseVisualStyleBackColor = true;
            // 
            // CkB_gerenciamento
            // 
            this.CkB_gerenciamento.AutoSize = true;
            this.CkB_gerenciamento.Location = new System.Drawing.Point(7, 182);
            this.CkB_gerenciamento.Name = "CkB_gerenciamento";
            this.CkB_gerenciamento.Size = new System.Drawing.Size(101, 17);
            this.CkB_gerenciamento.TabIndex = 2;
            this.CkB_gerenciamento.Text = "Gerenciamento ";
            this.CkB_gerenciamento.UseVisualStyleBackColor = true;
            // 
            // CkB_pdv
            // 
            this.CkB_pdv.AutoSize = true;
            this.CkB_pdv.Location = new System.Drawing.Point(7, 135);
            this.CkB_pdv.Name = "CkB_pdv";
            this.CkB_pdv.Size = new System.Drawing.Size(51, 17);
            this.CkB_pdv.TabIndex = 1;
            this.CkB_pdv.Text = "PDV ";
            this.CkB_pdv.UseVisualStyleBackColor = true;
            // 
            // CkB_estoque
            // 
            this.CkB_estoque.AutoSize = true;
            this.CkB_estoque.Location = new System.Drawing.Point(7, 43);
            this.CkB_estoque.Name = "CkB_estoque";
            this.CkB_estoque.Size = new System.Drawing.Size(65, 17);
            this.CkB_estoque.TabIndex = 0;
            this.CkB_estoque.Text = "Estoque";
            this.CkB_estoque.UseVisualStyleBackColor = true;
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.Crimson;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_deletar.Location = new System.Drawing.Point(206, 416);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(148, 28);
            this.btn_deletar.TabIndex = 7;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Green;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_salvar.Location = new System.Drawing.Point(66, 416);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(134, 28);
            this.btn_salvar.TabIndex = 6;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // tb_senhaFuncionario
            // 
            this.tb_senhaFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senhaFuncionario.Location = new System.Drawing.Point(11, 133);
            this.tb_senhaFuncionario.MaxLength = 20;
            this.tb_senhaFuncionario.Name = "tb_senhaFuncionario";
            this.tb_senhaFuncionario.PasswordChar = '*';
            this.tb_senhaFuncionario.Size = new System.Drawing.Size(262, 24);
            this.tb_senhaFuncionario.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha de acesso";
            // 
            // dt_Usuarios
            // 
            this.dt_Usuarios.AllowUserToAddRows = false;
            this.dt_Usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_Usuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt_Usuarios.EnableHeadersVisualStyles = false;
            this.dt_Usuarios.Location = new System.Drawing.Point(6, 56);
            this.dt_Usuarios.MultiSelect = false;
            this.dt_Usuarios.Name = "dt_Usuarios";
            this.dt_Usuarios.ReadOnly = true;
            this.dt_Usuarios.RowHeadersVisible = false;
            this.dt_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_Usuarios.Size = new System.Drawing.Size(555, 399);
            this.dt_Usuarios.TabIndex = 0;
            this.dt_Usuarios.TabStop = false;
            this.dt_Usuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dt_Usuarios_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 42);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(7, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gerenciamento de Usuários";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::mysql_conection.Properties.Resources.close__1_;
            this.pictureBox1.Location = new System.Drawing.Point(563, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lb_totalUsers);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 543);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 26);
            this.panel2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(4, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Usuários:";
            // 
            // lb_totalUsers
            // 
            this.lb_totalUsers.AutoSize = true;
            this.lb_totalUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalUsers.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_totalUsers.Location = new System.Drawing.Point(107, 6);
            this.lb_totalUsers.Name = "lb_totalUsers";
            this.lb_totalUsers.Size = new System.Drawing.Size(15, 15);
            this.lb_totalUsers.TabIndex = 1;
            this.lb_totalUsers.Text = "0";
            // 
            // tab_novoUsers
            // 
            this.tab_novoUsers.Controls.Add(this.tabPage1);
            this.tab_novoUsers.Controls.Add(this.tabPage2);
            this.tab_novoUsers.Location = new System.Drawing.Point(9, 47);
            this.tab_novoUsers.Name = "tab_novoUsers";
            this.tab_novoUsers.SelectedIndex = 0;
            this.tab_novoUsers.Size = new System.Drawing.Size(575, 487);
            this.tab_novoUsers.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tb_busca);
            this.tabPage1.Controls.Add(this.dt_Usuarios);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(567, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista de Usuários";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Buscar Usuário";
            // 
            // tb_busca
            // 
            this.tb_busca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_busca.Location = new System.Drawing.Point(6, 24);
            this.tb_busca.Name = "tb_busca";
            this.tb_busca.Size = new System.Drawing.Size(555, 26);
            this.tb_busca.TabIndex = 1;
            this.tb_busca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_limpar);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btn_deletar);
            this.tabPage2.Controls.Add(this.btn_salvar);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(567, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Novo Usuário";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_limpar.Location = new System.Drawing.Point(361, 416);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(134, 28);
            this.btn_limpar.TabIndex = 125;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_nomeFuncionario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_senhaFuncionario);
            this.groupBox1.Controls.Add(this.cbx_previlegios);
            this.groupBox1.Controls.Add(this.tb_usuarioFuncionario);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 226);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // F_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 569);
            this.Controls.Add(this.tab_novoUsers);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_usuarios";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de Usuários";
            this.Load += new System.EventHandler(this.F_usuarios_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_Usuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tab_novoUsers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nomeFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_usuarioFuncionario;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox tb_senhaFuncionario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nomeFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_data_criacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_permiss_estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_permiss_Pdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_permiss_gerenciamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_permiss_contas_receber;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_permiss_clientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_permiss_funcionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_permiss_usuarios;
        private System.Windows.Forms.ComboBox cbx_previlegios;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox CkB_usuarios;
        private System.Windows.Forms.CheckBox CkB_funcionarios;
        private System.Windows.Forms.CheckBox CkB_clientes;
        private System.Windows.Forms.CheckBox CkB_contasAreceber;
        private System.Windows.Forms.CheckBox CkB_gerenciamento;
        private System.Windows.Forms.CheckBox CkB_pdv;
        private System.Windows.Forms.CheckBox CkB_estoque;
        public System.Windows.Forms.DataGridView dt_Usuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_totalUsers;
        private System.Windows.Forms.TabControl tab_novoUsers;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_busca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.CheckBox CkB_status;
    }
}