using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("X\t\tY");
            Console.WriteLine("---------------------");
            int x, y;
            for (x = -5; x < 5; x++)
            {
                y = 2 * x * x - 4 * x + 3;
                Console.WriteLine("{0:0.0}\t\t{0:0.0}", x, y);
            }

        }
    }
}
