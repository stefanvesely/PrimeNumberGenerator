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
            BuildList(150000);//Change this number to Change amount of prime numbers.
        }

        private static async void BuildList(int Total)
        {
            CalculationsClass cs1 = new CalculationsClass(Total);
            await cs1.CalculateAsync();          
            for (int i = 0; i < Total; i++)
            {
                Console.WriteLine(cs1.PrimeNumbers[i] + ": " + (i + 1).ToString());
            }
            Console.ReadKey();
        }
    }
}