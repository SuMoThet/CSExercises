using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int no = int.Parse(Console.ReadLine());

            int i, j;
            int sum = 0;

             for (i = 1; i <= no; i++)
             {

                 if (no % i == 0)
                {
                    j = no / i;

    	                 if (j != no)
    	                    sum = sum + j;

             	    }
             }
             if (sum == no)
             {
                 Console.WriteLine("Perfect Number.");
                 return;
             }
             else

                 Console.WriteLine("Not Perfect Number.");
                 return;

}
        }
    }

