using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleAppAssignmentPart6
{
    class Program
    {
        static void Main(string[] args)
        {
            //CONSOLE APPLICATION ASSIGNMENT PART 1
            // Create a one-dimensional array of strings
            Console.WriteLine("Part 1");
            string[] messages = { "Happy ", "HAppy ", "HAPpy ", "HAPPy ", "HAPPY " };
           
            Console.WriteLine("Words that can be combined with the word 'Happy' to make a phrase. \n");

            // Ask the user for input
            Console.Write("Please input some text: ");
            string userInput = Console.ReadLine();

            // First loop: append user input to each string (no output yet)
            for (int i = 0; i < messages.Length; i++)
            {
                messages[i] += userInput;
            }

            // Second loop: print each updated string
            Console.WriteLine("\nYour messages:");
            foreach (string msg in messages)
            {
                Console.WriteLine(msg);
            }

            Console.WriteLine("\nGoodbye");
            Console.ReadLine();


            //--------------------------------------------------------------------------------------------------------------------------
            //CONSOLE APPLICATION ASSIGNMENT PART 2
            //Infinite loop example
            Console.WriteLine("Part 2");
            Console.WriteLine("Infinite loop example");
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j++);
                // Forgot to increment i → infinite loop. This will print 0 indefinitely. To fix it, we need to add i++ inside the loop.

            }
            Console.ReadLine();


            //--------------------------------------------------------------------------------------------------------------------------
            //CONSOLE APPLICATION ASSIGNMENT PART 3
            // A loop where the "<" operator is used to continue iterating the loop until a certain condition is met. In this case, the loop will continue as long as i is less than 5.
            Console.WriteLine("Part 3");
            Console.WriteLine("Loop with '<' ");
            int k = 0;

            while (k < 5)
            {
                Console.WriteLine("i is: " + k);
                k++;

            }

            // A loop where the "<=" operator is used to continue iterating the loop until a certain condition is met. In this case, the loop will continue as long as i is less than or equal to 5.
            Console.WriteLine();
            Console.WriteLine("Loop with '<=' ");
            int l = 0;

            while (l <= 5)
            {
                Console.WriteLine("l is: " + l);
                l++;
            }
            Console.ReadLine();


            //--------------------------------------------------------------------------------------------------------------------------
            //CONSOLE APPLICATION ASSIGNMENT PART 4
            // Create a list of strings
            Console.WriteLine("Part 4");
            Console.WriteLine("Matching items on list");
            List<string> items = new List<string>()
                {
                    "car",
                    "bus",
                    "train",
                    "ship",
                    "plane"
                };
            // Ask the user for input
            Console.Write("Please input a text: ");
            string search = Console.ReadLine();
            // Loop through the list and check if the user input matches any of the items in the list
            bool found = false;
            // If a match is found, print the index of the item in the list and the item itself
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ToLower().Contains(search.ToLower()))
                {
                    Console.WriteLine($"Text is found on the list as item no. {i}: {items[i]}");
                    found = true;
                    break; // stop the loop once a match is found
                }
            }
            // If no match is found after looping through the entire list, print a message indicating that the user input is not on the list
            if (!found)
            {
                Console.WriteLine("Your input is not on the list.");
            }
            Console.ReadLine();


            //--------------------------------------------------------------------------------------------------------------------------
            //CONSOLE APPLICATION ASSIGNMENT PART 5
            Console.WriteLine("Part 5");
            Console.WriteLine("Matching items on list with 1 duplicate");
            List<string> itemss = new List<string>()
            {
                "car",
                "bus",
                "ship",
                "car",
                "plane",
                "train"
            };
            // Ask the user for input
            Console.Write("Enter text to search for: ");
            string search1 = Console.ReadLine();
            // Loop through the list and check if the user input matches any of the items in the list
            bool found1 = false;
            // If a match is found, print the index of the item in the list and the item itself
            for (int m = 0; m < itemss.Count; m++)
            {
                // Case-insensitive match using ToLower()
                if (itemss[m].ToLower().Contains(search1.ToLower()))
                {
                    Console.WriteLine($"Match found at index {m}: {itemss[m]}"); // Print the index and the item
                    found1 = true;
                }
            }

            // After the loop, check if nothing was found
            if (!found1)
            {
                Console.WriteLine("Your input is not on the list.");
            }
            Console.ReadLine();


            //--------------------------------------------------------------------------------------------------------------------------
            //CONSOLE APPLICATION ASSIGNMENT PART 6
            //Create a List of strings that has atleast two identical strings in the List
            Console.WriteLine("Part 6");
            Console.WriteLine("Matching items on list with multiple duplicates");
            Console.WriteLine();
            List<string> names = new List<string>()
                {
                "Alice",
                "Bob",
                "Charlie",
                "David",
                "Eve",
                "Eve",
                "Alice",
                };
            // Checks the list for any duplicate/repeat names
            List<string> repeatCheck = new List<string>();
            Console.WriteLine("Friends List:");
            //Create a foreach loop that evaluates each item and displays a message whether the string is a duplicate
            foreach (string name in names)
            {
                Console.WriteLine(name);
                // Displays a message stating that the name is a duplicate
                if (repeatCheck.Contains(name))
                {
                    Console.WriteLine("This name is a duplicate. \nUse last name initial when referring to this student.");
                }
                else
                {
                    Console.WriteLine("This name has not been repeated.");
                }
                repeatCheck.Add(name);
            }
            Console.ReadLine();
        }
    }
}
