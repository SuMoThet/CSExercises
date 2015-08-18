using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
   public class Ex25b
    {
       public static void Main(string[] args)
       {
           int i, n, fact;
            Console.WriteLine( "Enter the Number: ");
            n = int.Parse(Console.ReadLine());
            fact = n  ;
            for (i = n- 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFactorial of Given Number is: "+fact);
            Console.ReadLine();
       }
    }
}
