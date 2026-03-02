using System;
using System.Collections.Generic;
using System.Linq;


namespace LambdaExpressionAssignment
{
   class Program
    {
        static void Main(string[] args)
        {
            //In the main() method, create a list of atleast 10 employees.
            //Atleast two employees should have the first name "Joe".
            List<Employee> campus = new List<Employee>()
            {
                new Employee() { Id = 1, firstName = "Joe", lastName = "Smith" },
                new Employee() { Id = 2, firstName = "Jane", lastName = "Doe" },
                new Employee() { Id = 3, firstName = "John", lastName = "Doe" },
                new Employee() { Id = 4, firstName = "Joe", lastName = "Johnson" },
                new Employee() { Id = 5, firstName = "Emily", lastName = "Davis" },
                new Employee() { Id = 6, firstName = "Michael", lastName = "Brown" },
                new Employee() { Id = 7, firstName = "Sarah", lastName = "Wilson" },
                new Employee() { Id = 8, firstName = "David", lastName = "Miller" },
                new Employee() { Id = 9, firstName = "Laura", lastName = "Garcia" },
                new Employee() { Id = 10, firstName = "James", lastName = "Anderson" }
            };
            //Using a foreach loop, create a new list of all employees with the first name "Joe".
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in campus)
            {
                if (employee.firstName == "Joe")
                {
                    joes.Add(employee);
                }
            }
            //Do the same thing again, but this time with a lambda expression.
            List<Employee> joes2 = campus.Where(x => x.firstName == "Joe").ToList();
            //Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> bigId = campus.Where(x => x.Id > 5).ToList();
            Console.ReadLine();

        }
    }
}
