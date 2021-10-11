using System;

namespace Homework_error
{
    public enum Unauthorized
    {
        Unauthorized = 1, InvalidCastException = 2, ArgumentException = 3, NullReferenceException = 4
    }

    class Error
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1-4 , that know error");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("Unauthorized") ;
            }
            else if(a == 2)
            {
                Console.WriteLine("InvalidCastException");
            }
            else if (a == 3)
            {
                Console.WriteLine("ArgumentException");
            }
            else if (a == 4)
            {
                Console.WriteLine("NullReferenceException");
            }
            else
            {
                Console.WriteLine("Enter the number 1-4 , that know error");
            }

        }
    }
    
}
