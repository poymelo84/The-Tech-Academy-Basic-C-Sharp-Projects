using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace ConsoleAppArrayAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String Array with 11 colors
            string[] colorArray = { "Red", "Green", "Blue", "Orange", "Yellow", "White", "Black", "Pink", "Purple", "Brown", "Gold" };
            // Ask the user to select a number between 0 and 10 to display a color from the array
            Console.WriteLine("Choose a number between 0 and 10 to select a color from the array:");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;

            while (!validString)
            {
                try
                { 
                    Console.WriteLine("You selected: " + colorArray[stringSelect]); 
                    validString = true; 
                }
                // If the user selects a number outside of the array range, catch the exception and prompt them to select a valid number
                catch
                {
                    Console.WriteLine("Invalid selection. Please choose a number between 0 and 10:");
                    stringSelect = Convert.ToInt32(Console.ReadLine()); 
                }
            }
            // List of strings
            List<string> occupationList = new List<string>()
            {
                "Doctor", "Engineer", "Teacher", "Artist", "Chef", "Musician", "Writer", "Athlete", "Scientist", "Lawyer", "Pilot"
            };
            
            // Ask the user for a number to display the string at that index
            Console.WriteLine("\nSelect another number between 0 and 10 to select an occupation from the list:");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool validList = false;

            while (!validList)
            {
                try
                {
                    Console.WriteLine("Your new occupation is: " + occupationList[listSelect]);
                    validList = true;
                }
                // Add a message to display if the user picks an index that does not exist
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Select a number between 0 and 10. ");
                    listSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
            //Array of integers
            int[] intArray = { 17, 22, 3, 67, 11, 91, 5, 23, 6, 42, 11 };
            //Ask the user for a number to display the string at that index 
            Console.WriteLine("\nSelect a third number between 0 and 10:");
            int intSelect = Convert.ToInt32(Console.ReadLine());
            bool validInt = false;

            while (!validInt)
            {
                try
                {

                    Console.WriteLine("Your lucky number is " + intArray[intSelect]);
                    validInt = true;
                }
                // Add a message to display if the user picks an index that does not exist
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Select a number between 0 and 9. ");
                    intSelect = Convert.ToInt32(Console.ReadLine());

                }
            }

        }
    }
}
