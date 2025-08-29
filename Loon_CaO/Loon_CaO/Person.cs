using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_CaO
{
    internal class Person
    {
        //Class member
        public int age;
        public string name;
        public string gender;

        public void Greet()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" Hello good afternoon everyone and good afternoon Ms Farah, My name is " + name + " I'm " + age + "years old, and my gender is " + gender);
        }
    }
}
