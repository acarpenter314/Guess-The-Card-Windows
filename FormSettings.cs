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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void buttonBackSettings_Click(object sender, EventArgs e)
        {
            FormIntro myForm = new FormIntro(); // Create the new form object
            this.Hide(); // Hide the old form
            myForm.ShowDialog(); // Show the new form
        }
    }
}
