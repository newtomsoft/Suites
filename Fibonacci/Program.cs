﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 45;
            int i = 0;
            foreach (var nb in Fibonacci.Suite().Take(max))
            {
                Console.WriteLine($"entier {++i} : {nb}");
            }
            Console.ReadLine();
        }
    }
}
