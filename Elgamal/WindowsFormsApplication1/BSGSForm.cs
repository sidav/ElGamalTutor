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
    public partial class BSGSForm : Form
    {
        public BSGSForm()
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
            else if (!(matan.isPrime(m)))
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
    }
}
