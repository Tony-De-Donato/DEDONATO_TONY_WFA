using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_pong
{
    public partial class Tong : Form
    {
        // Location Variables
        int cpuDirection = 5;
        int ballXCoordinate = 10;
        int ballYCoordinate = 10;
        // Score Variables
        int playerScore = 0;
        int cpuScore = 0;
        // Size Variables
        int bottomBoundary;
        int centerPoint;
        int xMidpoint;
        int yMidpoint;
        // Detection Variables
        bool playerDetectedUp;
        bool playerDetectedDown;
        bool autoPlay;
        bool cpuUp;
        bool cpuDown;
        // Special Keys
        int spaceBarClicked = 0;


        

        public Tong()
        {
            InitializeComponent();
            bottomBoundary = ClientSize.Height - leftPlayer.Height;
            xMidpoint = ClientSize.Width / 2;
            yMidpoint = ClientSize.Height / 2;
            this.DoubleBuffered = true;
            autoPlay = true;
        }
         private void Tong_Load(object sender, EventArgs e)
        {

        }
        
        private void theTimer_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);
            // Adjust where the ball is
            theBall.Top -= ballYCoordinate;
            theBall.Left -= ballXCoordinate;
            // Make the CPU move
            if (autoPlay == true) {    
                rightPlayer.Top += cpuDirection;
                // Check if CPU has reached the top or the bottom
                if (rightPlayer.Top < 0 || rightPlayer.Top > bottomBoundary) {
                        cpuDirection = -cpuDirection; 
                    }
            } else
            {
                if (cpuUp == true && rightPlayer.Top > 0) { rightPlayer.Top -= 10; }
                if (cpuDown == true && rightPlayer.Top < bottomBoundary) { rightPlayer.Top += 10; }
            }
            // Check if the ball has exited the left side of the screen
            if (theBall.Left < 0)
            {
                theBall.Left = xMidpoint;
                theBall.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;
                cpuScore++;
                scoreRight.Text = cpuScore.ToString();
            }

            // Check if the ball has exited the right side of the screen
            if (theBall.Left + theBall.Width > ClientSize.Width)
            {
                theBall.Left = xMidpoint;
                theBall.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;
                playerScore++;
                scoreLeft.Text = playerScore.ToString();
            }

            // Ensure the ball is within the boundaries of the screen
            if (theBall.Top < 0 || theBall.Top + theBall.Height > ClientSize.Height) { ballYCoordinate = -ballYCoordinate; }

            // Check if the ball hits the player or CPU paddle
            if (theBall.Bounds.IntersectsWith(leftPlayer.Bounds) || theBall.Bounds.IntersectsWith(rightPlayer.Bounds))
            {
                // Send ball opposite direction
                ballXCoordinate = -ballXCoordinate;
            }

            // Move player up
            if (playerDetectedUp == true && leftPlayer.Top > 0) { leftPlayer.Top -= 10; }
            // Move player down
            if (playerDetectedDown == true && leftPlayer.Top < bottomBoundary) { leftPlayer.Top += 10; }
            // Check for left player win
            if (playerScore >= 10) { theTimer.Stop(); }
            // Check for right player / CPU win
            if (cpuScore >= 10) { theTimer.Stop(); }
        }

        private void Tong_KeyUp(object sender, KeyEventArgs e)
                {
                    if (e.KeyCode == Keys.Z) { playerDetectedUp = false; }
                    if (e.KeyCode == Keys.S) { playerDetectedDown = false; }

                    if (e.KeyCode == Keys.Up) { cpuUp = false; }
                    if (e.KeyCode == Keys.Down) { cpuDown = false; }
                }


        private void Tong_KeyDown(object sender, KeyEventArgs e)
        {
            // If player presses the up arrow, move paddle upwards
            if (e.KeyCode == Keys.Z) { playerDetectedUp = true; }
            // If player presses the down arrow, move paddle downwards
            if (e.KeyCode == Keys.S) { playerDetectedDown = true; }

            // If Player presses the M key, toggle auto play
            if (e.KeyCode == Keys.M)
            { 
                autoPlay = true;
            }

            // If Player presses the up or down arrow, toggle manual play
            if (e.KeyCode == Keys.Up)
            {
                cpuUp = true;
                autoPlay = false;
            }   
            if (e.KeyCode == Keys.Down)
            {
                cpuDown = true;
                autoPlay = false;
            }




            // If player presses space bar, pause the game
            if (e.KeyCode == Keys.Space)
            {
                if (spaceBarClicked % 2 == 0)
                {
                    theTimer.Stop();
                    pauseInfo.Text = "Click SPACE to continue";
                    pauseMenuCtn.Visible = true;
                }
                else
                {
                    pauseInfo.Text = "Click SPACE to pause";
                    pauseMenuCtn.Visible = false;
                    theTimer.Start();
                }
            }
            spaceBarClicked++;


        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            // Reset the game
            
            spaceBarClicked = 0;
            playerScore = 0;
            cpuScore = 0;
            scoreLeft.Text = "0";
            scoreRight.Text = "0";
            pauseMenuCtn.Visible = false;
            theBall.Left = xMidpoint;
            theBall.Top = yMidpoint;
            ballXCoordinate = 10;
            ballYCoordinate = 10;
            leftPlayer.Top = yMidpoint;
            rightPlayer.Top = yMidpoint;
            theTimer.Start();
            Focus();
            

        }

        
    }
}
