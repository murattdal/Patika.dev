using System;
using System.Linq;

namespace EnumStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kodun okunabilirliğini arttırmak için kullanılır

            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Tuesday);
            Console.WriteLine((int)Days.Monday);

            Console.WriteLine("#############");

            Console.Write("How many degrees is the air temperature?: ");
            int temperature = Convert.ToInt32(Console.ReadLine());

            if (temperature <= (int)WeatherForceast.normal)
                Console.WriteLine("Let's wait for the weather to get a little warmer to go outside");
            else if (temperature >= (int)WeatherForceast.hot)
                Console.WriteLine("It's a hot day to go outside");
            else if (temperature >= (int)WeatherForceast.normal && temperature < (int)WeatherForceast.veryHot)
                Console.WriteLine("Let's go outside");
        }


    }

    enum Days
    {
        Monday = 5, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    enum WeatherForceast
    {
        cold = 5, normal = 20, hot = 25, veryHot = 30
    }
}
