using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_exercises_2
{
    internal class Exercises3
    {
        public void RandomNumbersGreater45()
        {
            Random rnd = new Random();

            int lengthOfList = rnd.Next(10, 20);

            Console.WriteLine(lengthOfList);

            IList<int> randNumbers = new List<int>() { };

            for (int i = 0; i < lengthOfList; i++)
            {
                randNumbers.Add(rnd.Next(20, 60));

                Console.WriteLine(randNumbers[i]);
            }

            var evens1 = randNumbers.Where(i => i > 45);

            for (int i = 0; i < evens1.Count(); i++)
            {
                Console.WriteLine("-" + evens1.ToList()[i]);
            }
        }
    }
}