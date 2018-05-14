﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ElgamalTutor
{
    static class BigIntegerSqrt
    {

        private static BigInteger modulo = BigInteger.Pow(BigInteger.Parse("10000000000000000000000"), 10000);

        public static BigInteger Sqrt(this BigInteger n)
        {
            if (n == 0) return 0;
            if (n > 0)
            {
                int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (bitLength / 2);

                while (!isSqrt(n, root))
                {
                    root += n / root;
                    root /= 2;
                }

                return root;
            }

            throw new ArithmeticException("NaN");
        }

        private static Boolean isSqrt(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = root * root;
            BigInteger upperBound = (root + 1) * (root + 1);

            return (n >= lowerBound && n < upperBound);
        }

        public static BigInteger Power(this BigInteger n, BigInteger exponent)
        {
            // return BigInteger.Pow(n, (int)exponent);
            return BigInteger.ModPow(n, exponent, modulo);
        }
    }
}
