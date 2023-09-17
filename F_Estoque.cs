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
    public partial class F_Estoque : Form
    {
        int idSelected = 0;
        public F_Estoque()
        {
            InitializeComponent();
        }

       
        private void Atualizar()
        {
            dgv_produtos.DataSource = ObterProdutosFiltro(tb_busca.Text);
            LimparCampo();
            tabEstoque.SelectedIndex = 0;

            lb_quantTotal.Text = dgv_produtos.RowCount.ToString();
        }

        private DataTable ObterProdutosId(int id)
        {
            return SendDB.Get("SELECT * FROM tb_produtos WHERE id='"+id+"'");
        }

        private DataTable ObterProdutosFiltro(string filtro)
        {
            return SendDB.Get(@"SELECT 
                               id as 'Cód. Item',
                               tb_descricaoProduto as 'Descrição do Produto',
                               date as 'Data Criação',
                               tb_codInterno as 'Cód. Interno',
                               tb_typeUnidade as 'Tipo de Unidade',
                               tb_fornecedor as 'Fornecedor',
                               tb_fabricante as 'Fabricante', 
                               tb_codBarras as 'Cod. Barras',
                               tb_setor as 'Setor',
                               tb_precoCusto as 'Preço de Custo',
                               tb_precoVenda as 'Preço de Venda', 
                               tb_precoAtacado as 'Preço de Atacado',
                               tb_precoPromocao as 'Preço de Promoção', 
                               tb_estoque as 'Estoque',
                               tb_observacao as 'Observação',
                               tb_disponibilidade as 'Disponível'
                               FROM tb_produtos WHERE  tb_descricaoProduto LIKE '%%" + filtro + "%%'");
        }

        private void F_Estoque_Load(object sender, EventArgs e)
        {
            Fornecedor.add(cbx_fornecedor);
            Setor.add(cbx_setor);
            Fabricante.add(cbx_fabricante);
            tb_busca.Focus();
            VerificaCampoVazio();
            btn_delete.Enabled = false;
            btn_delete.BackColor = Color.Gray;
            rd_indisponivel.Checked = true;
            Atualizar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            tabEstoque.SelectedIndex = 1;
        }

        private void LimparCampo()
        {
            tb_id.Text = "";
            tb_descricaoProduto.Text = "";
            tb_codInterno.Text = "";
            cbx_typeUnidade.Text = "";
            cbx_fornecedor.Text = "";
            cbx_fabricante.Text = "";
            tb_codBarras.Text = "";
            cbx_setor.Text = "";
            num_precoCusto.Value = 0;
            num_precoVenda.Value = 0;
            num_precoAtacado.Value = 0;
            num_precoPromocao.Value = 0;
            numb_estoque.Value = 0;
            tb_observacao.Text = "";
            rd_disponivel.Checked = false;
            rd_indisponivel.Checked = false;
        }

        private void VerificaCampoVazio()
        {
            if (tb_descricaoProduto.Text == ""
                && numb_estoque.Value == 0
                && num_precoVenda.Value == 0)
            {
                btn_salvar.Enabled = false;
                btn_salvar.BackColor = Color.Gray;
            }
            else
            {
                btn_salvar.Enabled = true;
                btn_salvar.BackColor = Color.Green;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string descricaoProduto = tb_descricaoProduto.Text;
            string codInterno = tb_codInterno.Text;
            string typeUnidade = cbx_typeUnidade.Text;
            string fornecedor = cbx_fornecedor.Text;
            string fabricante = cbx_fabricante.Text;
            string codBarras = tb_codBarras.Text;
            string setor = cbx_setor.Text;
            Decimal precoCusto = num_precoCusto.Value;
            Decimal precoVenda = num_precoVenda.Value;
            Decimal precoAtacado = num_precoAtacado.Value;
            Decimal precoPromocao = num_precoPromocao.Value;
            Decimal estoque = numb_estoque.Value;
            string observacao = tb_observacao.Text;
            string disponibilidade = rd_disponivel.Checked ? "Disponível" : "Indisponível";

            if (btn_salvar.Text == "Salvar")
            {
                SendDB.Post(@"INSERT INTO tb_produtos 
                        (tb_descricaoProduto,
                        tb_codInterno,
                        tb_typeUnidade,
                        tb_fornecedor,
                        tb_fabricante,
                        tb_codBarras,
                        tb_setor,
                        tb_precoCusto,
                        tb_precoVenda,
                        tb_precoAtacado,
                        tb_precoPromocao,
                        tb_estoque,
                        tb_email,
                        tb_site,
                        tb_observacao,
                        tb_disponibilidade
                        ) VALUES ('" + descricaoProduto + "','" + codInterno + "', '" + typeUnidade + "', '" + fornecedor + "', '" + fabricante + "', '" + codBarras + "','" + setor + "', '" + precoCusto + "', '" + precoVenda + "','" + precoAtacado + "', '" + precoPromocao + "', '" + estoque + "', '" + observacao + "', '" + disponibilidade + "')");
            }
            else
            {
                if (idSelected >= 1)
                {
                    SendDB.Update(@"UPDATE tb_produtos SET tb_descricaoProduto='" + descricaoProduto + "', tb_codInterno = '" + codInterno + "', tb_typeUnidade = '" + typeUnidade + "', tb_fornecedor = '" + fornecedor + "', tb_fabricante = '" + fabricante + "', tb_codBarras = '" + codBarras + "', tb_setor = '" + setor + "', tb_precoCusto = '" + precoCusto + "', tb_precoVenda = '" + precoVenda + "', tb_precoAtacado = '" + precoAtacado + "', tb_precoPromocao = '" + precoPromocao + "', tb_estoque = '" + estoque + "', tb_observacao = '" + observacao + "', tb_disponibilidade = '" + disponibilidade + "' WHERE id='"+idSelected+"'");
                }
                else
                {
                    btn_salvar.Enabled = false;
                    btn_salvar.BackColor = Color.Gray;
                }
            }
            
            Atualizar();
        }

        private void tb_descricaoProduto_TextChanged(object sender, EventArgs e)
        {
            VerificaCampoVazio();
        }

        private void numb_estoque_ValueChanged(object sender, EventArgs e)
        {
            if (numb_estoque.Value >= 1)
            {
                rd_disponivel.Checked = true;
            }
            else
            {
                rd_indisponivel.Checked = true;
            }
        }

        private void tb_busca_TextChanged(object sender, EventArgs e)
        {
            dgv_produtos.DataSource = ObterProdutosFiltro(tb_busca.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusão do Produto?", "Excluir Produto",MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                SendDB.Delete("DELETE FROM tb_produtos WHERE id='" + idSelected + "'");
                tabEstoque.SelectedIndex = 0;
                Atualizar();
            }
        }

        private void dgv_produtos_MouseClick(object sender, MouseEventArgs e)
        {
            {
                DataTable dt = new DataTable();
                int id = int.Parse(dgv_produtos.SelectedRows[0].Cells[0].Value.ToString());
                idSelected = id;
                dt = ObterProdutosId(id);

                tb_id.Text = id.ToString();
                tb_descricaoProduto.Text = dt.Rows[0].Field<string>("tb_descricaoProduto");
                tb_codInterno.Text = dt.Rows[0].Field<string>("tb_codInterno");
                cbx_typeUnidade.Text = dt.Rows[0].Field<string>("tb_typeUnidade");
                cbx_fornecedor.Text = dt.Rows[0].Field<string>("tb_fornecedor");
                cbx_fabricante.Text = dt.Rows[0].Field<string>("tb_fabricante");
                tb_codBarras.Text = dt.Rows[0].Field<string>("tb_codBarras");
                cbx_setor.Text = dt.Rows[0].Field<string>("tb_setor");
                num_precoCusto.Value = Convert.ToDecimal(dt.Rows[0].Field<string>("tb_precoCusto"));
                num_precoVenda.Value = Convert.ToDecimal(dt.Rows[0].Field<string>("tb_precoVenda"));
                num_precoAtacado.Value = Convert.ToDecimal(dt.Rows[0].Field<string>("tb_precoAtacado"));
                num_precoPromocao.Value = Convert.ToDecimal(dt.Rows[0].Field<string>("tb_precoPromocao"));
                numb_estoque.Value = dt.Rows[0].Field<Int64>("tb_estoque");
                tb_observacao.Text = dt.Rows[0].Field<string>("tb_observacao");
                string disponibilidade = dt.Rows[0].Field<string>("tb_disponibilidade");

                if (disponibilidade == "Disponível")
                {
                    rd_disponivel.Checked = true;
                }
                else
                {
                    rd_indisponivel.Checked = true;
                }

                btn_delete.Enabled = true;
                btn_delete.BackColor = Color.Crimson;
                tabEstoque.SelectedIndex = 1;
                btn_salvar.Text = "Alterar";
            }
        }

        private void btn_limparCampo_Click(object sender, EventArgs e)
        {
            LimparCampo();
            tabEstoque.SelectedIndex = 0;
        }
    }
}
