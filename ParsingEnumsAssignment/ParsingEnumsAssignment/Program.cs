using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        //Create an enum for the days of the week.
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            bool isvalid = false;
            while(!isvalid)
            {
                try
                {
                    //prompt the user to enter the current day of the week.
                    Console.WriteLine("Please enter the current day of the week:");
                    string dayinput = Console.ReadLine();
                    //Assign the value to a variable of that enum data type you just created.
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayinput);
                    Console.WriteLine("Have a nice " + day);
                    isvalid = true;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter an actual day of the week");
                    Console.ReadLine();
                }
            }
        }
    }
}
