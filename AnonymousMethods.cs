using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethods
{
    // delegateを用いた匿名メソッド
    class AnonymousMethods
    {
        // delegate宣言
        delegate int CountIt(int end);

        static void Main(string[] args)
        {
            CountIt ci = delegate (int end)
            {
                int sum = 0;
                for (int i = 0; i < end; i++)
                {
                    Console.Write(i + " ");
                    sum += i;
                }
                Console.WriteLine();
                return sum;
            };

            int ret = ci(5);
            Console.WriteLine("sum of 0 to 5 : " + ret);
        }
    }
}
