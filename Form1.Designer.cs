namespace Guess_The_Card
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            buttonMedium = new RadioButton();
            buttonHard = new RadioButton();
            buttonSettings = new Button();
            buttonStart = new Button();
            buttonHelp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(107, 53);
            label1.Name = "label1";
            label1.Size = new Size(235, 45);
            label1.TabIndex = 0;
            label1.Text = "Guess the Card";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 402);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 1;
            label2.Text = "Difficulty Level";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(174, 405);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(48, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Easy";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // buttonMedium
            // 
            buttonMedium.AutoSize = true;
            buttonMedium.Location = new Point(248, 405);
            buttonMedium.Name = "buttonMedium";
            buttonMedium.Size = new Size(70, 19);
            buttonMedium.TabIndex = 3;
            buttonMedium.TabStop = true;
            buttonMedium.Text = "Medium";
            buttonMedium.UseVisualStyleBackColor = true;
            // 
            // buttonHard
            // 
            buttonHard.AutoSize = true;
            buttonHard.Location = new Point(340, 405);
            buttonHard.Name = "buttonHard";
            buttonHard.Size = new Size(51, 19);
            buttonHard.TabIndex = 4;
            buttonHard.TabStop = true;
            buttonHard.Text = "Hard";
            buttonHard.UseVisualStyleBackColor = true;
            // 
            // buttonSettings
            // 
            buttonSettings.Location = new Point(36, 512);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(75, 23);
            buttonSettings.TabIndex = 5;
            buttonSettings.Text = "Settings";
            buttonSettings.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(174, 512);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(75, 23);
            buttonStart.TabIndex = 6;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(316, 512);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 23);
            buttonHelp.TabIndex = 7;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.saloon;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(454, 651);
            Controls.Add(buttonHelp);
            Controls.Add(buttonStart);
            Controls.Add(buttonSettings);
            Controls.Add(buttonHard);
            Controls.Add(buttonMedium);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton buttonMedium;
        private RadioButton buttonHard;
        private Button buttonSettings;
        private Button buttonStart;
        private Button buttonHelp;
    }
}