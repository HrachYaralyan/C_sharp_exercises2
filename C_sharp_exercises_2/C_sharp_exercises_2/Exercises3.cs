using System;
using System.Collections.Generic;
using System.Linq;
//Exercise 3:
//Write a method in C# to create a list of random numbers with random list length and display the numbers greater than 45 as output.
namespace C_sharp_exercises_2
{
    internal class Exercises3
    {
        public void filteringRandomNumbersGreater45()
        {
            Random rnd = new Random();
            int lengthOfList = rnd.Next(10, 20);
            Console.WriteLine(lengthOfList);
            var randNumbers = new List<int>() { };
            for (int i = 0; i < lengthOfList; i++)
            {
                randNumbers.Add(rnd.Next(20, 60));
                Console.WriteLine(randNumbers[i]);
            }
            var chekedNumber = randNumbers.Where(i => i > 45);
            for (int i = 0; i < chekedNumber.Count(); i++)
            {
                Console.WriteLine("-" + chekedNumber.ToList()[i]);
            }
        }
    }
}
