using System;

namespace Homework_summ
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ, product;
            int [] number = new int[10] ;

            for (int i=0; i<10; i++)
            {
                number[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (number[0]>0&& number[1]>0 && number[2]> 0 && number[3] > 0 && number[4] > 0 )
            {
                summ = number[0]+ number[1]+ number[2]+ number[3]+ number[4];
                Console.WriteLine($"summ={summ}");
            }
            else
            {
                product = number[5] * number[6] * number[7] * number[8] * number[9];
                Console.WriteLine($"product={product}");
            }
            
        }
    }
}
