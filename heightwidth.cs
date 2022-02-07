using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Assignment
{
    class heightwidth
    {
        class Table
        {
            private int w = 0;
            private int h = 0;

            public Table(int w, int h)
            {
                if (w >= 0) this.w = w;
                if (h >= 0) this.h = h;
            }
            public void ShowData() => Console.WriteLine("Height - {0} cm, width - {1} cm", h, w);
        }
        class program
        {
            static void Main(string[] args)
            {
                Table[] arr = new Table[10];
                Random value = new Random();
                for (int i = 0; i < 10; i++)
                    arr[i] = new Table(value.Next(10, 50), value.Next(10, 50));
                foreach (var i in arr)
                    i.ShowData();
            }
        }
    }
}
