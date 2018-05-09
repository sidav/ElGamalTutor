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
    public partial class EncryptForm : Form
    {
        private BigInteger p = new BigInteger(0);
        private BigInteger g = new BigInteger(0);
        private BigInteger y = new BigInteger(0);
        private BigInteger k = new BigInteger(0);
        private BigInteger a = new BigInteger(0);
        private BigInteger b = new BigInteger(0);
        private BigInteger M = new BigInteger(0);
        public EncryptForm()
        {
            InitializeComponent();
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            if (M < p)
            {
                a = BigInteger.ModPow(g, k, p);
                aBox.Text = a.ToString();
                b = BigInteger.ModPow(y, k, p);
                b *= M;
                b %= p;
                bBox.Text = b.ToString();
            }
        }

        private void pBox_TextChanged(object sender, EventArgs e)
        {
            BigInteger.TryParse(pBox.Text, out p);
        }

        private void gBox_TextChanged(object sender, EventArgs e)
        {
            BigInteger.TryParse(gBox.Text, out g);
        }

        private void kBox_TextChanged(object sender, EventArgs e)
        {
            BigInteger.TryParse(kBox.Text, out k);
            if (k > p - 1) k = 0; 
        }

        private void MBox_TextChanged(object sender, EventArgs e)
        {
            Encoding encoding = Encoding.GetEncoding(1251);
            byte[] converted = encoding.GetBytes(MBox.Text + (char)0);
            M = new BigInteger(converted);
            if (M > p)
                ERRORLabel.Visible = true;
            else
                ERRORLabel.Visible = false;
        }

        private void genkBtn_Click(object sender, EventArgs e)
        {
            // matan.DIGITS = 10;
            do
            {
                k = CryptoMath.genRand(10);
            } while (k > p - 1);
            kBox.Text = k.ToString();
        }

        private void yBox_TextChanged(object sender, EventArgs e)
        {
            BigInteger.TryParse(yBox.Text, out y);
        }

    }
}
