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
    public partial class F_Setores : Form
    {
        DataTable dt = new DataTable();
        public F_Setores()
        {
            InitializeComponent();
        }

        private void  ObterSetoresFilter(string filtro)
        {
            lbx_setores.Items.Clear();
            dt = SendDB.Get("SELECT * FROM tb_setores WHERE setor LIKE '%%" + filtro + "%%'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lbx_setores.Items.Add(dt.Rows[i].Field<string>("setor"));
            }
        }

        private void F_Setores_Load(object sender, EventArgs e)
        {
            ObterSetoresFilter(tb_busca.Text);
        }

        private void tb_busca_TextChanged(object sender, EventArgs e)
        {
            lbx_setores.Items.Clear();
            ObterSetoresFilter(tb_busca.Text);
           
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            tab_setores.SelectedIndex = 1; 
        }

        private void LimparCampo()
        {
            lbx_setores.Items.Clear();
            ObterSetoresFilter(tb_busca.Text);

            tb_id.Text = "";
            btn_salvar.Text = "Salvar";
            tb_setor.Text = "";

            btn_deletarLinha.Enabled = false;
            btn_deletarLinha.BackColor = Color.Gray;
        }

        private void ObterIdSelec()
        {
            string pos = lbx_setores.SelectedIndex.ToString();

            if (!pos.Contains("-"))
            {
                tb_id.Text = dt.Rows[int.Parse(pos)].Field<Int64>("id").ToString();
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string setor = tb_setor.Text;
            string id = tb_id.Text;

            if (tb_setor.Text != "")
            {
                if (btn_salvar.Text == "Salvar")
                {
                    SendDB.Post("INSERT INTO tb_setores (setor) VALUES ('" + setor + "')");
                    if (SendDB.isRespostaPost)
                    {
                        LimparCampo();
                        MessageBox.Show("Registro salvo com sucesso!!");
                        ObterSetoresFilter(tb_busca.Text);
                        tab_setores.SelectedIndex = 0;
                    }
                }
                else
                {
                    SendDB.Update("UPDATE tb_setores SET setor='" + setor + "' WHERE id = '" + id + "'");
                  
                    if (SendDB.isRespostaUpdate)
                    {
                        LimparCampo();
                        MessageBox.Show("Registro Atualizado com sucesso!!");
                        ObterSetoresFilter(tb_busca.Text);
                        tab_setores.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("Campo esta Vázio");
                tb_setor.Focus();
            }
           
        }

        private void DeletarSetor()
        {
            SendDB.Delete("DELETE FROM tb_setores WHERE id = '" + tb_id.Text + "'");

            if (SendDB.isRespostaDelete)
            {
                MessageBox.Show("Registro Deletado com Sucesso!");
                tab_setores.SelectedIndex = 0;
                LimparCampo();
            }
        }

        private void lbx_setores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_setores.SelectedIndex.ToString().Contains("-1"))
            {
                return;
            }
            btn_salvar.Text = "Alterar";
            tb_setor.Text = lbx_setores.SelectedItem.ToString();
            ObterIdSelec();
            tab_setores.SelectedIndex = 1;
            btn_deletarLinha.Enabled = true;
            btn_deletarLinha.BackColor = Color.Crimson;
        }
      
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            DeletarSetor();
        }

        private void btn_deletarLinha_Click(object sender, EventArgs e)
        {
            lbx_setores.Items.Clear();
            DeletarSetor();
            LimparCampo();
            ObterIdSelec();
        }
    }
}
