using System;
using System.Collections.Generic;
using System.Text;

namespace GitLesson
{
    class Car
    {
        public Car()
        {
            Console.WriteLine("Hello from default constuctor!");

        }

        public Car(string name)
        {
            Console.WriteLine($"Hello from {name}");
        }
    }
}
