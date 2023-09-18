using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        //Abstract classlar sadece kalıtım için kullanılır 
        //nesneleri yaratılamazlar
        //Bir sınıf üzerinden türetilmesi gerekir
        static void Main(string[] args)
        {
            Console.WriteLine("######Interface######");

            Civic civic = new Civic();
            Console.WriteLine(civic.Brand().ToString());
            Console.WriteLine(civic.StandartColor().ToString());
            Console.WriteLine(civic.NumberWheels());

            Console.WriteLine("######Interface######");

            Focus focus = new Focus();
            Console.WriteLine(focus.Brand().ToString());
            Console.WriteLine(focus.StandartColor().ToString());
            Console.WriteLine(focus.NumberWheels());

            Console.WriteLine("######Abstract######");

            NewCorolla corolla = new NewCorolla();
            Console.WriteLine(corolla.Brand().ToString());
            Console.WriteLine(corolla.StandartColor().ToString());
            Console.WriteLine(corolla.NumberWheels());


        }
    }
}
