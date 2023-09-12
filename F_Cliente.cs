using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace mysql_conection
{
    public partial class F_Cliente : Form
    {
        public F_Cliente()
        {
            InitializeComponent();
        }

        private string tipoFilter()
        {
            switch (cbx_filterBusca.Text)
            {
                case "Nome": return "clienteNome";
                case "Código": return "id";
                case "Celular": return "celular";
                case "Email": return "email";
                default: return "clienteNome";
            }
        }

        private DataTable PegaUsuariosFilter(string filter)
        {

            return SendDB.Get(@"SELECT 
                            id as 'Cód Item',
                            clienteNome as 'Nome Cliente',
                            data as 'Data Criação',
                            apelido as 'Apelido',
                            endereco as 'Endereço',
                            numero as 'Número',
                            bairro as 'Bairro',
                            cidade as 'Cidade',
                            cep as 'CEP',
                            uf as 'UF',
                            cpf_cnpj as 'CPF/CNPJ',
                            telefone as 'Telefone',
                            celular as 'Celular',
                            limiteCredito as 'Limite',
                            prazo as 'Prazo',
                            email as 'E-Mail',
                            site as 'Site',
                            observacao as 'Observacão',
                            status as 'Status',
                            tipoCliente as 'Tipo Cliente'
                            FROM tb_cliente WHERE "+ tipoFilter() + " LIKE '%%" + filter + "%%' ");
        }

        private void F_Cliente_Load(object sender, EventArgs e)
        {

            mask_Cnpj.Visible = false;
            mask_cpf.Visible = true;
            dtg_usuarios.DataSource = PegaUsuariosFilter(tb_busca.Text);
            lb_totalCliente.Text = dtg_usuarios.RowCount.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void LimparCampo()
        {
            tb_codCliente.Text = "";
            tb_nome.Text = "";
            dtp_data.Text = "";
            tb_apelido.Text = "";
            tb_endereco.Text = "";
            num_Numero.Value = 0;
            tb_bairro.Text = "";
            tb_cidade.Text = "";
            mask_cep.Text = "";
            cbx_uf.Text = "";
            mask_cpf.Text = "";
            mask_Cnpj.Text = "";
            mask_telefone.Text = "";
            mask_celular.Text = "";
            mask_limite.Text = "";
            mask_prazo.Text = "";
            tb_email.Text = "";
            tb_site.Text = "";
            tb_observacao.Text = "";
            rdb_ativo.Checked = true;
            rdb_fisica.Checked = true;
        }

        private void PrenchimentoCampo()
        {
            
            LimparCampo();
            tb_codCliente.Text = dtg_usuarios.SelectedRows[0].Cells[0].Value.ToString();
            tb_nome.Text = dtg_usuarios.SelectedRows[0].Cells[1].Value.ToString();
            dtp_data.Text = dtg_usuarios.SelectedRows[0].Cells[2].Value.ToString();
            tb_apelido.Text = dtg_usuarios.SelectedRows[0].Cells[3].Value.ToString();
            tb_endereco.Text = dtg_usuarios.SelectedRows[0].Cells[4].Value.ToString(); ;
            num_Numero.Value = int.Parse(dtg_usuarios.Rows[0].Cells[5].Value.ToString());
            tb_bairro.Text = dtg_usuarios.SelectedRows[0].Cells[6].Value.ToString();
            tb_cidade.Text = dtg_usuarios.SelectedRows[0].Cells[7].Value.ToString();
            mask_cep.Text = dtg_usuarios.SelectedRows[0].Cells[8].Value.ToString();
            cbx_uf.Text = dtg_usuarios.SelectedRows[0].Cells[9].Value.ToString();
            mask_cpf.Text = dtg_usuarios.SelectedRows[0].Cells[10].Value.ToString();
            mask_Cnpj.Text = dtg_usuarios.SelectedRows[0].Cells[10].Value.ToString();
            mask_telefone.Text = dtg_usuarios.SelectedRows[0].Cells[11].Value.ToString();
            mask_celular.Text = dtg_usuarios.SelectedRows[0].Cells[12].Value.ToString();
            mask_limite.Text = dtg_usuarios.SelectedRows[0].Cells[13].Value.ToString();
            mask_prazo.Text = dtg_usuarios.SelectedRows[0].Cells[14].Value.ToString();
            tb_email.Text = dtg_usuarios.SelectedRows[0].Cells[15].Value.ToString();
            tb_site.Text = dtg_usuarios.SelectedRows[0].Cells[16].Value.ToString();
            tb_observacao.Text = dtg_usuarios.SelectedRows[0].Cells[17].Value.ToString();
            rdb_ativo.Checked = dtg_usuarios.SelectedRows[0].Cells[18].Value.ToString() == "Ativo";
            rdb_inativo.Checked = dtg_usuarios.SelectedRows[0].Cells[18].Value.ToString() == "Inativo";
         
            rdb_fisica.Checked = dtg_usuarios.SelectedRows[0].Cells[19].Value.ToString() == "Física"; ;
            rdb_juridica.Checked = dtg_usuarios.SelectedRows[0].Cells[19].Value.ToString() == "Juridica"; ;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string codCliente = tb_codCliente.Text;
            string nome = tb_nome.Text;
            string data = dtp_data.Text;
            string apelido = tb_apelido.Text;
            string endereco = tb_endereco.Text;
            decimal numero = num_Numero.Value;
            string bairro = tb_bairro.Text;
            string cidade = tb_cidade.Text;
            string cep = mask_cep.Text;
            string uf = cbx_uf.Text;
            string CPF_CNPJ = rdb_fisica.Checked == true ? mask_cpf.Text : mask_Cnpj.Text;
            string telefone = mask_telefone.Text;
            string celular = mask_celular.Text;
            string limite = mask_limite.Text;
            string prazo = mask_prazo.Text;
            string email = tb_email.Text;
            string site = tb_site.Text;
            string observacao = tb_observacao.Text;
            string status = rdb_ativo.Checked ? "Ativo" : "Inativo";
            string tipoCliente = rdb_fisica.Checked ? "Física" : "Juridica";

            if (btn_salvar.Text == "Salvar")
            {
                if (tb_nome.Text != "" && mask_limite.Text != "" && mask_prazo.Text != "")
                {
                    SendDB.Post("INSERT INTO tb_cliente (clienteNome, data, apelido, endereco, numero, bairro, cidade, cep, uf, cpf_cnpj, telefone, celular, limiteCredito, prazo, email, site, observacao, status, tipoCliente) VALUES ('" + nome + "', '" + data + "', '" + apelido + "','" + endereco + "','" + numero + "','" + bairro + "', '" + cidade + "','" + cep + "','" + uf + "','" + CPF_CNPJ + "','" + telefone + "','" + celular + "','" + limite + "','" + prazo + "','" + email + "','" + site + "','" + observacao + "','" + status + "','" + tipoCliente + "');");
                }
                else
                {
                    MessageBox.Show("Há Campos Obrigatório Vázios");
                }

                if (SendDB.isRespostaPost)
                {
                    MessageBox.Show("Cliente Registrado com Sucesso!!");
                    LimparCampo();
                    dtg_usuarios.DataSource = PegaUsuariosFilter(tb_busca.Text);
                    tab_users.SelectedIndex = 0;

                }
            }
            else
            {
                if (tb_nome.Text != "" && mask_limite.Text != "" && mask_prazo.Text != "")
                {
                    SendDB.Update("UPDATE tb_cliente SET clienteNome='" + nome + "', data='" + data + "', apelido='" + apelido + "', endereco = '" + endereco + "', numero='" + numero + "', bairro='" + bairro + "', cidade='" + cidade + "', cep='" + cep + "', uf='" + uf + "', cpf_cnpj='" + CPF_CNPJ + "', telefone='" + telefone + "', celular='" + celular + "', limiteCredito='" + limite + "', prazo='" + prazo + "', email='" + email + "', site='" + site + "', observacao='" + observacao + "', status='" + status + "', tipoCliente='" + tipoCliente + "' WHERE id ='"+ codCliente + "';");
                }
                else
                {
                    MessageBox.Show("Há Campos Obrigatório Vázios");
                }

                if (SendDB.isRespostaUpdate)
                {
                    MessageBox.Show("Registro Alterado com Sucesso!!");
                    LimparCampo();
                    dtg_usuarios.DataSource = PegaUsuariosFilter(tb_busca.Text);
                    tab_users.SelectedIndex = 0;

                }
            }
         
         
        }

        private void rdb_fisica_CheckedChanged(object sender, EventArgs e)
        {
            mask_Cnpj.Visible = false;
            mask_cpf.Visible = true;
        }

        private void rdb_juridica_CheckedChanged(object sender, EventArgs e)
        {
            mask_Cnpj.Visible = true;
            mask_cpf.Visible = false;
        }

        private void tb_busca_TextChanged(object sender, EventArgs e)
        {
            dtg_usuarios.DataSource = PegaUsuariosFilter(tb_busca.Text);
        }

        private void dtg_usuarios_DoubleClick(object sender, EventArgs e)
        {
            PrenchimentoCampo();
            btn_salvar.Text = "Alterar";
            tab_users.SelectedIndex = 1;
            btn_Deletar.Enabled = true;
            btn_Deletar.Enabled = true;
            btn_Deletar.BackColor = Color.Crimson;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampo();
            btn_salvar.Text = "Salvar";
            tab_users.SelectedIndex = 0;
            btn_Deletar.Enabled = false;
            btn_Deletar.BackColor = Color.Gray;
        }
        private void deleteCliente()
        {
            string id = dtg_usuarios.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult res =  MessageBox.Show("Confirma Exclusão do Usuário?", "Excluir Usuário",MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                SendDB.Delete("DELETE FROM tb_cliente WHERE id = '" + id + "'");

                if (SendDB.isRespostaDelete)
                {
                    MessageBox.Show("Registro Deletado com Sucesso");
                    LimparCampo();
                    dtg_usuarios.DataSource = PegaUsuariosFilter(tb_busca.Text);
                }
            }


        }
        private void btn_deletar_item_Click(object sender, EventArgs e)
        {
            deleteCliente();
        }

        private void btn_Deletar_Click(object sender, EventArgs e)
        {
            deleteCliente();
            tab_users.SelectedIndex = 0;
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            tab_users.SelectedIndex = 1;
        }
    }
}
