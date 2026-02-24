using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Employee class and call the SayName() method on it.
            Employee emp = new Employee() { firstName = "Richard", lastName = "Winters" };
            // Call the Quit() method on the object.
            IQuittable quitter = emp;

            quitter.Quit();
            Console.ReadLine();
        }
    }
}
