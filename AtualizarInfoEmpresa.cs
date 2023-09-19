using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql_conection
{
    internal class AtualizarInfoEmpresa
    {
       
        public static void Atualizar()
        {
            DataTable dt_empresa = new DataTable();
            dt_empresa = SendDB.Get("SELECT * FROM tb_empresa WHERE id = 1;");

            Auth.logatipoName = dt_empresa.Rows[0].Field<string>("logotipoName");
            Auth.razaoSocial = dt_empresa.Rows[0].Field<string>("razao_social");
            Auth.slogan = dt_empresa.Rows[0].Field<string>("slogan");
            Auth.endereco = dt_empresa.Rows[0].Field<string>("endereco");
            Auth.cidade = dt_empresa.Rows[0].Field<string>("cidade");
            Auth.bairro = dt_empresa.Rows[0].Field<string>("bairro");
            Auth.uf = dt_empresa.Rows[0].Field<string>("uf");
            Auth.numero = dt_empresa.Rows[0].Field<string>("numero");
            Auth.CNPJ = dt_empresa.Rows[0].Field<string>("cnpj");
            Auth.incricaoEstadual = dt_empresa.Rows[0].Field<string>("inscricao_estadual");
            Auth.CEP = dt_empresa.Rows[0].Field<string>("cep");
            Auth.responsavel = dt_empresa.Rows[0].Field<string>("responsavel");
            Auth.tellResponsavel = dt_empresa.Rows[0].Field<string>("telefone_empresa");
            Auth.email = dt_empresa.Rows[0].Field<string>("email");
            Auth.tellEmpresa = dt_empresa.Rows[0].Field<string>("telefone_empresa");
            Auth.site = dt_empresa.Rows[0].Field<string>("site");
        }
    }
}
