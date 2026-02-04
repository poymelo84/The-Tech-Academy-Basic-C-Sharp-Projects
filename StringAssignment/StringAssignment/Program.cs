using System;
using System.Text;


namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "This is string concatenantion";
            //string threeStrings = "This strings is.. \"strung\". \nThis string in on a new line. \n \t This string jumped over the fence.";
            //string filename = @"C:\Users\Jaime";

            //bool trueOrFalse = name.Contains("J");
            //bool trueOrFalse2 = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("This is to write a paragraph");
            sb.AppendLine(" on multiple lines");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
