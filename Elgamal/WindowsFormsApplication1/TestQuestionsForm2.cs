using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElgamalTutor
{
    public partial class TestQuestionsForm2 : Form
    {
        public TestQuestionsForm2()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Answers.TestAnswers[2] = TrueAnswer3RButton.Checked;
            Answers.TestAnswers[3] = TrueAnswer4RButton.Checked;
            Answers.interruptTutorial = false;
            this.Close();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            Answers.interruptTutorial = false;
            Answers.formToShow -= 2;
            this.Close();
        }
    }
}
