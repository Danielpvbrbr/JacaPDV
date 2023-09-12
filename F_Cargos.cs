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
    public partial class F_Cargos : Form
    {
        DataTable dt = new DataTable();

        public F_Cargos()
        {
            InitializeComponent();
        }

        private void ObterCargosFilter(string filtro)
        {
            dt = SendDB.Get("SELECT * FROM tb_cargos WHERE cargo LIKE '%%" + filtro + "%%'");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list_cargos.Items.Add(dt.Rows[i].Field<string>("cargo"));
            }
        }

        private void F_Cargos_Load(object sender, EventArgs e)
        {
            ObterCargosFilter(tb_busca.Text);
            btn_deletarLinha.Enabled = false;
            btn_deletarLinha.BackColor = Color.Gray;
        }

        private void tb_busca_TextChanged(object sender, EventArgs e)
        {
            ObterCargosFilter(tb_busca.Text);
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            LimparCampo();
            tab_cargos.SelectedIndex = 1;
        }

        private void ObterIdSelec()
        {
            string pos = list_cargos.SelectedIndex.ToString();

            if (!pos.Contains("-"))
            {
                tb_id.Text = dt.Rows[int.Parse(pos)].Field<Int64>("id").ToString();
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
                if (tb_cargo.Text != "")
                {
                    if (btn_salvar.Text == "Salvar")
                    {
                        SendDB.Post("INSERT INTO tb_cargos (cargo) VALUES ('" + tb_cargo.Text + "');");
                   
                        if (SendDB.isRespostaPost)
                        {
                            tb_cargo.Focus();
                            list_cargos.Items.Clear();
                            ObterCargosFilter(tb_busca.Text);
                            MessageBox.Show("Registro de Cargo Salvo com sucesso!");
                        }
                    }
                    else
                    {
                        SendDB.Update("UPDATE tb_cargos SET cargo='"+ tb_cargo.Text + "' WHERE id='"+ tb_id.Text + "'");
                    
                        if (SendDB.isRespostaUpdate)
                        {
                            MessageBox.Show("Registro de Cargo Atualizado com sucesso!");
                            LimparCampo();
                            ObterCargosFilter(tb_busca.Text);
                            tab_cargos.SelectedIndex = 0;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Campo esta Vázio");
                    tb_cargo.Focus();
                }
             
        }
        private void LimparCampo()
        {
            tb_id.Text = "";
            btn_salvar.Text = "Salvar";
            tb_cargo.Text = "";
            btn_deletarLinha.Enabled = false;
            btn_deletarLinha.BackColor = Color.Gray;
        }

        private void list_cargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ObterIdSelec();
            tb_cargo.Text = list_cargos.SelectedItem.ToString();
            btn_salvar.Text = "Alterar";
            btn_deletarLinha.Enabled = true;
            btn_deletarLinha.BackColor = Color.Crimson;
            tab_cargos.SelectedIndex = 1;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }

        private void DeletaLinha()
        {
            SendDB.Delete("DELETE FROM tb_cargos WHERE id = '" + tb_id.Text + "'");

            if (SendDB.isRespostaDelete)
            {
                list_cargos.Items.Clear();
                LimparCampo();
                ObterCargosFilter(tb_busca.Text);
                MessageBox.Show("Registro Deletado com Sucesso!");
            }
        }
        private void btn_deletar_Click(object sender, EventArgs e)
        {
            DeletaLinha();
        }

        private void btn_deletarLinha_Click(object sender, EventArgs e)
        {
            DeletaLinha();
            LimparCampo();
            tab_cargos.SelectedIndex = 0;
        }
    }
}
