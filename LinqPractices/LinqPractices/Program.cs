using LinqPractices.DbOperations;
using LinqPractices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataGenerator.Initialize();
            LinqDbContext context = new LinqDbContext();

            var students = context.Students.ToList<Student>();


            //Find()
            //Arama yaparak veriye erişmeyi sağlıyor

            Console.WriteLine("##########Find##########");

            var student = context.Students.Find(1);

            Console.WriteLine(student.FirstName);

            //FirstOrDefault()
            //İlk veriyi getirir

            Console.WriteLine("##########FirstOrDefault##########");

            student = context.Students.Where(x => x.FirstName == "Murat").FirstOrDefault();

            Console.WriteLine(student.LastName);
            Console.WriteLine();

            //Diğer yazımı
            student = context.Students.FirstOrDefault(x => x.FirstName == "Murat");
            Console.WriteLine(student.LastName);


            //SingleOrDefault
            //1 ya da 0 veri bekler 2 tane veri gelirse hata fırlatılır

            Console.WriteLine("##########SingleOrDefault##########");

            student = context.Students.SingleOrDefault(x => x.FirstName == "Deniz");

            Console.WriteLine(student.StudentId);


            //ToList()
            //Listeleme işlemi yapar

            Console.WriteLine("##########ToList()##########");

            var studentList = context.Students.Where(x => x.ClassId == 2).ToList();
            Console.WriteLine(studentList.Count);

            foreach (var item in studentList)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }


            //OrderBy
            //verilen değişkene göre sıralama işlemi yapar

            Console.WriteLine("##########OrderBy##########");

            students = context.Students.OrderBy(x => x.FirstName).ToList();
            foreach (var item in students)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }


            //OrderByDescending
            //verilen kolona göre descending sıralar yani z'den a'ya sıralar

            Console.WriteLine("##########OrderByDescending##########");

            students = context.Students.OrderByDescending(x => x.FirstName).ToList();
            foreach (var item in students)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }



            //Anonymous object Result
            //Daha kompleks objeler döndürmek için kullanılır

            Console.WriteLine();

            Console.WriteLine("##########Anonymous object Result##########");

            var anonymousObject = context.Students
                                    .Where(x => x.ClassId == 2)
                                    .Select(x => new
                                    {
                                        Id = x.StudentId,
                                        FullName = x.FirstName + " " + x.LastName,
                                    });

            foreach (var item in anonymousObject)
            {
                Console.WriteLine(item.Id + " - " + item.FullName);
            }

        }
    }
}
