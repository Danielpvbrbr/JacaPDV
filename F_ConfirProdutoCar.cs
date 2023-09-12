using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace mysql_conection
{
    public partial class F_ConfirProdutoCar : Form
    {
        F_Venda fp_Vendas;

        public F_ConfirProdutoCar(F_Venda fp)
        {
            InitializeComponent();
            fp_Vendas = fp;
        }

        public string PegarValorTabela(int i)
        {
            return fp_Vendas.dt_tabelaDeProdutos.SelectedRows[0].Cells[i].Value.ToString();
        }

        public void AdicionarValorTabela(string[] row)
        {
         
            fp_Vendas.dt_cart_item.ColumnCount = row.Length;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);

            fp_Vendas.dt_cart_item.Columns[0].Name = "Cód.item";
            fp_Vendas.dt_cart_item.Columns[1].Name = "Descrção";
            fp_Vendas.dt_cart_item.Columns[2].Name = "Cód. barras";
            fp_Vendas.dt_cart_item.Columns[3].Name = "Preço";
            fp_Vendas.dt_cart_item.Columns[4].Name = "Preço Atacado";
            fp_Vendas.dt_cart_item.Columns[5].Name = "Preço Promoção";
            fp_Vendas.dt_cart_item.Columns[6].Name = "Quantidade";
            fp_Vendas.dt_cart_item.Columns[7].Name = "SubTotal";
            fp_Vendas.dt_cart_item.Columns[8].Name = "Desconto";
            object[] rows = new object[] { row };

            foreach (string[] rowArray in rows)
            {
                fp_Vendas.dt_cart_item.Rows.Add(rowArray);
            }

            fp_Vendas.tb_buscaProduto.Text = "";
        }

        private void F_ConfirProdutoCar_Load(object sender, EventArgs e)
        {
            tb_coditem.Text = PegarValorTabela(0);
            tb_descricao.Text = PegarValorTabela(1);
            tb_quantidade.Text = "1";
            tb_precoUnitario.Text = PegarValorTabela(10);
            tb_precoAtacado.Text = PegarValorTabela(11);
            tb_precoPromocao.Text = PegarValorTabela(12);
            tb_subTotal.Text = PegarValorTabela(10);
            tb_desconto.Text = "0";
            lb_quantidade.Text = $"Quantidade({PegarValorTabela(13)})";
            tb_subTotalDesconto.Text = PegarValorTabela(10);
          ;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string  SomaSubTotal(string quantidade)
        {
            float preco = float.Parse(PegarValorTabela(10));
            return (preco * int.Parse(quantidade)).ToString();
        }

        //private string SomentNumeros(string v)
        //{
        //    return String.Join("", System.Text.RegularExpressions.Regex.Split(v, @"[^\d]"));
        //}

        //public double CalcularPerce(string N1, string N2)
        //{
        //    double calc = ((double.Parse(N1)) * (double.Parse(N2)) / 100 - (double.Parse(N2)));

        //    return (calc *= -1);
        //}

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
                    Btn_Confirmar.Enabled = true;
                    Btn_Confirmar.BackColor = Color.Green;
                    isLiberar = true;
                }
                else if (!isNumber && temPerceNoCampo)
                {
                    //("numero e porcentagem");
                    Btn_Confirmar.Enabled = true;
                    Btn_Confirmar.BackColor = Color.Green;
                    isLiberar = true;
                }
                else
                {
                    //("numero e e outro simbulo");
                    Btn_Confirmar.Enabled = false;
                    Btn_Confirmar.BackColor = Color.Gray;
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
                if (int.Parse(SomenteNumeros.Convert(tb_quantidade.Text)) <= int.Parse(PegarValorTabela(13)))
                {
                    tb_quantidade.Text = SomenteNumeros.Convert(tb_quantidade.Text);
                }
                else
                {
                    MessageBox.Show("Estoque insuficiente, E nescessario reabastecer");
                    tb_quantidade.Text = PegarValorTabela(13);
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
        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            fp_Vendas.rowSelecionada = true;
            string eNull = (tb_quantidade.Text == "" ? tb_quantidade.Text = "1" : tb_quantidade.Text);

            string[] row = new string[] {
                PegarValorTabela(0), //"Cód.item"
                PegarValorTabela(1), //"Descrção"
                PegarValorTabela(7), //"Cód. barras"
                PegarValorTabela(10),//"Preço"
                PegarValorTabela(11),//"Preço atacado"
                PegarValorTabela(12),//"Preço Promoção"
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

        private void F_ConfirProdutoCar_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp_Vendas.SomaTotal();
         
        }

    }
}
