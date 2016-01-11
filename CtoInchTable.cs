using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtoInchTable
{
    class CtoInchTable
    {
        // インチ から センチに変換する 100cm 39.37inch 
        static void Main(string[] args)
        {
            double cm,inch;

            for (inch = 1.0; inch <= 144.0; inch++)
            {
                cm = inch / 39.37 * 100.0;
                Console.WriteLine(inch + "inch is " + cm + "cm.");
            }
        }
    }
}
