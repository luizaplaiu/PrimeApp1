using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimeApp
{
    public class PrimeN
    {
        public PrimeN()
        { }

        public List<int> CheckPrime(int input)
        {
            List<int> Prime = new List<int>();

            for (int i = 1; i <= input; i++)
            {
                if (IsPrime(i))
                {
                    Prime.Add(i); //prime numbers lower or equal to input
                }
            }

            List<int> Prime1 = new List<int>(); // last item of previous list
            Prime1.Add(Prime.LastOrDefault()); //returns value requested
            


            return (Prime1);
        }

        public static bool IsPrime(int x) // check if number is prime
        {
            if (x < 0)
                throw new ArgumentOutOfRangeException("x", x, "That's embarrassing! Please input a number greater than 0");
            if (x <= 3)
                return true;
            else
                for (int i =2; i<=x-1; i++)
                {
                    if (x % i == 0)
                        return false;
                }
            return true;
        
        }


    }
}