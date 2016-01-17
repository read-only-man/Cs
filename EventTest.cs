using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTest
{
    // イベント用delegate
    delegate void MyEventHandler();

    class MyEvent
    {
        // イベント宣言
        public event MyEventHandler SomeEvent;

        public void Fire()
        {
            if (SomeEvent != null)
                // イベントの送信
                SomeEvent();
        }
    }

    class EventTest
    {

        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();
            evt.SomeEvent += delegate {
                Console.WriteLine("This event called.");
            };

            evt.Fire();
        }
    }
}
