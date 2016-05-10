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
    public partial class TutorForm2 : Form
    {
        BigInteger fi1, fi2, fi3;
        BigInteger ans1, ans2, ans3;

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Answers.interruptTutorial = false;
            Answers.formToShow -= 2;
            this.Close();
        }

        Random rand = new Random();
        public TutorForm2()
        {
            InitializeComponent();
            textBox1.Select(0, 0);
            fi1 = rand.Next(2, 30);
            QuestionLabel1.Text = "fi(" + fi1 + ") = ";
            fi2 = rand.Next(2, 30);
            if (fi2 == fi1) fi2++;
            QuestionLabel2.Text = "fi(" + fi2 + ") = ";
            fi3 = rand.Next(2, 30);
            if (fi3 == fi1) fi3++;
            if (fi3 == fi2) fi3++;
            QuestionLabel3.Text = "fi(" + fi3 + ") = ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BigInteger.TryParse(answerBox1.Text, out ans1) && BigInteger.TryParse(answerBox2.Text, out ans2) && BigInteger.TryParse(answerBox3.Text, out ans3))
            {
                Answers.EulerAnswers[0] = (ans1 == matan.phi(fi1));
                Answers.EulerAnswers[1] = (ans2 == matan.phi(fi2));
                Answers.EulerAnswers[2] = (ans3 == matan.phi(fi3));
                //var newForm = new TutorForm3();
                //newForm.Show();
                Answers.interruptTutorial = false;
                this.Close();
            }
        }
    }
}
