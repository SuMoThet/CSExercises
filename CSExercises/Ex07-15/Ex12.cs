﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter distance travel in km : ");
            double d = double.Parse(Console.ReadLine());

            double charge = 2.40;

            double total = d * 0.4 + charge;

            Console.WriteLine("\n" + "The total fare is : " + total );

            double result = Math.Round(total * 100.0) / 100.0; ;

            Console.WriteLine("\n" + "The total fare in two decimal places : " + result + "\n");
        }
    }
}
