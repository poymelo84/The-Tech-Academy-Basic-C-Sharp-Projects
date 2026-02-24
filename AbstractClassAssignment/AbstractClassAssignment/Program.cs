using System;

namespace AbstractClassAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            //In the main method, instatiate an Employee object
            Employee sam = new Employee() { firstName = "Aaron", lastName = "Rodgers" };
            //Call the SayName method on the object
            sam.SayName();
            Console.ReadLine();
        }
    }
}
