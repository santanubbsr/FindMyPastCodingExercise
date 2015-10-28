using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodingExercise.Services.Services;
using System.Linq;

namespace CodingExercise.Tests
{
    [TestClass]
    public class CodingExerciseTests
    {
        public object Enumerable { get; private set; }

        [TestMethod]
        public void Is_Prime_Number_Matrix_Returns_Correctly()
        {
            int inputNumber = 5;

            //intializing the expected matrix
            int[,] expectedPrimeNumberMatrix =
            {

                {4,6,10 },
                {6,9,15 },
                {10,15,25},
            };

            PrimeNumberServices primeNumberServices = new PrimeNumberServices();
            int[,] actualPrimeNumberMatrix = primeNumberServices.GetPrimeNumbersMatrix(inputNumber);
            bool IsEqual = true;
          

            
            
            for (int i = 0; i < expectedPrimeNumberMatrix.GetLength(0); i++)
            {
                int loop2 = 0;
                if (!IsEqual)
                    break;
                for (int j = 0; j < actualPrimeNumberMatrix.GetLength(0); j++)
                {
                    loop2++;
                    int A = expectedPrimeNumberMatrix[i, j];
                    int B = actualPrimeNumberMatrix[i, j];
                    if (A != B)
                    {
                        IsEqual = false;
                        break;
                    }
                    if (loop2 == 2)
                        break;
                }
            }
           
            Assert.IsTrue(IsEqual);
        }
    }
}
