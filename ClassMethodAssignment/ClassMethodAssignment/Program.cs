using System;

namespace ClassMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class so we can call its non-static methods
            VoidMethod math = new VoidMethod();

            // Ask the user for a number
            Console.WriteLine("Input a number:");
            int dividend = Convert.ToInt32(Console.ReadLine());

            // Call the void method that divides the number by 2
            math.MathOp(dividend);

            // Display the result stored in the Value property
            Console.WriteLine("Half of your number is: " + math.Value);
            Console.ReadLine();

            // Ask the user for a phrase
            Console.WriteLine("Input a phrase:");
            string input = Console.ReadLine();

            // Call the method with an output parameter
            string phrase = math.StringCounter(input, out int count);

            // Display the returned string and the count
            Console.WriteLine(phrase);
            Console.WriteLine("Doubled would be: " + (count * 2));
            Console.ReadLine();

            // Ask for another phrase
            Console.WriteLine("Input another phrase:");
            string input2 = Console.ReadLine();

            // Call the overloaded version of StringCounter
            int phrase2_len = math.StringCounter(input2);

            // Display the length
            Console.WriteLine("This phrase is " + phrase2_len + " characters long");
            Console.ReadLine();

            // Ask for another phrase for the static class
            Console.WriteLine("Input another phrase:");
            string input3 = Console.ReadLine();

            // Call the static method in the static class
            int i_count = StaticTools.IFinder(input3);

            // Display the number of 'i' characters
            Console.WriteLine("This phrase has " + i_count + " i's in it");
            Console.ReadLine();


        }
    }
}
