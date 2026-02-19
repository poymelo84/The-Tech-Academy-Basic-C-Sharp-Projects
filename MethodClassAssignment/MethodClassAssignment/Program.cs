using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOperations ops = new MathOperations();
            Console.WriteLine("Calling in the method by passing the two numbers normally.");

            // Call the method by passing two numbers normally
            ops.DoMath(10, 25);
            Console.WriteLine("Calling in the method by passing the two numbers using named parameters.");
            // Call the method using named parameters
            Console.WriteLine("firstNumber = 10, secondNumber = 25");

            Console.ReadLine();

        }
    }
}
