using System;

namespace Task_4
{
    public class Car
    {
        private string name;
        public string color { get; set; }
        private double price;
        private const string CompanyName = "BMW";
       

        public Car() { }


        public Car(string new_name,string new_color, double new_price)
        {
            name = new_name;
            color = new_color;
            price = new_price;
        }

        public void Input()
        {
            Console.Write("Name: ");
            name =  Console.ReadLine();
            Console.Write("Color: ");
            color = Console.ReadLine();
            Console.Write("Price: ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"The mark of car is {CompanyName}, model is {name}, color {color} and this satisfaction cost {price}");
        }

        public void ChangePrice(double x)
        {
            price -= (price / 100)*x;
            Console.Write($"{name} , {price}");
        }
        public static bool operator ==(Car first, Car second)
        {
            return first.name == second.name  || first.price == second.price;
        }
        public static bool operator !=(Car first, Car second)
        {
            return !(first.name == second.name && first.price == second.price);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Car first = new Car();
            Car second = new Car();
            Car third = new Car();
            first.Input();
            first.Print();
            second.Input();
            second.Print();
            third.Input();
            third.Print();
            first.ChangePrice(10);

            if(first.color == "white")
            {
                Console.WriteLine("Enter the color: ");
                first.color = Console.ReadLine();
                Console.WriteLine($"Change color the first car to {first.color}");
            }
            if (second.color == "white")
            {
                Console.WriteLine("Enter the color: ");
                second.color = Console.ReadLine();
                Console.WriteLine($"Change color the first car to {second.color}");
            }
            if (third.color == "white")
            {
                Console.WriteLine("Enter the color: ");
                third.color = Console.ReadLine();
                Console.WriteLine($"Change color the first car to {third.color}");
            }
            if (first == second )
            {
                Console.WriteLine("The same names ");
            }
            else
            {
                Console.WriteLine("Not the same names ");
            }
                
        }
    }
}
