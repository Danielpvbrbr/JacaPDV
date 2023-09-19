using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mysql_conection
{
    public partial class F_EmpresaCofig : Form
    {
        DataTable dt = new DataTable();
        public F_EmpresaCofig()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string logotipoName = "";
            string razaoSocial = tb_razaoSocial.Text;
            string slogan = tb_slogan.Text;
            string endereco = tb_endereco.Text;
            string bairro = tb_bairro.Text;
            string cidade = tb_cidade.Text;
            string uf = cbx_uf.Text;
            string cnpj = mask_cnpj.Text;
            string numero = num_numero.Text;
            string cep = mask_Cep.Text;
            string insc_estadual = mask_insc_estadual.Text;
            string responsavel = tb_responsavel.Text;
            string telefoneResp = mask_telefoneResp.Text;
            string telefoneEmpre = mask_telefoneEmpre.Text;
            string email = tb_email.Text;
            string site = tb_site.Text;

            SendDB.Update("UPDATE tb_empresa SET razao_social='"+ razaoSocial + "',slogan='"+ slogan + "',endereco='"+ endereco + "',bairro='"+ bairro + "',cidade='"+ cidade + "',uf='"+ uf + "',numero='"+ numero + "',cnpj='"+ cnpj + "',inscricao_estadual='"+ insc_estadual + "',cep='"+cep+"',responsavel='"+ responsavel + "',telefone_responsavel='"+ telefoneResp + "',email='"+email+"',telefone_empresa='"+ telefoneEmpre + "',site='"+site+"',logotipoName='"+ logotipoName + "' WHERE id = 1");
            if (SendDB.isRespostaUpdate)
            {
                MessageBox.Show("Registro de Informações Atualizados");
                AtualizarInfoEmpresa.Atualizar();
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            tb_razaoSocial.Text = "";
            tb_slogan.Text= "";
            tb_endereco.Text = "";
            tb_bairro.Text = "";
            tb_cidade.Text = "";
            mask_cnpj.Text = "";
            num_numero.Text = "";
            mask_Cep.Text = "";
            mask_insc_estadual.Text = "";
            tb_responsavel.Text = "";
            mask_telefoneResp.Text = "";
            mask_telefoneEmpre.Text = "";
            tb_email.Text = "";
            tb_site.Text = "";
        }

        private void F_EmpresaCofig_Load(object sender, EventArgs e)
        {
            tb_razaoSocial.Text = Auth.razaoSocial;
            tb_slogan.Text = Auth.slogan;
            tb_endereco.Text = Auth.endereco;
            tb_bairro.Text = Auth.bairro;
            tb_cidade.Text = Auth.cidade;
            cbx_uf.Text = Auth.uf;
            mask_cnpj.Text = Auth.CNPJ;
            num_numero.Text = Auth.numero;
            mask_Cep.Text = Auth.CEP;
            mask_insc_estadual.Text = Auth.incricaoEstadual;
            tb_responsavel.Text = Auth.responsavel;
            mask_telefoneResp.Text = Auth.tellResponsavel;
            mask_telefoneEmpre.Text = Auth.tellEmpresa;
            tb_email.Text = Auth.email;
            tb_site.Text = Auth.site;

            // Auth.logatipoName 
        }

        private void btn_addLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
