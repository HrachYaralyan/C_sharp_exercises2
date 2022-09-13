﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_exercises_2
{
    public class Exercises1
    {
        public void CharactersAndFrequency()
        {
            Console.Write("input text:\t");
            string inputstring = Console.ReadLine();

            Dictionary<string, int> fruitsDictonary = new Dictionary<string, int>();

            for (int i = 0; i < inputstring.Length; i++)
            {
                if (!fruitsDictonary.ContainsKey($"{inputstring[i]}"))
                {

                    int thisChar = inputstring.Where(x => (x == inputstring[i])).Count();

                    fruitsDictonary.Add($"{inputstring[i]}", thisChar);

                    Console.WriteLine("Character " + inputstring[i] + ": " + thisChar + " times");

                }
            }
        }

    }
}