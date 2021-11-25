
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.P1Score = new System.Windows.Forms.Label();
            this.P2Score = new System.Windows.Forms.Label();
            this.engine = new System.Windows.Forms.Timer(this.components);
            this.winLabel = new System.Windows.Forms.Label();
            this.replayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // P1Score
            // 
            this.P1Score.BackColor = System.Drawing.Color.Transparent;
            this.P1Score.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Score.ForeColor = System.Drawing.Color.Red;
            this.P1Score.Location = new System.Drawing.Point(165, 9);
            this.P1Score.Name = "P1Score";
            this.P1Score.Size = new System.Drawing.Size(25, 25);
            this.P1Score.TabIndex = 0;
            this.P1Score.Text = "0";
            this.P1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P2Score
            // 
            this.P2Score.BackColor = System.Drawing.Color.Transparent;
            this.P2Score.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Score.ForeColor = System.Drawing.Color.DodgerBlue;
            this.P2Score.Location = new System.Drawing.Point(200, 9);
            this.P2Score.Name = "P2Score";
            this.P2Score.Size = new System.Drawing.Size(25, 25);
            this.P2Score.TabIndex = 1;
            this.P2Score.Text = "0";
            this.P2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // engine
            // 
            this.engine.Enabled = true;
            this.engine.Interval = 20;
            this.engine.Tick += new System.EventHandler(this.engine_Tick);
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.DimGray;
            this.winLabel.Location = new System.Drawing.Point(93, 185);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(198, 25);
            this.winLabel.TabIndex = 2;
            this.winLabel.Text = "winLabel";
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winLabel.Visible = false;
            // 
            // replayButton
            // 
            this.replayButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.replayButton.Location = new System.Drawing.Point(0, 370);
            this.replayButton.MaximumSize = new System.Drawing.Size(70, 40);
            this.replayButton.Name = "replayButton";
            this.replayButton.Size = new System.Drawing.Size(70, 30);
            this.replayButton.TabIndex = 3;
            this.replayButton.Text = "Play Again";
            this.replayButton.UseVisualStyleBackColor = true;
            this.replayButton.Visible = false;
            this.replayButton.Click += new System.EventHandler(this.replayButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exitButton.Location = new System.Drawing.Point(0, 340);
            this.exitButton.MaximumSize = new System.Drawing.Size(70, 40);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(70, 30);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit Game";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Visible = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.replayButton);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.P2Score);
            this.Controls.Add(this.P1Score);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Square Chaser";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label P1Score;
        private System.Windows.Forms.Label P2Score;
        private System.Windows.Forms.Timer engine;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Button replayButton;
        private System.Windows.Forms.Button exitButton;
    }
}

