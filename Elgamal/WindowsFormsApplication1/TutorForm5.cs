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
    public partial class TutorForm5 : Form
    {
        private BigInteger p = new BigInteger(0);
        private BigInteger g = new BigInteger(0);
        private BigInteger x = new BigInteger(0);
        private BigInteger y = new BigInteger(0);
        public TutorForm5()
        {
            matan.DIGITS = 30;
            InitializeComponent();                
        }

        //генерация р
        private void generatepBtn_Click(object sender, EventArgs e)
        {
            p = matan.genSimpleRand();
            gtextBox.Text = "";
            xtextBox.Text = "";
            ytextBox.Text = "";
            ptextBox.Text = p.ToString();
        }

        private void generategBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            if (p>2) 
                if (matan.DIGITS > 10)
                    g = matan.calculateFakePrimitiveRoot(p);
                else
                    g = matan.calculatePrimitiveRoot(p);
            gtextBox.Text = g.ToString();
            this.Enabled = true;
        }

        private void generatexBtn_Click(object sender, EventArgs e)
        {
            if (p>2) 
                 do
                    x = matan.genRand();
                 while (x == 0 || x >= p);
            xtextBox.Text = x.ToString();
        }

        private void generateyBtn_Click(object sender, EventArgs e)
        {
            if (p > 2) 
                y = BigInteger.ModPow(g, x, p);
            ytextBox.Text = y.ToString();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (matan.isPrime(p) && p > 2 && x > 1 && g > 1 && y > 0)
            {
                var newForm = new TutorForm6(g, p, y, x);
                newForm.ShowDialog();
                this.Close();
            }
            if (!matan.isPrime(p)) wrongpLabel.Visible = true;
        }

        private void ptextBox_TextChanged(object sender, EventArgs e)
        {
            BigInteger.TryParse(ptextBox.Text, out p);

        }

        private void gtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TutorForm2_Load(object sender, EventArgs e)
        {

        }

        private void ptextBox_TextChanged_1(object sender, EventArgs e)
        {
            BigInteger.TryParse(ptextBox.Text, out p);
        }

        private void xtextBox_TextChanged(object sender, EventArgs e)
        {
            BigInteger.TryParse(xtextBox.Text, out x);
        }

        private void ytextBox_TextChanged(object sender, EventArgs e)
        {
          //  ytextBox.Text = BigInteger.ModPow(g, x, p).ToString();
        }
    }
}
