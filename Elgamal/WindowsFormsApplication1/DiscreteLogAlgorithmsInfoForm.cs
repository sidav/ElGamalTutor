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
    public partial class DiscreteLogAlgorithmsInfoForm : Form
    {
        static Random r = new Random();
        static BigInteger base1, base2, num1, num2, mod1, mod2, ans1, ans2;

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Answers.interruptTutorial = false;
            Answers.formToShow -= 2;
            this.Close();
        }

        public DiscreteLogAlgorithmsInfoForm()
        {
            InitializeComponent();
            textBox1.Select(0, 0);
            // textBox2.Select(0, 0);
            base1 = new BigInteger(r.Next(100000) + 2);
            base2 = new BigInteger(r.Next(100000) + 2);
            mod1 = matan.genSimpleRand(8);
            if (mod1 == base1) mod1++;
            mod2 = matan.genSimpleRand(8);
            if (mod2 == base2) mod1++;
            BigInteger rnd1 = matan.genRand(100000);
            BigInteger rnd2 = matan.genRand(100000);
            num1 = BigInteger.ModPow(base1, rnd1, mod1);
            num2 = BigInteger.ModPow(base2, rnd2, mod2);
            Task1Label.Text =
                base1.ToString() + "^x  = " + num1.ToString() + " mod " + mod1.ToString();
            Task2Label.Text =
                base2.ToString() + "^x  = " + num2.ToString() + " mod " + mod2.ToString();
        }

        private void DiscreteLogAlgorithmsInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (BigInteger.TryParse(AnswerBox1.Text, out ans1) && BigInteger.TryParse(AnswerBox2.Text, out ans2))
            {
                Answers.AlgorithmicDLOGAnswers[0] = (num1 == BigInteger.ModPow(base1, ans1, mod1));
                Answers.AlgorithmicDLOGAnswers[1] = (num2 == BigInteger.ModPow(base2, ans2, mod2));
                //var newForm = new TutorForm3();
                //newForm.Show();
                Answers.interruptTutorial = false;
                this.Close();
            }
        }
    }
}
