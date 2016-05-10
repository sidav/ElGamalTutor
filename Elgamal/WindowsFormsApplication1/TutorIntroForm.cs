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
    public partial class TutorIntroForm : Form
    {
        public TutorIntroForm()
        {
            InitializeComponent();
            textBox1.Select(0, 0);
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            var newForm = new TutorForm1();
            newForm.Show();
            this.Close();
        }
    }
}
