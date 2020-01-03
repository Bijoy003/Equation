namespace Equation
{
    partial class StartOperator
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
            this.FirstVariable = new System.Windows.Forms.Label();
            this.SecondVariable = new System.Windows.Forms.Label();
            this.ThirdVariable = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Score = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.inform = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstVariable
            // 
            this.FirstVariable.AutoSize = true;
            this.FirstVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstVariable.Location = new System.Drawing.Point(208, 237);
            this.FirstVariable.Name = "FirstVariable";
            this.FirstVariable.Size = new System.Drawing.Size(34, 37);
            this.FirstVariable.TabIndex = 0;
            this.FirstVariable.Text = "1";
            this.FirstVariable.Click += new System.EventHandler(this.FirstVariable_Click);
            // 
            // SecondVariable
            // 
            this.SecondVariable.AutoSize = true;
            this.SecondVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondVariable.Location = new System.Drawing.Point(362, 237);
            this.SecondVariable.Name = "SecondVariable";
            this.SecondVariable.Size = new System.Drawing.Size(36, 37);
            this.SecondVariable.TabIndex = 0;
            this.SecondVariable.Text = "2";
            this.SecondVariable.Click += new System.EventHandler(this.SecondVariable_Click);
            // 
            // ThirdVariable
            // 
            this.ThirdVariable.AutoSize = true;
            this.ThirdVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdVariable.Location = new System.Drawing.Point(506, 237);
            this.ThirdVariable.Name = "ThirdVariable";
            this.ThirdVariable.Size = new System.Drawing.Size(36, 37);
            this.ThirdVariable.TabIndex = 0;
            this.ThirdVariable.Text = "3";
            this.ThirdVariable.Click += new System.EventHandler(this.ThirdVariable_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(572, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "=";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(628, 237);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(36, 37);
            this.Result.TabIndex = 0;
            this.Result.Text = "4";
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(280, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 44);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "*";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(433, 233);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(37, 44);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "+";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Score.Location = new System.Drawing.Point(503, 132);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(52, 55);
            this.Score.TabIndex = 0;
            this.Score.Text = "0";
            this.Score.Click += new System.EventHandler(this.Score_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(325, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 55);
            this.label2.TabIndex = 0;
            this.label2.Tag = " ";
            this.label2.Text = "Score :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Done
            // 
            this.Done.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.Done.FlatAppearance.BorderSize = 3;
            this.Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.Location = new System.Drawing.Point(327, 363);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(215, 76);
            this.Done.TabIndex = 2;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            this.Done.MouseEnter += new System.EventHandler(this.Done_MouseEnter);
            this.Done.MouseLeave += new System.EventHandler(this.Done_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // inform
            // 
            this.inform.AutoSize = true;
            this.inform.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inform.Location = new System.Drawing.Point(336, 315);
            this.inform.Name = "inform";
            this.inform.Size = new System.Drawing.Size(0, 24);
            this.inform.TabIndex = 3;
            this.inform.Click += new System.EventHandler(this.inform_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Equation.Properties.Resources.TimeBar2;
            this.pictureBox1.Location = new System.Drawing.Point(-932, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(934, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // StartOperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(924, 521);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inform);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ThirdVariable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SecondVariable);
            this.Controls.Add(this.FirstVariable);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartOperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartOperator";
            this.Load += new System.EventHandler(this.StartOperator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstVariable;
        private System.Windows.Forms.Label SecondVariable;
        private System.Windows.Forms.Label ThirdVariable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label inform;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}