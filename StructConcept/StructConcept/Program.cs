using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructConcept
{
    internal class Program
    {
        //structlar yapısı itibariyle sınıflara çok benzerler
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.ShortEdge = 3;
            rectangle.LongSide = 4;

            Console.WriteLine("Class field account: {0}",rectangle.CalculateArea());

            Console.WriteLine("############");

            Rectangle_Struct rectangle_Struct = new Rectangle_Struct(3,4);

            Console.WriteLine("Struct field account: {0}", rectangle_Struct.CalculateArea());

        }
        

    }

    //Sınıflar structlara göre çok güçlü ama structlar stackte tutulması nedeniyle performans sağlıyor
    class Rectangle
    {
        public int LongSide, ShortEdge;

        public long CalculateArea()
        {
            return this.LongSide * this.ShortEdge;
        }
    }

    //structların constructor'u parametre almalıdır
    struct Rectangle_Struct
    {
        public int LongSide, ShortEdge;

        public Rectangle_Struct(int longSide, int shortEdge)
        {
            this.LongSide = longSide;
            this.ShortEdge = shortEdge;
        }
        public long CalculateArea()
        {
            return this.LongSide * this.ShortEdge;
        }
    }
}
