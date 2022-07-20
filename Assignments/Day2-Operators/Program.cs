using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Day2_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

            int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

            int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

        }

        public static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double tipCost = meal_cost * tip_percent / 100;
            double taxtCost = meal_cost * tax_percent / 100;
            double totalCost = meal_cost + tipCost + taxtCost;
        
            Console.WriteLine(Math.Round(totalCost));
        }
    }

    
}
