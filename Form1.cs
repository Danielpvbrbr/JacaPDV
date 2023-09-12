using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;


namespace mysql_conection
{
    public partial class F_Login : Form
    {
        DataTable dt = new DataTable();
        public F_Login()
        {
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            F_Registrar f_Registrar = new F_Registrar();
            f_Registrar.ShowDialog();
            this.Close();
        }

        private void btn_Acessar_Click(object sender, EventArgs e)
        {
            F_Home f_Home = new F_Home();
            string usuario = tb_user.Text;
            string password = tb_password.Text;

            if (usuario == "" || password == "")
            {
                MessageBox.Show("Campo vázio");
                if (usuario == "")
                {
                    tb_user.Focus();
                    return;
                }
                else if (password == "")
                {
                    tb_password.Focus();
                    return;
                }
            }
            
            dt = SendDB.Get("SELECT * FROM tb_usuarios WHERE user_funcionario='" + usuario + "' AND senha_funcionario= '" + password + "';");
             
            if (dt.Rows.Count == 1)
            {
                
                Auth.nome = dt.Rows[0].Field<string>("nome_funcionario");
                Auth.user = dt.Rows[0].Field<string>("user_funcionario");
                Auth.senha = dt.Rows[0].Field<string>("senha_funcionario");
                Auth.privilegio_funcionario = dt.Rows[0].Field<string>("privilegio_funcionario");
                Auth.status = Convert.ToInt32(dt.Rows[0].Field<Int64>("status").ToString());
                Auth.permiss_estoque = Convert.ToInt32(dt.Rows[0].Field<Int64>("permiss_estoque").ToString());
                Auth.permiss_Pdv = Convert.ToInt32(dt.Rows[0].Field<Int64>("permiss_Pdv").ToString());
                Auth.permiss_gerenciamento = Convert.ToInt32(dt.Rows[0].Field<Int64>("permiss_gerenciamento").ToString());
                Auth.permiss_contas_receber = Convert.ToInt32(dt.Rows[0].Field<Int64>("permiss_contas_receber").ToString());
                Auth.permiss_clientes = Convert.ToInt32(dt.Rows[0].Field<Int64>("permiss_clientes").ToString());
                Auth.permiss_funcionarios = Convert.ToInt32(dt.Rows[0].Field<Int64>("permiss_funcionarios").ToString());
                Auth.permiss_usuarios = Convert.ToInt32(dt.Rows[0].Field<Int64>("permiss_usuarios").ToString());

                f_Home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
