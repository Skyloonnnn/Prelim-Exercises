using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_COContructorUserInput
{
    internal class Foods
    {
        //Fields
        public string pig, fish, chicken;


        //Parameterized constructor
        public Foods(string pigFood, string fishFood, string chickenFood)
        {
            pig = pigFood;
            fish = fishFood;
            chicken = chickenFood;
        }

        // Methods to display food details
        public void DisplayFoodDetail()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Here are the favorite food you want in this different meat of animals");
            Console.WriteLine("\nYour favorite Pig Food: " + pig);
            Console.WriteLine("Your favorite Fish Food: " + fish);
            Console.WriteLine("Your favorite Chicken Food: " + chicken);
        }
    }
}
