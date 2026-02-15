using System;
using System.Collections.Generic;

internal class Program
{
   static void Main(string[] args)
   {
        //Create a list of integers
        List<int> intList = new List<int>() { 3, 234, 6783, 2, 1001, 87012, 45, 9, 0, 56 };
        Console.WriteLine("(3, 234, 6783, 2, 1001, 87012, 45, 9, 0, 56)");
        //Ask the user for input and loop through the list dividing each number by the input
        bool numValid = false;
        while (!numValid)
        {
            //Use a try/catch block to give an error message
            try
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a number to divide the above list by: ");
                Console.WriteLine();
                float numDivide = float.Parse(Console.ReadLine());
                Console.WriteLine();
                //If statement to check if the user entered 0
                if (numDivide == 0)
                {
                    Console.WriteLine("Please enter a number other than 0.");
                }
                //Dividing each number in the list by the input
                else
                {
                    foreach (int num in intList)
                    {
                        float Divide = num / numDivide;
                        Console.WriteLine(num + "/" + numDivide + " = " + Divide);
                    }
                    numValid = true;
                }
            }
            //Catch block to display error message for string input
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
        //Message to let the user know the program has exited the try/catch block
        Console.WriteLine();
        Console.WriteLine("The program has exited the try/catch block.");
        Console.ReadLine();
   }
}

