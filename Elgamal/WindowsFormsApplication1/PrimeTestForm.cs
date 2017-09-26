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
    public partial class PrimeTestForm : Form
    {
        public PrimeTestForm()
        {
            InitializeComponent();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            ansLabel.Visible = false;
            BigInteger testInt;
            BigInteger.TryParse(inputBox.Text, out testInt);
            if (testInt > 0)
            {
                if (matan.isPrime(testInt))
                    ansLabel.Text = "Введённое число - простое";
                else ansLabel.Text = "Введённое число - составное";
            }
            else
                ansLabel.Text = "Введено неправильное значение";
            ansLabel.Visible = true;
            this.Enabled = true;
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            ansLabel.Visible = false;
        }
    }
}
