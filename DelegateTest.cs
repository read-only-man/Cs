using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest
{
    class DelegateTest
    {
        public delegate string strMod(string str);
        static readonly string str = "This is a test";

        // スペースをハイフンで置き換える
        public static string ReplaceSpaces(string str)
        {
            return str.Replace(' ', '-');
        }

        // スペースを除く
        public static string RemoveSpaces(string str)
        {
            string[] words = str.Split(' ');
            return string.Join("",words);
        }

        // 文字列の並びを逆順させる
        public static string Reverse(string str)
        {
            IEnumerable<char> e = str.Reverse<char>();
            StringBuilder buf = new StringBuilder();
            foreach (char c in  e)
            {
                buf.Append(c);
            }
            return buf.ToString();
        }

        static void Main(string[] args)
        {
            strMod[] strOps = { ReplaceSpaces, RemoveSpaces , Reverse };
            foreach(strMod strOp in strOps)
            {
                Console.WriteLine(strOp(str));
            }
        }
    }
}
