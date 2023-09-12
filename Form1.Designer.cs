namespace mysql_conection
{
    partial class F_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_enviar = new System.Windows.Forms.Button();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.panel_login = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_pass = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_Acessar = new System.Windows.Forms.Button();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_enviar
            // 
            this.btn_enviar.Location = new System.Drawing.Point(119, 217);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(75, 23);
            this.btn_enviar.TabIndex = 1;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = true;
            // 
            // tb_user
            // 
            this.tb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_user.Location = new System.Drawing.Point(25, 181);
            this.tb_user.MaxLength = 20;
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(212, 26);
            this.tb_user.TabIndex = 2;
            this.tb_user.Text = "danielpv";
            // 
            // panel_login
            // 
            this.panel_login.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_login.Controls.Add(this.pictureBox2);
            this.panel_login.Controls.Add(this.pictureBox1);
            this.panel_login.Controls.Add(this.lb_pass);
            this.panel_login.Controls.Add(this.lb_user);
            this.panel_login.Controls.Add(this.btn_registrar);
            this.panel_login.Controls.Add(this.tb_password);
            this.panel_login.Controls.Add(this.btn_Acessar);
            this.panel_login.Controls.Add(this.tb_user);
            this.panel_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_login.Location = new System.Drawing.Point(0, 0);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(266, 391);
            this.panel_login.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::mysql_conection.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(54, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::mysql_conection.Properties.Resources.close__1_;
            this.pictureBox1.Location = new System.Drawing.Point(233, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_pass.Location = new System.Drawing.Point(24, 215);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(38, 13);
            this.lb_pass.TabIndex = 7;
            this.lb_pass.Text = "Senha";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.BackColor = System.Drawing.Color.Transparent;
            this.lb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_user.Location = new System.Drawing.Point(23, 162);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(43, 13);
            this.lb_user.TabIndex = 6;
            this.lb_user.Text = "Usuário";
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_registrar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_registrar.FlatAppearance.BorderSize = 0;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_registrar.Location = new System.Drawing.Point(26, 304);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(212, 29);
            this.btn_registrar.TabIndex = 5;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.ForeColor = System.Drawing.Color.Black;
            this.tb_password.Location = new System.Drawing.Point(25, 231);
            this.tb_password.MaxLength = 6;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(212, 24);
            this.tb_password.TabIndex = 4;
            this.tb_password.TabStop = false;
            this.tb_password.Text = "123";
            // 
            // btn_Acessar
            // 
            this.btn_Acessar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Acessar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Acessar.FlatAppearance.BorderSize = 0;
            this.btn_Acessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Acessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Acessar.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Acessar.Location = new System.Drawing.Point(26, 269);
            this.btn_Acessar.Name = "btn_Acessar";
            this.btn_Acessar.Size = new System.Drawing.Size(212, 29);
            this.btn_Acessar.TabIndex = 3;
            this.btn_Acessar.Text = "Acessar";
            this.btn_Acessar.UseVisualStyleBackColor = false;
            this.btn_Acessar.Click += new System.EventHandler(this.btn_Acessar_Click);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 391);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.btn_enviar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_Acessar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

