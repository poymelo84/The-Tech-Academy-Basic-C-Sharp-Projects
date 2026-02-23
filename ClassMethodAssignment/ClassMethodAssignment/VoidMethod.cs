using System;

namespace ClassMethodAssignment
{
    public class VoidMethod
    {
        // Property used to store the result of MathOp()
        public int Value { get; set; }

        // Void method that divides the passed integer by 2
        public void MathOp(int number)
        {
            // Divide the number by 2 and store it in the Value property
            Value = number / 2;
        }

        // Method with an output parameter
        public string StringCounter(string input, out int count)
        {
            // Count the number of characters in the string
            count = input.Length;

            // Return a message containing the original string
            return "You typed: " + input;
        }

        // Overloaded method: same name, different parameters
        public int StringCounter(string input)
        {
            // Simply return the length of the string
            return input.Length;


        }
    }
}
