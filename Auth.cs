using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql_conection
{
    internal class Auth
    {
        //Propiedades
        public static string versao =  "1.0";
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "LeinPDV_database.db";
        public static string caminhoBanco = caminho + @"\database\";
        //Dados do Usuários
        public static string authentication = "0";
        public static string nome = "";
        public static string user = "";
        public static string senha = "";
        public static int status = 0;
        public static string privilegio_funcionario = "";
        //Permissão do Usuário
        public static int permiss_estoque = 0;
        public static int permiss_Pdv = 0;
        public static int permiss_gerenciamento = 0;
        public static int permiss_contas_receber = 0;
        public static int permiss_clientes = 0;
        public static int permiss_funcionarios = 0;
        public static int permiss_usuarios = 0;
        //Registro da Empresa
        public static string logatipoName = "";
        public static string razaoSocial = "NOME DA EMPRESA";
        public static string slogan = "SLOGA DA EMPRESA";
        public static string endereco = "ENDEREÇO DA EMPRESA";
        public static string cidade = "CIDADE DA EMPRESA";
        public static string bairro = "BAIRRO DA EMPRESA";
        public static string uf = "MG";
        public static string numero = "0";
        public static string CNPJ = "00.000.000/0000-00";
        public static string incricaoEstadual = "000.000-00";
        public static string CEP = "00000-000";
        public static string responsavel = "RESPONSÁVEL DA EMPRESA";
        public static string tellResponsavel = "990000000";
        public static string email = "email@provedor.com.br";
        public static string tellEmpresa = "990000000";
        public static string site = "www.seusite.com.br";
    }
}
