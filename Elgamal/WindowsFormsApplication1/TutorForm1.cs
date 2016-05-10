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
    public partial class TutorForm1 : Form
    {

        int g1, x1, m1, answer1;
        int g2, x2, m2, answer2;
        int g3, x3, m3, answer3;
        
        Random rand = new Random();

        public TutorForm1()
        {
            InitializeComponent();
            textBox1.Select(0, 0);
            g1 = rand.Next(2, 4);
            x1 = rand.Next(2, 4);
            m1 = rand.Next(3, 20);
            QuestionLabel1.Text =
                "Попробуйте возвести " + g1.ToString() + " в степень " + x1.ToString() + " по модулю " + m1.ToString();
            g2 = rand.Next(2, 10);
            x2 = rand.Next(2, 6);
            m2 = rand.Next(5, 20);
            QuestionLabel2.Text =
                g2.ToString() + "^" + x2.ToString() + " mod " + m2.ToString() + " = ";
            g3 = rand.Next(2, 10);
            x3 = rand.Next(2, 6);
            m3 = rand.Next(5, 20);
            QuestionLabel3.Text =
                g3.ToString() + "^" + x3.ToString() + " mod " + m3.ToString() + " = ";
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(answerBox1.Text, out answer1) && int.TryParse(answerBox2.Text, out answer2) && int.TryParse(answerBox3.Text, out answer3))
            {
                Answers.modpowAnswers[0] = (answer1 == BigInteger.ModPow(g1, x1, m1));
                Answers.modpowAnswers[1] = (answer2 == BigInteger.ModPow(g2, x2, m2));
                Answers.modpowAnswers[2] = (answer3 == BigInteger.ModPow(g3, x3, m3));
                var newForm = new TutorForm2();
                this.Close();
                newForm.Show();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TutorForm11_Load(object sender, EventArgs e)
        {

        }

        private void answerBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
