using System;

namespace Homework_1_2
{
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("First number:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Second number:");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Third number:");
                int c = Convert.ToInt32(Console.ReadLine());

                if (a > b && a > c)
                {
                    Console.WriteLine($"{a} the biggest number ");
                }
            
                if(b > a && b > c)
                {
                    Console.WriteLine($"{b}the biggest number ");
                }

                else
                {
                    Console.WriteLine($"{c} the biggest number");
                }
                if (a == b && a == c)
                {
                Console.WriteLine($"Number is equal {a}");
                }
                if (a < b && a < c)
                {
                    Console.WriteLine($"{a} the smallest number ");
                }
                if (b < a && b < c)
                {
                    Console.WriteLine($"{b} the smallest number ");
                }
                if (c < a && c < b)
                {
                    Console.WriteLine($"{c} the smallest number ");
                }

        }
        }
}

