using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int i=1, sum=0, num;
                for (num = 1; num <1000; num++)
                {
                i = 1;
                while (i < num)
                {
                if (num % i == 0)
                {
                sum = sum + i;
                }
                i++;
                }
                if (sum == num)
                {
                Console.WriteLine(num);
                }
                sum = 0;

                }
                Console.ReadLine();
            }
        }
    }

