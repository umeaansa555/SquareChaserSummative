
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
            this.components = new System.ComponentModel.Container();
            this.P1Score = new System.Windows.Forms.Label();
            this.P2Score = new System.Windows.Forms.Label();
            this.engine = new System.Windows.Forms.Timer(this.components);
            this.winLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // P1Score
            // 
            this.P1Score.AutoSize = true;
            this.P1Score.BackColor = System.Drawing.Color.Transparent;
            this.P1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Score.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.P1Score.Location = new System.Drawing.Point(82, 9);
            this.P1Score.Name = "P1Score";
            this.P1Score.Size = new System.Drawing.Size(94, 25);
            this.P1Score.TabIndex = 0;
            this.P1Score.Text = "P1Score";
            // 
            // P2Score
            // 
            this.P2Score.AutoSize = true;
            this.P2Score.BackColor = System.Drawing.Color.Transparent;
            this.P2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Score.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.P2Score.Location = new System.Drawing.Point(182, 9);
            this.P2Score.Name = "P2Score";
            this.P2Score.Size = new System.Drawing.Size(94, 25);
            this.P2Score.TabIndex = 1;
            this.P2Score.Text = "P2Score";
            // 
            // engine
            // 
            this.engine.Enabled = true;
            this.engine.Interval = 20;
            this.engine.Tick += new System.EventHandler(this.engine_Tick);
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.winLabel.Location = new System.Drawing.Point(142, 171);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(97, 25);
            this.winLabel.TabIndex = 2;
            this.winLabel.Text = "winLabel";
            this.winLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.P2Score);
            this.Controls.Add(this.P1Score);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label P1Score;
        private System.Windows.Forms.Label P2Score;
        private System.Windows.Forms.Timer engine;
        private System.Windows.Forms.Label winLabel;
    }
}

