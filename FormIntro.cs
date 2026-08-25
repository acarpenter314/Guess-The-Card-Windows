using System;
using System.Windows.Forms;

namespace Guess_The_Card
{
    public partial class FormIntro : Form
    {
        // Difficulty setting:
        // 0 = Easy (guess suit)
        // 1 = Medium (guess rank)
        // 2 = Hard (guess rank + suit)
        public static int difficulty = 0;

        // Win/loss counters
        public static int winCount = 0;
        public static int lossCount = 0;

        public FormIntro()
        {
            InitializeComponent();

            // Update labels on intro screen
            labelWins.Text = winCount.ToString();
            labelLosses.Text = lossCount.ToString();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            // Determine selected difficulty
            if (radioButtonEasy.Checked)
            {
                difficulty = 0;
            }
            else if (radioButtonMedium.Checked)
            {
                difficulty = 1;
