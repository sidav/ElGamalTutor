using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ElgamalTutor
{
    class Pollards_Rho
    {
        public static BigInteger[] ext_euclid(BigInteger a, BigInteger b)
        {
            if (b == 0)
            {
                return new BigInteger[] { a, 1, 0 };
            }
            else
            {
                BigInteger[] arr_results = ext_euclid(b, a % b);
                BigInteger d = arr_results[0];
                BigInteger xx = arr_results[1];
                BigInteger yy = arr_results[2];
                BigInteger x = yy;
                BigInteger y = xx - (a / b) * yy;
                return new BigInteger[] { d, x, y };
            }
        }

        public static BigInteger inverse(BigInteger a, BigInteger n)
        {
            return ext_euclid(a, n)[1];
        }

        public static BigInteger[] PollardStep(BigInteger x, BigInteger a, BigInteger b, BigInteger G, BigInteger H, BigInteger P, BigInteger Q)
        {
            BigInteger sub = x % 3;
            if (sub == 0)
            {
                x = x * G % P;
                a = (a + 1) % Q;
            }

            if (sub == 1)
            {
                x = x * H % P;
                b = (b + 1) % Q;
            }

            if (sub == 2)
            {
                x = x * x % P;
                a = a * 2 % Q;
                b = b * 2 % Q;
            }
            return new BigInteger[] { x, a, b };
        }

        public static BigInteger Pollard(BigInteger G, BigInteger H, BigInteger P)
        {
            BigInteger Q = (P - 1) / 2;
            // Console.WriteLine($"Q = {Q}");

            BigInteger x = G * H;
            BigInteger a = 1;
            BigInteger b = 1;

            BigInteger X = x;
            BigInteger A = a;
            BigInteger B = b;

            for (BigInteger i = 1; i < P; i++)
            {
                BigInteger[] hedgehog = PollardStep(x, a, b, G, H, P, Q);
                x = hedgehog[0];
                a = hedgehog[1];
                b = hedgehog[2];

                BigInteger[] rabbit = PollardStep(X, A, B, G, H, P, Q);
                X = rabbit[0];
                A = rabbit[1];
                B = rabbit[2];
                rabbit = PollardStep(X, A, B, G, H, P, Q);
                X = rabbit[0];
                A = rabbit[1];
                B = rabbit[2];

                if (x == X)
                {
                    break;
                }
            }

            BigInteger nom = a - A;
            BigInteger denom = B - b;
            BigInteger res = (inverse(denom, Q) * nom) % Q;
            if (res >= 0 && BigInteger.ModPow(G, res, P) == H)
                return res;
            return res + Q;
        }


    }
}
