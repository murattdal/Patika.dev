using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.FirstName = "Test";
            student.LastName = "Test";
            student.StudentNumber = 1;
            student.StudentClass = 1;

            student.BringStudentInformation();
            Console.WriteLine("#######################");

            student.SkipClass();

            student.BringStudentInformation();
            Console.WriteLine("#######################");

            student.DropClass();

            student.BringStudentInformation();


            Student student2 = new Student(2, 1,"Test2","Test2");

            student2.BringStudentInformation();
            Console.WriteLine("#######################");

            student2.DropClass();
            student2.DropClass();

            student2.BringStudentInformation();


        }

        class Student
        {
            private string firstName;
            private string lastName;
            private int studentNumber;
            private int studentClass;

            public string FirstName { get => firstName; set => firstName = value; }
            public string LastName { get => lastName; set => lastName = value; }
            public int StudentNumber { get => studentNumber; set => studentNumber = value; }
            public int StudentClass
            {
                get => studentClass;

                set
                {
                    if (value <1)
                    {
                        Console.WriteLine("The class can be at least one!!");
                        studentClass = 1;
                    }else
                        studentClass = value;



                }
            }

            public Student(int studentClass, int studentNumber, string lastName, string firstName)
            {
                this.StudentClass = studentClass;
                this.studentNumber = studentNumber;
                this.lastName = lastName;
                this.firstName = firstName;
            }

            public Student() { }


            public void BringStudentInformation()
            {
                Console.WriteLine("######### Student Information #########");
                Console.WriteLine("Student First Name: {0}", this.firstName);
                Console.WriteLine("Student Last Name: {0}", this.lastName);
                Console.WriteLine("Student Number: {0}", this.studentNumber);
                Console.WriteLine("Student Grade: {0}", this.StudentClass);
            }

            public void SkipClass()
            {
                this.StudentClass += 1;
            }

            public void DropClass()
            {
                this.StudentClass -= 1;
            }
        }
    }
}
