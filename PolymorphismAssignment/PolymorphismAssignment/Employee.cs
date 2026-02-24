using System;

namespace PolymorphismAssignment
{
    
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        //Implement the SayName() method from Person
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }

        //Implement the Quit() method from IQuittable
        public void Quit()
        {
            // Implement the Quit() method to print a message to the console indicating that the employee has quit the company.
            Console.WriteLine($"{firstName} {lastName} has quit the company.");
        }
    }

}