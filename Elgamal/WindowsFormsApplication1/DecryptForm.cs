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
    public partial class DecryptForm : Form
    {
        private BigInteger p = new BigInteger(0);
        private BigInteger g = new BigInteger(0);
        private BigInteger x = new BigInteger(0);
        private BigInteger y = new BigInteger(0);
        private BigInteger a = new BigInteger(0);
        private BigInteger b = new BigInteger(0);
        private BigInteger M = new BigInteger(0);
        public DecryptForm()
        {
            InitializeComponent();
            digitsBox.Text = matan.DIGITS.ToString();
        }

        private void genpgBtn_Click(object sender, EventArgs e)
        {
            string pstr;
            switch (digitsBox.Text)
            {
                case "p40":
                    pstr = "7524548124131735373612526345481757634861";
                    BigInteger.TryParse(pstr, out p);
                    g = 7;
                    break;
                case "p41":
                    pstr = "61571157514825784611687343327637886854113";
                    BigInteger.TryParse(pstr, out p);
                    g = 3;
                    break;
                default:
                    p = matan.genSimpleRand();
                    g = matan.calculateFakePrimitiveRoot(p);            
                    break;
            }
            pBox.Text = p.ToString();
            gBox.Text = g.ToString();
        }

        private void genxBtn_Click(object sender, EventArgs e)
        {
            if (p > 2)
                do
                    x = matan.genRand();
                while (x == 0 || x >= p);
            xBox.Text = x.ToString();
        }

        private void genyBtn_Click(object sender, EventArgs e)
        {
            if (p > 2)
                y = BigInteger.ModPow(g, x, p);
            yBox.Text = y.ToString();
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            Encoding encoding = Encoding.GetEncoding(1251);
            BigInteger apx = BigInteger.ModPow(a, x, p);
            apx = BigInteger.ModPow(apx, p - 2, p);
            M = (b * apx) % p;
            byte[] textBytes = M.ToByteArray();
            MBox.Text = encoding.GetString(textBytes);
        }

        private void digitsBox_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (int.TryParse(digitsBox.Text, out i) && i >= 0)
                matan.DIGITS = i;
        }

        private void pBox_TextChanged(object sender, EventArgs e)
        {
            BigInteger.TryParse(pBox.Text, out p);
        }

        private void gBox_TextChanged(object sender, EventArgs e)
        {
            BigInteger.TryParse(gBox.Text, out g);
        }

        private void xBox_TextChanged(object sender, EventArgs e)
        {
            BigInteger.TryParse(xBox.Text, out x);
        }

        private void yBox_TextChanged(object sender, EventArgs e)
        {
            BigInteger.TryParse(yBox.Text, out y);
        }

        private void aBox_TextChanged(object sender, EventArgs e)
        {
            BigInteger.TryParse(aBox.Text, out a);
        }

        private void bBox_TextChanged(object sender, EventArgs e)
        {
            BigInteger.TryParse(bBox.Text, out b);
        }
    }
}
