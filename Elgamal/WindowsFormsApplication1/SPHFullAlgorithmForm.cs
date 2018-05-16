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
    public partial class SPHFullAlgorithmForm : Form
    {
        public SPHFullAlgorithmForm()
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

        private void endBtn_Click(object sender, EventArgs e)
        {
            Answers.interruptTutorial = false;
            this.Close();
        }
    }
}
