﻿using System;
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
    }
}
