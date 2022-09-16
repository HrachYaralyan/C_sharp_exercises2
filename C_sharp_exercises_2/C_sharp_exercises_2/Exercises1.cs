using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Exercise 1:
//Write a method in C# to display the characters and frequency of character from giving string
namespace C_sharp_exercises_2
{
    public class Exercises1
    {
        public void CountingFrequencyCharacters()
        {
            Console.Write("input text:\t");
            string inputstring = Console.ReadLine();
            Dictionary<string, int> letterDictonary = new Dictionary<string, int>();
            for (int i = 0; i < inputstring.Length; i++)
            {
                if (!letterDictonary.ContainsKey($"{inputstring[i]}"))
                {
                    int currentChar = inputstring.Where(x => (x == inputstring[i])).Count();
                    letterDictonary.Add($"{inputstring[i]}", currentChar);
                    Console.WriteLine("Character " + inputstring[i] + ": " + currentChar + " times");
                }
            }
        }
    }
}