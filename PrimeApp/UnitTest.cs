using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimeApp
{

    [TestClass]

    public class UnitTest //for IsPrime method
    {


        [TestMethod]
        public void SmallPrimes()
        {
            int[] tests = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

            for (var i = 0; i < tests.Length; i++)
            {
                Assert.IsTrue(PrimeN.IsPrime(tests[i]));
                }

        }


        [TestMethod]
        public void SmallNotPrimes()
        {
            int[] tests = { 4, 6, 8, 10, 12, 14, 15, 16, 18, 20 };

            for (var i = 0; i < tests.Length; i++)
            {
                Assert.IsFalse(PrimeN.IsPrime(tests[i]));
            }

        }

        [TestMethod]
        public void Negatives()
        {
            int[] tests = { -2, -3, -5, -7, -11, -13, -17, -19, -23, -29 };

            for (var i = 0; i < tests.Length; i++)
            {
                Assert.IsFalse(PrimeN.IsPrime(tests[i]));
            }
        }


        [TestMethod]
        public void Zero()
        {
            Assert.IsFalse(PrimeN.IsPrime(0));
        }


        [TestMethod]
        public void Unu()
        {
            Assert.IsFalse(PrimeN.IsPrime(1));
        }


        public void BigPrimes()
        {
            int[] tests = { 24923, 37579, 21929};

            for (var i = 0; i < tests.Length; i++)
            {
                Assert.IsTrue(PrimeN.IsPrime(tests[i]));
            }

        }


        [TestMethod]
        public void BigNotPrimes()
        {
            int[] tests = { 100000, 250000, 985632};

            for (var i = 0; i < tests.Length; i++)
            {
                Assert.IsFalse(PrimeN.IsPrime(tests[i]));
            }

        }



    }
}