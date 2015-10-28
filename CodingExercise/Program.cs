using CodingExercise.Services;
using CodingExercise.Services.Services;
using System.Collections.Generic;
using System;

namespace CodingExercise
{
    class Program
    {
        private IPrimeNumberServices _serviceProvider = new PrimeNumberServices() ;

        public Program()
        {

        }
        //implementing constructor injection
        public Program(IPrimeNumberServices serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please provide a number greater than 1 :");
            int numberProvided = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();
            p.DisplayMatrix(numberProvided);


        }
        public void DisplayMatrix(int number)
        {
            //PrimeNumberServices primeNumberServices = new PrimeNumberServices();

             _serviceProvider.PrintPrimeNumbersMatrix(number);
        }
    }

    

}
