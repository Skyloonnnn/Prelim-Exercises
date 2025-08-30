using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyLoon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.name = "Sky Loon";

            person.DisplayInfo();

            Console.ReadKey();
        }
    }
}
