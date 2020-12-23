using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCalculator.API.Services
{
    public class BasicCalculationService : IBasicCalculationService
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public decimal Division(int num1, int num2)
        {
            return num1 / num2;
        }

    }
}
