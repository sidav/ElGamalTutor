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
    public partial class CalcfiForm : Form
    {
        BigInteger input = new BigInteger(0);
        public CalcfiForm()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            input = BigInteger.Parse(inputBox.Text);
            input = CryptoMath.phi(input);
            outputBox.Text = input.ToString();
            label2.Visible = true;
            outputBox.Visible = true;
            this.Enabled = true;
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
            outputBox.Visible = false;
        }
    }
}
