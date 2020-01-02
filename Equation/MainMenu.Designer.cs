namespace Equation
{
    partial class MainMenu
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
            this.Exit = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.Difficulty = new System.Windows.Forms.Button();
            this.Game_Mode = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(412, 286);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(412, 240);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(75, 23);
            this.About.TabIndex = 0;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Difficulty
            // 
            this.Difficulty.Location = new System.Drawing.Point(412, 200);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(75, 23);
            this.Difficulty.TabIndex = 0;
            this.Difficulty.Text = "Difficulty";
            this.Difficulty.UseVisualStyleBackColor = true;
            this.Difficulty.Click += new System.EventHandler(this.Difficulty_Click);
            // 
            // Game_Mode
            // 
            this.Game_Mode.Location = new System.Drawing.Point(412, 152);
            this.Game_Mode.Name = "Game_Mode";
            this.Game_Mode.Size = new System.Drawing.Size(75, 23);
            this.Game_Mode.TabIndex = 0;
            this.Game_Mode.Text = "Game Mode";
            this.Game_Mode.UseVisualStyleBackColor = true;
            this.Game_Mode.Click += new System.EventHandler(this.GameMode_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(412, 104);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Game_Mode);
            this.Controls.Add(this.Difficulty);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Difficulty;
        private System.Windows.Forms.Button Game_Mode;
        private System.Windows.Forms.Button Start;
    }
}