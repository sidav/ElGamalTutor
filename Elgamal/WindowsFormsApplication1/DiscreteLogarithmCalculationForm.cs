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
    public partial class DiscreteLogarithmCalculationForm : Form
    {
        public DiscreteLogarithmCalculationForm()
        {
            InitializeComponent();
        }

        private void DoMagicBtn_Click(object sender, EventArgs e)
        {
            BSGSProgressBar.Value = 0;
            BigInteger a, b, m, answer;
            a = 0;
            b = 0;
            m = 0;
            answer = 0;

            ResultLabel.Visible = false;
            ResultLabel.ForeColor = Color.Red;

            BigInteger.TryParse(ABox.Text, out a);
            BigInteger.TryParse(BBox.Text, out b);
            BigInteger.TryParse(MBox.Text, out m);

            if (a < 2 || b < 0 || m < 3 || b > m)
                ResultLabel.Text = "Неправильный ввод данных";
            else if (!(CryptoMath.isPrime(m)))
                ResultLabel.Text = "М должно быть простым";
            else
            {
                if (m.ToString().Length > 10)
                {
                    ResultLabel.Text = "Слишком большое М - \nВозможна нехватка памяти";
                    ResultLabel.Visible = true;
                }
                try
                {
                    BSGSProgressBar.Visible = true;
                    this.Enabled = false;
                    answer = BabyStepGiantStep.bsgs2(a, b, m, BSGSProgressBar);
                }
                catch (OutOfMemoryException)
                {
                    ResultLabel.Text = "Нехватка оперативной памяти";
                    ResultLabel.Visible = true;
                    this.Enabled = true;
                    return;
                }
                if (answer == -1)
                    ResultLabel.Text = "Такого Х не найдено";
                else
                {
                    ResultLabel.ForeColor = Color.Green;
                    ResultLabel.Text = $"X = {answer}";
                    if (BigInteger.ModPow(a, answer, m) != b)
                        ResultLabel.Text += "?";
                }
            }
            BSGSProgressBar.Visible = false;
            ResultLabel.Visible = true;
            this.Enabled = true;
        }

        private void PohligButton_Click(object sender, EventArgs e)
        {
            BSGSProgressBar.Value = 0;
            BigInteger a, b, m, answer;
            a = 0;
            b = 0;
            m = 0;
            answer = 0;

            ResultLabel.Visible = false;
            ResultLabel.ForeColor = Color.Red;

            BigInteger.TryParse(ABox.Text, out a);
            BigInteger.TryParse(BBox.Text, out b);
            BigInteger.TryParse(MBox.Text, out m);

            if (a < 2 || b < 0 || m < 3 || b > m)
                ResultLabel.Text = "Неправильный ввод данных";
            else if (!(CryptoMath.isPrime(m)))
                ResultLabel.Text = "М должно быть простым";
            else
            {
                if (m.ToString().Length > 5)
                {
                    ResultLabel.Text = "Слишком большое М - \nВозможно крайне долгое время работы";
                    ResultLabel.Visible = true;
                }
                try
                {
                    BSGSProgressBar.Visible = true;
                    this.Enabled = false;
                    answer = SilverPohligHellman.PohligHellman(a, b, m, BSGSProgressBar);
                }
                catch (OutOfMemoryException)
                {
                    ResultLabel.Text = "Нехватка оперативной памяти";
                    ResultLabel.Visible = true;
                    this.Enabled = true;
                    return;
                }
                if (answer == -1)
                    ResultLabel.Text = "Такого Х не найдено";
                else
                {
                    ResultLabel.ForeColor = Color.Green;
                    ResultLabel.Text = $"X = {answer}";

                    if (BigInteger.ModPow(a, answer, m) != b)
                    {
                        ResultLabel.ForeColor = Color.Red;
                        ResultLabel.Text = "Такого Х не найдено";
                    }
                    // ResultLabel.Text += "?";
                }
            }
            BSGSProgressBar.Visible = false;
            ResultLabel.Visible = true;
            this.Enabled = true;
        }

        private void RhoButton_Click(object sender, EventArgs e)
        {
            BSGSProgressBar.Value = 0;
            BigInteger a, b, m, answer;
            a = 0;
            b = 0;
            m = 0;
            answer = 0;

            ResultLabel.Visible = false;
            ResultLabel.ForeColor = Color.Red;

            BigInteger.TryParse(ABox.Text, out a);
            BigInteger.TryParse(BBox.Text, out b);
            BigInteger.TryParse(MBox.Text, out m);

            if (a < 2 || b < 0 || m < 3 || b > m)
                ResultLabel.Text = "Неправильный ввод данных";
            else if (!(CryptoMath.isPrime(m)))
                ResultLabel.Text = "М должно быть простым";
            else if (!(CryptoMath.isPrime((m - 1) / 2)))
                ResultLabel.Text = "Порядок группы М должен быть простым";
            else
            {
                if (m.ToString().Length > 5)
                {
                    ResultLabel.Text = "Слишком большое М - \nВозможно долгое время работы";
                    ResultLabel.Visible = true;
                }
                try
                {
                    BSGSProgressBar.Visible = true;
                    this.Enabled = false;
                    answer = Pollards_Rho.Pollard(a, b, m, BSGSProgressBar);
                }
                catch (OutOfMemoryException)
                {
                    ResultLabel.Text = "Нехватка оперативной памяти";
                    ResultLabel.Visible = true;
                    this.Enabled = true;
                    return;
                }
                if (answer == -1)
                    ResultLabel.Text = "Такого Х не найдено";
                else
                {
                    ResultLabel.ForeColor = Color.Green;
                    ResultLabel.Text = $"X = {answer}";

                    if (BigInteger.ModPow(a, answer, m) != b)
                    {
                        ResultLabel.ForeColor = Color.Red;
                        ResultLabel.Text = "Такого Х не найдено";
                    }
                    //ResultLabel.Text += "?";
                }
            }
            BSGSProgressBar.Visible = false;
            ResultLabel.Visible = true;
            this.Enabled = true;
        }

        private void RandomDataButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int size = rand.Next(11) + 2;
            BigInteger M = 0;
            while (!CryptoMath.isPrime((M-1)/2))
                M = CryptoMath.genSimpleRand(size);
            MBox.Text = M.ToString();
            ABox.Text = (CryptoMath.genRand(rand.Next(size - 1) + 1)+2).ToString();
            BBox.Text = (CryptoMath.genRand(rand.Next(size - 1) + 1)).ToString();
        }
    }
}
