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
    public partial class F_Home : Form
    {
        public F_Home()
        {
            InitializeComponent();
        }

        private void F_Home_Load(object sender, EventArgs e)
        {
            lb_privilegio_funcionario.Text = Auth.privilegio_funcionario;
            lb_nome.Text = Auth.nome;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            F_Venda f_Venda = new F_Venda();
            f_Venda.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            F_Estoque f_Estoque = new F_Estoque();
            f_Estoque.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            F_Gerenciamento f_Gerenciamento = new F_Gerenciamento();
            f_Gerenciamento.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            F_ContasAreceber f_ContasAreceber = new F_ContasAreceber();
            f_ContasAreceber.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            F_Cliente f_Cliente = new F_Cliente();
            f_Cliente.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            F_Funcionarios f_Funcionarios = new F_Funcionarios();
            f_Funcionarios.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Estoque f_Estoque = new F_Estoque();
            f_Estoque.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Cliente f_Cliente = new F_Cliente();
            f_Cliente.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Funcionarios f_Funcionarios = new F_Funcionarios();
            f_Funcionarios.ShowDialog();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_EmpresaCofig f_EmpresaCofig = new F_EmpresaCofig();
            f_EmpresaCofig.ShowDialog();
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Estoque f_Estoque = new F_Estoque();
            f_Estoque.ShowDialog();
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Cargos f_Cargos = new F_Cargos();
            f_Cargos.ShowDialog();
        }

        private void setorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Setores f_Setores = new F_Setores();
            f_Setores.ShowDialog();
        }

        private void fabricantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Fabricantes_Marcas f_Fabricantes = new F_Fabricantes_Marcas();
            f_Fabricantes.ShowDialog();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Fornecedores f_Fornecedores = new F_Fornecedores();
            f_Fornecedores.ShowDialog();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Venda f_Venda = new F_Venda();
            f_Venda.ShowDialog();
        }

        private void gerenciamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Gerenciamento f_Gerenciamento = new F_Gerenciamento();
            f_Gerenciamento.ShowDialog();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ContasAreceber f_ContasAreceber = new F_ContasAreceber();
            f_ContasAreceber.ShowDialog();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Orcamento f_Orcamento = new F_Orcamento();
            f_Orcamento.tabControl1.SelectedIndex = 1;
            f_Orcamento.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Orcamento f_Orcamento = new F_Orcamento();
            f_Orcamento.tabControl1.SelectedIndex = 0;
            f_Orcamento.ShowDialog();
        }

        private void gerenciarCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GerenciamentoCaixaDia f_GerenciamentoCaixaDia = new  F_GerenciamentoCaixaDia();
            f_GerenciamentoCaixaDia.ShowDialog();
        }

        private void listaDeContaAReberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ContasAreceber f_ContasAreceber = new F_ContasAreceber();
            f_ContasAreceber.tabControl1.SelectedIndex = 0;
            f_ContasAreceber.ShowDialog();
        }

        private void novaContaAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ContasAreceber f_ContasAreceber = new F_ContasAreceber();
            f_ContasAreceber.tabControl1.SelectedIndex = 1;
            f_ContasAreceber.ShowDialog();
        }



        private void novaEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GerenciamentoCaixaDia f_GerenciamentoCaixaDia = new F_GerenciamentoCaixaDia();
            f_GerenciamentoCaixaDia.tab_gerenciadorCaixa.SelectedIndex = 1;
            f_GerenciamentoCaixaDia.ShowDialog();
        }

        private void novaRetiradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GerenciamentoCaixaDia f_GerenciamentoCaixaDia = new F_GerenciamentoCaixaDia();
            f_GerenciamentoCaixaDia.tab_gerenciadorCaixa.SelectedIndex = 2;
            f_GerenciamentoCaixaDia.ShowDialog();
        }


        private void extratoDeEntradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GerenciamentoCaixaDia f_GerenciamentoCaixaDia = new F_GerenciamentoCaixaDia();
            f_GerenciamentoCaixaDia.tab_gerenciadorCaixa.SelectedIndex = 1;
            f_GerenciamentoCaixaDia.tab_Entradas.SelectedIndex = 1;
            f_GerenciamentoCaixaDia.ShowDialog();
        }

        private void extratoDeRetiradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GerenciamentoCaixaDia f_GerenciamentoCaixaDia = new F_GerenciamentoCaixaDia();
            f_GerenciamentoCaixaDia.tab_gerenciadorCaixa.SelectedIndex = 2;
            f_GerenciamentoCaixaDia.tab_Retiradas.SelectedIndex = 1;
            f_GerenciamentoCaixaDia.ShowDialog();
        }

        private void iniciosDeEntradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_IniciosCaixa f_IniciosCaixa  = new F_IniciosCaixa();
            f_IniciosCaixa.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_usuarios f_Usuarios = new F_usuarios();
            f_Usuarios.ShowDialog();
        }

    }
}
