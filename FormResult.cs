using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guess_The_Card
{
    public partial class FormReveal : Form
    {
        public FormReveal()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            FormStart myForm = new FormStart(); // Create the new form object
            this.Hide(); // Hide the old form
            myForm.ShowDialog(); // Show the new form
            this.Close(); // Close the old form
        }

        private void buttonMainScreen_Click(object sender, EventArgs e)
        {
            FormIntro myForm = new FormIntro(); // Create the new form object
            this.Hide(); // Hide the old form
            myForm.ShowDialog(); // Show the new form
            this.Close(); // Close the old form
        }
    }
}
