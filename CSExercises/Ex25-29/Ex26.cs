using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NO"+ "\t" +"INVERSE"+ "\t"+ "\t" +"SQUARE ROOT"+ "\t"+"SQUARE");
            Console.WriteLine("---------------------------------------------------");
            double i; double inverse; double Square_root; double Square; double tem;
            for (i = 1; i < 11; i++)
            {
               
                tem = 1/i;
                inverse = Math.Round(tem * 1000.0) / 1000.0;
                tem = 0;
                tem = (double)Math.Sqrt(i);
                Square_root = Math.Round(tem * 1000.0) / 1000.0;
                Square = i*i;

                Console.WriteLine("{0:0.0}\t", i + "\t" + inverse + "\t" + "\t" + Square_root + "\t" + "\t" + Square);
            
            
            }

        }
    }
}
