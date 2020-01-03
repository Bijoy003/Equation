namespace Equation
{
    partial class Difficulty
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
            this.HardButton = new System.Windows.Forms.Button();
            this.MediumButton = new System.Windows.Forms.Button();
            this.EasyButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HardButton
            // 
            this.HardButton.FlatAppearance.BorderSize = 0;
            this.HardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.HardButton.Location = new System.Drawing.Point(344, 316);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(270, 60);
            this.HardButton.TabIndex = 3;
            this.HardButton.Text = "Hard";
            this.HardButton.UseVisualStyleBackColor = true;
            this.HardButton.Click += new System.EventHandler(this.button3_Click);
            this.HardButton.MouseEnter += new System.EventHandler(this.HardMouseEnter);
            this.HardButton.MouseLeave += new System.EventHandler(this.HardMouseLeave);
            // 
            // MediumButton
            // 
            this.MediumButton.FlatAppearance.BorderSize = 0;
            this.MediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MediumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.MediumButton.Location = new System.Drawing.Point(344, 259);
            this.MediumButton.Name = "MediumButton";
            this.MediumButton.Size = new System.Drawing.Size(270, 60);
            this.MediumButton.TabIndex = 4;
            this.MediumButton.Text = "Medium";
            this.MediumButton.UseVisualStyleBackColor = true;
            this.MediumButton.Click += new System.EventHandler(this.button2_Click);
            this.MediumButton.MouseEnter += new System.EventHandler(this.MediumMouseEnter);
            this.MediumButton.MouseLeave += new System.EventHandler(this.MediumMouseLeave);
            // 
            // EasyButton
            // 
            this.EasyButton.FlatAppearance.BorderSize = 0;
            this.EasyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EasyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.EasyButton.Location = new System.Drawing.Point(344, 199);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(270, 60);
            this.EasyButton.TabIndex = 5;
            this.EasyButton.Text = "Easy";
            this.EasyButton.UseVisualStyleBackColor = true;
            this.EasyButton.Click += new System.EventHandler(this.button1_Click);
            this.EasyButton.MouseEnter += new System.EventHandler(this.EasyMouseEnter);
            this.EasyButton.MouseLeave += new System.EventHandler(this.EasyMouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(242, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Game Difficulty";
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.HardButton);
            this.Controls.Add(this.MediumButton);
            this.Controls.Add(this.EasyButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Difficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Difficulty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HardButton;
        private System.Windows.Forms.Button MediumButton;
        private System.Windows.Forms.Button EasyButton;
        private System.Windows.Forms.Label label1;
    }
}