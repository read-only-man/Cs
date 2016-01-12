using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumOfSpaceWhilePriod
{
    /*
     ピリオドまでキー入力を読み込み、
     挿入されたスペースの数を表示する。
    */
    class CountNumOfSpaceWhilePriod
    {
        static void Main(string[] args)
        {
            char c;
            int cnt=0;
            StringBuilder buf = new StringBuilder();

            while ((c = (char) Console.Read()) != '.'){
                if (c == ' ')
                {
                    cnt++;
                }
                buf.Append(c);
            }
            Console.WriteLine(buf + " has " + cnt + " spaces");
        }
    }
}
