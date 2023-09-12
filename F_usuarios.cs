using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql_conection
{
    public partial class F_usuarios : Form
    {
        string idSelected = "";

        public F_usuarios()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_nomeFuncionario_TextChanged(object sender, EventArgs e)
        {
            tb_usuarioFuncionario.Text = GerarUsers.Ger(tb_nomeFuncionario.Text);
        }

        private void LiparCampos()
        {
            tb_nomeFuncionario.Text = "";
            tb_usuarioFuncionario.Text = "";
            tb_senhaFuncionario.Text = "";
            cbx_previlegios.Text = "Operador";
            CkB_status.Checked = false;
            CkB_estoque.Checked = false;
            CkB_contasAreceber.Checked = false;
            CkB_usuarios.Checked = false;
            CkB_clientes.Checked = false;
            CkB_pdv.Checked = false;
            CkB_funcionarios.Checked = false;
            CkB_gerenciamento.Checked = false;
            idSelected = "";

            btn_salvar.Text = "Salvar";
            btn_deletar.Enabled = false;
            btn_deletar.BackColor = Color.DarkGray;
        }

        private DataTable ObterUsuariosId(string id)
        {
            return SendDB.Get("SELECT * FROM tb_usuarios WHERE id='" + id + "'");
        }

        private DataTable ObterUsuariosFiltro(string filtro)
        {
            return SendDB.Get(@"SELECT 
                               id as 'Código',
                               nome_funcionario as 'Nome Funcionario',
                               date as 'Data Criação',
                               user_funcionario as 'Usuário',
                               senha_funcionario as 'Senha',
                               privilegio_funcionario as 'Previlegio',
                               status as 'Status', 
                               permiss_estoque as 'PermEstoque',
                               permiss_Pdv as 'PermPDV',
                               permiss_gerenciamento as 'PermGerencimento',
                               permiss_contas_receber as 'PermContasAreceber', 
                               permiss_clientes as 'PermClientes',
                               permiss_funcionarios as 'PermFuncionarios', 
                               permiss_usuarios as 'PermUsuários' 
                               FROM tb_usuarios WHERE  nome_funcionario LIKE '%%" + filtro + "%%'");

        }

        private void Atualizar()
        {
            dt_Usuarios.DataSource = ObterUsuariosFiltro(tb_busca.Text);
            tab_novoUsers.SelectedIndex = 0;
            lb_totalUsers.Text = dt_Usuarios.RowCount.ToString();
            LiparCampos();
        }

        private void F_usuarios_Load(object sender, EventArgs e)
        {
            Atualizar();
            dt_Usuarios.Columns[0].Width = 50;
            CkB_status.Checked = true;
            CkB_pdv.Checked = true;
            CkB_clientes.Checked = true;
            lb_totalUsers.Text = dt_Usuarios.RowCount.ToString();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LiparCampos();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma Exclusão do Usuário?", "Excluir Usuário", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                SendDB.Delete("DELETE FROM tb_usuarios WHERE id='" + idSelected + "'");
                Atualizar();
                tab_novoUsers.SelectedIndex = 0;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string date = DataFormatada.data;
            string nome = tb_nomeFuncionario.Text;
            string usuario = tb_usuarioFuncionario.Text;
            string senha = tb_senhaFuncionario.Text;
            string previlegios = cbx_previlegios.Text;
            int status = CkB_status.Checked ? 1 : 0;
            int permEstoque = CkB_estoque.Checked ? 1 : 0;
            int permContasAreceber = CkB_contasAreceber.Checked ? 1 : 0;
            int permUsuarios = CkB_usuarios.Checked ? 1 : 0;
            int permClientes = CkB_clientes.Checked ? 1 : 0;
            int permPdv = CkB_pdv.Checked ? 1 : 0;
            int permFuncionario = CkB_funcionarios.Checked ? 1 : 0;
            int permGerenciamento = CkB_gerenciamento.Checked ? 1 : 0;

            if (tb_nomeFuncionario.Text != "" && tb_senhaFuncionario.Text != "")
            {
                if (btn_salvar.Text == "Salvar")
                {
                    if (SendDB.isRespostaPost)
                    {
                        SendDB.Post(@"INSERT INTO tb_usuarios 
                                    (nome_funcionario,
                                    user_funcionario,
                                    senha_Funcionario,
                                    date,
                                    status,
                                    privilegio_funcionario,
                                    permiss_estoque,
                                    permiss_contas_receber,
                                    permiss_usuarios,
                                    permiss_clientes,
                                    permiss_Pdv,
                                    permiss_funcionarios,
                                    permiss_gerenciamento 
                                    ) VALUES (
                                    '" + nome + "'," +
                                    "'" + usuario + "'," +
                                    " '" + senha + "'," +
                                      " '" + date + "'," +
                                    " '" + status + "'," +
                                    "'" + previlegios + "'," +
                                    "'" + permEstoque + "'," +
                                    " '" + permContasAreceber + "'," +
                                    " '" + permUsuarios + "'," +
                                    " '" + permClientes + "', " +
                                    "'" + permPdv + "', " +
                                    "'" + permFuncionario + "'," +
                                    "'" + permGerenciamento + "')" +
                                    "");
                        Atualizar();
                        MessageBox.Show("Registro Salvo com Sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao salvar, Tente mais tarde!");
                    }
                }
                else
                {
                    if(SendDB.isRespostaUpdate)
                    {
                        SendDB.Update(@"UPDATE tb_usuarios SET nome_funcionario='" + nome + "',user_funcionario = '" + usuario + "', senha_Funcionario = '" + senha + "', status = '" + status + "', privilegio_funcionario = '" + previlegios + "', permiss_estoque = '" + permEstoque + "', permiss_contas_receber = '" + permContasAreceber + "', permiss_usuarios = '" + permUsuarios + "', permiss_clientes = '" + permClientes + "', permiss_Pdv = '" + permPdv + "', permiss_funcionarios = '" + permFuncionario + "', permiss_gerenciamento = '" + permGerenciamento + "' WHERE id='"+idSelected+"'");
                        Atualizar();
                        MessageBox.Show("Registro Atualizado com Sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao salvar, Tente mais tarde!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Erro ao Salvar Campo Vázio!");
            }
        }

        private void cbx_previlegios_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbx_previlegios.Text)
            {
                case "Operador":
                    CkB_status.Checked = true;
                    CkB_pdv.Checked = true;
                    CkB_clientes.Checked = true;
                    CkB_estoque.Checked = false;
                    CkB_contasAreceber.Checked = false;
                    CkB_usuarios.Checked = false;
                    CkB_funcionarios.Checked = false;
                    CkB_gerenciamento.Checked = false;
                    break;
                case "Supervisor":
                    CkB_status.Checked = true;
                    CkB_estoque.Checked = true;
                    CkB_contasAreceber.Checked = true;
                    CkB_gerenciamento.Checked = true;
                    CkB_usuarios.Checked = false;
                    CkB_clientes.Checked = false;
                    CkB_pdv.Checked = true;
                    CkB_funcionarios.Checked = false;
                    break;
                case "Administrador":
                    CkB_status.Checked = true;
                    CkB_estoque.Checked = true;
                    CkB_contasAreceber.Checked = true;
                    CkB_usuarios.Checked = true;
                    CkB_clientes.Checked = true;
                    CkB_pdv.Checked = true;
                    CkB_funcionarios.Checked = true;
                    CkB_gerenciamento.Checked = true;
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dt_Usuarios.DataSource = ObterUsuariosFiltro(tb_busca.Text);
        }

        private void dt_Usuarios_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;

            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = ObterUsuariosId(id);
                idSelected = id;
                tb_nomeFuncionario.Text = dt.Rows[0].Field<string>("nome_funcionario");
                tb_usuarioFuncionario.Text = dt.Rows[0].Field<string>("user_funcionario");
                tb_senhaFuncionario.Text = dt.Rows[0].Field<string>("senha_Funcionario");
                cbx_previlegios.Text = dt.Rows[0].Field<string>("privilegio_funcionario");
                CkB_status.Checked = Convert.ToBoolean(dt.Rows[0].Field<Int64>("status"));
                CkB_estoque.Checked = Convert.ToBoolean(dt.Rows[0].Field<Int64>("permiss_estoque"));
                CkB_contasAreceber.Checked = Convert.ToBoolean(dt.Rows[0].Field<Int64>("permiss_contas_receber"));
                CkB_usuarios.Checked = Convert.ToBoolean(dt.Rows[0].Field<Int64>("permiss_usuarios"));
                CkB_clientes.Checked = Convert.ToBoolean(dt.Rows[0].Field<Int64>("permiss_clientes"));
                CkB_pdv.Checked = Convert.ToBoolean(dt.Rows[0].Field<Int64>("permiss_Pdv"));
                CkB_funcionarios.Checked = Convert.ToBoolean(dt.Rows[0].Field<Int64>("permiss_funcionarios"));
                CkB_gerenciamento.Checked = Convert.ToBoolean(dt.Rows[0].Field<Int64>("permiss_gerenciamento"));

                lb_totalUsers.Text = dt.Rows.Count.ToString();
                btn_salvar.Text = "Alterar";
                btn_deletar.Enabled = true;
                btn_deletar.BackColor = Color.Crimson;
                tab_novoUsers.SelectedIndex = 1;
            }
        }
    }
   
}
