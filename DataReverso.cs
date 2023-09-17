using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysql_conection
{
    internal class DataReverso
    {
       static public string DataReversoTo(string aDate) {

            string[] dateReverse = aDate.Split('/');
            return $"{dateReverse[2]}/{dateReverse[1]}/{dateReverse[0]}";
       }
     
    }
}
