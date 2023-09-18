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
    public partial class F_Gerenciamento : Form
    {
        public F_Gerenciamento()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string TipoVenda(string tipo)
        {
            switch (tipo)
            {
                case "Vendas Avista": return "Dinheiro";
                case "Venda a Prazo": return "Prazo";
                case "Vendas Canceladas": return "Cancelado";
                case "Recebimento a Prazo": return "cReceber";
                default:
                    return "Dinheiro";
            }
        }

        private DataTable ObterOrdenVendas()
        {
            string periodo1 = dtp_periodo1.Text;
            string periodo2 = dtp_periodo2.Text;

            return SendDB.Get(@"SELECT 
                               id as 'Cód de Itém',
                               codVenda as 'Cód. Venda',
                               descricao as 'Descrição',
                               preco_unitario as 'Preço Venda',
                               precoCusto as 'Preço Compra', 
                               quantidade as 'Quantidade',
                               total as 'Sub Total',
                               dataHora as 'Data Criação',
                               Cliente as 'Nome do Cliente',
                               desconto as 'Desconto',
                               tipo_de_venda as 'Tipo de Venda',
                               userFuncionario as 'Funcionario User',
                               tipoCartao as 'Tipo de cartão'
                               FROM tb_ordenVendas WHERE dataHora BETWEEN '" + periodo1 + "' AND '" + periodo2 + "' AND tipo_de_venda LIKE '%%" + TipoVenda(cbx_tipo.Text) + "%%'");
        }

        private DataTable ObterContasAreceber()
        {
            string periodo1 = dtp_periodo1.Text;
            string periodo2 = dtp_periodo2.Text;

            return SendDB.Get(@"SELECT 
                               id as 'Cód de Itém',
                               descricao as 'Descricão',
                               valor as 'Valor',
                               cliente as 'Cliente',
                               vencimento as 'Vencimento', 
                               data as 'Data Criação',
                               status as 'Status'
                               FROM tb_contasAreceber WHERE data BETWEEN '" + periodo1 + "' AND '" + periodo2 + "'");
        }

        private void F_Gerenciamento_Load(object sender, EventArgs e)
        {
          
            dtp_periodo1.Format = DateTimePickerFormat.Custom;
            dtp_periodo1.CustomFormat = "yyyy/MM/dd";

            dtp_periodo2.Format = DateTimePickerFormat.Custom;
            dtp_periodo2.CustomFormat = "yyyy/MM/dd";
            dtg_ordenVenda.DataSource = ObterOrdenVendas();
            dtg_ordenVenda.Columns[2].Width = 185;
           
        }

        private void cbx_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoVenda(cbx_tipo.Text);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dtg_ordenVenda.DataSource = ObterOrdenVendas();

            if (TipoVenda(cbx_tipo.Text) == "cReceber")
            {
                dtg_ordenVenda.DataSource = ObterContasAreceber();
                dtg_ordenVenda.Columns[1].Width = 290;
                dtg_ordenVenda.Columns[3].Width = 239;
            }
        }

        private void dtg_ordenVenda_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            float total = 0.00f;
            float desconto = 0.00f;
            float lucro = 0.00f;
            float totalRecebido = 0.00f;

            for (int i = 0; i < dtg_ordenVenda.RowCount; i++)
            {
                if (TipoVenda(cbx_tipo.Text) == "cReceber")
                {
                    totalRecebido += float.Parse(dtg_ordenVenda.Rows[i].Cells[2].Value.ToString());
                }else
                {
                    total += float.Parse(dtg_ordenVenda.Rows[i].Cells[6].Value.ToString());
                    desconto += float.Parse(dtg_ordenVenda.Rows[i].Cells[9].Value.ToString());
                    lucro += float.Parse(dtg_ordenVenda.Rows[i].Cells[4].Value.ToString());
                }
            }

            if (TipoVenda(cbx_tipo.Text) == "cReceber")
            {
                tb_totalRecebidos.Text = totalRecebido.ToString("F");
                tb_totalCancelados.Text = "0,00";
                tb_totalVendas.Text = "0,00";
                tb_totaLucros.Text = "0,00";
            }
            else
            {
                if (dtg_ordenVenda.RowCount > 0)
                {
                    tb_totalDescontos.Text = desconto.ToString("F");
                    tb_totaLucros.Text = (total - lucro).ToString("F");

                    if (TipoVenda(cbx_tipo.Text) == "Dinheiro")
                    {
                        tb_totalCancelados.Text = "0,00";
                        tb_totalVendas.Text = total.ToString("F");
                    }
                    else if (TipoVenda(cbx_tipo.Text) == "Cancelado")
                    {
                        dtg_ordenVenda.DefaultCellStyle.BackColor = Color.Crimson;
                        dtg_ordenVenda.DefaultCellStyle.ForeColor = Color.White;
                        tb_totalVendas.Text = "0,00";
                        tb_totalCancelados.Text = total.ToString("F");
                        tb_totaLucros.Text = "0,00";
                    }
                    else if (TipoVenda(cbx_tipo.Text) == "Prazo")
                    {
                        tb_totalCancelados.Text = "0,00";
                        tb_totalVendas.Text = total.ToString("F");
                    }
                }
                else
                {
                    tb_totalVendas.Text = "0,00";
                    tb_totalCancelados.Text = "0,00";
                }
            }
            
           
           
        }
    }
}
