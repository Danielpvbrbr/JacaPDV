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
                    return "";
            }
        }

        private DataTable ObterOrdenVendas()
        {
            string periodo1 = dtp_periodo1.Text;
            string periodo2 = dtp_periodo2.Text;
            string tipo = cbx_tipo.Text;

            return SendDB.Get(@"SELECT 
                               id as 'Cód de Itém',
                               codVenda as 'Cód. Venda',
                               descricao as 'Descrição',
                               preco_unitario as 'Preço',
                               precoAtacado as 'Preço Atacado', 
                               precoPromocional as 'Preço Promocional',
                               quantidade as 'Quantidade',
                               total as 'Sub Total',
                               dataHora as 'Data Criação',
                               Cliente as 'Nome do Cliente',
                               desconto as 'Desconto',
                               tipo_de_venda as 'Tipo de Venda',
                               userFuncionario as 'Funcionario User',
                               tipoCartao as 'Tipo de cartão'
                               FROM tb_ordenVendas WHERE dataHora BETWEEN '" + dtp_periodo1 + "' AND '" + dtp_periodo2 + "' AND tipo_de_venda LIKE '%%" + TipoVenda(cbx_tipo.Text) + "%%'");
        }

        private void F_Gerenciamento_Load(object sender, EventArgs e)
        {
            dtg_ordenVenda.DataSource = ObterOrdenVendas();
            dtg_ordenVenda.Columns[0].Width = 90;
            dtg_ordenVenda.Columns[1].Width = 87;
            dtg_ordenVenda.Columns[2].Width = 185;
            dtg_ordenVenda.Columns[3].Width = 70;
            dtg_ordenVenda.Columns[4].Width = 102;
            dtg_ordenVenda.Columns[5].Width = 123;
            dtg_ordenVenda.Columns[6].Width = 85;
            dtg_ordenVenda.Columns[7].Width = 82;
            dtg_ordenVenda.Columns[8].Width = 94;
            dtg_ordenVenda.Columns[9].Width = 185;
            dtg_ordenVenda.Columns[10].Width = 77;
            dtg_ordenVenda.Columns[11].Width = 105;
            dtg_ordenVenda.Columns[12].Width = 110;

            dtp_periodo1.Format = DateTimePickerFormat.Custom;
            dtp_periodo1.CustomFormat = "yyyy/MM/dd";

            dtp_periodo2.Format = DateTimePickerFormat.Custom;
            dtp_periodo2.CustomFormat = "yyyy/MM/dd";
       
        }

        private void cbx_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoVenda(cbx_tipo.Text);
        }
    }
}
