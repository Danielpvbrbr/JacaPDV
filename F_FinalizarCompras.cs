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
    public partial class F_FinalizarCompras : Form
    {
        F_Venda f_ConfirProdDados;
        DataGridViewRowCollection rows;
        string tipoPagamento = "";
        DataTable db_cliente = SendDB.Get("SELECT id, status, limiteCredito, clienteNome FROM tb_cliente;");

        public F_FinalizarCompras(F_Venda fc)
        {
            InitializeComponent();
            f_ConfirProdDados = fc;
            rows = f_ConfirProdDados.dt_cart_item.Rows;
        }

       private string Line(int i, int idx)
        {
            return rows[i].Cells[idx].Value.ToString().ToUpper();
        }

        private void F_FinalizarCompras_Load(object sender, EventArgs e)
        {
            f_ConfirProdDados.rowSelecionada = false;
            tb_totalApagar.Text = f_ConfirProdDados.tb_valorTotal.Text;
            gpb_tipoDeCartao.Visible = false;
            gpb_infoCliente.Visible = false;

            btn_finalizar.Enabled = false;
            btn_finalizar.BackColor = Color.Gray;
            tipoPagamento = "Dinheiro";
            rdb_credito.Checked = true;

            string titulo =
                $"\n   {Auth.slogan}\r\n" +
                $"   {Auth.endereco} Nº.{Auth.numero} {Auth.bairro}\r\n" +
                $"   {Auth.cidade} - \r\n" +
                $"   CNPJ: {Auth.CNPJ}\r\n" +
                $"   DATA / HORA: {f_ConfirProdDados.lb_dataHora.Text}\r" +
                "\n   =======================================================\n" +
                "   COMPROVANTE NÃO FISCAL ELETRÔNICA" +
                "\n   =======================================================\r\n"+
                "   #  |  CÓD  |  DESCRICAO  |  QTD  |  UN  |  VL UNIT(R$)  |  SUBTOTAL\r\n" +
                "   --------------------------------------------------------------------------------------------------------------\r\n";
            Rtb_notaFiscal.SelectionAlignment = HorizontalAlignment.Left;
            Rtb_notaFiscal.SelectionFont = new Font("Lucinda Console", 8);
            Rtb_notaFiscal.SelectedText = titulo;

            for (int i = 0; i < rows.Count; i++)
            {
                Rtb_notaFiscal.SelectedText = $"  {i.ToString().PadLeft(4, '0')}    {Line(i, 0).PadLeft(5, '0')}    {Line(i, 1).Substring(0, (Line(i, 1).Length >= 22) ?  22: Line(i, 1).Length) }    {Line(i, 6)}    {"Un"}    {Line(i, 3)}    {Line(i, 7)}\n";
            }

            string rodape =
               "\n   =======================================================\r\n" +
               $"   QTD TOTAL DE ITENS                                                                {rows.Count.ToString().PadLeft(4, '0')}\r\n" +
               $"   VALOR TOTAL                                                                     R$ {f_ConfirProdDados.tb_valorTotal.Text}\r\n";
            Rtb_notaFiscal.SelectedText = rodape;

            Clientes.add(cbx_clientes);

        }
        private void InfoCliente(DataTable cbx, int i)
        {
            //string status = db_cliente.Rows[i].Field<string>("status").ToString();
            tb_limite.Text = float.Parse(cbx.Rows[i].Field<String>("limiteCredito")).ToString("F");

            if(tipoPagamento == "Prazo")
            {
                if (float.Parse(tb_limite.Text) >= float.Parse(tb_totalApagar.Text))
                {
                    tb_limiteRest.Text = ((float.Parse(tb_limite.Text) - float.Parse(tb_totalApagar.Text))).ToString("F");
                    tb_limite.ForeColor = Color.SpringGreen;
                    btn_finalizar.Enabled = true;
                    btn_finalizar.BackColor = Color.Green;
                    tb_valorPago.ForeColor = Color.White;
                }
                else
                {
                    tb_limite.ForeColor = Color.Crimson;
                    btn_finalizar.Enabled = false;
                    btn_finalizar.BackColor = Color.Gray;
                    tb_valorPago.ForeColor = Color.Red;
                }
            }
            
        }

        private void btn_retonar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void IsBtnTipoPagamento(string vBtn)
        {
            switch (vBtn) {
                case "din":
                    btn_dinheiro.Enabled = true;
                    gpb_infoCliente.Visible = false;
                    gpb_entradaTroco.Visible = true;
                    gpb_tipoDeCartao.Visible = false;
                    btn_cartao.BackColor = Color.Gray;
                    btn_dinheiro.BackColor = Color.Green;
                    btn_prazo.BackColor = Color.Gray;
                    tipoPagamento = "Dinheiro";
                    tb_limite.Text = "0,00";
                    tb_limiteRest.Text = "0,00";
                    cbx_clientes.Text = "Selecionar Cliente";
                    break;
                case "cart":
                    gpb_tipoDeCartao.Visible = true;
                    gpb_infoCliente.Visible = false;
                    btn_cartao.Enabled = true;
                    gpb_entradaTroco.Visible = false;
                    btn_cartao.BackColor = Color.Green;
                    btn_dinheiro.BackColor = Color.Gray;
                    btn_prazo.BackColor = Color.Gray;
                    tipoPagamento = "Cartão";
                    tb_limite.Text = "0,00";
                    tb_limiteRest.Text = "0,00";
                    cbx_clientes.Text = "Selecionar Cliente";
                    break;
                case "praz":
                    btn_prazo.Enabled = true;
                    gpb_infoCliente.Visible = true;
                    gpb_entradaTroco.Visible = false;
                    gpb_tipoDeCartao.Visible = false;
                    btn_cartao.BackColor = Color.Gray;
                    btn_dinheiro.BackColor = Color.Gray;
                    btn_prazo.BackColor = Color.Green;
                    tipoPagamento = "Prazo";
                    break;
            }

        }
        private void btn_dinheiro_Click(object sender, EventArgs e)
        {
            IsBtnTipoPagamento("din");
        }

        private void btn_cartao_Click(object sender, EventArgs e)
        {
            IsBtnTipoPagamento("cart");
        }

        private void btn_prazo_Click(object sender, EventArgs e)
        {
            IsBtnTipoPagamento("praz");
        }

        private void tb_valorPago_KeyPress(object sender, KeyPressEventArgs e)
        {

           if(SomenteNumeros.Convert(tb_valorPago.Text) == ""){
                tb_valorPago.Text = tb_valorPago.Text += "0,00";
           }

           if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
           {
                e.Handled = true;
           }

           if (!tb_valorPago.Text.Contains(","))
           {
                tb_valorPago.Text = tb_valorPago.Text += ",";
           }
        }

        private void tb_valorPago_TextChanged(object sender, EventArgs e)
        {

            if (tb_valorPago.Text != "" && SomenteNumeros.Convert(tb_valorPago.Text) != "")
            {
                if (float.Parse(SomenteNumeros.Convert(tb_valorPago.Text)) >= float.Parse(SomenteNumeros.Convert(tb_totalApagar.Text)))
                {
                    float somarTroca = float.Parse(tb_totalApagar.Text) - (float.Parse(tb_valorPago.Text));
                    Boolean isNegativo = somarTroca.ToString("F").Contains("-");

                    if (isNegativo)
                    {
                        tb_troco.Text = somarTroca.ToString("F").Trim(new Char[] { '-' });
                    }
                    else
                    {
                        tb_troco.Text = somarTroca.ToString("F");
                    }

                    btn_finalizar.Enabled = true;
                    btn_finalizar.BackColor = Color.Green;
                    tb_valorPago.ForeColor = Color.White;
                }
                else
                {
                    tb_troco.Text = "0,00";
                    btn_finalizar.Enabled = false;
                    btn_finalizar.BackColor = Color.Gray;
                    tb_valorPago.ForeColor = Color.Red;
                }

            }

        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
      
            for (int i = 0; i < rows.Count; i++)
            {
                DataTable db = new DataTable();
                db = SendDB.Get("SELECT tb_estoque  From tb_produtos WHERE id='" + Line(i, 0).ToString() + "'");
                string qtdDb = db.Rows[0].Field<Int64>("tb_estoque").ToString();
                int qtdRest;

                qtdRest = int.Parse(qtdDb) - int.Parse(Line(i, 6));

                string codVenda = Line(i, 0).PadLeft(5, '0');
                string descricao = Line(i, 1);
                int quantidade = int.Parse(Line(i, 6));
                string preco_unitario = Line(i, 3);
                string precoAtacado = Line(i, 4);
                string precoPromocional = Line(i, 5);
                string desconto = Line(i, 8);
                string total = Line(i, 7);
                string tipo_de_venda = tipoPagamento;
                string dataHora = DataFormatada.dataReverse;
                string Cliente = cbx_clientes.Text;
                string userFuncionario = Auth.user;
                string tipoCartao = "";

                SendDB.Update("UPDATE tb_produtos SET tb_estoque='"+ qtdRest + "' WHERE id='"+ Line(i, 0) + "'");
                SendDB.Post("INSERT INTO tb_ordenVendas (codVenda, descricao, quantidade, preco_unitario, precoAtacado, precoPromocional, desconto, total,tipo_de_venda, dataHora, Cliente, userFuncionario, tipoCartao) VALUES ('" + codVenda + "','" + descricao + "','" + quantidade + "','" + preco_unitario + "','" + precoAtacado + "','" + precoPromocional + "','" + desconto + "','" + total + "','" + tipo_de_venda + "','" + dataHora + "','" + Cliente + "','" + userFuncionario + "','"+ tipoCartao + "');");
               
                if (tipoPagamento == "Prazo")
                {
                    string id = db_cliente.Rows[cbx_clientes.SelectedIndex].Field<Int64>("id").ToString();
                    SendDB.Update("UPDATE tb_cliente SET limiteCredito='" + tb_limiteRest.Text + "' WHERE id='" + id + "'");
                }
            }

            if (SendDB.isRespostaPost)
            {
                f_ConfirProdDados.rowSelecionada = false;
                f_ConfirProdDados.dt_cart_item.Rows.Clear();
                f_ConfirProdDados.dt_cart_item.DataSource = null;
                f_ConfirProdDados.StatusCaixa();

                Close();
            }
        }

        private void cbx_clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cbx_clientes.SelectedIndex;
            InfoCliente(db_cliente, idx);

        }
    }
}
