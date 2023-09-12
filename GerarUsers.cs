using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql_conection
{
    internal class GerarUsers 
    {
        static public string  Ger(string nome)
        {
            var date = DateTime.Now;

            if (nome.Length <= 6)
            {
                nome = Regex.Replace(nome, @"\s+", String.Empty).ToLower() + date.Second;
            }

            return nome;
        }
    }
}
