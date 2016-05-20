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
    public partial class TutorForm3 : Form
    {
        BigInteger ans1, ans2;
        public TutorForm3()
        {
            InitializeComponent();
            textBox1.Select(0, 0);
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Answers.interruptTutorial = false;
            Answers.formToShow -= 2;
            this.Close();
        }

        private void TutorForm3_Load(object sender, EventArgs e)
        {

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Answers.interruptTutorial = false;
            BigInteger.TryParse(answerBox1.Text, out ans1);
            BigInteger.TryParse(answerBox2.Text, out ans2);
            Answers.ReverseAnswers[0] = ans1 == 7;
            Answers.ReverseAnswers[1] = ans2 == 21;
            //var newForm = new TutorForm4();
            //newForm.Show();
            this.Close();
        }
    }
}
