using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql_conection
{
    internal class Conectar
    {
        //private static MySqlConnection Mysql;
        private static SQLiteConnection SQLite;
        public static Boolean status = false;
        public static string banco = "Desconected"; //SQLite
        public static string path2 = Auth.caminho + @"\database\LeinPDV_database.db";

        //public static MySqlConnection ConectionMysql()
        //{
        //    try
        //    {
        //        Mysql = new MySqlConnection(Conn.strConn);
        //        Mysql.Open();
        //        status = true;
        //        MessageBox.Show("Conectado com sucesso");
        //        return Mysql;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro de conexão" + ex);
        //        status = false;
        //        return Mysql;
        //    }
        //    finally
        //    {
        //        Mysql.Close();
        //    }
        //}

        public static SQLiteConnection ConectionSQLite()
        {
            try
            {
               // SQLite = new SQLiteConnection("Data Source = D:\\Curso C#\\WindowsForm\\JacaPDV\\database\\LeinPDV_database.db");
                SQLite = new SQLiteConnection("Data Source =" + Auth.caminhoBanco + Auth.nomeBanco);
                SQLite.Open();
                status = true;
                return SQLite;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão" + ex);
                SQLite.Close();
                status = false;
                throw ex;
            }
        }


    }
}
