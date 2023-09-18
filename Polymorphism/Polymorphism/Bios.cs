using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bios
    {
        //sealed anahtar kelimesi kalıtım yapmayı engellemek için kullanılır
        //örnek olarak: public sealed class Bios
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

        //Polymorphism
        public virtual void Reaction()
        {
            Console.WriteLine("Living things react to stimuli.");
        }
    }
}
