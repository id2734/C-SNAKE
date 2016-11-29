using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SNAKE
{
    class Program
    {
        static void Main(string[] args)
        {
            Point P1 = new Point();

            P1.x = 1;
            P1.y = 3;
            P1.sym = '#';
            P1.DrawPoint();
            Console.Read();

        }
      
    }
}
