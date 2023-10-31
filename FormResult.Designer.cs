namespace Guess_The_Card
{
    partial class FormReveal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelWinner = new Label();
            buttonExit = new Button();
            buttonPlayAgain = new Button();
            buttonMainScreen = new Button();
            labelLoser = new Label();
            SuspendLayout();
            // 
            // labelWinner
            // 
            labelWinner.AutoSize = true;
            labelWinner.BackColor = SystemColors.ActiveCaptionText;
            labelWinner.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            labelWinner.ForeColor = Color.Lime;
            labelWinner.Location = new Point(54, 16);
            labelWinner.Name = "labelWinner";
            labelWinner.Size = new Size(172, 59);
            labelWinner.TabIndex = 19;
            labelWinner.Text = "Winner!";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.ActiveCaptionText;
            buttonExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.ForeColor = SystemColors.ButtonFace;
            buttonExit.Location = new Point(108, 140);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(81, 35);
            buttonExit.TabIndex = 20;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonPlayAgain
            // 
            buttonPlayAgain.BackColor = SystemColors.ActiveCaptionText;
            buttonPlayAgain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPlayAgain.ForeColor = SystemColors.ButtonFace;
            buttonPlayAgain.Location = new Point(24, 85);
            buttonPlayAgain.Name = "buttonPlayAgain";
            buttonPlayAgain.Size = new Size(117, 35);
            buttonPlayAgain.TabIndex = 21;
            buttonPlayAgain.Text = "Play Again?";
            buttonPlayAgain.UseVisualStyleBackColor = false;
            buttonPlayAgain.Click += buttonPlayAgain_Click;
            // 
            // buttonMainScreen
            // 
            buttonMainScreen.BackColor = SystemColors.ActiveCaptionText;
            buttonMainScreen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMainScreen.ForeColor = SystemColors.ButtonFace;
            buttonMainScreen.Location = new Point(163, 85);
            buttonMainScreen.Name = "buttonMainScreen";
            buttonMainScreen.Size = new Size(111, 35);
            buttonMainScreen.TabIndex = 22;
            buttonMainScreen.Text = "Main Screen";
            buttonMainScreen.UseVisualStyleBackColor = false;
            buttonMainScreen.Click += buttonMainScreen_Click;
            // 
            // labelLoser
            // 
            labelLoser.AutoSize = true;
            labelLoser.BackColor = SystemColors.ActiveCaptionText;
            labelLoser.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            labelLoser.ForeColor = Color.Lime;
            labelLoser.Location = new Point(68, 16);
            labelLoser.Name = "labelLoser";
            labelLoser.Size = new Size(137, 59);
            labelLoser.TabIndex = 23;
            labelLoser.Text = "Loser!";
            // 
            // FormReveal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(317, 195);
            Controls.Add(labelLoser);
            Controls.Add(buttonMainScreen);
            Controls.Add(buttonPlayAgain);
            Controls.Add(buttonExit);
            Controls.Add(labelWinner);
            Name = "FormReveal";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "FormResult";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWinner;
        private Button buttonExit;
        private Button buttonPlayAgain;
        private Button buttonMainScreen;
        private Label labelLoser;
    }
}