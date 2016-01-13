using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class ReverseString
    {
        // 入力された文字を逆順にする
        static void Main(string[] args)
        {
            string arg = Console.ReadLine();

            Console.WriteLine(rev(arg));

        }

        private static string rev(string arg)
        {
            StringBuilder buf = new StringBuilder();
            buf.Append(arg.Substring(arg.Length - 1));
            if (arg.Length > 1) buf.Append(rev(arg.Substring(0, arg.Length - 1)));
            return buf.ToString();
        }
    }
}
