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
    public partial class TestQuestionsForm3 : Form
    {
        public TestQuestionsForm3()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Answers.TestAnswers[4] = TrueAnswer5RButton.Checked;
            Answers.TestAnswers[5] = TrueAnswer6RButton.Checked;
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
