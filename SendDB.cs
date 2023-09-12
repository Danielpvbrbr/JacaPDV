using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql_conection
{
    internal class SendDB
    {
        static public bool isRespostaGet = false;
        static public bool isRespostaPost = false;
        static public bool isRespostaUpdate = false;
        static public bool isRespostaDelete = false;

        static public  void Post(string query)
        {
            try
            {
                var vcon = Conectar.ConectionSQLite(); ;
                var cmd = vcon.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                vcon.Close();

              
                isRespostaPost = true;
            }
            catch (Exception ex)
            {
                isRespostaPost = false;
                MessageBox.Show("Erro de gravação" + ex);
            }
        }

        public static DataTable Get(string query)
        {
            SQLiteDataAdapter da = null;
            DataTable dados = new DataTable();

            try
            {
                var vcon = Conectar.ConectionSQLite();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = query;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dados);

                return dados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao acessar banco de dados");
                throw ex;
            }
        }

        public static void Delete(string query)
        {
            SQLiteDataAdapter da = null;
            DataTable dados = new DataTable();

            try
            {
                var vcon = Conectar.ConectionSQLite();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = query;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
                da.Fill(dados);

                isRespostaDelete = true;
                //MessageBox.Show("Dados Excluido com sucesso");
            }
            catch (Exception ex)
            {
                isRespostaDelete = false;
                MessageBox.Show("Erro ao acessar banco de dados");
                throw ex;
            }
        }

        public static void Update(string query)
        {
            SQLiteDataAdapter da = null;
            DataTable dados = new DataTable();

            try
            {
                var vcon = Conectar.ConectionSQLite();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = query;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

                isRespostaUpdate = true;
                //MessageBox.Show("Dados Atualizado com sucesso");
            }
            catch (Exception ex)
            {
                isRespostaUpdate = false;
                MessageBox.Show("Erro ao acessar banco de dados");
                throw ex;
            }
        }
    }


}
