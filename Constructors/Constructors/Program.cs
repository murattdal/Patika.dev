using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Test", "Test",1, "Test");
            employee.EmployeeInformation();

            Console.WriteLine("########################");

            Employee employee2 = new Employee("Test2", "Test2", 2, "Test2");
            employee2.EmployeeInformation();

            Console.WriteLine("########################");

            Employee employee3 = new Employee("Test3", "Test3");
            employee3.EmployeeInformation();
        }

    }
    class Employee
    {
        public string FirstName;
        public string LastName;
        public int Number;
        public string Department;

        public Employee() { }
        public Employee(string firstName, string lastName, int number, string department) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Number = number;
            this.Department = department;
            
        }public Employee(string firstName, string lastName) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;

        }


        public void EmployeeInformation()
        {
            Console.WriteLine("First Name: {0}", FirstName);
            Console.WriteLine("Last Name: {0}", LastName);
            Console.WriteLine("Number: {0}", Number);
            Console.WriteLine("Department: {0}", Department);

        }
    }
}
