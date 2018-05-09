using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace ElgamalTutor
{
    class CryptoMath
    {
        public static Random rand = new Random();
        public static int MILLER_RABIN_ROUNDS = 4000;
        public const long DIGITS = 20;

        public static BigInteger phi(BigInteger n)
        {
            BigInteger result = n;
            BigInteger i = new BigInteger(2);
            for (i = 2; i * i <= n; ++i)
                if (n % i == 0)
                {
                    while (n % i == 0)
                        n /= i;
                    result -= result / i;
                }
            if (n > 1)
                result -= result / n;
            return result;
        }

        //public static BigInteger powmod(BigInteger a,BigInteger b,BigInteger m)
        //{
        //    BigInteger r=1;
        //    a%=m;
        //    while (b>0)
        //    {
        //        if (b%2 ==1) r=(r*a)%m;
        //        a=(a*a)%m;
        //        b>>=1;
        //    }
        //    return r;
        //}



        public static bool isPrime(BigInteger n)
        {
            if (n == 2 || n == 3 || n == 5 || n == 7)
                return true;
          if ((n % 60) % 5 == 0)
          return false;
          if ((n % 60) % 3 == 0)
          return false;
          if ((n % 60) % 2 == 0)
          return false;
          //тест Миллера-Рабина
          //сначала представим m-1 в виде m-1 = 2^s * t
          BigInteger m = n-1;
          BigInteger s = 0;
          BigInteger t = 1;
          while(m/2 > 0 && m%2 == 0)
          {
               m /= 2;
               s++;
          }
          t = m;
          m = n;
          for (BigInteger i = 0; i < MILLER_RABIN_ROUNDS; i++)      //максимальное i неплохо бы там log_2(m)
          {
              BigInteger a = rand.Next()%(m-3) + 3; 
              BigInteger x = BigInteger.ModPow(a,t,m);
              if (x == 1 || x == m-1) continue;
              for (BigInteger j = 0; j < s-1; j++)
              {
                  x = BigInteger.ModPow(x, 2, m);
                  if (x == m-1) break;
                  if (x == 1)  return false;

              }
           if (x==m-1) continue;
           return false;
          }
           return true;
        }

        public static BigInteger calculatePrimitiveRoot(BigInteger p) //!вычислялка первообразного корня по модулю p.
        {
        	List<BigInteger> fact = new List<BigInteger>();
        	BigInteger phi = p-1,  n = phi;
	        for (BigInteger i=2; i*i<=n; ++i)
	        	if (n % i == 0) {
	        		fact.Add(i);
		    	while (n % i == 0)
		    		n /= i;
	    	    }
	        if (n > 1)
		        fact.Add(n);
        	for (BigInteger res=2; res<=p; ++res)
            {
	    	    bool ok = true;
	    	    for (int i=0; i<fact.Count && ok; ++i)
			        ok &= BigInteger.ModPow(res, phi / fact[i], p) != 1;
		        if (ok)  return res;
	        }
        	return -1;
        }

        public static BigInteger calculateFakePrimitiveRoot(BigInteger p) //!вычислялка первообразного корня по модулю p.
        {
            List<BigInteger> fact = new List<BigInteger>();
            BigInteger phi = p - 1, n = phi;
            for (BigInteger i = 2; i * i * i * i <= n; ++i)
                if (n % i == 0)
                {
                    fact.Add(i);
                    while (n % i == 0)
                        n /= i;
                }
            if (n > 1)
                fact.Add(n);
            for (BigInteger res = 2; res <= p; ++res)
            {
                bool ok = true;
                for (int i = 0; i < fact.Count && ok; ++i)
                    ok &= BigInteger.ModPow(res, phi / fact[i], p) != 1;
                if (ok) return res;
            }
            return -1;
        }

        public static BigInteger genSimpleRand(long decDigits/*=DIGITS*/)
        {
            BigInteger a = new BigInteger(0);
            BigInteger pow = 1;
            while (!isPrime(a))
            {
                a = 0;
                pow = 1;
                for (long i = 0; i < decDigits; i++)
                {
                    BigInteger rnd = (rand.Next(8)+1) * pow;
                    a += rnd;
                    pow *= 10;
                }
            }
            return a;
        }

        public static BigInteger genRand(long decDigits/* = DIGITS*/)
        {
            BigInteger a = new BigInteger(0);
            BigInteger pow = 1;
                a = 0;
                pow = 1;
                for (long i = 0; i < decDigits; i++)
                {
                    BigInteger rnd = rand.Next(10) * pow;
                    a += rnd;
                    pow *= 10;
                }
            return a;
        }
    }
}
