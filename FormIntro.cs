namespace Guess_The_Card
{
    public partial class FormIntro : Form
    {
        public FormIntro()
        {
            InitializeComponent();
        }

        private static int difficulty = 0;

        public static int Difficulty
        {
            get { return difficulty; }
            set { int difficulty = value; }
        }

        // button event to open the settings form
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            FormSettings myForm = new FormSettings(); // Create the new form object
            this.Hide(); // Hide the old form
            myForm.ShowDialog(); // Show the new form
            this.Close(); // Close the old form
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp myForm = new FormHelp(); // Create the new form object
            this.Hide(); // Hide the old form
            myForm.ShowDialog(); // Show the new form
            this.Close(); // Close the old form
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormStart myForm = new FormStart(); // Create the new form object
            this.Hide(); // Hide the old form
            myForm.ShowDialog(); // Show the new form
            this.Close(); // Close the old form
        }

        private void groupBoxDifficulty_Enter(object sender, EventArgs e)
        {
            if (buttonEasy.Checked == true)
            {
                difficulty = 0;
                MessageBox.Show(Convert.ToString(difficulty));
            }
            if (buttonMedium.Checked == true)
            {
                difficulty = 1;
            }
            if (buttonHard.Checked == true)
            {
                difficulty = 2;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}