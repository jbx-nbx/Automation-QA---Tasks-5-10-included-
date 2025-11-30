using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dev1
{
    public class isPrime
    {

        public static bool isPrime2(int number)
        {
           int Nsqrt = (int) Math.Sqrt(number);
            if (number <= 1) return false; // Not prime
            if (number == 2) return true; // Prime
            if (number % 2 == 0) return false; // Not prime
            
            for (int i = 3; i <= Nsqrt; i += 2)
            {
                if (number % i == 0)
                    return false; // Not prime
            }
            return true; // Prime
        }

        public static bool ChkIfArrIsPrime2(int[] numbers)
        {   //if all numbers are null OR numbers.length is 0 (which is an empty array)
            if (numbers == null || numbers.Length == 0) { return false; }
            int primeCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (isPrime2(numbers[i]))
                {
                    primeCount++;
                }
            }
            return primeCount > numbers.Length / 2;
        }

    }
}



