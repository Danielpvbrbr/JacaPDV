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
    public partial class F_Orcamento : Form
    {

        public F_Orcamento()
        {
            InitializeComponent();
        }

        private void F_Orcamento_Load(object sender, EventArgs e)
        {
            tb_busca.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void tb_busca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
