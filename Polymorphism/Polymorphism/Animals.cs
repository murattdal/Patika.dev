using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Animals:Bios
    {
        protected void Adaptation()
        {
            Console.WriteLine("Animals can adapt.");
        }

        //Polymorphism
        public override void Reaction()
        {
            base.Reaction();
            Console.WriteLine("Animals react to contact");
        }
    }

    public class Reptiles:Animals
    {
        public Reptiles()
        {
            base.Adaptation();
            base.Nutrition();
            base.Respiration();
            base.Discharge();
        }
        public void CrawlingMotion()
        {
            Console.WriteLine("Reptiles move by crawling.");
        }
    }

    public class Birds:Animals
    {
        public Birds()
        {
            base.Adaptation();
            base.Nutrition();
            base.Respiration();
            base.Discharge();

            //Polymorphism
            base.Reaction();
        }
        public void FlyingMotion()
        {
            Console.WriteLine("Birds move by flying.");
        }
    }
}
