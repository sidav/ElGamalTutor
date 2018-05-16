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
    public partial class TutorResults : Form
    {
        private static string BoolToResult(bool b)
        {
            if (b) return "Верно";
            else return "Неверно";
        }

        public TutorResults()
        {
            InitializeComponent();
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TutorResults_Load(object sender, EventArgs e)
        {
            if (Answers.modpowAnswers[0])
                powmodAnsLabel1.Text += "Верно";
            else
                powmodAnsLabel1.Text += "Неверно";
            if (Answers.modpowAnswers[1])
                powmodAnsLabel2.Text += "Верно";
            else
                powmodAnsLabel2.Text += "Неверно";
            if (Answers.modpowAnswers[2])
                powmodAnsLabel3.Text += "Верно";
            else
                powmodAnsLabel3.Text += "Неверно";
            if (Answers.EulerAnswers[0])
                EulerAnsLabel1.Text += "Верно";
            else
                EulerAnsLabel1.Text += "Неверно";
            if (Answers.EulerAnswers[1])
                EulerAnsLabel2.Text += "Верно";
            else
                EulerAnsLabel2.Text += "Неверно";
            if (Answers.EulerAnswers[2])
                EulerAnsLabel3.Text += "Верно";
            else
                EulerAnsLabel3.Text += "Неверно";
            if (Answers.ReverseAnswers[0])
                ReverseAnsLabel1.Text += "Верно";
            else
                ReverseAnsLabel1.Text += "Неверно";
            if (Answers.ReverseAnswers[1])
                ReverseAnsLabel2.Text += "Верно";
            else
                ReverseAnsLabel2.Text += "Неверно";
            if (Answers.DiscreteLogAnswers[0])
                DiscreteLogAnsLabel1.Text += "Верно";
            else
                DiscreteLogAnsLabel1.Text += "Неверно";
            if (Answers.DiscreteLogAnswers[1])
                DiscreteLogAnsLabel2.Text += "Верно";
            else
                DiscreteLogAnsLabel2.Text += "Неверно";
            if (Answers.AlgorithmicDLOGAnswers[0])
                AlgAnsLabel1.Text += "Верно";
            else
                AlgAnsLabel1.Text += "Неверно";
            if (Answers.AlgorithmicDLOGAnswers[1])
                AlgAnsLabel2.Text += "Верно";
            else
                AlgAnsLabel2.Text += "Неверно";

            //////////////////////////

            TestAnswer1Label.Text += BoolToResult(Answers.TestAnswers[0]);
            TestAnswer2Label.Text += BoolToResult(Answers.TestAnswers[1]);
            TestAnswer3Label.Text += BoolToResult(Answers.TestAnswers[2]);
            TestAnswer4Label.Text += BoolToResult(Answers.TestAnswers[3]);
            TestAnswer5Label.Text += BoolToResult(Answers.TestAnswers[4]);
            TestAnswer6Label.Text += BoolToResult(Answers.TestAnswers[5]);
            TestAnswer7Label.Text += BoolToResult(Answers.TestAnswers[6]);
            TestAnswer8Label.Text += BoolToResult(Answers.TestAnswers[7]);
            TestAnswer9Label.Text += BoolToResult(Answers.TestAnswers[8]);
            TestAnswer10Label.Text += BoolToResult(Answers.TestAnswers[9]);

            //Some LINQ magic
            double summa = Answers.modpowAnswers.Sum(a => a ? 1 : 0) + Answers.EulerAnswers.Sum(a => a ? 1 : 0) 
                + Answers.ReverseAnswers.Sum(a => a ? 1 : 0) + Answers.DiscreteLogAnswers.Sum(a => a ? 1 : 0) 
                + Answers.TestAnswers.Sum(a => a ? 1 : 0) + Answers.AlgorithmicDLOGAnswers.Sum(a => a ? 1 : 0);
            double FinalMark = 3 * (summa / 20) + 2;
            if (FinalMark % 1 >= 0.5)
                FinalMark += 1;
            FinalMarkLabel.Text = ((int)FinalMark).ToString();
        }
    }
}
