using PrimeNumberGenerator.Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberGenerator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> PrimeNumbers = new List<int>();
            CalculationsClass cs1 = new CalculationsClass(100);
            cs1.CalculateAsync();
            PrimeNumbers = cs1.PrimeNumbers;
            int iCounter = 1;
            foreach (int i in PrimeNumbers)
            {
                Console.WriteLine(i + ": " + iCounter);
                iCounter++;
            }
            Console.ReadKey();
        }
    }
}