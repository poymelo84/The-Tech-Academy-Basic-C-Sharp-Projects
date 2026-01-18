using System;


namespace MathAndComparisonOperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");   // Initializes the program
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            decimal hourlyRate1 = decimal.Parse(Console.ReadLine());    // A decimal value can be entered
            Console.WriteLine("Hours worked per week?");
            decimal hours1 = decimal.Parse(Console.ReadLine());     // A decimal value can be entered
            decimal salary1 = hourlyRate1 * hours1 * 52;            // The product is in decimal
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            decimal hourlyRate2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            decimal hours2 = decimal.Parse(Console.ReadLine());
            decimal salary2 = hourlyRate2 * hours2 * 52;
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine(salary1);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isMore = salary1 > salary2;                        // Boolean comparator
            Console.WriteLine(isMore);
            Console.ReadLine();
        }
    }
}
