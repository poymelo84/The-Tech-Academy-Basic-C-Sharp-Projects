using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Number struct and assign a value to the Amount property
            Number myNumber = new Number();
            myNumber.Amount = 67;

            // Display the value of the Amount property to the console
            Console.WriteLine(myNumber.Amount);
            Console.ReadLine();

        }
    }
}
