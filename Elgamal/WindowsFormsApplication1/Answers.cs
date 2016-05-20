using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ElgamalTutor
{
    static class Answers
    {
        public static int formToShow = 0;
        public static bool tutorialEnded = false;
        public static bool interruptTutorial = false;

        public static BigInteger p = new BigInteger(0);
        public static BigInteger g = new BigInteger(0);
        public static BigInteger x = new BigInteger(0);
        public static BigInteger y = new BigInteger(0);
        //public static BigInteger k = new BigInteger(0);
        public static BigInteger a = new BigInteger(0);
        public static BigInteger b = new BigInteger(0);

        public static bool[] modpowAnswers = new bool[3];
        public static bool[] EulerAnswers = new bool[3];
        public static bool[] ReverseAnswers = new bool[2];
        public static bool[] DiscreteLogAnswers = new bool[2];
    }
}
