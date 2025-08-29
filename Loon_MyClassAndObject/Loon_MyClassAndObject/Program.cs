using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_MyClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object instantiation
            Food food1 = new Food();
            Food food2 = new Food();

            //initialize fields
            food1.pig = "Letchon Baboy";
            food1.fish = "Pritong Isda";
            food1.chicken = "Letchon Manok";

            food2.pig = "Pork Adobo";
            food2.fish = "Sinigang na Bangus";
            food2.chicken = "Chicken Adobo";

            //call the method to display
            food1.DisplayFood();
            food2.DisplayFood();

            Console.ReadKey();
        }
    }
}
