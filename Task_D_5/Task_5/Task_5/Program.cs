using System;
using System.Collections;
using System.Collections.Generic;

namespace Task_5
{
    public interface IFlyable
    {
        void Fly();
    }
    public class Bird : IFlyable
    {
        public string name { get; set; }
        public string canFly { get; set; }
        public void Fly()
        {
            Console.WriteLine($"name : {name} and this bird {canFly}");
        }
        
    }
    public class Plane : IFlyable
    {
        public string mark { get; set; }
        public int hightFly { get; set; }
        public void Fly()
        {
            Console.WriteLine($"mark : {mark} and {hightFly} km");
        }
    }
    public class Space : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<IFlyable> fly = new List<IFlyable>
            {
                new Bird{name = "Swallow",canFly = "can fly"},
                new Bird{name = "Owl",canFly = "can fly"},
                new Bird{name = "Hummingbird",canFly = "can fly"},
                new Bird{name = "Flamingo",canFly = "can't fly"},
                new Space{},
                new Plane{mark = "Aviatech",hightFly= 35},
                new Plane{mark = "Neman",hightFly=27},
                new Plane{mark = "Sigma-5",hightFly=31},
                new Plane{mark = "Yakutia",hightFly=24},
            };
           
            foreach (IFlyable i in fly )
            {
                i.Fly();
            }
        }
    }
}
