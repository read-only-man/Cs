using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRect
{
    class MyRect
    {
        private int width;
        private int height;

        public MyRect(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public String toString()
        {
            return this.width + " : " + this.height;
        }

        public int area()
        {
            return this.width * this.height;
        }
    }
    class UseMyRect
    {
        static void Main()
        {
            int r = (new MyRect(30, 50)).area();
            Console.WriteLine("area is " + r);
        }
    }
}
