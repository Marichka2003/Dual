using System;

namespace homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("First number:");
            float a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Second number:");
            float b = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("Third number:");
            float c = Convert.ToSingle(Console.ReadLine());

            if (a > -5 && a < 5 && b > -5 && b < 5 && c > -5 && c< 5)
            {
                Console.WriteLine("Yes - a,b,c in range [-5 ; 5]");
            }
            else
            {
                Console.WriteLine("No - a,b,c doesn't in range [-5 ; 5]");
            }

                    

        }
    }
}
