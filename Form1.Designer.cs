
namespace SquareChaser
{
    partial class Form1
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
            this.P1Score = new System.Windows.Forms.Label();
            this.P2Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // P1Score
            // 
            this.P1Score.AutoSize = true;
            this.P1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Score.Location = new System.Drawing.Point(82, 9);
            this.P1Score.Name = "P1Score";
            this.P1Score.Size = new System.Drawing.Size(94, 25);
            this.P1Score.TabIndex = 0;
            this.P1Score.Text = "P1Score";
            // 
            // P2Score
            // 
            this.P2Score.AutoSize = true;
            this.P2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Score.Location = new System.Drawing.Point(182, 9);
            this.P2Score.Name = "P2Score";
            this.P2Score.Size = new System.Drawing.Size(94, 25);
            this.P2Score.TabIndex = 1;
            this.P2Score.Text = "P2Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.P2Score);
            this.Controls.Add(this.P1Score);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label P1Score;
        private System.Windows.Forms.Label P2Score;
    }
}

