using System;
using System.Collections.Generic;
using System.Text;

namespace GitLesson
{
    class Car
    {
        
        public Car()
        {
            Console.WriteLine("Hello from Car default constructor!");
        }

        public Car(string model, int year)
        {
            Console.WriteLine($"Model: {model}, Year: {year}");

        }

        public Car(string name)
        {
            Console.WriteLine($"Hello from {name}");
        }

        public void PrintInfo(string name, string model, int year)
        {
            Console.WriteLine($"Name: {name}, Model:  {model}, Year: {year}");
        }
    }
}
