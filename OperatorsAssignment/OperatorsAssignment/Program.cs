using System;

namespace OperatorsAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Create an Employee object
            Employee emp1 = new Employee
            {
                Id = 23,
                FirstName = "Michael",
                LastName = "Jordan"
            };

            // Create another Employee object with the same Id but different names
            Employee emp2 = new Employee
            {
                Id = 45,
                FirstName = "Michael",
                LastName = "Jordan"
            };

            // Display the Employee objects
            Console.WriteLine("The Employee objects are being compared here:");
            Console.WriteLine();
            // Display the properties of emp1
            Console.WriteLine($"emp1 == emp2 --> {emp1 == emp2}");
            // Display the properties of emp2
            Console.WriteLine($"emp1 != emp2 --> {emp1 != emp2}");

            Console.ReadLine();
            


        }
    }
}
