using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql_conection
{
    internal class SomenteNumeros
    {
        static public string Convert(string v)
        {
            return String.Join("", System.Text.RegularExpressions.Regex.Split(v, @"[^\d]"));
        }

        
    }
}
