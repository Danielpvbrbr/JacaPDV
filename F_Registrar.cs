using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql_conection
{
    public partial class F_Registrar : Form
    {
        public F_Registrar()
        {
            InitializeComponent();
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            F_Login f_Login = new F_Login();
            f_Login.ShowDialog();
            this.Close();   
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string usuario = tb_user.Text;
            string password = tb_pass.Text;

            if (name == "" || usuario == "" || password == "")
            {
                MessageBox.Show("Campo esta vázio..");
                if (name == "")
                {
                    tb_name.Focus();

                }
                else if(usuario == "")
                {
                    tb_user.Focus();
                }
                else if (password == "")
                {
                    tb_pass.Focus();
                }
                return;
            }
            try
            {
                SendDB.Post("INSERT INTO teste_tb (nome,usuario,password) VALUES ('" + name + "','" + usuario + "','" + password + "')");
                
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Err o salvar", ex.Message);
            }
            
        }
    }
}
