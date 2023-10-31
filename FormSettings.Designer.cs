namespace Guess_The_Card
{
    partial class FormSettings
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
            buttonBackSettings = new Button();
            buttonMusicOnOff = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonBackSettings
            // 
            buttonBackSettings.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBackSettings.ForeColor = SystemColors.ActiveCaptionText;
            buttonBackSettings.Location = new Point(186, 438);
            buttonBackSettings.Name = "buttonBackSettings";
            buttonBackSettings.Size = new Size(84, 47);
            buttonBackSettings.TabIndex = 7;
            buttonBackSettings.Text = "Back";
            buttonBackSettings.UseVisualStyleBackColor = true;
            buttonBackSettings.Click += buttonBackSettings_Click;
            // 
            // buttonMusicOnOff
            // 
            buttonMusicOnOff.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMusicOnOff.ForeColor = SystemColors.ActiveCaptionText;
            buttonMusicOnOff.Location = new Point(198, 324);
            buttonMusicOnOff.Name = "buttonMusicOnOff";
            buttonMusicOnOff.Size = new Size(60, 30);
            buttonMusicOnOff.TabIndex = 6;
            buttonMusicOnOff.Text = "Off";
            buttonMusicOnOff.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(155, 261);
            label2.Name = "label2";
            label2.Size = new Size(144, 30);
            label2.TabIndex = 5;
            label2.Text = "Music On/Off";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(170, 166);
            label1.Name = "label1";
            label1.Size = new Size(100, 32);
            label1.TabIndex = 4;
            label1.Text = "Settings";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(70, 52);
            label3.Name = "label3";
            label3.Size = new Size(311, 59);
            label3.TabIndex = 19;
            label3.Text = "Guess the Card";
            // 
            // FormSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(454, 651);
            Controls.Add(label3);
            Controls.Add(buttonBackSettings);
            Controls.Add(buttonMusicOnOff);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "FormSettings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormSettings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBackSettings;
        private Button buttonMusicOnOff;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}