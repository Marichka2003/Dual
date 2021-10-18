using System;

namespace Homework_4
{
    public class Person
    {
        private string name { get; set; }
        private DateTime birthYear { get; set; }
        public int age;
        public Person() { }

        public Person(string new_name, DateTime new_birthYear)
        {
            name = new_name;
            birthYear = new_birthYear;
        }

        public void Age()
        {
            age = DateTime.Now.Year - birthYear.Year;
            Console.WriteLine($"{name} is {age}");
        }

        public void Input()
        {
            Console.WriteLine("Enter name of person");
            name = Console.ReadLine();
            Console.WriteLine("Enter birth of person");
            birthYear = Convert.ToDateTime(Console.ReadLine());
        }
        public void ChangeName()
        {
            Console.WriteLine("Change the name");
            name = "Very Young";
        }
        public void Output()
        {
            name.ToString();
        }
        public static bool operator ==(Person first, Person second)
        {
            return first.name == second.name;
        }
        public static bool operator !=(Person first, Person second)
        {
            return !(first.name == second.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[6];
            for (int i = 0; i < 6; i++)
            {
                person[i] = new Person();
                person[i].Input();
            }
            for (int i = 0; i < 6; i++)
            {
                person[i].Output();
                person[i].Age();
                if (person[i].age < 16)
                {
                    person[i].ChangeName();
                }
            }
            for (int i = 0; i < 6; i++)
            {
                person[i].Output();
            }
            for (int i = 0; i < 6; i++)
            {

                if (i == 4)
                {
                    if (person[i] == person[i + 1])
                    {
                        person[i].Output();
                        person[i].Age();
                    }
                    break;
                }
                if (person[i] == person[i + 1])
                {
                    person[i].Output();
                    person[i].Age();
                }
            }
        }
    }
}