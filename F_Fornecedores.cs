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
    public partial class F_Fornecedores : Form
    {
        public F_Fornecedores()
        {
            InitializeComponent();
        }

        private DataTable ObterFornecFilter(string filter)
        {
            return SendDB.Get(@"SELECT 
                            id as 'Cód Forn',
                            nome as 'Nome Fornecedor',
                            data as 'Data Criação',
                            endereco as 'Endereço',
                            numero as 'numero',
                            bairro as 'Bairro',
                            cep as 'CEP',
                            cidade as 'Cidade',
                            uf as 'UF',
                            CNPJ,
                            telefone1 as 'Telefone1',
                            telefone2 as 'Telefone2',
                            celular_whatsApp as 'Celular WhatsApp',
                            email as 'E-mail',
                            site as 'Site',
                            nome_representante as 'Representante',
                            email_representante as 'email Represent',
                            observacao as 'Observacao'
                            FROM tb_fornecedores WHERE nome LIKE '%%" + filter + "%%'");
        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete()
        {
            string id = dtg_fornecedores.SelectedRows[0].Cells[0].Value.ToString();
            SendDB.Delete("DELETE FROM tb_fornecedores WHERE id='"+id+"' ");
            if (SendDB.isRespostaDelete)
            {
                MessageBox.Show("Registro Deletado com sucesso");
                Atualizar();
            }
        }

        private void Atualizar()
        {
            dtg_fornecedores.DataSource = ObterFornecFilter(tb_busca.Text);
            lb_totalForn.Text = dtg_fornecedores.RowCount.ToString();
            LimparCampo();
            tab_fornecedores.SelectedIndex = 0;
        }

        private void F_Fornecedores_Load(object sender, EventArgs e)
        {
            Atualizar();
            btn_deletar.Enabled = false;
            btn_deletar.BackColor = Color.Gray;
        }

        private void LimparCampo()
        {
            tb_codItem.Text = "";
            tb_nomeFornecedor.Text = "";
            tb_endereco.Text = "";
            num_numero.Value = 0 ;
            tb_bairro.Text = "";
            mask_cep.Text = "";
            tb_cidade.Text = "";
            cbx_uf.Text = "";
            mask_CNPJ.Text = "";
            mask_telefone1.Text = "";
            mask_telefone2.Text = "";
            mask_celular.Text = "";
            tb_email.Text = "";
            tb_site.Text = "";
            tb_repres.Text = "";
            tb_emailRepres.Text = "";
            tb_observacao.Text = "";

            btn_salvar.Text = "Salvar";
            btn_deletar.Enabled = false;
            btn_deletar.BackColor = Color.Gray;

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string id = tb_codItem.Text;
            string nome = tb_nomeFornecedor.Text;
            string data = DataFormatada.data;
            string endereco = tb_endereco.Text;
            string numero = num_numero.Value.ToString();
            string bairro = tb_bairro.Text;
            string cep = mask_cep.Text;
            string cidade = tb_cidade.Text;
            string uf = cbx_uf.Text;
            string cnpj = mask_CNPJ.Text;
            string telefone1 = mask_telefone1.Text;
            string telefone2 = mask_telefone2.Text;
            string celular = mask_celular.Text;
            string email = tb_email.Text;
            string site = tb_site.Text;
            string representante = tb_repres.Text;
            string emailRepres = tb_emailRepres.Text;
            string observacao = tb_observacao.Text;

            if (tb_nomeFornecedor.Text != "")
            {
                if (btn_salvar.Text == "Salvar")
                {
                    SendDB.Post("INSERT INTO tb_fornecedores (nome, data, endereco, numero, bairro, cep, cidade, uf, CNPJ, telefone1, telefone2, celular_whatsApp, email, site, nome_representante, email_representante, observacao) VALUES ('" + nome + "','" + data + "','" + endereco + "','" + numero + "','" + bairro + "','" + cep + "','" + cidade + "','" + uf + "','" + cnpj + "','" + telefone1 + "','" + telefone2 + "','" + celular + "','" + email + "','" + site + "','" + representante + "','" + emailRepres + "','" + observacao + "')");
                    if (SendDB.isRespostaPost)
                    {
                        MessageBox.Show("Registro salvo com sucesso!");
                        Atualizar();
                    }
                }
                else
                {
                    SendDB.Update("UPDATE tb_fornecedores SET nome='" + nome + "', endereco='" + endereco + "', numero='" + numero + "', bairro='" + bairro + "', cep='" + cep + "', cidade='" + cidade + "', uf='" + uf + "', CNPJ='" + cnpj + "', telefone1='" + telefone1 + "', telefone2='" + telefone2 + "', celular_whatsApp='" + celular + "', email='" + email + "', site='" + site + "', nome_representante='" + representante + "', email_representante='" + emailRepres + "', observacao='" + observacao + "' WHERE id = '"+id+"'");
                    if (SendDB.isRespostaUpdate)
                    {
                        MessageBox.Show("Registro atualizado com sucesso");                      
                        Atualizar();
                    }
                }
            }
            else
            {
                MessageBox.Show("Campo Obrigatório Vázio!");
                tb_nomeFornecedor.Focus();
            }
        }
     
        private void dtg_fornecedores_DoubleClick(object sender, EventArgs e)
        {
            btn_salvar.Text = "Alterar";
            btn_deletar.Enabled  = true;
            btn_deletar.BackColor = Color.Crimson;
            tb_codItem.Text = dtg_fornecedores.SelectedRows[0].Cells[0].Value.ToString();
            tb_nomeFornecedor.Text = dtg_fornecedores.SelectedRows[0].Cells[1].Value.ToString();
            tb_endereco.Text = dtg_fornecedores.SelectedRows[0].Cells[3].Value.ToString();
            num_numero.Value = int.Parse(dtg_fornecedores.SelectedRows[0].Cells[4].Value.ToString());
            tb_bairro.Text = dtg_fornecedores.SelectedRows[0].Cells[5].Value.ToString();
            mask_cep.Text = dtg_fornecedores.SelectedRows[0].Cells[6].Value.ToString();
            tb_cidade.Text = dtg_fornecedores.SelectedRows[0].Cells[7].Value.ToString();
            cbx_uf.Text = dtg_fornecedores.SelectedRows[0].Cells[8].Value.ToString();
            mask_CNPJ.Text = dtg_fornecedores.SelectedRows[0].Cells[9].Value.ToString();
            mask_telefone1.Text = dtg_fornecedores.SelectedRows[0].Cells[10].Value.ToString();
            mask_telefone2.Text = dtg_fornecedores.SelectedRows[0].Cells[11].Value.ToString();
            mask_celular.Text = dtg_fornecedores.SelectedRows[0].Cells[12].Value.ToString();
            tb_email.Text = dtg_fornecedores.SelectedRows[0].Cells[13].Value.ToString();
            tb_site.Text = dtg_fornecedores.SelectedRows[0].Cells[14].Value.ToString();
            tb_repres.Text = dtg_fornecedores.SelectedRows[0].Cells[15].Value.ToString();
            tb_emailRepres.Text = dtg_fornecedores.SelectedRows[0].Cells[16].Value.ToString();
            tb_observacao.Text = dtg_fornecedores.SelectedRows[0].Cells[17].Value.ToString();
            tab_fornecedores.SelectedIndex = 1;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampo();
        }

        private void btn_deletar_item_Click(object sender, EventArgs e)
        {
           
            Delete();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
