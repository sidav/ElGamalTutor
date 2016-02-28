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

        private void startTutorBtn_Click(object sender, EventArgs e)
        {
            var newForm = new TutorIntroForm();
            newForm.ShowDialog();
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
    }
}
