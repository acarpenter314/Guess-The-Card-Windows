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

namespace Guess_The_Card
{
    public partial class FormStart : Form
    {
        int winner = 0;
        string[] guessCard;
        public FormStart()
        {
            InitializeComponent();
            pictureBoxCover.Visible = true;
            pictureBoxCard.Visible = false; 
        }

        private void groupBoxSuit_Enter(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonReveal_Click(object sender, EventArgs e)
        {
            if (pictureBoxCard = guessCard[])
            {
                winner = 1;
            }
            else winner = 0;

            pictureBoxCover.Visible = false;
            pictureBoxCard.Visible = true;
            FormReveal myForm = new FormReveal(); // Create the new form object
            myForm.ShowDialog(); // Show the new form
            
        }

        private void buttonMainScreen_Click(object sender, EventArgs e)
        {
            // Guess_The_Card.FormIntro.ShowDialog();
            this.Close();

        }

        private void pictureBoxCard_Click(object sender, EventArgs e)
        {

            var rand = new Random();
            var files = Directory.GetFiles("Cards\", "*.png");
             files[rand.Next(files.Length)];
        }
    }
}
