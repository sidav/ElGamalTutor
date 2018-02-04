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
    public partial class TutorForm6 : Form
    {
        private bool hasLoadedKey = false;
        private BigInteger p = new BigInteger(0);
        private BigInteger g = new BigInteger(0);
        private BigInteger x = new BigInteger(0);
        private BigInteger y = new BigInteger(0);
        private BigInteger k = new BigInteger(0);
        private BigInteger a = new BigInteger(0);
        private BigInteger b = new BigInteger(0);
        private BigInteger M = new BigInteger(0);
        public TutorForm6(/*BigInteger garg, BigInteger parg, BigInteger yarg, BigInteger xarg*/)
        {
            InitializeComponent();
            //g = Answers.g;
            //p = Answers.p;
            //y = Answers.y;
            //x = Answers.x;
            //gLabel.Text += g.ToString();
            //pLabel.Text += p.ToString();
            //yLabel.Text += y.ToString();
        }
        

        private void generatekBtn_Click(object sender, EventArgs e)
        {
            do
            {
                k = matan.genRand(20);
            } while (k > p - 1);
            kBox.Text = k.ToString();
        }

        private void calcaBtn_Click(object sender, EventArgs e)
        {
            a = BigInteger.ModPow(g, k, p);
            aBox.Text = a.ToString();
        }

        private void MBox_TextChanged(object sender, EventArgs e)
        {
            Encoding encoding = Encoding.GetEncoding(1251);
            byte[] converted = encoding.GetBytes(MBox.Text + (char)0);
            M = new BigInteger(converted);
            if (M >= p) wrongMLabel.Visible = true;
            else wrongMLabel.Visible = false;
            aBox.Text = "";
            bBox.Text = "";
            a = 0;
            b = 0;
        }

        private void calcbbtn_Click(object sender, EventArgs e)
        {   //подозрительный код, может взять и не заработать
            b = BigInteger.ModPow(y, k, p);
            b *= M;
            b %= p;
            bBox.Text = b.ToString();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (M < p && M > 0 && a > 0 && b > 0 && k > 0)
            {
                //var newForm = new TutorForm7(g, p, y, x, a, b);
                //newForm.Show();
                Answers.interruptTutorial = false;
                Answers.a = a;
                Answers.b = b;
                Answers.g = g;
                Answers.p = p;
                Answers.y = y;
                Answers.x = x;
                this.Close();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void kBox_TextChanged(object sender, EventArgs e)
        {
            BigInteger.TryParse(kBox.Text, out k);
        }

        private void TutorForm6_Load(object sender, EventArgs e)
        {
            if (!hasLoadedKey)
            {
                g = Answers.g;
                p = Answers.p;
                y = Answers.y;
                x = Answers.x;
                gLabel.Text += g.ToString();
                pLabel.Text += p.ToString();
                yLabel.Text += y.ToString();
                hasLoadedKey = true;
            }
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Answers.interruptTutorial = false;
            Answers.formToShow -= 2;
            this.Close();
        }
    }
}
