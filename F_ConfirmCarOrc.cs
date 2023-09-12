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
    public partial class F_ConfirmCarOrc : Form
    {
        F_Orcamento f_Orcamento;
        public F_ConfirmCarOrc(F_Orcamento fo)
        {
            InitializeComponent();
            f_Orcamento = fo;
        }

        public void AdicionarValorTabela(string[] row)
        {
            f_Orcamento.dtg_carinho.ColumnCount = row.Length;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);

            f_Orcamento.dtg_carinho.Columns[0].Name = "Cód.item";
            f_Orcamento.dtg_carinho.Columns[1].Name = "Descrção";
            //f_Orcamento.dtg_carinho.Columns[2].Name = "Cód. barras";
            f_Orcamento.dtg_carinho.Columns[2].Name = "Preço";
            f_Orcamento.dtg_carinho.Columns[3].Name = "Preço Atacado";
            f_Orcamento.dtg_carinho.Columns[4].Name = "Preço Promoção";
            f_Orcamento.dtg_carinho.Columns[5].Name = "Quantidade";
            f_Orcamento.dtg_carinho.Columns[6].Name = "SubTotal";
            f_Orcamento.dtg_carinho.Columns[7].Name = "Desconto";

            object[] rows = new object[] { row };

            foreach (string[] rowArray in rows)
            {
                f_Orcamento.dtg_carinho.Rows.Add(rowArray);
            }

            f_Orcamento.tb_buscaProdutos.Text = "";
        }

        private void F_ConfirmCarOrc_Load(object sender, EventArgs e)
        {
            tb_coditem.Text = f_Orcamento.PegarValorTbProdutos(0);
            tb_descricao.Text = f_Orcamento.PegarValorTbProdutos(1);
            tb_quantidade.Text = "1";
            tb_precoUnitario.Text = f_Orcamento.PegarValorTbProdutos(10);
            tb_precoAtacado.Text = f_Orcamento.PegarValorTbProdutos(11);
            tb_precoPromocao.Text = f_Orcamento.PegarValorTbProdutos(12);
            tb_subTotal.Text = f_Orcamento.PegarValorTbProdutos(10);
            tb_desconto.Text = "0";
            lb_quantidade.Text = $"Quantidade({f_Orcamento.PegarValorTbProdutos(13)})";
            tb_subTotalDesconto.Text = f_Orcamento.PegarValorTbProdutos(10);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string SomaSubTotal(string quantidade)
        {
            float preco = float.Parse(f_Orcamento.PegarValorTbProdutos(10));
            return (preco * int.Parse(quantidade)).ToString();
        }

        private Boolean VerificaErroCampoo()
        {
            int numericValue;
            bool isNumber = int.TryParse(tb_desconto.Text, out numericValue);
            Boolean temPerceNoCampo = tb_desconto.Text.Contains("%");
            Boolean isLiberar = false;

            if (tb_quantidade.Text != "" && tb_desconto.Text != "" && (SomenteNumeros.Convert(tb_desconto.Text).Length > 0))
            {
                if (isNumber)
                {
                    //("Somente numero");
                    btn_Confirmar.Enabled = true;
                    btn_Confirmar.BackColor = Color.Green;
                    isLiberar = true;
                }
                else if (!isNumber && temPerceNoCampo)
                {
                    //("numero e porcentagem");
                    btn_Confirmar.Enabled = true;
                    btn_Confirmar.BackColor = Color.Green;
                    isLiberar = true;
                }
                else
                {
                    //("numero e e outro simbulo");
                    btn_Confirmar.Enabled = false;
                    btn_Confirmar.BackColor = Color.Gray;
                    isLiberar = false;
                }
            }

            return isLiberar;
        }

        private void AtuaCampo()
        {
            Boolean temPerceNoCampo = tb_desconto.Text.Contains("%");
            if (tb_quantidade.Text != "")
            {
                if (int.Parse(SomenteNumeros.Convert(tb_quantidade.Text)) <= int.Parse(f_Orcamento.PegarValorTbProdutos(13)))
                {
                    tb_quantidade.Text = SomenteNumeros.Convert(tb_quantidade.Text);
                }
                else
                {
                    MessageBox.Show("Estoque insuficiente, E nescessario reabastecer");
                    tb_quantidade.Text = f_Orcamento.PegarValorTbProdutos(13);
                }
            }


            if (VerificaErroCampoo())
            {
                tb_subTotal.Text = SomaSubTotal(SomenteNumeros.Convert(tb_quantidade.Text));

                if (temPerceNoCampo)
                {
                    tb_subTotalDesconto.Text = CalcularPercet.Valor(SomenteNumeros.Convert(tb_desconto.Text), SomaSubTotal(tb_quantidade.Text)).ToString("F");
                }
                else
                {
                    if (float.Parse(SomenteNumeros.Convert(tb_desconto.Text)) <= float.Parse(tb_subTotal.Text))
                    {
                        tb_subTotalDesconto.Text = (float.Parse(tb_subTotal.Text) - float.Parse(SomenteNumeros.Convert(tb_desconto.Text))).ToString();
                    }
                    else
                    {
                        tb_subTotalDesconto.Text = "0.00";
                    }
                }
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            f_Orcamento.rowSelecionada = true;
            string eNull = (tb_quantidade.Text == "" ? tb_quantidade.Text = "1" : tb_quantidade.Text);

            string[] row = new string[] {
                f_Orcamento.PegarValorTbProdutos(0), //"Cód.item"
                f_Orcamento.PegarValorTbProdutos(1), //"Descrção"
                //f_Orcamento.PegarValorTbProdutos(7), //"Cód. barras"
                f_Orcamento.PegarValorTbProdutos(10),//"Preço"
                f_Orcamento.PegarValorTbProdutos(11),//"Preço atacado"
                f_Orcamento.PegarValorTbProdutos(12),//"Preço Promoção"
                eNull,
                tb_subTotalDesconto.Text,
                tb_desconto.Text
                };
            AdicionarValorTabela(row);
            Close();
        }

        private void tb_quantidade_TextChanged(object sender, EventArgs e)
        {
            AtuaCampo();
        }

        private void tb_desconto_TextChanged(object sender, EventArgs e)
        {
            AtuaCampo();
        }

        private void F_ConfirmCarOrc_FormClosed(object sender, FormClosedEventArgs e)
        {
            f_Orcamento.SomaTotal();
        }

        
    }
}
