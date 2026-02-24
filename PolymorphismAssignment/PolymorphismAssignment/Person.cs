using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // Create an abstract class called Person with two properties: firstName and lastName, and a method SayName() that prints the person's full name to the console.
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        // Implement the SayName() method to print the person's full name to the console.

        public virtual void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}
