using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class NewCorolla : Car
    {
        public override Brands Brand()
        {
            return Brands.Toyota;
        }

        public override Colors StandartColor()
        {
            return Colors.Blue;
        }
    }
}
