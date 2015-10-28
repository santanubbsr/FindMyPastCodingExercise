using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingExercise.Services
{
    public interface IPrimeNumberServices
    {
        void PrintPrimeNumbersMatrix(int number);
        int[,] GetPrimeNumbersMatrix(int number);
        List<int> GetFirstTenPrimeNumbers(int inputNumber);
        bool IsPrime(int numbersToBeCheckedForPrime);
    }
}
