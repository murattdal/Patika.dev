using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Vegatiton : Bios
    {
        protected void Photosynthesis()
        {
            Console.WriteLine("Plants do photosynthesis.");
        }

        //Polymorphism
        public override void Reaction()
        {
            // base.Reaction();
            Console.WriteLine("Plants react to the sun.");
        }
    }

    public class SeededPlants : Vegatiton
    {
        public SeededPlants()
        {
            base.Photosynthesis();
            base.Nutrition();
            base.Respiration();
            base.Discharge();
        }
        public void SeedPropagation()
        {
            Console.WriteLine("Seeded plants reproduce by seed");
        }
    }

    public class SeedlessPlants : Vegatiton
    {
        public SeedlessPlants()
        {
            //base anahtar kelimesi kalıtım aldığım üst sınıflara erişme şansı tanır
            base.Photosynthesis();
            base.Nutrition();
            base.Respiration();
            base.Discharge();

            //Polymorphism
            base.Reaction();
        }
        public void SportsPropagation()
        {
            Console.WriteLine("Seedless plants reproduce by spores");
        }
    }
}
