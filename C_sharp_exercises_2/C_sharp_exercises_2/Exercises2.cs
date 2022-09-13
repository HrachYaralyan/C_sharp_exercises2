using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_exercises_2
{
    public class Exercises2
    {
        public void frequencyAndMultiplication()
        {
            IList<int> listNumbers = new List<int>() { };

            Dictionary<int, int> NumbersCount = new Dictionary<int, int>();

            Console.Write("Enter your Number: ");
            int inputNUmber = int.Parse(Console.ReadLine());

            for (int z = 0; z < inputNUmber; z++)
            {
                Console.Write($"Enter your  {z + 1} integer  number:");
                var initialNumber = Console.ReadLine();
                bool parseSuccess = int.TryParse(initialNumber, out int inputNumber);

                if (parseSuccess)
                {
                    Console.WriteLine("Added in list ");
                    listNumbers.Add(inputNumber);
                }
                else
                {
                    Console.WriteLine("wrong number type try again ");
                    z--;
                    continue;
                }
            }

            for (int i = 0; i < listNumbers.Count; i++)
            {

                if (!NumbersCount.ContainsKey(listNumbers[i]))
                {
                    NumbersCount.Add(listNumbers[i], i);

                    int countNum = listNumbers.Where(x => (x == listNumbers[i])).Count();

                    Console.WriteLine($" Number :  {listNumbers[i]} | Number*Frequency :   {countNum * listNumbers[i]} | Count :{countNum} ");


                }
            }

        }
    }
}