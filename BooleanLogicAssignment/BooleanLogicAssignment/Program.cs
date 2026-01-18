using System;


namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application"); // Initiates the program
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());  // Converts it to an integer and stores it in "age"
            Console.WriteLine("Have you ever had a DUI? (Yes or No)");
            string answer = Console.ReadLine().ToLower();  // Converts to lower case and stores it in "answer" 
            bool dui = answer == "yes";                     // If the user types yes, dui becomes true. Otherwise, it becomes false
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified for insurance?");
            bool qualified = age > 15 && !dui && (tickets <= 3);    //Applicant must be over 15 years old AND(&&) no DUIs AND(&&) must have 3 or fewer tickets
            Console.WriteLine(qualified);
        }
    }
}
