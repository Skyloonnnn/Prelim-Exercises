using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_COContructorUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Sky Loon
        //IT306
        //Exercise 3:User Input with Constructor

        Main:
            //Ask user to input favorite foods
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tThis program will ask if what is your Favorite Food");
            Console.Write("\nWhat is your favorite Fish Food: ");
            string fishFood = Console.ReadLine();
            Console.Write("\nWhat is your favorite Pig Food: ");
            string pigFood = Console.ReadLine();
            Console.Write("\nWhat is your favorite Chicken Food: ");
            string chickenFood = Console.ReadLine();

            //instantiation of a class object
            Foods foods = new Foods(fishFood, pigFood, chickenFood);

            //call the method to display detail
            foods.DisplayFoodDetail();

            //ask the user to input another
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nDo you want to input another favorite food? (y/n) ");
            char choice = Convert.ToChar(Console.ReadLine());
            if (choice == 'y')
            {
                goto Main;
            }
            else if (choice == 'n')
            {
                return;
            }

        }
    }
}
