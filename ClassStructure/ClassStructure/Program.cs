using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Test";
            employee.LastName = "Test";
            employee.Number = 1;
            employee.Department = "Test";

            employee.EmployeeInformation();

            Console.WriteLine("########################");
            
            Employee employee2 = new Employee();
            employee2.FirstName = "Test2";
            employee2.LastName = "Test2";
            employee2.Number = 2;
            employee2.Department = "Test2";

            employee2.EmployeeInformation();
        }

    }
    class Employee
    {
        public string FirstName;
        public string LastName;
        public int Number;
        public string Department;


        public void EmployeeInformation()
        {
            Console.WriteLine("First Name: {0}", FirstName);
            Console.WriteLine("Last Name: {0}", LastName);
            Console.WriteLine("Number: {0}", Number);
            Console.WriteLine("Department: {0}", Department);

        }
    }
}
