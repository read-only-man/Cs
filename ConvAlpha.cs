using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConvAlpha
{
    /*
      ピリオドまでキー入力を読み込み、
      アルファベットを変換して表示する。
    */
    class ConvAlpha
    {
        static void Main(string[] args)
        {
            char c;

            while ((c = (char)Console.Read()) != '.')
            {
                if (Regex.IsMatch( c.ToString(),"[a-z]"))
                {
                    int i = (int)c;
                    c = (char) (i - 32);
                }
                else if(Regex.IsMatch(c.ToString(), "[A-Z]"))
                {
                    int i = (int)c;
                    c = (char)(i + 32);
                }
                Console.WriteLine(c);
            }
        }
    }
}
