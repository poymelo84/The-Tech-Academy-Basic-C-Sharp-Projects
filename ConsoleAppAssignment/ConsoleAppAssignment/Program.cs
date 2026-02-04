using System;


namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            do              //This is a do while loop
            { 
                Console.WriteLine("This is a do while loop done 10 times");
                count++;    //Add one to count each time
            } 
            while (count < 10); //Loop coninues until it counts 10


            int counting = 0;
            while (counting < 8)    //This is a while loop
            {
                Console.WriteLine("This is a while loop done 8 times");
                counting++;     //Add one to count each time

            }
            Console.ReadLine();
        }
    }
}
