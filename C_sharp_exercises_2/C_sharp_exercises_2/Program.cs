﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_exercises_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exercises1 = new Exercises1();
            exercises1.CharactersAndFrequency();

            Console.WriteLine("__Next Task__");

            var exercises2 = new Exercises2();
            exercises2.frequencyAndMultiplication();

            Console.WriteLine("__Next Task__");

            var exercises3 = new Exercises3();
            exercises3.RandomNumbersGreater45();

            Console.WriteLine("__Next Task__");


            var exercises4 = new Exercises4();
            exercises4.libraryFilter();
        }
    }
}
