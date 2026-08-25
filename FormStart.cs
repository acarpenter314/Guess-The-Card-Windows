using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Guess_The_Card
{
    public partial class FormStart : Form
    {
        private SpriteSheetLoader cardLoader;

        // Game state
        public static int winner = 0;
        public static string userRank = "";
        public static string userSuit = "";
        public string dealerRank = "";
        public string dealerSuit = "";

        // Rank and suit arrays
        private readonly string[] suits = { "Clubs", "Diamonds", "Hearts", "Spades" };
        private readonly string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

        public FormStart()
        {
            InitializeComponent();

            // Load sprite sheet
            cardLoader = new SpriteSheetLoader("Cards/cards.png", 4, 14);

            Random random = new Random();

            // Difficulty selection
            if (FormIntro.difficulty == 0)
            {
                // Easy: guess suit only
                dealerSuit = suits[random.Next(suits.Length)];
                dealerRank = "Back1"; // suit only
                groupBoxSuit.Visible = true;
                groupBoxValue.Visible = false;
            }
            else if (FormIntro.difficulty == 1)
            {
                // Medium: guess rank only
                dealerRank = ranks[random.Next(ranks.Length)];
                dealerSuit = "Hearts"; // rank only
                groupBoxSuit.Visible = false;
                groupBoxValue.Visible = true;
            }
            else if (FormIntro.difficulty == 2)
            {
                // Hard: guess rank and suit
                dealerSuit = suits[random.Next(suits.Length)];
                dealerRank = ranks[random.Next(ranks.Length)];
                groupBoxSuit.Visible = true;
                groupBoxValue.Visible = true;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void buttonReveal_Click(object sender, EventArgs e)
        {
            // Reveal dealer card
            pictureBoxCard.Image = cardLoader.GetCard(dealerRank, dealerSuit);
            pictureBoxCover.Visible = false;
            pictureBoxCard.Visible = true;

            // Easy mode: suit only
            if (FormIntro.difficulty == 0)
            {
                if (radioButtonClubs.Checked) userSuit = "Clubs";
                if (radioButtonDiamonds.Checked) userSuit = "Diamonds";
                if (radioButtonHearts.Checked) userSuit = "Hearts";
                if (radioButtonSpades.Checked) userSuit = "Spades";

                userRank = "Back1";
            }

            // Medium mode: rank only
            else if (FormIntro.difficulty == 1)
            {
                if (radioButtonAce.Checked) userRank = "A";
                if (radioButtonTwo.Checked) userRank = "2";
                if (radioButtonThree.Checked) userRank = "3";
                if (radioButtonFour.Checked) userRank = "4";
                if (radioButtonFive.Checked) userRank = "5";
                if (radioButtonSix.Checked) userRank = "6";
                if (radioButtonSeven.Checked) userRank = "7";
                if (radioButtonEight.Checked) userRank = "8";
                if (radioButtonNine.Checked) userRank = "9";
                if (radioButtonTen.Checked) userRank = "10";

                userSuit = "Hearts";
            }

            // Hard mode: rank and suit
            else if (FormIntro.difficulty == 2)
            {
                if (radioButtonAce.Checked) userRank = "A";
                if (radioButtonTwo.Checked) userRank = "2";
                if (radioButtonThree.Checked) userRank = "3";
                if (radioButtonFour.Checked) userRank = "4";
                if (radioButtonFive.Checked) userRank = "5";
                if (radioButtonSix.Checked) userRank = "6";
                if (radioButtonSeven.Checked) userRank = "7";
                if (radioButtonEight.Checked) userRank = "8";
                if (radioButtonNine.Checked) userRank = "9";
                if (radioButtonTen.Checked) userRank = "10";

                if (radioButtonClubs.Checked) userSuit = "Clubs";
                if (radioButtonDiamonds.Checked) userSuit = "Diamonds";
                if (radioButtonHearts.Checked) userSuit = "Hearts";
                if (radioButtonSpades.Checked) userSuit = "Spades";
            }

            // Win or lose
            if (dealerRank == userRank && dealerSuit == userSuit)
            {
                winner = 1;
                FormIntro.winCount++;
                labelWinCount.Text = FormIntro.winCount.ToString();
                MessageBox.Show("You Win!");
            }
            else
            {
                winner = 0;
                FormIntro.lossCount++;
                labelLossCount.Text = FormIntro.lossCount.ToString();
                MessageBox.Show("You Lose!");
            }

            buttonReveal.Visible = false;
            buttonPlayAgain.Visible = true;
        }

        private void buttonMainScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIntro myForm = new FormIntro();
            myForm.ShowDialog();
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStart myForm = new FormStart();
            myForm.ShowDialog();
            buttonReveal.Visible = true;
            buttonPlayAgain.Visible = false;
        }
    }
}