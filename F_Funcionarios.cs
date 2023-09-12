using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mysql_conection
{
    public partial class F_Funcionarios : Form
    {
        public F_Funcionarios()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private DataTable ObterFuncionariosFilter(string filter)
        {
           return SendDB.Get(@"SELECT id as 'Cód Func',
                            nomeFuncionario as 'Nome Funcionario',
                            dataNascimento as 'Data de Nascimento',
                            cep as 'CEP', endereco as 'endereço',
                            numero as 'Número',
                            bairro as 'Bairro',
                            cidade as 'Cidade',
                            uf as 'UF',
                            cpf as 'CPF',
                            celular as 'Celular',
                            salario as 'Salario',
                            dataAdimissao as 'Data Adimissão',
                            email as 'E-mail',
                            cargo as 'Cargo',
                            IsUser as 'Usuário'
                            FROM tb_funcionarios WHERE nomeFuncionario LIKE '%%" + filter + "%%'");
        }

        private void ObterListCargo()
        {
            cbx_cargo.Items.Clear();
            DataTable dt = new DataTable();
            dt = SendDB.Get("SELECT * FROM tb_cargos");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbx_cargo.Items.Add(dt.Rows[i].Field<string>("cargo").ToString());
            }
        }

        private void F_Funcionarios_Load(object sender, EventArgs e)
        {
            ObterListCargo();
            Atualizar();

        }

        private void tb_busca_TextChanged(object sender, EventArgs e)
        {
            dtg_funcionarios.DataSource =  ObterFuncionariosFilter(tb_busca.Text);
        }

        private void LimparCampo()
        {
            btn_salvar.Text = "Salvar";
            tb_cod_func.Text = "";
            tb_nomeFunc.Text = "";
            dt_dataNasc.Text = "";
            mask_cep.Text = "";
            tb_endereco.Text = "";
            tb_numero.Text = "";
            tb_bairro.Text = "";
            tb_cidade.Text = "";
            cbx_uf.Text = "";
            mask_cpf.Text = "";
            mask_telefone.Text = "";
            mask_salario.Text = "";
            dt_dataAdmissao.Text = "";
            tb_email.Text = "";
            cbx_cargo.Text = "";

            btn_salvar.Text = "Salvar";
            btn_delete.Enabled = false;
            btn_delete.BackColor = Color.Gray;
            
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string id = tb_cod_func.Text;
            string nome = tb_nomeFunc.Text;
            string dataNasc = dt_dataNasc.Text;
            string cep = mask_cep.Text;
            string endereco = tb_endereco.Text;
            string numero = tb_numero.Text;
            string bairro = tb_bairro.Text;
            string cidade = tb_cidade.Text;
            string uf = cbx_uf.Text;
            string cpf = mask_cpf.Text;
            string celular = mask_telefone.Text;
            string salario = mask_salario.Text;
            string dataAdmissao = dt_dataAdmissao.Text;
            string email = tb_email.Text;
            string cargo = cbx_cargo.Text;

            if (tb_nomeFunc.Text != "" && mask_cpf.Text != "" && mask_telefone.Text != "")
            {
                if (btn_salvar.Text == "Salvar")
                {
                    SendDB.Post("INSERT INTO tb_funcionarios (nomeFuncionario, dataNascimento, cep, endereco, salario, numero, bairro, cidade, uf, cpf, celular, dataAdimissao, email, cargo) VALUES ('" + nome + "', '" + dataNasc + "','" + cep + "','" + endereco + "','" + salario + "','" + numero + "','" + bairro + "','" + cidade + "','" + uf + "','" + cpf + "','" + celular + "','" + dataAdmissao + "','" + email + "','" + cargo + "')");
                    if (SendDB.isRespostaPost)
                    {
                        MessageBox.Show("Registro Salvo com Sucesso!");

                        Atualizar();
                    }
                }
                else
                {
                    SendDB.Update("UPDATE tb_funcionarios SET nomeFuncionario='"+ nome + "', dataNascimento='"+ dataNasc + "', cep='"+cep+"', endereco='"+endereco+"', salario='"+salario+"', numero='"+numero+"', bairro='"+bairro+"', cidade='"+cidade+"', uf='"+uf+"', cpf='"+cpf+"', celular='"+celular+"', dataAdimissao='"+dataAdmissao+"', email='"+email+"', cargo='"+cargo+"' WHERE id = "+id+";");
                    if (SendDB.isRespostaUpdate)
                    {
                        MessageBox.Show("Registro Atualizado com Sucesso!");
                        Atualizar();
                       
                    }
                }
            }
            else
            {
                MessageBox.Show("Há Campo(*) Obrigatorio Vázio");
            }
        }

        private void dtg_funcionarios_DoubleClick(object sender, EventArgs e)
        {
            LimparCampo();
            btn_salvar.Text = "Alterar";
            tb_cod_func.Text = dtg_funcionarios.SelectedRows[0].Cells[0].Value.ToString();
            tb_nomeFunc.Text = dtg_funcionarios.SelectedRows[0].Cells[1].Value.ToString(); 
            dt_dataNasc.Text = dtg_funcionarios.SelectedRows[0].Cells[2].Value.ToString(); 
            mask_cep.Text = dtg_funcionarios.SelectedRows[0].Cells[3].Value.ToString(); 
            tb_endereco.Text = dtg_funcionarios.SelectedRows[0].Cells[4].Value.ToString(); 
            tb_numero.Text = dtg_funcionarios.SelectedRows[0].Cells[5].Value.ToString(); 
            tb_bairro.Text = dtg_funcionarios.SelectedRows[0].Cells[6].Value.ToString(); 
            tb_cidade.Text = dtg_funcionarios.SelectedRows[0].Cells[7].Value.ToString(); 
            cbx_uf.Text = dtg_funcionarios.SelectedRows[0].Cells[8].Value.ToString(); 
            mask_cpf.Text = dtg_funcionarios.SelectedRows[0].Cells[9].Value.ToString(); 
            mask_telefone.Text = dtg_funcionarios.SelectedRows[0].Cells[10].Value.ToString();
            mask_salario.Text = dtg_funcionarios.SelectedRows[0].Cells[11].Value.ToString(); 
            dt_dataAdmissao.Text = dtg_funcionarios.SelectedRows[0].Cells[12].Value.ToString(); 
            tb_email.Text = dtg_funcionarios.SelectedRows[0].Cells[13].Value.ToString(); 
            cbx_cargo.Text = dtg_funcionarios.SelectedRows[0].Cells[14].Value.ToString();

            btn_delete.Enabled = true;
            btn_delete.BackColor = Color.Crimson;
            tab_funcionario.SelectedIndex = 1;

        }

        private void Delete()
        {
            string id = dtg_funcionarios.SelectedRows[0].Cells[0].Value.ToString();
            SendDB.Delete("DELETE FROM tb_funcionarios WHERE id='" + id + "' ");
            if (SendDB.isRespostaDelete)
            {
                MessageBox.Show("Registro Deletado com sucesso");
                Atualizar();
            }
        }

        private void Atualizar()
        {
            dtg_funcionarios.DataSource = ObterFuncionariosFilter(tb_busca.Text);
            lb_totalFunc.Text = dtg_funcionarios.RowCount.ToString();
            LimparCampo();
            tab_funcionario.SelectedIndex = 0;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampo();   
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            tab_funcionario.SelectedIndex = 1;
        }

        private void btn_deletar_item_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
