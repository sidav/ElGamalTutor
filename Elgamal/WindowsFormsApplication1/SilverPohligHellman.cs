using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;

namespace ElgamalTutor
{
    class SilverPohligHellman
    {

        static ProgressBar progress;

        public static List<BigInteger> PrimeFactorization(BigInteger p)
        {
            BigInteger d = 2;
            List<BigInteger> primeFactors = new List<BigInteger>();
            if (d*d <= p)
                if (p % d == 0)
                {
                    primeFactors.Add(d);
                    p /= d;
                }
            d += 1;
            while (d * d <= p)
            {
                while (p % d == 0)
                {
                    primeFactors.Add(d);
                    p /= d;
                }
                d += 2;
                progress.Increment(progress.Width / 100);
            }
            if (p > 1)
                primeFactors.Add(p);
            return primeFactors;
        }

        public static List<BigInteger[]> CountOccurences(List<BigInteger> primeFactors)
        {
            List<BigInteger[]> res = new List<BigInteger[]>();
            var set_of_unique = primeFactors.Select(value => value).Distinct();
            foreach (var x in set_of_unique)
            {
                progress.Increment(progress.Width / 100);
                res.Add(new BigInteger[] { x, primeFactors.Count(elem => elem == x) });
            }
            return res;
        }

        public static BigInteger[] ExtendedGCD(BigInteger a, BigInteger b)
        {
            BigInteger a2 = 1;
            BigInteger a1 = 0;
            BigInteger b1 = 1;
            BigInteger b2 = 0;

            while (b > 0)
            {
                BigInteger q = a / b;
                BigInteger r = a % b;
                BigInteger temp = a1;
                a1 = a2 - q * a1;
                a2 = temp;
                temp = b1;
                b1 = b2 - q * b1;
                b2 = temp;
                a = b;
                b = r;
            }
            return new BigInteger[] { a, a2, b2 };
        }

        public static BigInteger modularInverse(BigInteger b, BigInteger n)
        {
            BigInteger[] res = ExtendedGCD(b, n);
            BigInteger g = res[0];
            BigInteger x = res[1];
            BigInteger ret = 0;
            if (g == 1)
            {
                ret = (x % n);
                while (x < 0) x += n;
                return x;
            }
            return -1; 
        }

        public static BigInteger ChineseRemainder(List<BigInteger[]> pairs)
        {
            BigInteger N = pairs[0][1];
            BigInteger X = 0;
            for (int i = 1; i < pairs.Count; i++)
            {
                // BigInteger[] ni = pairs[i,];
                N *= pairs[i][1];
                progress.Value = 100 * (pairs.Count * 2 / i);
            }
            for (int i = 0; i < pairs.Count; i++)
            {
                progress.Value = (int)(pairs.Count * 2 / (i+1));
                BigInteger ai = pairs[i][0];
                BigInteger ni = pairs[i][1];
                BigInteger mi = (N / ni);
                X += mi * ai * ExtendedGCD(mi, ni)[1];
            }
            while (X < 0) X += N;
            return X % N;
        }

        public static BigInteger ShanksAlgorithm(BigInteger alpha, BigInteger beta, BigInteger n)
        {
            return BabyStepGiantStep.bsgs2(alpha, beta, n);
            BigInteger m = (n-1).Sqrt() + 1;
            BigInteger a = BigInteger.ModPow(alpha, m, n);
            BigInteger b = ExtendedGCD(alpha, n)[1];
            List<BigInteger[]> L1 = new List<BigInteger[]>();
            List<BigInteger[]> L2 = new List<BigInteger[]>();

            for (int ii = 0; ii < m; ii++)
            {
                L1.Add(new BigInteger[] { ii, BigInteger.ModPow(a, ii, n) });
                BigInteger second = beta * BigInteger.Pow(b, ii) % n;
                while (second < 0) second += n;
                L2.Add(new BigInteger[] { ii, second });
            }

            L1 = L1.OrderBy(x => x[1]).ToList();
            L2 = L2.OrderBy(x => x[1]).ToList();

            int i = 0;
            int j = 0;
            bool found = false;
            while (!found && i < m && j < m)
            {
                if (L1[j][1] == L2[i][1])
                    return m * L1[j][0] + L2[i][0] % n;
                else if (BigInteger.Abs(L1[j][1]) > BigInteger.Abs(L2[i][1]))
                    i += 1;
                else
                    j += 1;
            }
            return -1;
        }

        public static BigInteger[] CongruencePair(BigInteger g, BigInteger h, BigInteger p, BigInteger q, BigInteger e, BigInteger e1, BigInteger e2)
        {
            BigInteger alphaInverse = modularInverse(e1, p);
            BigInteger x = 0;
            for (BigInteger i = 1; i < e+1; i++)
            {
                progress.Value = 100 * (int)(i / e+1);
                BigInteger a = BigInteger.ModPow(e1, q.Power(e - 1), p);
                BigInteger b = BigInteger.ModPow(e2 * alphaInverse.Power(x), q.Power(e - i), p);
                x += ShanksAlgorithm(a, b, p) * (q.Power(i - 1));
            }
            return new BigInteger[] { x, q.Power(e) };
        }

        public static BigInteger PohligHellman(BigInteger h, BigInteger g, BigInteger p, ProgressBar prg = null)
        {
            progress = prg;
            List<BigInteger[]> CountOccurencesList = CountOccurences(PrimeFactorization(p - 1));

            //foreach (var fuck in CountOccurencesList)
            //{
            //    Console.Write($"({fuck[0]}, {fuck[1]})");
            //}
            //Console.Write(CountOccurencesList.Count);

            BigInteger tick = CountOccurencesList.Count / 100; // for progressbar
            if (tick == 0)
                tick = 1;

            var CongruenceList = new List<BigInteger[]>();
            for (int i = 0; i < CountOccurencesList.Count; i++)
            {
                progress.Value = 100 * (i+1) / (CountOccurencesList.Count+1);
                progress.Update();
                progress.Refresh();
                progress.Invalidate();
                BigInteger e1 = (h.Power((p - 1) / (CountOccurencesList[i][0].Power(CountOccurencesList[i][1])))) % p;
                BigInteger e2 = (g.Power((p - 1) / (CountOccurencesList[i][0].Power(CountOccurencesList[i][1])))) % p;
                try
                {
                    CongruenceList.Add(CongruencePair(g, h, p, CountOccurencesList[i][0], CountOccurencesList[i][1], e1, e2));
                    // progress.Increment(upd_value);
                }
                catch(Exception e)
                {
                    return -1;
                }
            }
            return ChineseRemainder(CongruenceList);
        }
        //////////////////////////////////////////
    }
}
