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
        
        // Left Player Score
        int playerScore = 0;

        // Right Player Score
        int cpuScore = 0;

        // Paddle Speed
        int cpuDirection = 5;

        // Ball Speed
        int ballXCoordinate = 10;
        int ballYCoordinate = 10;
        
        // Size Variables
        int bottomBoundary;
        int centerPoint;
        int xMidpoint;
        int yMidpoint;

        // Left Player Movement
        bool playerDetectedUp;
        bool playerDetectedDown;

        // Right Player Movement
        bool autoPlay;
        bool cpuUp;
        bool cpuDown;

        // Restart pause problem
        int spaceBarClicked = 0;



        public Tong()
        {
            // Initialize the game
            InitializeComponent();

            // get some necessary sizes and positions
            bottomBoundary = ClientSize.Height - leftPlayer.Height;
            xMidpoint = ClientSize.Width / 2;
            yMidpoint = ClientSize.Height / 2;

            // Get rid of the white pixels around the ball when it moves
            this.DoubleBuffered = true;

            // set the auto play to true by default
            autoPlay = true;
        }
         private void Tong_Load(object sender, EventArgs e)
        {
            // ???


        }
        
        private void theTimer_Tick(object sender, EventArgs e)
        {
            // use the timer to loop the game

            // Create a random number generator
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);
            // Move the ball
            theBall.Top -= ballYCoordinate;
            theBall.Left -= ballXCoordinate;
            // Make the right paddle move automatically if autoPlay is true
            if (autoPlay == true) {         
                rightPlayer.Top += cpuDirection;
                // Check if CPU has reached the top or the bottom
                if (rightPlayer.Top < 0 || rightPlayer.Top > bottomBoundary) {
                        cpuDirection = -cpuDirection; 
                    }
            } else // Make the right paddle move with users entry if autoPlay is false
            {
                if (cpuUp == true && rightPlayer.Top > 0) { rightPlayer.Top -= 10; }
                if (cpuDown == true && rightPlayer.Top < bottomBoundary) { rightPlayer.Top += 10; }
            }
            // Check if the ball hit the left wall
            if (theBall.Left < 0)
            {
                // Reset the ball to the middle of the screen
                theBall.Left = xMidpoint;
                // Randomize the ball's vertical position
                theBall.Top = newSpot;
                // Send the ball in the opposite direction
                ballXCoordinate = -ballXCoordinate;
                cpuScore++;
                scoreRight.Text = cpuScore.ToString();
            }

            // Check if the ball hit the right wall
            if (theBall.Left + theBall.Width > ClientSize.Width)
            {
                // see above
                theBall.Left = xMidpoint;
                theBall.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;
                playerScore++;
                scoreLeft.Text = playerScore.ToString();
            }

            // check if the ball hit the top or bottom wall and send it in the opposite direction
            if (theBall.Top < 0 || theBall.Top + theBall.Height > ClientSize.Height) { ballYCoordinate = -ballYCoordinate; }

            // Check if the ball hits the left or right paddle
            if (theBall.Bounds.IntersectsWith(leftPlayer.Bounds) || theBall.Bounds.IntersectsWith(rightPlayer.Bounds))
            {
                // Send ball opposite direction
                ballXCoordinate = -ballXCoordinate;
            }

            // Move left player up
            if (playerDetectedUp == true && leftPlayer.Top > 0) { leftPlayer.Top -= 10; }
            // Move left player down
            if (playerDetectedDown == true && leftPlayer.Top < bottomBoundary) { leftPlayer.Top += 10; }
            // Check for left player win (win = 2 points)
            if (playerScore >= 2) { 
                // Stop the game, show the end game panel and display the winner
                theTimer.Stop();
                endGamePanel.Visible = true;
                endGameText.Text = "Left player \r\nwin !!!";
            }
            // Check for right player / CPU win (win = 2 points)
            if (cpuScore >= 2) {
                // Stop the game, show the end game panel and display the winner
                theTimer.Stop();
                endGamePanel.Visible = true;
                endGameText.Text = "Right player \r\nwin !!!";
            }
        }

        private void Tong_KeyUp(object sender, KeyEventArgs e)
                {
                    // If left player releases the up or down arrow, stop moving the paddle
                    if (e.KeyCode == Keys.Z) { playerDetectedUp = false; }
                    if (e.KeyCode == Keys.S) { playerDetectedDown = false; }

                    // If right player the up or down arrow, stop moving the paddle
                    if (e.KeyCode == Keys.Up) { cpuUp = false; }
                    if (e.KeyCode == Keys.Down) { cpuDown = false; }
                }


        private void Tong_KeyDown(object sender, KeyEventArgs e)
        {
            // If left player presses the up arrow, move left paddle up
            if (e.KeyCode == Keys.Z) { playerDetectedUp = true; }
            // If player presses the down arrow, move left paddle down
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
                // If space bar is pressed an even number of times, pause the game
                if (spaceBarClicked % 2 == 0)
                {
                    theTimer.Stop();
                    pauseInfo.Text = "Click SPACE to continue";
                    pauseMenuCtn.Visible = true;
                }
                else // If space bar is pressed an odd number of times, continue the game
                {
                    pauseInfo.Text = "Click SPACE to pause";
                    pauseMenuCtn.Visible = false;
                    theTimer.Start();
                }
            }
            // Increment the space bar clicked counter by 1 (solved problem when retsart)
            spaceBarClicked++;


        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            // obvious
            restartGame();
        }

        private void restartBtn2_Click(object sender, EventArgs e)
        {
            // obvious
            restartGame();
        }

        void restartGame()
        {
            // Reset the game
            spaceBarClicked = 0;
            playerScore = 0;
            cpuScore = 0;
            scoreLeft.Text = "0";
            scoreRight.Text = "0";
            pauseMenuCtn.Visible = false; 
            endGamePanel.Visible = false;
            theBall.Left = xMidpoint;
            theBall.Top = yMidpoint;
            ballXCoordinate = 10;
            ballYCoordinate = 10;
            leftPlayer.Top = yMidpoint;
            rightPlayer.Top = yMidpoint;
            theTimer.Start();
            // Set the focus on the form, because its still on the restart button so space bar (pause) doesn't work
            Focus();
        }

        private void leaveBtn_Click(object sender, EventArgs e)
        {
            // obvious
            Application.Exit();
        }

        private void leaveBtn2_Click(object sender, EventArgs e)
        {
            // obvious
            Application.Exit();
        }
    }
}
