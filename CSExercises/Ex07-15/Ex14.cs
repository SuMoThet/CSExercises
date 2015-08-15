using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the value of a : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of b : ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of c : ");
            int c = int.Parse(Console.ReadLine());

            double s =( a + b + c) / 2;

            double s1 = s - a;
            double s2 = s - b;
            double s3 = s - c;
            double s4 = s * s1 * s2 * s3;

            double area = (double)Math.Sqrt( s4 );

            Console.WriteLine("\n" + "Area : " + area);
            

        }
    }
}