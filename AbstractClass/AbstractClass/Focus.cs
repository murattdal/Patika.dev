using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Focus : ICar
    {
        public Brands Brand()
        {
            return Brands.Ford;
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
