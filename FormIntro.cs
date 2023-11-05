using System.Windows.Forms;

namespace Guess_The_Card
{
    public partial class FormIntro : Form
    {
        public FormIntro()
        {
            InitializeComponent();
        }

        public static int difficulty;
        public static int winCount = 0;
        public static int lossCount = 0;
        // button event to open the settings form
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings myForm = new FormSettings(); // Create the new form object
            this.Hide(); // Hide the old form
            myForm.ShowDialog(); // Show the new form
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp myForm = new FormHelp(); // Create the new form object
            this.Hide(); // Hide the old form
            myForm.ShowDialog(); // Show the new form
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

            if (buttonEasy.Checked == true)
            {
                difficulty = 0;
            }
            else if (buttonMedium.Checked == true)
            {
                difficulty = 1;
            }
            else if (buttonHard.Checked == true)
            {
                difficulty = 2;
            }
            //MessageBox.Show(Convert.ToString(difficulty));
            if (buttonEasy.Checked == false && buttonMedium.Checked == false &&
                buttonHard.Checked == false)
            {
                MessageBox.Show("Pick a Difficulty.");
            }
            else
            {
                FormStart myForm = new FormStart(); // Create the new form object
                this.Hide(); // Hide the old form
                myForm.ShowDialog(); // Show the new form
            }
        }

        private void groupBoxDifficulty_Enter(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}