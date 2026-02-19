using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    public class MathOperations
    {
        // Create a void method that takes two integers
        public void DoMath(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer
            int result = (firstNumber + 20);

            // Display the result of the math operation
            Console.WriteLine("20 added to the first number is: " + result);

            // Display the second integer
            Console.WriteLine("The second number is: " + secondNumber);
            Console.WriteLine(); // Add a blank line for better readability

        }

    }
}
