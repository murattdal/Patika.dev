using LinqPractices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractices.DbOperations
{
    public class DataGenerator
    {
        public static void Initialize()
        {
            using (var context = new LinqDbContext())
            {
                if (context.Students.Any())
                {
                    return;
                }

                context.Students.AddRange(
                    new Student()
                    {
                       // StudentId = 1,
                        FirstName = "Murat",
                        LastName = "Dal",
                        ClassId = 1,

                    },

                    new Student()
                    {
                       // StudentId = 2,
                        FirstName = "Deniz",
                        LastName = "Arda",
                        ClassId = 2,

                    },

                     new Student()
                     {
                       //  StudentId = 3,
                         FirstName = "Ayşe",
                         LastName = "Yılmaz",
                         ClassId = 2,

                     },

                     new Student()
                     {
                        // StudentId = 4,
                         FirstName = "Merve",
                         LastName = "Çalışkan",
                         ClassId = 1,

                     });

                context.SaveChanges();

            }
        }
    }
}
