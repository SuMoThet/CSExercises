
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter x1 : ");
            int x1 = int.Parse(Console.ReadLine());

            Console.Write("Enter y1 : ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Enter x2 : ");
            int x2 = int.Parse(Console.ReadLine());


            Console.Write("Enter y2 : ");
            int y2 = int.Parse(Console.ReadLine());

            
            double distance = (double)Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));

            Console.WriteLine("\n" + "Distance = " + distance + "\n");
        }
    }
}
