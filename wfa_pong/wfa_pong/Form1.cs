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
        int leftPlayerScore = 0;

        // Right Player Score
        int rightPlayerScore = 0;

        // Paddle Speed
        int rightPaddleDirection = 5;

        // Ball Speed
        int ballXSpeed = 10;
        int ballYSpeed = 10;
        
        // Size Variables
        int windowBottom;
        int windowCenter;
        int horizontalMiddle;
        int verticalMiddle;

        // Left Player Movement
        bool leftPlayerDetectedUp;
        bool leftPlayerDetectedDown;

        // Right Player Movement
        bool autoPlay;
        bool rightPlayerDetectedUp;
        bool rightPlayerDetectedDown;

        // Restart pause problem
        int spaceBarCurrentState = 0;



        public Tong()
        {
            // Initialize the game
            InitializeComponent();

            // get some necessary sizes and positions
            windowBottom = ClientSize.Height - leftPlayer.Height;
            horizontalMiddle = ClientSize.Width / 2;
            verticalMiddle = ClientSize.Height / 2;

            // Get rid of the white pixels around the ball when it moves
            this.DoubleBuffered = true;

            // set the auto play to true by default
            autoPlay = true;

            // Disable TabStop for the restartBtn and optionsBtn
            restartBtn.TabStop = false;
            optionsBtn.TabStop = false;
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
            theBall.Top -= ballYSpeed;
            theBall.Left -= ballXSpeed;
            // Make the right paddle move automatically if autoPlay is true
            if (autoPlay == true) {         
                rightPlayer.Top += rightPaddleDirection;
                // Check if CPU has reached the top or the bottom
                if (rightPlayer.Top < 0 || rightPlayer.Top > windowBottom) {
                        rightPaddleDirection = -rightPaddleDirection; 
                    }
            } else // Make the right paddle move with users entry if autoPlay is false
            {
                if (rightPlayerDetectedUp == true && rightPlayer.Top > 0) { rightPlayer.Top -= 10; }
                if (rightPlayerDetectedDown == true && rightPlayer.Top < windowBottom) { rightPlayer.Top += 10; }
            }
            // Check if the ball hit the left wall
            if (theBall.Left < 0)
            {
                // Reset the ball to the middle of the screen
                theBall.Left = horizontalMiddle;
                // Randomize the ball's vertical position
                theBall.Top = newSpot;
                // Send the ball in the opposite direction
                ballXSpeed = -ballXSpeed;
                rightPlayerScore++;
                scoreRight.Text = rightPlayerScore.ToString();
                if (rightPlayerScore >= 3 && rightPlayerScore <= 7 && rightPlayerScore >= leftPlayerScore )
                {
                    // Increase the ball speed
                    if (ballXSpeed < 0) { ballXSpeed = -15; } else { ballXSpeed = 15; }
                } else if (rightPlayerScore >= 8)
                {
                    // Increase the ball speed again
                    if (ballXSpeed < 0) { ballXSpeed = -20; } else { ballXSpeed = 20; }
                }
            }

            // Check if the ball hit the right wall
            if (theBall.Left + theBall.Width > ClientSize.Width)
            {
                // see above
                theBall.Left = horizontalMiddle;
                theBall.Top = newSpot;
                ballXSpeed = -ballXSpeed;
                leftPlayerScore++;
                scoreLeft.Text = leftPlayerScore.ToString();
                if (leftPlayerScore >= 3 && leftPlayerScore <= 7 && leftPlayerScore >=rightPlayerScore )
                {
                    // see above
                    if (ballXSpeed < 0) { ballXSpeed = -15; } else { ballXSpeed = 15; }
                } else if (leftPlayerScore >= 8)
                {
                    // see above
                    if (ballXSpeed < 0) { ballXSpeed = -20; } else { ballXSpeed = 20; }
                }
            }

            // check if the ball hit the top or bottom wall and send it in the opposite direction
            if (theBall.Top < 0 || theBall.Top + theBall.Height > ClientSize.Height) { ballYSpeed = -ballYSpeed; }

            // Check if the ball hits the left or right paddle
            if (theBall.Bounds.IntersectsWith(leftPlayer.Bounds) || theBall.Bounds.IntersectsWith(rightPlayer.Bounds))
            {
                // Send ball opposite direction
                ballXSpeed = -ballXSpeed;
            }

            // Move left player up
            if (leftPlayerDetectedUp == true && leftPlayer.Top > 0) { leftPlayer.Top -= 10; }
            // Move left player down
            if (leftPlayerDetectedDown == true && leftPlayer.Top < windowBottom) { leftPlayer.Top += 10; }
            // Check for left player win (win = 2 points)
            if (leftPlayerScore >= 10) { 
                // Stop the game, show the end game panel and display the winner
                theTimer.Stop();
                endGamePanel.Visible = true;
                endGameText.Text = "Left player \r\nwin !!!";
            }
            // Check for right player / CPU win (win = 2 points)
            if (rightPlayerScore >= 10) {
                // Stop the game, show the end game panel and display the winner
                theTimer.Stop();
                endGamePanel.Visible = true;
                endGameText.Text = "Right player \r\nwin !!!";
            }
        }


        private void Tong_KeyUp(object sender, KeyEventArgs e)
                {
                    // If left player releases the up or down arrow, stop moving the paddle
                    if (e.KeyCode == Keys.Z) { leftPlayerDetectedUp = false; }
                    if (e.KeyCode == Keys.S) { leftPlayerDetectedDown = false; }

                    // If right player the up or down arrow, stop moving the paddle
                    if (e.KeyCode == Keys.Up) { rightPlayerDetectedUp = false; }
                    if (e.KeyCode == Keys.Down) { rightPlayerDetectedDown = false; }
                }



        private void Tong_KeyDown(object sender, KeyEventArgs e)
        {
            // If left player presses the up arrow, move left paddle up
            if (e.KeyCode == Keys.Z) { leftPlayerDetectedUp = true; }
            // If player presses the down arrow, move left paddle down
            if (e.KeyCode == Keys.S) { leftPlayerDetectedDown = true; }

            // If Player presses the M key, toggle auto play
            if (e.KeyCode == Keys.M)
            { 
                autoPlay = true;
            }

            // If Player presses the up or down arrow, toggle manual play
            if (e.KeyCode == Keys.Up)
            {
                rightPlayerDetectedUp = true;
                autoPlay = false;
            }   
            if (e.KeyCode == Keys.Down)
            {
                rightPlayerDetectedDown = true;
                autoPlay = false;
            }




            // If player presses space bar, pause the game
            if (e.KeyCode == Keys.Space)
            {
                // If space bar is pressed an even number of times, pause the game
                if (spaceBarCurrentState % 2 == 0)
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
            spaceBarCurrentState++;


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
            spaceBarCurrentState = 0;
            leftPlayerScore = 0;
            rightPlayerScore = 0;
            scoreLeft.Text = "0";
            scoreRight.Text = "0";
            pauseMenuCtn.Visible = false; 
            endGamePanel.Visible = false;
            theBall.Left = horizontalMiddle;
            theBall.Top = verticalMiddle;
            ballXSpeed = 10;
            ballYSpeed = 10;
            leftPlayer.Top = verticalMiddle;
            rightPlayer.Top = verticalMiddle;
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

        private void optionsBtn_Click(object sender, EventArgs e)
        {
            optionsBtn.TabStop = false;
            optionProblem.Visible = true;
            new Options().Show();
        }

        private void optionProblem_Click(object sender, EventArgs e)
        {
            spaceBarCurrentState = 0;
            pauseInfo.Text = "Click SPACE to pause";
            optionProblem.Visible = false;
            pauseMenuCtn.Visible = false;
            theTimer.Start();
            Focus();
        }
    }
}
