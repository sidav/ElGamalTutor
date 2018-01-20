using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;

namespace ElgamalTutor
{
    static class BabyStepGiantStep
    {

        public static BigInteger sqrt(BigInteger n)
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

        public static BigInteger bsgs(BigInteger a, BigInteger b, BigInteger m)
        {

            if (a == b)
                return 1;

            var map = new Dictionary<BigInteger, BigInteger>();
            BigInteger ans, n, i;
            ans = 1;

            n = sqrt(m) + 1; // 1

            for (i = n; i >= 1; --i) // 3
            {
                BigInteger curKey = BigInteger.ModPow(a, i * n, m);
                if (!(map.ContainsKey(curKey)))
                    map.Add(curKey, i);
                else
                    map[curKey] = i;
            }

            for (i = 0; i <= n; ++i) // 4
            {
                BigInteger cur = (BigInteger.ModPow(a, i, m) * b) % m;
                if (map.ContainsKey(cur))
                {
                    ans = map[cur] * n - i;
                    if (ans < m) return ans;
                }
            }

            return -1;
        }

        public static BigInteger bsgs2(BigInteger a, BigInteger b, BigInteger m, ProgressBar progress = null)
        {

            if (a == b)
                return 1;

            var map = new Dictionary<BigInteger, BigInteger>();
            BigInteger ans, n, i, an, curKey;
            ans = 1;
            an = 1;

            n = sqrt(m) + 1; // 1
            an = BigInteger.ModPow(a, n, m);
            //for (i = 0; i < n; ++i)
            //    an = (an * a) % m;

            BigInteger tick = n / 50; // for progressbar
            if (tick == 0)
                tick = 1;
            // int progressQuantum = (progress.Width / 100);

            for (i = 1, curKey = an; i <= n; ++i) // 3
            {
                if (!(map.ContainsKey(curKey)))
                    map.Add(curKey, i);
                curKey = (curKey * an) % m;

                if (progress != null) // progressbar
                    if (i % tick == 0)          // progressbar!
                        progress.Increment(progress.Width / 100);  //
            }

            for (i = 0, curKey = b; i <= n; ++i) // 4
            {
                if (map.ContainsKey(curKey))
                {
                    ans = map[curKey] * n - i;
                    if (ans < m) return ans;
                }
                curKey = (curKey * a) % m;

                if (progress != null) // progressbar
                    if (i % tick == 0)          // progressbar!
                        progress.Increment(progress.Width / 100);  //

            }

            return -1;
        }

    }
}
