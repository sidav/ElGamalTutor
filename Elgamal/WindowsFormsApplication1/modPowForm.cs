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
    public partial class modPowForm : Form
    {
        BigInteger X = new BigInteger(0);
        BigInteger Y = new BigInteger(0);
        BigInteger M = new BigInteger(0);
        public modPowForm()
        {
            InitializeComponent();
        }

        private void modPowBtn_Click(object sender, EventArgs e)
        {
            BigInteger.TryParse(XBox.Text, out X);
            BigInteger.TryParse(YBox.Text, out Y);
            BigInteger.TryParse(MBox.Text, out M);
            if (X*Y*M > 0)
            {
                BigInteger result;
                result = BigInteger.ModPow(X, Y, M);
                modPowBox.Text = result.ToString();
            }
        }
    }
}
