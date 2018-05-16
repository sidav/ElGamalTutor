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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
           InitializeComponent();
        }

        //private static void debugAnswers()
        //{
        //    Answers.modpowAnswers = new bool[]{ true, true, true };
        //    Answers.EulerAnswers = new bool[] { true, true, true };
        //    Answers.ReverseAnswers = new bool[] { true, true};
        //    Answers.DiscreteLogAnswers = new bool[] { true, true };
        //    Answers.AlgorithmicDLOGAnswers = new bool[] { true, true };
        //    Answers.TestAnswers = new bool[] { true, true, true,true,true, true, true, true};

        //}

        private void startTutorBtn_Click(object sender, EventArgs e)
        {
            Answers.interruptTutorial = false;
            Answers.formToShow = 0;
            var formList = new List<Form>();

            ////REMOVE
            //debugAnswers();
            //(new TutorResults()).ShowDialog();
            ////REMOVE

            formList.Add(new TutorIntroForm());
            formList.Add(new TutorForm1());
            formList.Add(new TutorForm2());
            formList.Add(new TutorForm3());
            formList.Add(new ElGamalInfoForm());
            formList.Add(new TutorForm4());
            formList.Add(new TutorForm5());
            formList.Add(new TutorForm6());
            formList.Add(new TutorForm7());
            formList.Add(new DiscrLogTutor());
            formList.Add(new DiscreteLogAlgorithmsInfoForm());
            formList.Add(new GelfondShanksInfoForm());
            formList.Add(new GelfondShanksTheoryForm());
            formList.Add(new GelfondShanksAlgorithmForm());
            formList.Add(new SPHInfoForm());
            formList.Add(new SPHParticularAlgorithmForm());
            formList.Add(new SPHFullAlgorithmForm());
            formList.Add(new RhoInfoForm());
            formList.Add(new TestQuestionsForm1());
            formList.Add(new TestQuestionsForm2());
            formList.Add(new TestQuestionsForm3());
            formList.Add(new TestQuestionsForm4());
            formList.Add(new TestQuestionsForm5());
            formList.Add(new TutorResults());

            while (!Answers.tutorialEnded && !Answers.interruptTutorial)
            {
                Answers.interruptTutorial = true;
                if (Answers.formToShow >= formList.Count)
                    break;
                formList[Answers.formToShow].ShowDialog();
                Answers.formToShow++;
            }
            //this.Close();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void fiBtn_Click(object sender, EventArgs e)
        {
            var newForm = new CalcfiForm();
            newForm.ShowDialog();
        }

        private void primitBtn_Click(object sender, EventArgs e)
        {
            var newForm = new PrimitiveRootForm();
            newForm.ShowDialog();
        }

        private void genKeysBtn_Click(object sender, EventArgs e)
        {
            var newForm = new DecryptForm();
            newForm.ShowDialog();
        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            var newForm = new EncryptForm();
            newForm.ShowDialog();
        }

        private void primeTestBtn_Click(object sender, EventArgs e)
        {
            var newForm = new PrimeTestForm();
            newForm.ShowDialog();
        }

        private void modPowBtn_Click(object sender, EventArgs e)
        {
            var newForm = new modPowForm();
            newForm.ShowDialog();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            var newForm = new AboutForm();
            newForm.ShowDialog();
        }

        private void BSGSBtn_Click(object sender, EventArgs e)
        {
            var newForm = new DiscreteLogarithmCalculationForm();
            newForm.ShowDialog();
        }
    }
}
