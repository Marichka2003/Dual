using System;

namespace Homework_Calculate
{
    class Program
    {

        static void Main(string[] args)
        {
            
            string str = Console.ReadLine();
            int a = 0,
                o = 0,
                e = 0,
                i = 0;
            foreach(int l in str)
            {
                if (l == 'a')
                {
                    a++;
                }  
                else if(l == 'o')
                {
                    o++;
                }
                else if(l == 'e')
                {
                    e++;
                }
                else if (l == 'i')
                {
                    i++;
                }
            }
            Console.WriteLine($"a={a}\no={o}\ne={e}\ni={i}");
        }
    }
}
