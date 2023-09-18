using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Civic civic = new Civic();
            Console.WriteLine(civic.Brand().ToString());
            Console.WriteLine(civic.StandartColor().ToString());
            Console.WriteLine(civic.NumberWheels());

            Console.WriteLine("############");

            Focus focus = new Focus();
            Console.WriteLine(focus.Brand().ToString());
            Console.WriteLine(focus.StandartColor().ToString());
            Console.WriteLine(focus.NumberWheels());
        }
    }
}
