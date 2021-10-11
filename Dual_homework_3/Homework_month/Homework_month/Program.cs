using System;

namespace Homework2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter number of month ");
                int month = Convert.ToInt32(Console.ReadLine());
                int year = 2021;
                DateTime dt1 = new DateTime(year, month, 1);
                DateTime dt2 = dt1.AddMonths(1);
                int days = (dt2 - dt1).Days;
                Console.WriteLine($"{days} - days in this month");
            }
        }
    }
}