namespace Equation
{
    partial class StartResult
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartResult));
            this.inform = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.ThirdVariable = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SecondVariable = new System.Windows.Forms.Label();
            this.FirstVariable = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.FirstOperand = new System.Windows.Forms.Label();
            this.SecondOperand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inform
            // 
            this.inform.AutoSize = true;
            this.inform.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inform.Location = new System.Drawing.Point(398, 331);
            this.inform.Name = "inform";
            this.inform.Size = new System.Drawing.Size(0, 24);
            this.inform.TabIndex = 14;
            // 
            // Done
            // 
            this.Done.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.Done.FlatAppearance.BorderSize = 3;
            this.Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.Location = new System.Drawing.Point(379, 379);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(215, 76);
            this.Done.TabIndex = 13;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(386, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 55);
            this.label2.TabIndex = 5;
            this.label2.Tag = " ";
            this.label2.Text = "Score :";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Score.Location = new System.Drawing.Point(564, 168);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(52, 55);
            this.Score.TabIndex = 6;
            this.Score.Text = "0";
            // 
            // ThirdVariable
            // 
            this.ThirdVariable.AutoSize = true;
            this.ThirdVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdVariable.Location = new System.Drawing.Point(567, 273);
            this.ThirdVariable.Name = "ThirdVariable";
            this.ThirdVariable.Size = new System.Drawing.Size(36, 37);
            this.ThirdVariable.TabIndex = 8;
            this.ThirdVariable.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(633, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 37);
            this.label4.TabIndex = 9;
            this.label4.Text = "=";
            // 
            // SecondVariable
            // 
            this.SecondVariable.AutoSize = true;
            this.SecondVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondVariable.Location = new System.Drawing.Point(423, 273);
            this.SecondVariable.Name = "SecondVariable";
            this.SecondVariable.Size = new System.Drawing.Size(36, 37);
            this.SecondVariable.TabIndex = 10;
            this.SecondVariable.Text = "2";
            // 
            // FirstVariable
            // 
            this.FirstVariable.AutoSize = true;
            this.FirstVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstVariable.Location = new System.Drawing.Point(269, 273);
            this.FirstVariable.Name = "FirstVariable";
            this.FirstVariable.Size = new System.Drawing.Size(34, 37);
            this.FirstVariable.TabIndex = 11;
            this.FirstVariable.Text = "1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1041, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1042, 52);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(686, 269);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(64, 44);
            this.Result.TabIndex = 12;
            this.Result.Text = "4";
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FirstOperand
            // 
            this.FirstOperand.AutoSize = true;
            this.FirstOperand.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstOperand.Location = new System.Drawing.Point(341, 272);
            this.FirstOperand.Name = "FirstOperand";
            this.FirstOperand.Size = new System.Drawing.Size(37, 37);
            this.FirstOperand.TabIndex = 10;
            this.FirstOperand.Text = "+";
            // 
            // SecondOperand
            // 
            this.SecondOperand.AutoSize = true;
            this.SecondOperand.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondOperand.Location = new System.Drawing.Point(495, 273);
            this.SecondOperand.Name = "SecondOperand";
            this.SecondOperand.Size = new System.Drawing.Size(28, 37);
            this.SecondOperand.TabIndex = 8;
            this.SecondOperand.Text = "-";
            // 
            // StartResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inform);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.SecondOperand);
            this.Controls.Add(this.ThirdVariable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FirstOperand);
            this.Controls.Add(this.SecondVariable);
            this.Controls.Add(this.FirstVariable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartResult";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label inform;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label ThirdVariable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SecondVariable;
        private System.Windows.Forms.Label FirstVariable;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label FirstOperand;
        private System.Windows.Forms.Label SecondOperand;
    }
}