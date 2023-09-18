using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Corolla : ICar
    {
        public Brands Brand()
        {
            return Brands.Toyota;
        }

        public int NumberWheels()
        {
            return 4;
        }

        public Colors StandartColor()
        {
            return Colors.Black;
        }
    }
}
