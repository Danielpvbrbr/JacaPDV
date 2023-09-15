using MySqlX.XDevAPI;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mysql_conection
{
    public partial class F_Orcamento : Form
    {
        DataTable dt = new DataTable();
        public Boolean rowSelecionada;
        DataTable db_cliente = SendDB.Get("SELECT id, status, limiteCredito, clienteNome FROM tb_cliente;");
        public F_Orcamento()
        {
            InitializeComponent();
        }

        private void ObterOrcamentoFilter(string filtro)
        {
            dt = SendDB.Get(@"SELECT 
                            id as 'Cód. Item',
                            nome_cliente as 'Nome Cliente',
                            quantidade as 'Quantidade',
                            total as 'Total',
                            data as 'Data',
                            status as 'Status',
                            desconto as 'Desconto' 
                            FROM  tb_orcamentos WHERE nome_cliente LIKE '%%" + filtro + "%%' ");
            dtg_orcamento.DataSource = dt;
        }

        public string PegarValorTbProdutos(int i)
        {
            return dtg_produtos.SelectedRows[0].Cells[i].Value.ToString();
        }

        private void ObterProdutosFiltro(string filtro)
        {
           dt = SendDB.Get(@"SELECT 
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
            dtg_produtos.DataSource = dt;
        }

        private DataTable ObterOrdenVendas(string filtro)
        {
            return SendDB.Get(@"SELECT 
                               id,
                               descricao,
                               preco_unitario,
                               precoAtacado, 
                               precoPromocional,
                               quantidade,
                               total,
                               desconto
                               FROM tb_ordenVendas WHERE Cliente LIKE '%%" + filtro + "%%'");

        }
        private void F_Orcamento_Load(object sender, EventArgs e)
        {
            ObterOrcamentoFilter(tb_busca.Text);

            for (int i = 0; i < db_cliente.Rows.Count; i++)
            {
                string nome = db_cliente.Rows[i].Field<string>("clienteNome").ToString();
                string[] rowsNome = { nome };
                cbx_clientes.Items.AddRange(rowsNome);
            }
            cbx_clientes.Text = "Selecionar Cliente";
            tb_busca.Focus();
            dtg_produtos.Visible = false;
            btn_finalizar.Enabled = false;
            btn_finalizar.BackColor = Color.Gray;
            lb_total_item.Text = dtg_carinho.RowCount.ToString();

            AtualizarBotao(false);
        }

        private void tb_busca_TextChanged(object sender, EventArgs e)
        {
            ObterOrcamentoFilter(tb_busca.Text);
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

        private void isProdutos()
        {
            if (tb_buscaProdutos.Text != "")
            {
                dtg_produtos.Visible = true;
                ObterProdutosFiltro(tb_buscaProdutos.Text);
            }
            else
            {
                dtg_produtos.Visible = false;
            }
        }

        public void SomaTotal()
        {
            float total = 0;
            float totalDesc = 0;
            int quantLinha = dtg_carinho.Rows.Count;
            if (quantLinha >= 1)
            {
                for (int i = 0; i < quantLinha; i++)
                {
                    total += float.Parse(dtg_carinho.Rows[i].Cells[6].Value.ToString());

                    if (dtg_carinho.Rows[i].Cells[7].Value.ToString().Contains("%"))
                    {
                        totalDesc += float.Parse(CalcularPercet.Rest(SomenteNumeros.Convert(dtg_carinho.Rows[i].Cells[7].Value.ToString()), dtg_carinho.Rows[i].Cells[2].Value.ToString()).ToString());
                    }
                    else
                    {
                        totalDesc += float.Parse(dtg_carinho.Rows[i].Cells[7].Value.ToString());
                    }
                }
                tb_valorTotal.Text = total.ToString();
                tb_totalDesconto.Text = totalDesc.ToString("C");
                tb_quantidade.Text = dtg_carinho.RowCount.ToString();
            }
            else
            {
                tb_totalDesconto.Text = totalDesc.ToString("C");
            }
        }

        private void tb_buscaProdutos_TextChanged(object sender, EventArgs e)
        {
            isProdutos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            isProdutos();
        }

        private void dtg_produtos_DoubleClick(object sender, EventArgs e)
        {
            F_ConfirmCarOrc f_ConfirmCarOrc = new F_ConfirmCarOrc(this);
            f_ConfirmCarOrc.ShowDialog();
        }

        private string Line(int i, int idx)
        {
            return dtg_carinho.Rows[i].Cells[idx].Value.ToString().ToUpper();
        }
        private void LimparTextBox()
        {
            ObterOrcamentoFilter(tb_busca.Text);
            rowSelecionada = false;
            cbx_clientes.Text = "Selecionar Cliente";
            dtg_carinho.Rows.Clear();
            dtg_carinho.DataSource = null;
            tb_valorTotal.Text = "0,00";
            tb_totalDesconto.Text = "0";
            tb_quantidade.Text = "0";
        }
        public void AddOrdenVendas(int i)
        {
            string codVenda = Line(i, 0).PadLeft(5, '0');
            string descricao = Line(i, 1);
            int quantidade = int.Parse(Line(i, 5));
            string preco_unitario = Line(i, 2);
            string precoAtacado = Line(i, 3);
            string precoPromocional = Line(i, 4);
            string desconto = Line(i, 7);
            string total = Line(i, 6);
            string tipo_de_venda = "Orçamento";
            string dataHora = DataFormatada.data;
            string Cliente = cbx_clientes.Text;
            string userFuncionario = Auth.user;
            string tipoCartao = "";

            SendDB.Post("INSERT INTO tb_ordenVendas (codVenda, descricao, quantidade, preco_unitario, precoAtacado, precoPromocional, desconto, total,tipo_de_venda, dataHora, Cliente, userFuncionario, tipoCartao) VALUES ('" + codVenda + "','" + descricao + "','" + quantidade + "','" + preco_unitario + "','" + precoAtacado + "','" + precoPromocional + "','" + desconto + "','" + total + "','" + tipo_de_venda + "','" + dataHora + "','" + Cliente + "','" + userFuncionario + "','" + tipoCartao + "');");
        }

        private void AddOrcamento()
        {
            string cliente = cbx_clientes.Text;
            int quant = dtg_carinho.RowCount;
            string total = tb_valorTotal.Text;
            string data = DataFormatada.data;
            string status = "Pendente";
            string desconto = tb_totalDesconto.Text;

            SendDB.Post(@"INSERT INTO tb_orcamentos (nome_cliente, quantidade, total, data, status, desconto) 
                                VALUES ('" + cliente + "','" + quant + "','" + total + "','" + data + "','" + status + "','" + desconto + "')");

            if (SendDB.isRespostaPost)
            {
                LimparTextBox();
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (btn_salvar.Text == "Salvar")
            {
                if (cbx_clientes.Text != "Selecionar Cliente")
                {
                    for (int i = 0; i < dtg_carinho.Rows.Count; i++)
                    {
                        AddOrdenVendas(i);
                    }

                    if (SendDB.isRespostaPost)
                    {
                        AddOrcamento();
                    }
                }
                else
                {
                    cbx_clientes.Focus();
                }
            }
            else
            {
                    for (int i = 0; i < dtg_carinho.Rows.Count; i++)
                    {
                        if (dtg_carinho.Rows[i].Cells[8].Value.ToString().Contains("#"))
                        {
                            AddOrdenVendas(i);
                        }
                    }

                    if (SendDB.isRespostaPost)
                    {
                        AtualizarQuant();
                        LimparTextBox();
                        tab_orcamento.SelectedIndex = 0;
                }
            }
        }

        private void btn_deletarSelect_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ao confirma o item sera deletado da lista", "Confirma Limpeza", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                rowSelecionada = false;
                var indice = dtg_carinho.SelectedRows[0].Index;
                string id = dtg_carinho.SelectedRows[0].Cells[0].Value.ToString();
                if (indice >= 0)
                {
                    var linha = dtg_carinho.Rows[indice];
                    if (!linha.IsNewRow)
                    {
                        SendDB.Delete("DELETE FROM tb_ordenVendas WHERE id = '"+ id + "'");
                        if (SendDB.isRespostaDelete)
                        {
                            tb_valorTotal.Text = ((float.Parse(tb_valorTotal.Text) - float.Parse(Line(indice, 7))).ToString("F"));
                            dtg_carinho.Rows.Remove(linha);
                            tb_quantidade.Text = dtg_carinho.RowCount.ToString();
                            SomaTotal();
                            AtualizarQuant();
                        }
                    }
                }
                rowSelecionada = true;
            }
        }
        private void AtualizarQuant()
        {
            string quant = dtg_carinho.RowCount.ToString();
            string id = dtg_orcamento.SelectedRows[0].Cells[0].Value.ToString();

            SendDB.Update("UPDATE tb_orcamentos SET quantidade = '"+ quant + "' WHERE id = '" + id + "'");

            if (SendDB.isRespostaUpdate)
            {
                ObterOrcamentoFilter(tb_busca.Text);
            }
        }
        private void dtg_orcamento_DoubleClick(object sender, EventArgs e)
        {
            F_ConfirmCarOrc f_ConfirmCarOrc = new F_ConfirmCarOrc(this);
            string nomeCliente = dtg_orcamento.SelectedRows[0].Cells[1].Value.ToString();
            string status = dtg_orcamento.SelectedRows[0].Cells[5].Value.ToString();
            dt = ObterOrdenVendas(nomeCliente);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string[] rows = new string[] {
                      dt.Rows[i].Field<Int64>("id").ToString(), //id,
                      dt.Rows[i].Field<string>("descricao"), //descricao,
                      dt.Rows[i].Field<string>("preco_unitario"), //preco_unitario,
                      dt.Rows[i].Field<string>("precoAtacado"), //precoAtacado, 
                      dt.Rows[i].Field<string>("precoPromocional"), //precoPromocional,
                      dt.Rows[i].Field<Int64>("quantidade").ToString(), //quantidade,
                      dt.Rows[i].Field<string>("total"), //total,
                      dt.Rows[i].Field<string>("desconto"),//desconto
                      " " //Verificador de item novo incluido na tabela
                    };
                f_ConfirmCarOrc.AdicionarValorTabela(rows);
            }
            tab_NovoOrcamento.Text = "Visualizar Orçamento";
            btn_salvar.Text = "Alterar";
            tab_orcamento.SelectedIndex = 1;
            cbx_clientes.Text = nomeCliente;
            cbx_clientes.Enabled = false;

            if (status == "Pago"){
                AtualizarBotao(false);
                lb_total_item.Text = dtg_carinho.RowCount.ToString();
            }
            else
            {
                AtualizarBotao(true);
            }
        }

        private void tab_orcamento_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (tab_orcamento.SelectedIndex == 0)
              {
                  tab_NovoOrcamento.Text = "Novo Orçamento";
                  dtg_carinho.Rows.Clear();
                  dtg_carinho.DataSource = null;
                  cbx_clientes.Text = "Selecionar Cliente";
                  cbx_clientes.Enabled = true;
                  btn_salvar.Text = "Salvar";
                  tb_buscaProdutos.Enabled = true;

                  btn_finalizar.Enabled = false;
                  btn_finalizar.BackColor = Color.Gray;
                  AtualizarBotao(false);
            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            string id = dtg_orcamento.SelectedRows[0].Cells[0].Value.ToString();

            SendDB.Update("UPDATE tb_orcamentos SET status = 'Pago' WHERE id = '"+ id + "'");
        }

        private void AtualizarBotao(bool el)
        {
            btn_deletarSelect.Enabled = el;
            btn_deletarSelect.BackColor = el ? Color.Crimson : Color.Gray;
            btn_salvar.Enabled = el;
            btn_salvar.BackColor = el ? Color.Green : Color.Gray;

            if (btn_salvar.Text == "Alterar")
            {
                tb_buscaProdutos.Enabled = el;
                btn_finalizar.Enabled = el;
                btn_finalizar.BackColor = el ? Color.RoyalBlue : Color.Gray;
            }  
        }

        private void dtg_carinho_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            AtualizarBotao(true);
        }

        private void dtg_carinho_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dtg_carinho.RowCount == 0)
            {
                if (btn_salvar.Text == "Salvar")
                {
                    AtualizarBotao(false);
                }
                else
                {
                    btn_deletarSelect.Enabled = false;
                    btn_deletarSelect.BackColor = Color.Gray;
                }
            }
            
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            tab_orcamento.SelectedIndex = 1;
        }
    }
}
