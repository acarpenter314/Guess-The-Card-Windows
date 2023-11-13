using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using Image = System.Drawing.Image;

namespace Guess_The_Card
{
    public partial class FormStart : Form
    {
        // Initialize variables
        public static int winner = 0;
        public static string userCard = "";
        public string dealerCard = "";

        // Array for Easy difficulty
        string[] suit = { "Hearts.png", "Diamonds.png", "Spades.png", "Clubs.png" };

        // Array for Medium difficulty
        string[] facevalue =
        {
            "Ace.png", "Two.png", "Three.png", "Four.png", "Five.png",
            "Six.png", "Seven.png", "Eight.png", "Nine.png", "Ten.png"
        };

        // Array for Hard difficulty
        string[] suitface =
        {
            "AceSpades.png", "TwoSpades.png", "ThreeSpades.png", "FourSpades.png",
            "FiveSpades.png", "SixSpades.png", "SevenSpades.png", "EightSpades.png",
            "NineSpades.png", "TenSpades.png",
            "AceClubs.png", "TwoClubs.png", "ThreeClubs.png", "FourClubs.png",
            "FiveClubs.png", "SixClubs.png", "SevenClubs.png", "EightClubs.png",
            "NineClubs.png", "TenClubs.png",
            "AceHearts.png", "TwoHearts.png", "ThreeHearts.png", "FourHearts.png",
            "FiveHearts.png", "SixHearts.png", "SevenHearts.png", "EightHearts.png",
            "NineHearts.png", "TenHearts.png",
            "AceDiamonds.png", "TwoDiamonds.png", "ThreeDiamonds.png", "FourDiamonds.png",
            "FiveDiamonds.png", "SixDiamonds.png", "SevenDiamonds.png", "EightDiamonds.png",
            "NineDiamonds.png", "TenDiamonds.png"
        };

        public FormStart()
        {
            InitializeComponent();
            Random random = new Random(); // create a random variable

            // Determines what to do based on what difficulty has been selected in FormIntro
            if (FormIntro.difficulty == 0)
            {
                dealerCard = Convert.ToString(suit[random.Next(suit.Length)]);
                groupBoxSuit.Visible = true;
                groupBoxValue.Visible = false;
            }

            else if (FormIntro.difficulty == 1)
            {
                dealerCard = Convert.ToString(facevalue[random.Next(facevalue.Length)]);
                groupBoxSuit.Visible = false;
                groupBoxValue.Visible = true;
            }
            else if (FormIntro.difficulty == 2)
            {
                dealerCard = Convert.ToString(suitface[random.Next(suitface.Length)]);
                groupBoxSuit.Visible = true;
                groupBoxValue.Visible = true;
            }


            //MessageBox.Show(Convert.ToString(dealerCard));


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Exit Application when button is clicked
            Environment.Exit(1);
        }

        private void buttonReveal_Click(object sender, EventArgs e)
        {
            // Assign a random image to pictureBoxCard
            pictureBoxCard.Image = Image.FromFile($"../../../Cards/{dealerCard}");
            pictureBoxCover.Visible = false; // Hide picturebox
            Thread.Sleep(300); // Delay 
            pictureBoxCard.Visible = true; // Show picturebox

            // Check which radiobutton has been checked for Easy difficulty
            if (FormIntro.difficulty == 0)
            {
                if (this.radioButtonClubs.Checked)
                {
                    userCard = "Clubs.png";
                }
                else if (this.radioButtonDiamonds.Checked)
                {
                    userCard = "Diamonds.png";
                }
                else if (this.radioButtonHearts.Checked)
                {
                    userCard = "Hearts.png";
                }
                else if (this.radioButtonSpades.Checked)
                {
                    userCard = "Spades.png";
                }

            }

            // Check which radiobutton has been checked for Medium difficulty
            else if (FormIntro.difficulty == 1)
            {
                if (this.radioButtonAce.Checked)
                {
                    userCard = "Ace.png";
                }
                else if (this.radioButtonTwo.Checked)
                {
                    userCard = "Two.png";
                }
                else if (this.radioButtonThree.Checked)
                {
                    userCard = "Three.png";
                }
                else if (this.radioButtonFour.Checked)
                {
                    userCard = "Four.png";
                }
                else if (this.radioButtonFive.Checked)
                {
                    userCard = "Five.png";
                }
                else if (this.radioButtonSix.Checked)
                {
                    userCard = "Six.png";
                }
                else if (this.radioButtonSeven.Checked)
                {
                    userCard = "Seven.png";
                }
                else if (this.radioButtonEight.Checked)
                {
                    userCard = "Eight.png";
                }
                else if (this.radioButtonNine.Checked)
                {
                    userCard = "Nine.png";
                }
                else if (this.radioButtonTen.Checked)
                {
                    userCard = "Ten.png";
                }
            }

            // Check which radio button has been checked for Hard Difficulty
            if (FormIntro.difficulty == 2)
            {
                if (this.radioButtonAce.Checked && radioButtonClubs.Checked)
                {
                    userCard = "AceClubs.png";
                }
                else if (this.radioButtonTwo.Checked && radioButtonClubs.Checked)
                {
                    userCard = "TwoClubs.png";
                }
                else if (this.radioButtonThree.Checked && radioButtonClubs.Checked)
                {
                    userCard = "ThreeClubs.png";
                }
                else if (this.radioButtonFour.Checked && radioButtonClubs.Checked)
                {
                    userCard = "FourClubs.png";
                }
                else if (this.radioButtonFive.Checked && radioButtonClubs.Checked)
                {
                    userCard = "FiveClubs.png";
                }
                else if (this.radioButtonSix.Checked && radioButtonClubs.Checked)
                {
                    userCard = "SixClubs.png";
                }
                else if (this.radioButtonSeven.Checked && radioButtonClubs.Checked)
                {
                    userCard = "SevenClubs.png";
                }
                else if (this.radioButtonEight.Checked && radioButtonClubs.Checked)
                {
                    userCard = "EightClubs.png";
                }
                else if (this.radioButtonNine.Checked && radioButtonClubs.Checked)
                {
                    userCard = "NineClubs.png";
                }
                else if (this.radioButtonTen.Checked && radioButtonClubs.Checked)
                {
                    userCard = "TenClubs.png";
                }
            }

            // Determine if the user has guessed the right card
            if (dealerCard == userCard)
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
            // Hide Reveal button and Show Play Again button
            buttonReveal.Visible = false;
            buttonPlayAgain.Visible = true;
        }

        private void buttonMainScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIntro myForm = new FormIntro(); // Create the new form object
            myForm.ShowDialog(); // Show the new form
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStart myForm = new FormStart(); // Create the new form object
            myForm.ShowDialog(); // Show the new form
            buttonReveal.Visible = true; // Show Reveal button
            buttonPlayAgain.Visible = false; // Hide Play Again button
        }
    }
}
