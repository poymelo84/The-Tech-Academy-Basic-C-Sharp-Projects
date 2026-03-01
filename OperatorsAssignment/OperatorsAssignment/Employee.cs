using System;

namespace OperatorsAssignment
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overload ==
        public static bool operator ==(Employee e1, Employee e2)
        {
            // Handle null cases
            if (ReferenceEquals(e1, e2))
                return true;

            if (ReferenceEquals(e1, null) || ReferenceEquals(e2, null))
                return false;

            return e1.Id == e2.Id;
        }

        // Overload !=
        public static bool operator !=(Employee e1, Employee e2)
        {
            return !(e1 == e2);
        }

        //// Override Equals (recommended when overloading ==)
        //public override bool Equals(object obj)
        //{
        //    if (obj is Employee other)
        //        return this.Id == other.Id;

        //    return false;
        //}

        //// Override GetHashCode (recommended when overriding Equals)
        //public override int GetHashCode()
        //{
        //    return Id.GetHashCode();
        //}


    }
}
