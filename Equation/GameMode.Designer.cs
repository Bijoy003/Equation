namespace Equation
{
    partial class GameMode
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
            this.label1 = new System.Windows.Forms.Label();
            this.MissingOperator = new System.Windows.Forms.Button();
            this.MissingVariable = new System.Windows.Forms.Button();
            this.MissingResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(283, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Game Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MissingOperator
            // 
            this.MissingOperator.FlatAppearance.BorderSize = 0;
            this.MissingOperator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MissingOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.MissingOperator.Location = new System.Drawing.Point(354, 194);
            this.MissingOperator.Name = "MissingOperator";
            this.MissingOperator.Size = new System.Drawing.Size(270, 60);
            this.MissingOperator.TabIndex = 1;
            this.MissingOperator.Text = "Missing Operator";
            this.MissingOperator.UseVisualStyleBackColor = true;
            this.MissingOperator.Click += new System.EventHandler(this.button1_Click);
            this.MissingOperator.MouseEnter += new System.EventHandler(this.OperatorMouseEnter);
            this.MissingOperator.MouseLeave += new System.EventHandler(this.OperatorMouseLeave);
            // 
            // MissingVariable
            // 
            this.MissingVariable.FlatAppearance.BorderSize = 0;
            this.MissingVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MissingVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.MissingVariable.Location = new System.Drawing.Point(354, 251);
            this.MissingVariable.Name = "MissingVariable";
            this.MissingVariable.Size = new System.Drawing.Size(270, 60);
            this.MissingVariable.TabIndex = 1;
            this.MissingVariable.Text = "Missing Variable";
            this.MissingVariable.UseVisualStyleBackColor = true;
            this.MissingVariable.Click += new System.EventHandler(this.button2_Click);
            this.MissingVariable.MouseEnter += new System.EventHandler(this.VariableMouseEnter);
            this.MissingVariable.MouseLeave += new System.EventHandler(this.VariableMouseLeave);
            // 
            // MissingResult
            // 
            this.MissingResult.FlatAppearance.BorderSize = 0;
            this.MissingResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MissingResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.MissingResult.Location = new System.Drawing.Point(354, 308);
            this.MissingResult.Name = "MissingResult";
            this.MissingResult.Size = new System.Drawing.Size(270, 60);
            this.MissingResult.TabIndex = 1;
            this.MissingResult.Text = "Missing Result";
            this.MissingResult.UseVisualStyleBackColor = true;
            this.MissingResult.Click += new System.EventHandler(this.button3_Click);
            this.MissingResult.MouseEnter += new System.EventHandler(this.ResultMouseEnter);
            this.MissingResult.MouseLeave += new System.EventHandler(this.ResultMouseLeave);
            // 
            // GameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.MissingResult);
            this.Controls.Add(this.MissingVariable);
            this.Controls.Add(this.MissingOperator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMode";
            this.Load += new System.EventHandler(this.GameMode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MissingOperator;
        private System.Windows.Forms.Button MissingVariable;
        private System.Windows.Forms.Button MissingResult;
    }
}