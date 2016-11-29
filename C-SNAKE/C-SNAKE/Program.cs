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
            Point P1 = new Point(7, 3, '#');

      
            

            List<Point> numList = new List<Point>();
            numList.Add(P1);

            foreach(Point i in numList)
            {
                i.DrawPoint();
            }

            Console.Read();

        }
      
    }
}
