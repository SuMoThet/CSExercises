using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name : ");
            string name = Convert.ToString(Console.ReadLine());

            Console.Write("Sex(F=Female/M=Male): ");
            char Sex = char.Parse(Console.ReadLine());

            Console.Write("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 40 && Sex == 'M')            
                Console.WriteLine("Good Morning Uncle " + name);
            
            else if (age > 40 && Sex == 'F')
                Console.WriteLine("Good Morning Aunty " + name);

            else if (age < 40 && Sex == 'M')
                Console.WriteLine("Good Morning Mr." + name);

            else if (age < 40 && Sex == 'F')
                Console.WriteLine("Good Morning Ms." + name);

           

            

        }
    }
}