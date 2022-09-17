using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrimeNumberGenerator.Calculations
{
    public class CalculationsClass
    {
        private int TotalCount = 0;
        private List<int> _PrimaNumbers = new List<int>();

        public CalculationsClass(int _TotalCount)
        {
            TotalCount = _TotalCount;
        }

        public List<int> PrimeNumbers
        {
            get { return _PrimaNumbers; }
        }

        public async Task CalculateAsync()
        {
            if (TotalCount == 0)
            {
                return;
            }
            await RunAll();
        }

        private async Task RunAll()
        {
            List<Task> Tasks = new List<Task>();
            int i = 3;
            PrimeNumbers.Add(2);
            while (PrimeNumbers.Count < TotalCount)
            {
                Tasks.Add(GetPrime(i));
                i++;
            }
        }

        private async Task GetPrime(int iCurrent)
        {
            if (await Task.Run(() => WorkoutIfPrime(iCurrent)))
            {
                PrimeNumbers.Add(iCurrent);
            }
        }

        private bool WorkoutIfPrime(int Number)
        {
            if (Number % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i < Number; i++)
            {
                if (Number % i == 0)
                {
                    return false;
                }
            }
            Console.WriteLine(Number);
            return true;
        }
    }
}