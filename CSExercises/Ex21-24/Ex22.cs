using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int a, b, Num1, Num2, temp, LCM, HCF;

            Console.Write("Enter A : ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter B : ");
            b = int.Parse(Console.ReadLine());

          
            Num1 = a;
            Num2 = b;
            while (Num2 != 0)
            {
                temp = Num2;
                Num2 = Num1 % Num2;
                Num1 = temp;
            }
            HCF = Num1;
            LCM = (a * b) / HCF;

            Console.WriteLine("LCM for {0} and {1} is {2}", a, b, LCM);
            Console.WriteLine("GCD for {0} and {1} is {2}", a, b, HCF);

           
        }
    }
}
