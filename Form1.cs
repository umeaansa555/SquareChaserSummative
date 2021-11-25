using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

// Square Chaser: 2 player game
// A. Ansari midterm summative Nov 2021


namespace SquareChaser
{
    public partial class Form1 : Form
    {

        Rectangle player1 = new Rectangle(190, 190, 20, 20);
        Rectangle player2 = new Rectangle(210, 210, 20, 20);
        Rectangle speedBoost = new Rectangle(0, 17, 10, 10);
        Rectangle goal = new Rectangle(0, 49, 10, 10);

        Random positionGen = new Random();
        
        
        int player1Score = 0;
        int player2Score = 0;

        int player1Speed = 4;
        int player2Speed = 4;

        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrowDown = false;
        bool rightArrowDown = false;

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);

        SoundPlayer boost = new SoundPlayer(Properties.Resources._445109__breviceps__mud_splat);

        public Form1()
        {
            InitializeComponent();
            goal.X = positionGen.Next(0, 381);
            goal.Y = positionGen.Next(0, 381);

            speedBoost.X = positionGen.Next(0, 381);
            speedBoost.Y = positionGen.Next(0, 381);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;

                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;

                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(redBrush, player1);
            e.Graphics.FillRectangle(blueBrush, player2);
            e.Graphics.FillRectangle(whiteBrush, goal);
            e.Graphics.FillRectangle(yellowBrush, speedBoost);

        }

        private void engine_Tick(object sender, EventArgs e)
        {
            //move player 1 
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= player1Speed;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += player1Speed;
            }


            if (aDown == true && player1.X > 0)
            {
                player1.X -= player1Speed;
            }

            if (dDown == true && player1.X < this.Width - player1.Width)
            {
                player1.X += player1Speed;
            }


            //move player 2 
            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= player2Speed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += player2Speed;
            }


            if (leftArrowDown == true && player2.X > 0)
            {
                player2.X -= player2Speed;
            }
            if (rightArrowDown == true && player2.X < this.Width - player2.Width)
            {
                player2.X += player2Speed;
            }


            ////update position of objects + adding points
            
            P1Score.Text = $"{player1Score}";
            P2Score.Text = $"{player2Score}";

            if (player1.IntersectsWith(goal))
            {
                player1Score++;
                goal.X = positionGen.Next(0, 381);
                goal.Y = positionGen.Next(0, 381);
            }
            if (player2.IntersectsWith(goal))
            {
                player2Score++;
                goal.X = positionGen.Next(0, 381);
                goal.Y = positionGen.Next(0, 381);
            }


            if (player1.IntersectsWith(speedBoost))
            {
                player1Speed += 4;
                
                speedBoost.X = positionGen.Next(0, 381);
                speedBoost.Y = positionGen.Next(0, 381);
                boost.Play();
            }
            if (player2.IntersectsWith(speedBoost))
            {
                player2Speed += 4;

                speedBoost.X = positionGen.Next(0, 381);
                speedBoost.Y = positionGen.Next(0, 381);
                boost.Play();
            }

            // check score and stop game if either player is at 5
            if (player1Score == 5)
            {
                engine.Enabled = false;
                winLabel.Visible = true;
                P1Score.Text = $"{player1Score}";
                P2Score.Text = $"{player2Score}";
                winLabel.Text = "Player 1 Wins!!";
            }
            else if (player2Score == 5)
            {
                engine.Enabled = false;
                winLabel.Visible = true;
                P1Score.Text = $"{player1Score}";
                P2Score.Text = $"{player2Score}";
                winLabel.Text = "Player 2 Wins!!";
            }

            Refresh();
        }
    }
}
