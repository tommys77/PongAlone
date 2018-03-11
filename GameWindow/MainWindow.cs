using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameWindow
{
    public partial class MainWindow : Form
    {
        #region fields

        private bool isPaused;

        private int xSpeed = 10;
        private int ySpeed = -10;
        public int xPos = 0;
        public int yPos = 0;
        public int livesLeft = 3;
        public int score = 0;

        #endregion


        public MainWindow()
        {
            InitializeComponent();
            this.KeyPreview = true;
            InitializeGame();
            isPaused = true;
            GamePaused();
        }

        private void InitializeGame()
        {
            xPos = batter.Location.X;
            yPos = batter.Location.Y;
            tb_Lives.Text = livesLeft.ToString();
            tb_Score.Text = score.ToString();
        }

        public void MoveBat(object sender, MouseEventArgs e)
        {
            xPos = e.X;

            if (!isPaused && xPos < (playfield.Width - batter.Width))
                batter.Location = new Point(xPos, yPos);
        }

        private void WhenTheMouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void WhenTheMouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void MainWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            var key = e.KeyChar;

            const char p = 'p';

            switch (key)
            {
                case p:
                    isPaused = !isPaused;
                    GamePaused();
                    break;
            }
        }

        private void Restart()
        {
            xSpeed = 10;
            ySpeed = 10;
        }

        private void GamePaused()
        {
            if (isPaused == true)
            {
                Cursor.Show();
                tb_Status.Text = "Paused";
            }
            else
            {
                Cursor.Hide();
                tb_Status.Clear();
            }
        }


        // If the ball moves past the batter, you lose one life.
        private bool LifeLost(Point location)
        {
            if (location.Y > playfield.Height - batter.Height)
            {
                livesLeft--;
                UpdateGameStatus();
                return true;
            }
            else return false;
        }

        private void BallTimer_Tick(object sender, EventArgs e)
        {
            var location = ball.Location;
            var lost = LifeLost(ball.Location);

            if (!isPaused)
            {
                if (lost)
                {
                    if (livesLeft == 0)
                    {
                        isPaused = true;
                        GamePaused();
                        tb_Status.Text = "Game Over!";
                        livesLeft = 3;
                    }
                    var rnd = new Random().Next(ball.Width * 2, playfield.Width - 2 * ball.Width);
                    ball.Location = new Point(rnd, 25);
                }

                else if (!CollidedWithBat(location))
                {
                    if ((location.X >= playfield.Width - ball.Width || location.X <= ball.Width))
                    {
                        xSpeed = -xSpeed;
                    }
                    if (location.Y <= ball.Height)
                    {
                        ySpeed = -ySpeed;
                    }
                }

                else ySpeed = -ySpeed;
                ball.Location = new Point(ball.Location.X + xSpeed, ball.Location.Y + ySpeed);
            }
        }

        // Updates the game's score and life count.
        private void UpdateGameStatus()
        {
            tb_Lives.Text = livesLeft.ToString();
            tb_Score.Text = score.ToString();
        }

        // Checks if the ball collides with the batter.
        private bool CollidedWithBat(Point location)
        {
            if (((location.X > batter.Location.X && location.X < batter.Location.X + batter.Width)
                 || (location.X + ball.Width > batter.Location.X
                 && location.X + ball.Width < batter.Location.X + batter.Width))
                 && ball.Bottom + ball.Height/3 > batter.Top)
            {
                score++;
                UpdateGameStatus();
                return true;
            }
            return false;
        }

        private void Btn_Play_Click(object sender, EventArgs e)
        {
            isPaused = false;
            GamePaused();
            ball.Location = new Point(new Random().Next(ball.Width * 2, playfield.Width - 2 * ball.Width), 2 * ball.Height);
            livesLeft = 3;
            score = 0;
            UpdateGameStatus();
            playfield.Focus();
        }
    }
}
