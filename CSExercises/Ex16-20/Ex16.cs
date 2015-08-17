using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            
            Console.Write("Enter your name : " + "\n");
            string name = Convert.ToString(Console.ReadLine());

            Console.Write("Sex(F=Female/M=Male): " + "\n");
            char Sex = char.Parse(Console.ReadLine());


            if (Sex == 'f')

            {
                Console.WriteLine("Good Morning Ms." + name);
            }

            else if (Sex == 'F')
            {
                Console.WriteLine("Good Morning Ms." + name);
            }
            else if (Sex == 'm')
            {
                Console.WriteLine("Good Morning Mr." + name);
            }
            else if (Sex == 'M')
            {
                Console.WriteLine("Good Morning Mr." + name);
            }
        
            else 
            {
                Console.WriteLine("Good Morning " + name);
            }
        }
    }
}