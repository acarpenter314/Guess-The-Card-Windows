namespace Guess_The_Card
{
    partial class FormHelp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonBackHelp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(172, 35);
            label1.Name = "label1";
            label1.Size = new Size(73, 37);
            label1.TabIndex = 0;
            label1.Text = "Help";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 142);
            label2.Name = "label2";
            label2.Size = new Size(314, 42);
            label2.TabIndex = 1;
            label2.Text = "the object of the game is to guess what card\r\n the dealer is holding.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(65, 260);
            label3.Name = "label3";
            label3.Size = new Size(324, 147);
            label3.TabIndex = 2;
            label3.Text = "Difficulty: There are three levels of Difficulty:\r\n\r\nEasy: Guess the suit of the card.\r\n\r\nMedium: Guess the card between Ace and 10.\r\n\r\nHard: Guess the suit and the card.\r\n";
            // 
            // buttonBackHelp
            // 
            buttonBackHelp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBackHelp.ForeColor = SystemColors.ActiveCaptionText;
            buttonBackHelp.Location = new Point(184, 481);
            buttonBackHelp.Name = "buttonBackHelp";
            buttonBackHelp.Size = new Size(75, 30);
            buttonBackHelp.TabIndex = 3;
            buttonBackHelp.Text = "Back";
            buttonBackHelp.UseVisualStyleBackColor = true;
            buttonBackHelp.Click += buttonBackHelp_Click;
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(454, 651);
            Controls.Add(buttonBackHelp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.Control;
            Name = "FormHelp";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormHelp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonBackHelp;
    }
}