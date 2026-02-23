using System;


namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        //Create a class called person and give it two properties, each of data type string
        //Once called FirstName, the other LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Give the class a void method called sayName() that takes no parameters and simply writes
        //the person's full name to the console in the format of: "Name: [full name]"
        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }
    }

}
