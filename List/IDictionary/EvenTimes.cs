using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDictionary
{
    internal class EvenTimes
    {
        public static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbersAndApperances = new Dictionary<int, int>();
            for(int i = 0; i < numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (!numbersAndApperances.ContainsKey(currentNumber))
                {
                    numbersAndApperances.Add(currentNumber, 0);
                }
                numbersAndApperances[currentNumber]++;
            }
            foreach(var number in numbersAndApperances)
            {
                if(number.Value % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}
