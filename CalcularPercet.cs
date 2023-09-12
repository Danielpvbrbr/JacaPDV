using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql_conection
{
    internal class CalcularPercet
    {

        static public double Valor(string N1, string N2) {
            double calc = ((double.Parse(N1)) * (double.Parse(N2)) / 100 - (double.Parse(N2)));
        
            return (calc *= -1);
        }

        static public double Rest(string N1, string N2)
        {
            double calc = ((double.Parse(N1)) * (double.Parse(N2)) / 100 - (double.Parse(N2)));
        ;
            return double.Parse((float.Parse(N2) - (calc *= -1)).ToString("F"));
        }

    }
}
