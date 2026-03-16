using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System;

using System;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new StudentContext())
        {
            var student = new Student
            {
                Name = "Steph Curry",
                Age = 20
            };

            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("One student added successfully.");
        }

        Console.ReadLine();
    }
}
public class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
    }
public class StudentContext : DbContext
{
    public StudentContext() : base("StudentDb")
    {
    }

    public DbSet<Student> Students { get; set; }
}
