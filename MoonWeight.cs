using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonWeight
{
    class MoonWeight
    {
        // 月の重力は地球の17%です。
        static void Main(string[] args)
        {
            double earth_weight, moon_weight;

            for (earth_weight=10.0;earth_weight < 100.0; earth_weight++)
            {
                moon_weight = earth_weight * 0.17;

                Console.WriteLine(earth_weight + "kg in earth : " + moon_weight + "kg in moon.");
            }
        }
    }
}
