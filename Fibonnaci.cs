using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    {
        public List<int> Fibonacci()
        {
            List<int> listFibonacci = new List<int> { 0, 1 };
            int firstNumber = 0;
            int secondNumber = 1;

            for (int i = 2; listFibonacci[i - 1] + listFibonacci[i - 2] <= 350; i++)
            {
                int temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp + secondNumber;
                listFibonacci.Add(secondNumber);
            }
            return listFibonacci;
        }

        public bool IsFibonacci(int confirmNumber)
        {
            return Fibonacci().Contains(confirmNumber);
        }
    }
}