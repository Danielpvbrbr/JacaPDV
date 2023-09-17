using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace mysql_conection
{
    public partial class F_Venda : Form
    {
       public Boolean rowSelecionada;

        public F_Venda()
        {
            InitializeComponent();
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

        private void F_Venda_Load(object sender, EventArgs e)
        {
            time_DataHora.Start();
            tb_buscaProduto.Focus();
            btn_finalizarVenda.BackColor = Color.Gray;
            btn_finalizarVenda.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           Close(); 
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void StatusCaixa()
        {
            if (dt_cart_item.Rows.Count > 0)
            {
                lb_caixaLive.Text = "CAIXA OCUPADO";
                lb_caixaLive.BackColor = Color.Crimson;
                lb_caixaLive.ForeColor = Color.White;

                btn_finalizarVenda.BackColor = Color.Green;
                btn_finalizarVenda.Enabled = true;
            }
            else
            {
                lb_caixaLive.Text = "CAIXA LIVRE";
                lb_caixaLive.BackColor = Color.White;
                lb_caixaLive.ForeColor = Color.Black;

                btn_finalizarVenda.BackColor = Color.Gray;
                btn_finalizarVenda.Enabled = false;
                tb_valorTotal.Text = "0,00";
                tb_totalDesconto.Text = "0,00";

            }
        }

        private void tb_buscaProduto_TextChanged(object sender, EventArgs e)
        {
            StatusCaixa();

            if (tb_buscaProduto.Text != "")
            {
                dt_tabelaDeProdutos.DataSource = ObterProdutosFiltro(tb_buscaProduto.Text);
                dt_tabelaDeProdutos.Visible = true;
            }
            else
            {
                dt_tabelaDeProdutos.Visible = false;
            }
        }

        private void btn_Localizar_Click(object sender, EventArgs e)
        {
            F_Estoque f_Estoque = new F_Estoque();
            f_Estoque.ShowDialog();
        }

        private void btn_contaCliente_Click(object sender, EventArgs e)
        {
            F_Cliente f_Cliente = new F_Cliente();
            f_Cliente.ShowDialog();
        }

        private void btn_sairPdv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Close();
            }
        }

        private void btn_orcamento_Click(object sender, EventArgs e)
        {
            F_Orcamento f_Orcamento = new F_Orcamento();
            f_Orcamento.ShowDialog();
        }

        private void F_Venda_KeyDown(object sender, KeyEventArgs e)
        {
            F_Estoque f_Estoque = new F_Estoque();
            F_Orcamento f_Orcamento = new F_Orcamento();
            F_Cliente f_Cliente = new F_Cliente();
            switch (e.KeyCode)
            {
                case Keys.F3:
                    f_Estoque.ShowDialog();
                    break;
                case Keys.F6:
                    f_Cliente.ShowDialog();
                    break;
                case Keys.F7:
                    f_Orcamento.ShowDialog();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        private void tb_buscaProduto_KeyDown(object sender, KeyEventArgs e)
        {
            F_Estoque f_Estoque = new F_Estoque();
            F_Orcamento f_Orcamento = new F_Orcamento();
            F_Cliente f_Cliente = new F_Cliente();

            switch (e.KeyCode)
            {  
                case Keys.F3:
                    f_Estoque.ShowDialog();
                    break;
                case Keys.F6:
                    f_Cliente.ShowDialog();
                    break;
                case Keys.F7:
                    f_Orcamento.ShowDialog();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        public string Teste(int i, int ex)
        {
            return dt_cart_item.Rows[i].Cells[ex].Value.ToString();
        }

        public string PegarValorTabela(int i)
        {
            return dt_cart_item.SelectedRows[0].Cells[i].Value.ToString();
        }

        public string PegarValorTbProdutos(int i)
        {
            return dt_tabelaDeProdutos.SelectedRows[0].Cells[i].Value.ToString();
        }

        private void dt_tabelaDeProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            rowSelecionada = true;
            if (int.Parse(PegarValorTbProdutos(13)) > 0)
            {
            
                F_ConfirProdutoCar f_ConfirProdutoCar = new F_ConfirProdutoCar(this);
                f_ConfirProdutoCar.ShowDialog();

            }else {
                MessageBox.Show("Estoque insuficiente, E nescessario reabastecer");
            }
        }

        private void dt_cart_item_SelectionChanged(object sender, EventArgs e)
        {
            if (rowSelecionada)
            {
                tb_mostraNomeItem.Text = PegarValorTabela(1);
                tb_quant.Text = PegarValorTabela(6);
                tb_codBarras.Text = PegarValorTabela(2);
                tb_precoUnitario.Text = PegarValorTabela(3);
                tb_subTotal.Text = PegarValorTabela(7);
                StatusCaixa();
            }
            else
            {
                tb_mostraNomeItem.Text = "";
                tb_quant.Text = "0";
                tb_codBarras.Text = "000000000";
                tb_precoUnitario.Text = "R$ 0,00";
                tb_subTotal.Text = "R$ 0,00";
                StatusCaixa();
            }
        }

        public void SomaTotal()
        {
            float total = 0;
            float totalDesc = 0;
            int quantLinha = dt_cart_item.Rows.Count;
            if (quantLinha >= 1)
            {
                for (int i = 0; i < quantLinha; i++)
                {
                    total += float.Parse(dt_cart_item.Rows[i].Cells[7].Value.ToString());

                    if (dt_cart_item.Rows[i].Cells[8].Value.ToString().Contains("%"))
                    {
                        totalDesc += float.Parse(CalcularPercet.Rest(SomenteNumeros.Convert(dt_cart_item.Rows[i].Cells[8].Value.ToString()), dt_cart_item.Rows[i].Cells[3].Value.ToString()).ToString());
                    }
                    else
                    {
                        totalDesc += float.Parse(dt_cart_item.Rows[i].Cells[8].Value.ToString());
                    }    
                }
                tb_valorTotal.Text = total.ToString();
                tb_totalDesconto.Text = totalDesc.ToString("C");
            }
        }

        private void time_DataHora_Tick(object sender, EventArgs e)
        {
            var data = DateTime.Now;
            lb_dataHora.Text = data.ToString();
        }

        private void btn_finalizarVenda_Click(object sender, EventArgs e)
        {
            F_FinalizarCompras f_FinalizarCompras = new F_FinalizarCompras(this);
            f_FinalizarCompras.ShowDialog();
        }

        private void btn_cancelarItem_Click(object sender, EventArgs e)
        {
            if (dt_cart_item.RowCount > 0)
            {
                rowSelecionada = false;
                var indice = dt_cart_item.SelectedRows[0].Index;
                if (indice >= 0)
                {
                    var linha = dt_cart_item.Rows[indice];
                    if (!linha.IsNewRow)
                    {
                        tb_valorTotal.Text = (float.Parse(tb_valorTotal.Text) - float.Parse(PegarValorTabela(7))).ToString("F");
                        dt_cart_item.Rows.Remove(linha);
                    }
                }
                rowSelecionada = true;
            }
            else
            {
                MessageBox.Show("Sem valor");
            }
        }

        public void AddOrdenVendas(int i)
        {
            string codVenda = Teste(i, 0).PadLeft(5, '0');
            string descricao = Teste(i, 1).ToUpper();
            int quantidade = int.Parse(Teste(i, 6));
            string preco_unitario = Teste(i, 3);
            string precoAtacado = Teste(i, 4);
            string precoPromocional = Teste(i, 5);
            string desconto = Teste(i, 8);
            string total = Teste(i, 7);
            string tipo_de_venda = "Cancelado";
            string dataHora = DataFormatada.dataReverse;
            string Cliente = "";
            string userFuncionario = Auth.user;
            string tipoCartao = "";
          
            SendDB.Post("INSERT INTO tb_ordenVendas (codVenda, descricao, quantidade, preco_unitario, precoAtacado, precoPromocional, desconto, total,tipo_de_venda, dataHora, Cliente, userFuncionario, tipoCartao) VALUES ('" + codVenda + "','" + descricao + "','" + quantidade + "','" + preco_unitario + "','" + precoAtacado + "','" + precoPromocional + "','" + desconto + "','" + total + "','" + tipo_de_venda + "','" + dataHora + "','" + Cliente + "','" + userFuncionario + "','" + tipoCartao + "');");
        }

        private void btn_cancelarVenda_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ao confirma o Carrinho sera Limpado","Confirma Limpeza", MessageBoxButtons.YesNo) ;
            if (res == DialogResult.Yes)
            {
                for (int i = 0; i < dt_cart_item.Rows.Count; i++)
                {
                    AddOrdenVendas(i);
                }

                if (SendDB.isRespostaPost)
                {
                    rowSelecionada = false;
                    dt_cart_item.Rows.Clear();
                    dt_cart_item.DataSource = null;
                    StatusCaixa();
                }
              
            }
        }
    }
}
