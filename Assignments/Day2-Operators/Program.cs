using System;

namespace Day2_Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            double tipCost = meal_cost * tip_percent / 100;
            double taxtCost = meal_cost * tax_percent / 100;
            double totalCost = meal_cost + tipCost + taxtCost;
        
            Console.WriteLine(Math.Round(totalCost)); // Math.Round ile en yakn integer değere yuvarla. 
        }
    }
}
