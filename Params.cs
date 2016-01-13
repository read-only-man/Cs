using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    class Params
    {
        static void Main(string[] args)
        {
            test("a", "b", "v", "f");
            test(1,2,3);
        }

        // 可変引数
        static private void test(params object[] ary)
        {
            foreach (object o in ary)
            {
                Console.WriteLine(o.GetType() == (Type)typeof(string) ? o : o.ToString());
            }
        }
    }
}
