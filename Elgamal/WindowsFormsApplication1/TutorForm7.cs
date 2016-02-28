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
    public partial class TutorForm7 : Form
    {
        private BigInteger p = new BigInteger(0);
        private BigInteger g = new BigInteger(0);
        private BigInteger x = new BigInteger(0);
        private BigInteger y = new BigInteger(0);
        private BigInteger a = new BigInteger(0);
        private BigInteger b = new BigInteger(0);
        private BigInteger M = new BigInteger(0);
        public TutorForm7(BigInteger garg, BigInteger parg, BigInteger yarg, BigInteger xarg, BigInteger aarg, BigInteger barg/*, BigInteger Marg*/)
        {
            InitializeComponent();
            g = garg;
            p = parg;
            y = yarg;
            x = xarg;
            a = aarg;
            b = barg;
            //M = Marg;
            gLabel.Text += g.ToString();
            pLabel.Text += p.ToString();
            yLabel.Text += y.ToString();
            xLabel.Text += x.ToString();
            aLabel.Text += a.ToString();
            bLabel.Text += b.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            Encoding encoding = Encoding.GetEncoding(1251);
            BigInteger apx = BigInteger.ModPow(a, x, p);
            apx = BigInteger.ModPow(apx, p - 2, p);
            M = (b * apx) % p;
            MNumBox.Text = M.ToString();
            byte[] textBytes = M.ToByteArray();
            MtextBox.Text = encoding.GetString(textBytes);
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            if (M > 0)
            {
                var newForm = new TutorResults();
                newForm.ShowDialog();
                this.Close();
            }
        }
    }
}
