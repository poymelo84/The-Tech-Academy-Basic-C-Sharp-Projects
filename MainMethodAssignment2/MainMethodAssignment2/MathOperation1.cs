using System;

namespace MainMethodAssignment2
{
    class MathOperation1
    {
        //Create a method that takes two integers as parameters
        //Make one parameter optional by providing a deafult value
        public int MathOperation(int i, int j = 1)
        {
            //Perform multiplication on integers and return the result
            int result = i * j;
            return result;
        }
    }
}
