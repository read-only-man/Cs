using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DispPrime
{
    class DispPrime
    {
        // キャッシュ
        static ArrayList primes = new ArrayList();

        // 10,000までの素数を表示する
        static void Main(string[] args)
        {
            primes.Add(2);

            for (int i=1;i < 10000; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine("{0:###,###}", i);
                }
            }
        }

        private static bool isPrime(int i)
        {
            bool result = true;

            if (i== 1 || i== 2)
            {
                return result;
            }

            foreach (int x in primes)
            {
                if (i % x == 0)
                {
                    return false;
                }
            }
            primes.Add(i);
            return result;
        }
    }
}
