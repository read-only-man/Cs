using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars
{
    // 火星までの通信時間を確認する。
    class Mars
    {
        static void Main(string[] args)
        {
            double distance, lightspeed, delay, delay_in_min;

            distance = 34000000; // 火星との距離 34,000,000マイル
            lightspeed = 186000; // 光の速さ 186,000　マイル/秒

            delay = distance / lightspeed;
            delay_in_min = delay / 60.0;

            // 書式設定して出力する。
            Console.WriteLine("Time delay when talking to Mars: {0:###.###} sec" , delay);
            Console.WriteLine("Time delay when talking to Mars: {0:###.###} min", delay_in_min);
        }
    }
}
