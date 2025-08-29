using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_CaO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sky Loon
            //IT306
            //Exercise 1: Creating a class 

            //Object instantiation
            Person person1 = new Person();

            //initialization of fields 
            person1.age = 18;
            person1.gender = "MALE";
            person1.name = "Sky Loon";

            //call the method
            person1.Greet();

            Console.ReadKey();
            
        }
    }
}
