using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseDecimal
{
    class UseDecimal
    {
        // 金利計算
        static void Main(string[] args)
        {
            // decimalは基本型128bit
            decimal balance, rate, rishi;

            balance = 10000.0m;
            rate = 0.1m;

            // decimal型のリテラルはmをつける
            for (int i = 0; i <= 100; i++)
            {
                rishi = rate * balance;

                // 1カ月10%金利で100カ月後まで計算
                Console.WriteLine(i + "month bal=" + balance + " rishi=" + rishi);
                balance += rishi;
            }
        }
    }
}
