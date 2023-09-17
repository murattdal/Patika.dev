using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The number of employee: {0}",Employee.EmployeeNumber);

            Employee employee = new Employee("Test","Test","Test");
            Console.WriteLine("The number of employee {0}",Employee.EmployeeNumber);

            Employee employee2 = new Employee("Test2", "Test2", "Test2");
            Console.WriteLine("The number of employee {0}", Employee.EmployeeNumber);


            Console.WriteLine("######################");

            Console.WriteLine("The result of the collection process: {0}", Transactions.Collect(100, 200));
            Console.WriteLine("The result of the extraction process: {0}", Transactions.Extraction(100, 200));

        }
    }
    //Statik değişkenlere class ismiyle erişilir 
    class Employee
    {
        private static int employeeNumber;

        public static int EmployeeNumber { get => employeeNumber; }

        private string firstName;

        private string lastName;

        private string department;

        public Employee(string firstName, string lastName, string department)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.department = department;
            employeeNumber += 1;
        }

        static Employee()
        {
            employeeNumber = 0;
        }

    }

    //Bir class'ı static yaparsak içindeki tüm propertyler,fieldlar,methodlar static olmak zorunda
    //Static classlara kalıtım uygulanamaz
    static class Transactions
    {
        public static long Collect(int number1,int number2)
        {
            return number1 + number2;
        }
        
        public static long Extraction(int number1,int number2)
        {
            return number1 - number2;
        }
    }
}
