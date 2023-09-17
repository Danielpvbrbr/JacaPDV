using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql_conection
{
    internal class Clientes
    {
        static public void add(ComboBox listClientes)
        {
            DataTable db_cliente = SendDB.Get("SELECT id, status, limiteCredito, clienteNome FROM tb_cliente;");
          ;
            for (int i = 0; i < db_cliente.Rows.Count; i++)
            {
                string nome = db_cliente.Rows[i].Field<string>("clienteNome").ToString();
                string[] rowsNome = { nome };
                listClientes.Items.AddRange(rowsNome);
            }
        }
    }
}
