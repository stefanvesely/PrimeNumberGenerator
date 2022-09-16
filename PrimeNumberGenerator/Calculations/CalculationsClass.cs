﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public async Task CalculateAsync ()
        {
            if (TotalCount == 0)
            {
                return;
            }
            await RunAll();
            
        }
        private async Task RunAll ()
        {
            List<Task> Tasks = new List<Task>();
            int i = 0;
            while (PrimeNumbers.Count < 101)
            {

                Tasks.Add(GetPrime(i));
                i++;
            }
        }
        private async Task GetPrime(int iCurrent)
        {
            
                if (await WorkoutIfPrime(iCurrent))
                {
                    PrimeNumbers.Add(iCurrent);
                }
                       
        }

        private async Task<bool> WorkoutIfPrime(int Number)
        {
            if (Number == 1 || Number == 0)
            {
                return false;
            }
            if (Number == 2)
            {
                return true;
            }
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
