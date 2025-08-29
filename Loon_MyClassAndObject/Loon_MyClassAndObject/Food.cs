using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_MyClassAndObject
{
    internal class Food
    {
        //attributes
        public string pig, fish, chicken;

        //method to display
        public void DisplayFood()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tFilipino Food Recipes ");

            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("\nPig Food: " + pig + "\nFish Food: " + fish + "\nChicken: " + chicken); 
        }
    }
}
