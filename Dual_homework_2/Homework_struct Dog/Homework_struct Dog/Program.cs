using System;

namespace Homework_struct_Dog
{
    struct Dog
    {
       public string name;
       public string mark;
       public int age;
        public override string ToString()
        {
            return string.Format("Override method ToString in struct");
        }
    };
    
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog;
            myDog.name = "Lucky";
            myDog.mark = "Akita-ino";
            myDog.age = 1;
            Console.WriteLine(myDog.ToString());
        }
    }
}
