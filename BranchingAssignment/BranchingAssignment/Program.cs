using System;


namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");  // Program start point
            Console.WriteLine("Please enter package weight");
            int weight = Convert.ToInt32(Console.ReadLine());   // Enter weight
            string result = weight > 50 ? "Package too heavy to be shipped via Package Express. Have a good day." : "Please enter the package width";   // Ternary operator. If entered number is greater than 50, condition 1 is ran. Otherwise, it is condition 2.
            Console.WriteLine(result);
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package height");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package length");
            int length = Convert.ToInt32(Console.ReadLine());
            string result1 = width + height + length > 50 ? "Package too big to be shipped via Package Express." : ""; // Ternary operator to check if total dimension is greater than 50.
            Console.WriteLine(result1);
            int total = (length * width * height) * weight / 100; // Mathematical operation to multiply package dimensions divided by 100 to get estimaterd total.
            Console.WriteLine("Your estimated total for shipping this package is: $" + total + ".00");

        }
        
    }
}
