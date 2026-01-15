using System;   // Using System library


namespace StudentDailyReport    // Namespace declaration
{
    class Program   // Class declaration
    {
        static void Main(string[] args) // Main method - entry point of the program
        {
            Console.WriteLine("Academy of Learning Career College");    // Print to console
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();      // Read user input
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());  // Convert input to integer
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();   // Read user input
            bool needHelpBool = bool.Parse(needHelp);   // Convert input to boolean
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);    // Convert input to integer
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine(); // Wait for user to press Enter before closing
        }
    }
}
