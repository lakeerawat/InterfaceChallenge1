﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceChallenge1
{
    interface IRandomizable
    {
        double GetRandomNum(double dUpperBound);
    }
    public class MyRandomizer : IRandomizable
    {
        public MyRandomizer() { }
        public double GetRandomNum(double dUpperBound)
        {
            Random rnumGen = new Random();
            double seed = rnumGen.NextDouble();
            return seed * dUpperBound;

        }
    }
     class Program
    {
        static void Main(string[] args)
        {
            MyRandomizer mr = new MyRandomizer();

            string str;
            do
            {
                Console.WriteLine("Enter a number for upper bound:");
                str = Console.ReadLine();
                try
                {
                    double upperBound = double.Parse(str);
                    Console.WriteLine("Random number betweeen 0 and {1}:{0}", mr.GetRandomNum(upperBound), upperBound);


                }

                catch (Exception e) { }
            }
            while (str != "exit");
                Console.WriteLine("\nHit Enter key to continue...");
                Console.ReadLine();
            }
        }
    }

