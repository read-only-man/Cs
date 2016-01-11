using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpTypedVar
{
    // 暗黙型の確認 バリアントを使う
    class ImpTypedVar
    {
        static void Main(string[] args)
        {
            // doubleになる
            var pi = 3.1416;

            // intになる
            var radius = 10;

            // stringになる
            var msg = "Radius: ";
            var msg2 = "Area: ";

            var area = pi * radius * radius;
            Console.WriteLine(msg + radius);
            Console.WriteLine(msg2 + area);
        }
    }
}
