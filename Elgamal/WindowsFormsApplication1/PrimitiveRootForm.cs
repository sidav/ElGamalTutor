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
    public partial class PrimitiveRootForm : Form
    {
        int digits = 10;
        BigInteger modulo = new BigInteger(0);
        BigInteger primit = new BigInteger(0);

        public PrimitiveRootForm()
        {
            InitializeComponent();
        }

        private void generatepBtn_Click(object sender, EventArgs e)
        {
            modulo = matan.genSimpleRand();
            pBox.Text = modulo.ToString();
        }

        private void pBox_TextChanged(object sender, EventArgs e)
        {
            BigInteger.TryParse(pBox.Text, out modulo);
        }

        private void trueGenBtn1_Click(object sender, EventArgs e)
        {
            if (modulo < 3) pBox.Text = "12345"; 
            primit = matan.calculatePrimitiveRoot(modulo);
            trueBox.Text = primit.ToString();
        }

        private void fakeGenBtn_Click(object sender, EventArgs e)
        {
            if (modulo < 3) pBox.Text = "12345"; 
            primit = matan.calculateFakePrimitiveRoot(modulo);
            fakeBox.Text = primit.ToString();
        }

        private void digitsBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(digitsBox.Text, out digits))
                 matan.DIGITS = digits;
        }
    }
}
