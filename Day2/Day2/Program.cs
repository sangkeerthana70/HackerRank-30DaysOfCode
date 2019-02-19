using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            double mealCost = 12.00;
            int tipPercent = 20;
            int taxPercent = 8;
            double result = CalculateTotalMealCost(mealCost, tipPercent, taxPercent);
        }

        static double CalculateTotalMealCost(double mealCost, int tipPercent, int taxPercent)
        {
            double tip;
            double tax;
            double totalCost;
            // calculate tip which is 20%
            
            tip = mealCost * tipPercent / 100;
            
            Console.WriteLine("tip: " + tip);
            // calculate tax which is 8%
            tax = mealCost * taxPercent / 100;
            Console.WriteLine("tax: " + tax);
            // round totalCost to the nearest dollar (integer) and then print our result, .
            totalCost = Math.Round(mealCost + tip + tax);
            Console.WriteLine("totalCost: " + totalCost);

            return totalCost;
        }
    }
}
