using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            double charge = 2.40;
            double distance;
            Console.Write("Input the distance travelled :\t");
            distance = Convert.ToDouble(Console.ReadLine());
            double cal_price = charge + distance * 0.4;
            double round_price = Math.Ceiling(cal_price);
            Console.WriteLine("The distance travelled \t" + round_price);
        }
    }
}
