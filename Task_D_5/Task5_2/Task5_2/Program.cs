using System;
using System.Collections;


namespace Task5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myColl = new ArrayList();
            for(int i = 0, b = 10; i< 10; i++)
            {
                Console.Write($"Enter {b} number :");
                myColl.Add(Convert.ToInt32(Console.ReadLine()));
                b--;
            }
            Console.WriteLine();
            Console.Write("Index of number \"-10\" : ");
            for (int i = 0 , n = 10; i < n ; i++)
            {
                if ((int)myColl[i] == -10)
                {
                    Console.Write($"{i} ");
                }                
            }
            Console.WriteLine();
            Console.Write("Remote number more than 20: ");
            for (int i = 0,  n = 10; i < n; i++)
            {
                if ((int)myColl[i] > 20)
                {
                    myColl.Remove(myColl[i]);
                    i--;
                    n--;
                }
                else
                {
                    Console.Write($"{myColl[i]} ");
                }
            }
           
            Console.WriteLine();
            myColl.Insert(2,1);
            myColl.Insert(8,-3);
            myColl.Insert(5,-4);
            Console.Write("Insert list: ");
            foreach (object i in myColl)
            {
                Console.Write($" {i} ");
            }
            Console.WriteLine();
            myColl.Sort();
            Console.Write("Sort list: ");
            foreach (object i in myColl)
            {
                Console.Write($" {i} ");
            }
            Console.WriteLine();
        }
    }
}
