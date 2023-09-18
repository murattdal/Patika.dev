﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public interface ICar
    {
        int NumberWheels();
        Brands Brand();
        Colors StandartColor();
    }
}
