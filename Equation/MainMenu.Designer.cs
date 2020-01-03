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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.Exit.Location = new System.Drawing.Point(339, 383);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(270, 45);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseEnter += new System.EventHandler(this.Exit_MouseEnter);
            this.Exit.MouseLeave += new System.EventHandler(this.Exit_MouseLeave);
            // 
            // About
            // 
            this.About.FlatAppearance.BorderSize = 0;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.About.Location = new System.Drawing.Point(339, 333);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(270, 45);
            this.About.TabIndex = 0;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            this.About.MouseEnter += new System.EventHandler(this.About_MouseEnter);
            this.About.MouseLeave += new System.EventHandler(this.About_MouseLeave);
            // 
            // Difficulty
            // 
            this.Difficulty.FlatAppearance.BorderSize = 0;
            this.Difficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.Difficulty.Location = new System.Drawing.Point(339, 283);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(270, 45);
            this.Difficulty.TabIndex = 0;
            this.Difficulty.Text = "Difficulty";
            this.Difficulty.UseVisualStyleBackColor = true;
            this.Difficulty.Click += new System.EventHandler(this.Difficulty_Click);
            this.Difficulty.MouseEnter += new System.EventHandler(this.Difficulty_MouseEnter);
            this.Difficulty.MouseLeave += new System.EventHandler(this.Difficulty_MouseLeave);
            // 
            // Game_Mode
            // 
            this.Game_Mode.FlatAppearance.BorderSize = 0;
            this.Game_Mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Game_Mode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.Game_Mode.Location = new System.Drawing.Point(339, 233);
            this.Game_Mode.Name = "Game_Mode";
            this.Game_Mode.Size = new System.Drawing.Size(270, 45);
            this.Game_Mode.TabIndex = 0;
            this.Game_Mode.Text = "Game Mode";
            this.Game_Mode.UseVisualStyleBackColor = true;
            this.Game_Mode.Click += new System.EventHandler(this.GameMode_Click);
            this.Game_Mode.MouseEnter += new System.EventHandler(this.Game_Mode_MouseEnter);
            this.Game_Mode.MouseLeave += new System.EventHandler(this.Game_Mode_MouseLeave);
            // 
            // Start
            // 
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.Start.Location = new System.Drawing.Point(339, 183);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(270, 45);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            this.Start.MouseEnter += new System.EventHandler(this.Start_MouseEnter);
            this.Start.MouseLeave += new System.EventHandler(this.Start_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Equation.Properties.Resources.Equation;
            this.pictureBox1.Location = new System.Drawing.Point(34, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(876, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Game_Mode);
            this.Controls.Add(this.Difficulty);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Exit);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Difficulty;
        private System.Windows.Forms.Button Game_Mode;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}