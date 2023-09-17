using MySqlX.XDevAPI;
using Org.BouncyCastle.Crypto.Engines;
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
    public partial class F_ContasAreceber : Form
    {
        DataTable dt = new DataTable();

        public F_ContasAreceber()
        {
            InitializeComponent();
        }

        private void ObterContaAreceber(string filtro)
        {
            dt = SendDB.Get("SELECT id as 'Cód. Item', cliente as 'Cliente', valor as 'Valor', vencimento as 'Vencimento', descricao as 'Descrição' FROM tb_contasAreceber WHERE cliente LIKE '%%" + filtro + "%%'");
            dtg_contasAreceber.DataSource = dt;
        }

        private void F_ContasAreceber_Load(object sender, EventArgs e)
        {
            ObterContaAreceber(tb_busca.Text);

            Clientes.add(cbx_clientes);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string cliente = cbx_clientes.Text;
            string descricao = tb_descricao.Text;
            string valor = tb_valor.Text;
            string vecimento = dtp_vencimento.Text;
         

            if (cbx_clientes.Text != "Selecionar Cliente" && tb_valor.Text != "0,00" && tb_valor.Text != " ")
            {
                if (btn_salvar.Text == "Salvar")
                {
                    SendDB.Post("INSERT INTO tb_contasAreceber (cliente, descricao, valor, vencimento) VALUES ('" + cliente + "','"+ descricao + "', '"+ valor + "','"+ vecimento + "')");
                    if (SendDB.isRespostaPost)
                    {
                        ObterContaAreceber(tb_busca.Text);
                        tab_contasAreceber.SelectedIndex = 0;
                    }
                }
                else
                {
                    string id = ObterSelecion(0);
                    SendDB.Update("UPDATE tb_contasAreceber SET cliente ='" + cliente + "', descricao = '" + descricao + "', valor = '" + valor + "', vencimento = '" + vecimento + "' WHERE id = '"+id+"'");
                    if (SendDB.isRespostaUpdate)
                    {
                        ObterContaAreceber(tb_busca.Text);
                        tab_contasAreceber.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha os Campos obrigatório");
            }
            
        }
        private string ObterSelecion(int i)
        {
            return dtg_contasAreceber.SelectedRows[0].Cells[i].Value.ToString();
        }


        private void dtg_contasAreceber_DoubleClick(object sender, EventArgs e)
        {
                
            cbx_clientes.Text = ObterSelecion(1);
            tb_valor.Text = ObterSelecion(2);
            dtp_vencimento.Text = ObterSelecion(3);
            tb_descricao.Text = ObterSelecion(4);
            tab_novo.Text = "Visualizar";
            cbx_clientes.Enabled = false;
            btn_salvar.Text = "Alterar";
            btn_deletar.Enabled = true;
            btn_deletar.BackColor = Color.Crimson;
            tab_contasAreceber.SelectedIndex = 1;
        }

        private void tab_contasAreceber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tab_contasAreceber.SelectedIndex == 0)
            {
                cbx_clientes.Text = "Selecionar Cliente"; 
                tb_valor.Text = "0,00"; 
                dtp_vencimento.Text = ""; 
                tb_descricao.Text = "";
                cbx_clientes.Enabled = true ;
                btn_salvar.Text = "Salvar";
                btn_deletar.Enabled = false;
                btn_deletar.BackColor = Color.Gray;
                tab_novo.Text = "Novo Conta a Receber";
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            if (ObterSelecion(4) != "")
            {
                SendDB.Delete("DELETE FROM tb_contasAreceber WHERE id = '" + ObterSelecion(0) + "'");

                if (SendDB.isRespostaDelete)
                {
                    ObterContaAreceber(tb_busca.Text);
                    tab_contasAreceber.SelectedIndex = 0;
                    tb_valor.Text = "0,00";
                    dtp_vencimento.Text = "";
                    tb_descricao.Text = "";
                    cbx_clientes.Enabled = true;
                    btn_salvar.Text = "Salvar";
                    btn_deletar.Enabled = false;
                    btn_deletar.BackColor = Color.Gray;
                    tab_novo.Text = "Novo Conta a Receber";
                }
                else
                {
                    ObterContaAreceber(tb_busca.Text);
                    MessageBox.Show("Erro ao Deletar tente, mais tarde!");
                    tb_valor.Text = "0,00";
                    dtp_vencimento.Text = "";
                    tb_descricao.Text = "";
                    cbx_clientes.Enabled = true;
                    btn_salvar.Text = "Salvar";
                    btn_deletar.Enabled = false;
                    btn_deletar.BackColor = Color.Gray;
                    tab_novo.Text = "Novo Conta a Receber";
                }
            }
           
        }

        private void tb_busca_TextChanged(object sender, EventArgs e)
        {
            ObterContaAreceber(tb_busca.Text);
        }

        private void tb_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (SomenteNumeros.Convert(tb_valor.Text) == "")
            {
                tb_valor.Text = tb_valor.Text += "0,00";
            }

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            if (!tb_valor.Text.Contains(","))
            {
                tb_valor.Text = tb_valor.Text += ",";
            }
        }
    }
}
