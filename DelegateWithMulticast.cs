using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateWithMulticast
{
    // delegateはマルチキャストできる（くっつけられる）
    class DelegateWithMulticast
    {
        public delegate void strMod(ref string str);
        static readonly string str = "This is a test";

        // スペースをハイフンで置き換える
        public static void ReplaceSpaces(ref string str)
        {
            str = str.Replace(' ', '-');
        }

        // スペースを除く
        public static void RemoveSpaces(ref string str)
        {
            string[] words = str.Split(' ');
            str = string.Join("", words);
        }

        // 文字列の並びを逆順させる
        public static void Reverse(ref string str)
        {
            IEnumerable<char> e = str.Reverse<char>();
            StringBuilder buf = new StringBuilder();
            foreach (char c in e)
            {
                buf.Append(c);
            }
            str = buf.ToString();
        }

        static void Main(string[] args)
        {
            string temp = str;

            strMod strOp = ReplaceSpaces;
            strOp += Reverse;

            strOp(ref temp);

            Console.WriteLine(temp);

            temp = str;

            strOp -= ReplaceSpaces;
            strOp += RemoveSpaces;

            strOp(ref temp);

            Console.WriteLine(temp);
        }
    }
}
