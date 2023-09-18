using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bios
    {
        protected void Nutrition()
        {
            Console.WriteLine("Living things are fed.");
        }

        protected void Respiration()
        {
            Console.WriteLine("Living things breathe.");
        }

        protected void Discharge()
        {
            Console.WriteLine("Living things make excretions.");
        }
    }
}
