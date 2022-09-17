using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeNumberGenerator.Calculations
{
    //Full Calculation Class
    public class CalculationsClass
    {
        private int TotalCount = 0;
        private List<int> _PrimeNumbers = new List<int>();

        public CalculationsClass(int _TotalCount)
        {
            TotalCount = _TotalCount;
            PrimeNumbers.Add(2); //Always adds 2 as we know it's the only prime number that prime and also even
        }

        public List<int> PrimeNumbers
        {
            get { return _PrimeNumbers; }
        }

        public async Task CalculateAsync()
        {
            if (TotalCount == 0)
            {
                return;
            }
            await RunAllParallel();
        }

        private async Task RunAllParallel()//creates a parallel calculations that work out if a number is prime
        {
            List<Task> Tasks = new List<Task>();
            int i = 3;
            while (PrimeNumbers.Count < TotalCount)
            {
                Tasks.Add(GetPrime(i));
                i++;
            }
            await Task.WhenAll(Tasks);
            _PrimeNumbers = _PrimeNumbers.OrderBy(x => x).ToList();
        }

        private async Task GetPrime(int iCurrent) //checks if a number is prime if it is, it adds it to a list
        {
            if (await Task.Run(() => WorkoutIfPrime(iCurrent)))
            {
                PrimeNumbers.Add(iCurrent);
            }
        }

        private bool WorkoutIfPrime(int Number) //prime calculations
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
            return true;
        }
    }
}