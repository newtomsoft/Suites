﻿using System;
using System.Linq;

namespace Suites
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci(45);
            Syracuse(50,1978);
            Conway(16, 1);
            Factorielle(12);
        }

        public static void Syracuse(int max, int nbInitial)
        {
            Suite syracuse = new Syracuse();
            AppelSuite(syracuse, nbInitial, max);
        }

        public static void Conway(int max, int nbInitial)
        {
            Suite conway = new Conway();
            AppelSuite(conway, nbInitial, max);
        }

        public static void Fibonacci(int max)
        {
            Suite fibonacci = new Fibonacci();
            AppelSuite(fibonacci, 0, max);
        }

        public static void Factorielle(int max)
        {
            Suite factorielle = new Factorielle();
            AppelSuite(factorielle, 0, max);
        }

        public static void AppelSuite(Suite laSuite, int init, int max)
        {
            Console.WriteLine(laSuite.ToString().Substring(7));
            int i = 0;
            foreach (var nb in laSuite.LaSuite(init).Take(max))
                Console.WriteLine($"{laSuite.ToString().Substring(7)} {++i} : {nb}");
            Console.ReadLine();

        }
    }
}
