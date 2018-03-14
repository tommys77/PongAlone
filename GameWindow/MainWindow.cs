using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace GameWindow
{
    public partial class MainWindow : Form
    {
        #region fields

        private bool isPaused;

        public int xPos = 0;
        public int yPos = 0;
        public int livesLeft = 3;
        public int score = 8;
        private int highscore = 0;
        private bool cheatmode = false;

        List<PictureBox> balls = new List<PictureBox>();

        private const string BALL_AGAINST_BAT = @"C:\Users\Tommy\source\repos\PongAlone\GameWindow\Resources\ball_against_bat.wav";
        private const string BALL_AGAINST_WALL = @"C:\Users\Tommy\source\repos\PongAlone\GameWindow\Resources\ball_against_wall.wav";
        private const string GAME_OVER = @"C:\Users\Tommy\source\repos\PongAlone\GameWindow\Resources\game_over.wav";
        private const string LOST_LIFE = @"C:\Users\Tommy\source\repos\PongAlone\GameWindow\Resources\lost_life.wav";

        //private SoundPlayer fx_ball_against_wall;
        //private SoundPlayer fx_ball_against_bat;
        //private SoundPlayer fx_game_over;
        //private SoundPlayer fx_lost_life;

        private WindowsMediaPlayer fx_ball_against_wall;
        private WindowsMediaPlayer fx_ball_against_bat;
        private WindowsMediaPlayer fx_game_over;
        private WindowsMediaPlayer fx_lost_life;

        #endregion


        public MainWindow()
        {
            InitializeComponent();
            this.KeyPreview = true;
            InitializeGame();
            isPaused = true;
            PauseGame();
        }

        private void InitializeGame()
        {
            PrepareSounds();
            xPos = batter.Location.X;
            yPos = batter.Location.Y;
            tb_Lives.Text = livesLeft.ToString();
            tb_Score.Text = score.ToString();
            balls.Add(ball);
        }

        private void PrepareSounds()
        {

            //fx_ball_against_bat = new SoundPlayer(Properties.Resources.ball_against_bat);
            //fx_ball_against_wall = new SoundPlayer(Properties.Resources.ball_against_wall);
            //fx_game_over = new SoundPlayer(Properties.Resources.game_over);
            //fx_lost_life = new SoundPlayer(Properties.Resources.lost_life);

            fx_ball_against_bat = new WindowsMediaPlayer();
            fx_ball_against_wall = new WindowsMediaPlayer();
            fx_game_over = new WindowsMediaPlayer();
            fx_lost_life = new WindowsMediaPlayer();
            //fx_ball_against_wall = new SoundPlayer(Properties.Resources.ball_against_wall);
            //fx_game_over = new SoundPlayer(Properties.Resources.game_over);
            //fx_lost_life = new SoundPlayer(Properties.Resources.lost_life);
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

        private void Restart()
        {
            Settings.DefaultSpeedSettings();
            livesLeft = 3;
            score = 0;
        }

        private void PauseGame()
        {
            if (isPaused == true)
            {
                Cursor.Show();
                ballTimer.Enabled = false;
                lbl_Status.Text = "Paused";
            }
            else
            {
                Cursor.Hide();
                ballTimer.Enabled = true;
                lbl_Status.Text = "";
            }
        }

        // If the ball moves past the batter, you lose one life.
        private bool LifeLost(Point location)
        {
            if (location.Y > playfield.Height - batter.Height)
            {
                fx_lost_life.URL = LOST_LIFE;
                livesLeft--;
                UpdateGameStatus();
                return true;
            }
            else return false;
        }

        bool difficultyRaised = false;

        private void BallTimer_Tick(object sender, EventArgs e)
        {
            var location = ball.Location;
            var lost = LifeLost(ball.Location);

            if (!isPaused)
            {
                CheckIfDifficultyNeedsRaised();

                if (score % 10 != 0)
                {
                    difficultyRaised = false;
                }

                statusTimer.Enabled = false;

                if (lost)
                {
                    if (livesLeft == 0)
                    {
                        GameOver();
                    }
                    var rnd = new Random().Next(ball.Width * 2, playfield.Width - 2 * ball.Width);
                    ball.Location = new Point(rnd, 25);
                }

                else if (!CollidedWithBat(location))
                {
                    if (((location.X >= playfield.Width - ball.Width && Settings.XSpeed > 0) || (location.X <= 0 && Settings.XSpeed < 0)))
                    {
                        fx_ball_against_wall.URL = BALL_AGAINST_WALL;
                        Settings.ReverseX();
                    }
                    if (location.Y <= 0 && Settings.YSpeed < 0)
                    {
                        fx_ball_against_wall.URL = BALL_AGAINST_WALL;
                        Settings.ReverseY();
                    }
                }

                else
                {
                    Settings.ReverseY();
                }

                ball.Location = new Point(ball.Location.X + Settings.XSpeed, ball.Location.Y + Settings.YSpeed);

            }
            statusTimer.Enabled = true;
        }

        private void CheckIfDifficultyNeedsRaised()
        {
            if ((livesLeft != 0 && score % 10 == 0 && score != 0 && !difficultyRaised))
            {
                Settings.IncreaseSpeed();
                difficultyRaised = true;
            }
        }

        private void GameOver()
        {
            fx_game_over.URL = GAME_OVER;
            isPaused = true;
            PauseGame();

            if (score > highscore && !cheatmode)
            {
                highscore = score;
                lbl_highscore.Text = score.ToString();
            }
            tb_Status.Text = "Game Over!";
            livesLeft = 3;
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
                 && ball.Bottom + ball.Height / 3 > playfield.Height - batter.Height
                 && Settings.YSpeed > 0)
            {
                fx_ball_against_bat.URL = BALL_AGAINST_BAT;
                score++;
                UpdateGameStatus();
                return true;
            }
            return false;
        }


        private void Btn_Play_Click(object sender, EventArgs e)
        {
            isPaused = false;
            PauseGame();
            tb_Status.Clear();
            ball.Location = new Point(new Random().Next(ball.Width * 2, playfield.Width - 2 * ball.Width), 2 * ball.Height);
            Restart();
            UpdateGameStatus();
            playfield.Focus();

            //if (twoBallsEnabled)
            //{
            //    PictureBox ball2 = ball;
            //    ball2.Location = new Point(new Random().Next(ball2.Width * 2, playfield.Width - 2 * ball2.Width), 2 * ball2.Height);
            //    balls.Add(ball2);
            //}

        }

        private void statusTimer_Tick(object sender, EventArgs e)
        {
            if (isPaused && lbl_Status.Visible)
            {
                lbl_Status.Visible = false;
            }
            else lbl_Status.Visible = true;
        }

        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            var key = e.KeyCode;


            switch (key)
            {
                case Keys.P:
                    isPaused = !isPaused;
                    PauseGame();
                    break;
                case Keys.Add:
                    if (cheatmode)
                        Settings.IncreaseSpeed();
                    break;
                case Keys.Subtract:
                    if (cheatmode)
                        Settings.DecreaseSpeed();
                    break;
            }
        }

        private void cb_cheatmode_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_cheatmode.Checked)
            {
                cheatmode = true;
            }
            else cheatmode = false;
        }


        //private void btn_two_balls_Click(object sender, EventArgs e)
        //{
        //    twoBallsEnabled = !twoBallsEnabled;

        //    if (twoBallsEnabled)
        //    {
        //        btn_two_balls.Text = "Off";
        //    }
        //    else btn_two_balls.Text = "On";
        //}
    }
}

