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
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
        }

        private void buttonBackHelp_Click(object sender, EventArgs e)
        {
            FormIntro myForm = new FormIntro(); // Create the new form object
            this.Hide(); // Hide the old form
            myForm.ShowDialog(); // Show the new form
            this.Close(); // Close the old form
        }
    }
}
