using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    class RefOut
    {
        static void Main(string[] args)
        {
            bool a, b, c;
            a = b = false;
            valMethod(a);
            refMethod(ref b);
            outMethod(out c);
            Console.Out.WriteLine("a = " + a);
            Console.Out.WriteLine("b = " + b);
            Console.Out.WriteLine("c = " + c);

        }

        // 値渡し
        static private void valMethod(bool x)
        {
            x = !x;
        }

        // ref 参照渡し
        static private void refMethod(ref bool x)
        {
            x = !x;
        }

        // out 出力（設定用の参照渡し）
        static private void outMethod(out bool x)
        {
            x = true;
        }
    }
}
