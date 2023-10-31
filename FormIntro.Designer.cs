namespace Guess_The_Card
{
    partial class FormIntro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIntro));
            buttonEasy = new RadioButton();
            buttonMedium = new RadioButton();
            buttonHard = new RadioButton();
            buttonSettings = new Button();
            buttonStart = new Button();
            buttonHelp = new Button();
            label1 = new Label();
            groupBoxDifficulty = new GroupBox();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            groupBoxDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonEasy
            // 
            buttonEasy.AutoSize = true;
            buttonEasy.BackColor = SystemColors.ActiveCaptionText;
            buttonEasy.ForeColor = SystemColors.ButtonFace;
            buttonEasy.Location = new Point(14, 22);
            buttonEasy.Name = "buttonEasy";
            buttonEasy.Size = new Size(67, 29);
            buttonEasy.TabIndex = 2;
            buttonEasy.TabStop = true;
            buttonEasy.Text = "Easy";
            buttonEasy.UseVisualStyleBackColor = false;
            // 
            // buttonMedium
            // 
            buttonMedium.AutoSize = true;
            buttonMedium.BackColor = SystemColors.ActiveCaptionText;
            buttonMedium.ForeColor = SystemColors.ButtonFace;
            buttonMedium.Location = new Point(88, 22);
            buttonMedium.Name = "buttonMedium";
            buttonMedium.Size = new Size(100, 29);
            buttonMedium.TabIndex = 3;
            buttonMedium.TabStop = true;
            buttonMedium.Text = "Medium";
            buttonMedium.UseVisualStyleBackColor = false;
            // 
            // buttonHard
            // 
            buttonHard.AutoSize = true;
            buttonHard.BackColor = SystemColors.ActiveCaptionText;
            buttonHard.ForeColor = SystemColors.ButtonFace;
            buttonHard.Location = new Point(194, 22);
            buttonHard.Name = "buttonHard";
            buttonHard.Size = new Size(71, 29);
            buttonHard.TabIndex = 4;
            buttonHard.TabStop = true;
            buttonHard.Text = "Hard";
            buttonHard.UseVisualStyleBackColor = false;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = SystemColors.ActiveCaptionText;
            buttonSettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSettings.ForeColor = SystemColors.ButtonFace;
            buttonSettings.Location = new Point(93, 478);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(82, 35);
            buttonSettings.TabIndex = 5;
            buttonSettings.Text = "Settings";
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = SystemColors.ActiveCaptionText;
            buttonStart.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStart.ForeColor = SystemColors.ButtonFace;
            buttonStart.Location = new Point(93, 548);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(81, 35);
            buttonStart.TabIndex = 6;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ActiveCaptionText;
            buttonHelp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHelp.ForeColor = SystemColors.ButtonFace;
            buttonHelp.Location = new Point(273, 478);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(75, 35);
            buttonHelp.TabIndex = 7;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(70, 52);
            label1.Name = "label1";
            label1.Size = new Size(311, 59);
            label1.TabIndex = 0;
            label1.Text = "Guess the Card";
            // 
            // groupBoxDifficulty
            // 
            groupBoxDifficulty.Controls.Add(buttonHard);
            groupBoxDifficulty.Controls.Add(buttonMedium);
            groupBoxDifficulty.Controls.Add(buttonEasy);
            groupBoxDifficulty.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxDifficulty.ForeColor = SystemColors.ButtonHighlight;
            groupBoxDifficulty.Location = new Point(79, 388);
            groupBoxDifficulty.Name = "groupBoxDifficulty";
            groupBoxDifficulty.Size = new Size(280, 53);
            groupBoxDifficulty.TabIndex = 8;
            groupBoxDifficulty.TabStop = false;
            groupBoxDifficulty.Text = "Difficulty Level";
            groupBoxDifficulty.Enter += groupBoxDifficulty_Enter;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = SystemColors.ActiveCaptionText;
            buttonExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.ForeColor = SystemColors.ButtonFace;
            buttonExit.Location = new Point(273, 548);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(81, 35);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(132, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 243);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // FormIntro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(454, 651);
            Controls.Add(pictureBox1);
            Controls.Add(buttonExit);
            Controls.Add(groupBoxDifficulty);
            Controls.Add(buttonHelp);
            Controls.Add(buttonStart);
            Controls.Add(buttonSettings);
            Controls.Add(label1);
            Name = "FormIntro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormIntro";
            groupBoxDifficulty.ResumeLayout(false);
            groupBoxDifficulty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RadioButton buttonEasy;
        private RadioButton buttonMedium;
        private RadioButton buttonHard;
        private Button buttonSettings;
        private Button buttonStart;
        private Button buttonHelp;
        private Label label1;
        private GroupBox groupBoxDifficulty;
        private Button buttonExit;
        private PictureBox pictureBox1;
    }
}