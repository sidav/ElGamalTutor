using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElgamalTutor
{
    public partial class DiscrLogTutor : Form
    {
        static Random r = new Random();
        static BigInteger base1, base2, num1, num2, mod1, mod2, ans1, ans2;
        public DiscrLogTutor()
        {
            base1 = r.Next(2)+2;
            base2 = r.Next(4)+2;
            mod1 = r.Next(5)+2;
            mod2 = r.Next(7) + 3;
            BigInteger rnd1 = r.Next(5) + 3;
            BigInteger rnd2 = r.Next(5) + 3;
            num1 = BigInteger.ModPow(base1, rnd1, mod1);
            num2 = BigInteger.ModPow(base2, rnd2, mod2);
            Task1Label.Text = 
                "Попробуйте найти логарифм по основанию " + base1.ToString() + " и модулю " + mod1.ToString() + " от числа " + num1.ToString() + ":";
            Task2Label.Text =
                "Логарифм по основанию " + base2.ToString() + " и модулю " + mod2.ToString() + " от числа " + num2.ToString() + ":";
            InitializeComponent();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Answers.interruptTutorial = false;
            Answers.formToShow -= 2;
            this.Close();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (BigInteger.TryParse(AnswerBox1.Text, out ans1) && BigInteger.TryParse(AnswerBox2.Text, out ans2))
            {
                Answers.DiscreteLogAnswers[0] = (num1 == BigInteger.ModPow(base1, ans1, mod1));
                Answers.DiscreteLogAnswers[1] = (num2 == BigInteger.ModPow(base2, ans2, mod2));
                //var newForm = new TutorForm3();
                //newForm.Show();
                Answers.interruptTutorial = false;
                this.Close();
            }
        }
    }
}
