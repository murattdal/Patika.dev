using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class NewFocus : Car
    {
        public override Brands Brand()
        {
            return Brands.Ford;
        }
    }
}
