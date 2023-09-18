using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        //Kalıtım üst sınıfın alt sınıfa miras vermesi anlamına gelir
        static void Main(string[] args)
        {
            /*                  Canlılar
                    Bitkiler        |       Hayvanlar
                 |           |            |           |
                Tohumlu     Tohumsuz    Sürüngenler  Kuşlar
            */

            SeedlessPlants seedlessPlants = new SeedlessPlants();
            seedlessPlants.SportsPropagation();


            Console.WriteLine("##################");

            Birds birds = new Birds();
            birds.FlyingMotion();

        }
    }
}
