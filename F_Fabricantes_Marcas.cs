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
    public partial class F_Fabricantes_Marcas : Form
    {
        DataTable dt = new DataTable();
        public F_Fabricantes_Marcas()
        {
            InitializeComponent();
        }

        private void ObterFabriFilter(string filtro)
        {
            lbx_fabricantes.Items.Clear();
            dt = SendDB.Get("SELECT * FROM tb_fabricantes WHERE fabricante LIKE '%%" + filtro + "%%'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lbx_fabricantes.Items.Add(dt.Rows[i].Field<string>("fabricante"));
            }
        }

        private void F_Fabricantes_Marcas_Load(object sender, EventArgs e)
        {
            ObterFabriFilter(tb_busca.Text);
        }

        private void tb_busca_TextChanged(object sender, EventArgs e)
        {
            lbx_fabricantes.Items.Clear();
            ObterFabriFilter(tb_busca.Text);
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            tab_fabricantes.SelectedIndex = 1;
        }

        private void LimparCampo()
        {
            lbx_fabricantes.Items.Clear();
            ObterFabriFilter(tb_fabricante.Text);

            tb_id.Text = "";
            btn_salvar.Text = "Salvar";
            tb_fabricante.Text = "";

            btn_deletarLinha.Enabled = false;
            btn_deletarLinha.BackColor = Color.Gray;
        }


        private void ObterIdSelec()
        {
            string pos = lbx_fabricantes.SelectedIndex.ToString();
            if (!pos.Contains("-"))
            {
                tb_id.Text = dt.Rows[int.Parse(pos)].Field<Int64>("id").ToString();
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string fabricante = tb_fabricante.Text;
            string id = tb_id.Text;

            if (tb_fabricante.Text != "")
            {
                if (btn_salvar.Text == "Salvar")
                {
                    SendDB.Post("INSERT INTO tb_fabricantes (fabricante) VALUES ('" + fabricante + "')");
                    if (SendDB.isRespostaPost)
                    {
                        LimparCampo();
                        MessageBox.Show("Registro salvo com sucesso!!");
                        ObterFabriFilter(tb_busca.Text);
                        tab_fabricantes.SelectedIndex = 0;
                    }
                }
                else
                {
                    SendDB.Update("UPDATE tb_fabricantes SET fabricante='" + fabricante + "' WHERE id = '" + id + "'");

                    if (SendDB.isRespostaUpdate)
                    {
                        LimparCampo();
                        MessageBox.Show("Registro Atualizado com sucesso!!");
                        ObterFabriFilter(tb_busca.Text);
                        tab_fabricantes.SelectedIndex = 0;
                    }
             
                }
            }
            else
            {
                MessageBox.Show("Campo esta Vázio");
                tb_fabricante.Focus();
            }
        }

        private void DeletarSetor()
        {
            SendDB.Delete("DELETE FROM tb_fabricantes WHERE id = '" + tb_id.Text + "'");

            if (SendDB.isRespostaDelete)
            {
                MessageBox.Show("Registro Deletado com Sucesso!");
                tab_fabricantes.SelectedIndex = 0;
                LimparCampo();
            }
        }

        private void lbx_fabricantes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_fabricantes.SelectedIndex.ToString().Contains("-1"))
            {
                return;
            }

            btn_salvar.Text = "Alterar";
            tb_fabricante.Text = lbx_fabricantes.SelectedItem.ToString();
            ObterIdSelec();
            tab_fabricantes.SelectedIndex = 1;
            btn_deletarLinha.Enabled = true;
            btn_deletarLinha.BackColor = Color.Crimson;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }

        private void btn_deletarLinha_Click(object sender, EventArgs e)
        {
            lbx_fabricantes.Items.Clear();
            DeletarSetor();
            LimparCampo();
            ObterIdSelec();
        }
       
    }
}
