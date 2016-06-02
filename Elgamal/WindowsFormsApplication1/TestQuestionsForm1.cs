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
    public partial class TestQuestionsForm1 : Form
    {
        public TestQuestionsForm1()
        {
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
            //Сюда прикрутить проверку ответов
            Answers.TestAnswers[0] = TrueAnswer1RButton.Checked;
            Answers.TestAnswers[1] = TrueAnswer2RButton.Checked;
            Answers.interruptTutorial = false;
            this.Close();
        }

        private void TestQuesionsForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
