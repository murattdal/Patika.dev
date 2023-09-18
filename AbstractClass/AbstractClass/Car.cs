using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Car
    {
        public int NumberWheels()
        {
            return 4;
        }

        public virtual Colors StandartColor()
        {
            return Colors.White;
        }

        public abstract Brands Brand();

    }
}
