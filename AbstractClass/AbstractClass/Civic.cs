using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Civic : ICar
    {
        public Brands Brand()
        {
            return Brands.Honda;
        }

        public int NumberWheels()
        {
            return 4;
        }

        public Colors StandartColor()
        {
            return Colors.White;
        }
    }
}
