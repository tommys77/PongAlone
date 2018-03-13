namespace GameWindow
{
    partial class MainWindow
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
            this.tb_Status = new System.Windows.Forms.TextBox();
            this.ballTimer = new System.Windows.Forms.Timer(this.components);
            this.tb_Score = new System.Windows.Forms.TextBox();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.tb_Lives = new System.Windows.Forms.TextBox();
            this.lbl_Lives = new System.Windows.Forms.Label();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.playfield = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.PictureBox();
            this.batter = new System.Windows.Forms.PictureBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_header_highscore = new System.Windows.Forms.Label();
            this.lbl_highscore = new System.Windows.Forms.Label();
            this.cb_cheatmode = new System.Windows.Forms.CheckBox();
            this.playfield.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batter)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Status
            // 
            this.tb_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Status.Enabled = false;
            this.tb_Status.ForeColor = System.Drawing.Color.Red;
            this.tb_Status.Location = new System.Drawing.Point(569, 353);
            this.tb_Status.Name = "tb_Status";
            this.tb_Status.Size = new System.Drawing.Size(192, 13);
            this.tb_Status.TabIndex = 6;
            this.tb_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ballTimer
            // 
            this.ballTimer.Enabled = true;
            this.ballTimer.Interval = 50;
            this.ballTimer.Tick += new System.EventHandler(this.BallTimer_Tick);
            // 
            // tb_Score
            // 
            this.tb_Score.Enabled = false;
            this.tb_Score.Location = new System.Drawing.Point(606, 22);
            this.tb_Score.Name = "tb_Score";
            this.tb_Score.Size = new System.Drawing.Size(100, 20);
            this.tb_Score.TabIndex = 7;
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Location = new System.Drawing.Point(566, 25);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(35, 13);
            this.lbl_Score.TabIndex = 8;
            this.lbl_Score.Text = "Score";
            // 
            // tb_Lives
            // 
            this.tb_Lives.Enabled = false;
            this.tb_Lives.Location = new System.Drawing.Point(606, 48);
            this.tb_Lives.Name = "tb_Lives";
            this.tb_Lives.Size = new System.Drawing.Size(35, 20);
            this.tb_Lives.TabIndex = 9;
            // 
            // lbl_Lives
            // 
            this.lbl_Lives.AutoSize = true;
            this.lbl_Lives.Location = new System.Drawing.Point(566, 51);
            this.lbl_Lives.Name = "lbl_Lives";
            this.lbl_Lives.Size = new System.Drawing.Size(32, 13);
            this.lbl_Lives.TabIndex = 10;
            this.lbl_Lives.Text = "Lives";
            // 
            // btn_Restart
            // 
            this.btn_Restart.Location = new System.Drawing.Point(569, 383);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(192, 42);
            this.btn_Restart.TabIndex = 11;
            this.btn_Restart.Text = "Play";
            this.btn_Restart.UseVisualStyleBackColor = false;
            this.btn_Restart.Click += new System.EventHandler(this.Btn_Play_Click);
            // 
            // playfield
            // 
            this.playfield.BackColor = System.Drawing.Color.MintCream;
            this.playfield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playfield.Controls.Add(this.ball);
            this.playfield.Controls.Add(this.batter);
            this.playfield.Location = new System.Drawing.Point(29, 22);
            this.playfield.Name = "playfield";
            this.playfield.Size = new System.Drawing.Size(527, 403);
            this.playfield.TabIndex = 1;
            this.playfield.MouseEnter += new System.EventHandler(this.WhenTheMouseEnter);
            this.playfield.MouseLeave += new System.EventHandler(this.WhenTheMouseLeave);
            this.playfield.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveBat);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Transparent;
            this.ball.BackgroundImage = global::GameWindow.Properties.Resources.tennis_PNG10416;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ball.InitialImage = null;
            this.ball.Location = new System.Drawing.Point(178, 130);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(25, 25);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // batter
            // 
            this.batter.BackColor = System.Drawing.Color.Black;
            this.batter.Enabled = false;
            this.batter.Location = new System.Drawing.Point(214, 378);
            this.batter.Name = "batter";
            this.batter.Size = new System.Drawing.Size(118, 24);
            this.batter.TabIndex = 0;
            this.batter.TabStop = false;
            this.batter.MouseEnter += new System.EventHandler(this.WhenTheMouseEnter);
            this.batter.MouseLeave += new System.EventHandler(this.WhenTheMouseLeave);
            // 
            // lbl_Status
            // 
            this.lbl_Status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Status.ForeColor = System.Drawing.Color.Red;
            this.lbl_Status.Location = new System.Drawing.Point(569, 323);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(192, 16);
            this.lbl_Status.TabIndex = 12;
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusTimer
            // 
            this.statusTimer.Enabled = true;
            this.statusTimer.Interval = 1000;
            this.statusTimer.Tick += new System.EventHandler(this.statusTimer_Tick);
            // 
            // lbl_header_highscore
            // 
            this.lbl_header_highscore.Location = new System.Drawing.Point(569, 100);
            this.lbl_header_highscore.Name = "lbl_header_highscore";
            this.lbl_header_highscore.Size = new System.Drawing.Size(72, 23);
            this.lbl_header_highscore.TabIndex = 13;
            this.lbl_header_highscore.Text = "Today\'s Best:";
            // 
            // lbl_highscore
            // 
            this.lbl_highscore.AutoSize = true;
            this.lbl_highscore.Location = new System.Drawing.Point(648, 100);
            this.lbl_highscore.Name = "lbl_highscore";
            this.lbl_highscore.Size = new System.Drawing.Size(13, 13);
            this.lbl_highscore.TabIndex = 14;
            this.lbl_highscore.Text = "0";
            // 
            // cb_cheatmode
            // 
            this.cb_cheatmode.AutoSize = true;
            this.cb_cheatmode.Location = new System.Drawing.Point(29, 432);
            this.cb_cheatmode.Name = "cb_cheatmode";
            this.cb_cheatmode.Size = new System.Drawing.Size(83, 17);
            this.cb_cheatmode.TabIndex = 15;
            this.cb_cheatmode.Text = "Cheat mode";
            this.cb_cheatmode.UseVisualStyleBackColor = true;
            this.cb_cheatmode.CheckedChanged += new System.EventHandler(this.cb_cheatmode_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.cb_cheatmode);
            this.Controls.Add(this.lbl_highscore);
            this.Controls.Add(this.lbl_header_highscore);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.lbl_Lives);
            this.Controls.Add(this.tb_Lives);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.tb_Score);
            this.Controls.Add(this.tb_Status);
            this.Controls.Add(this.playfield);
            this.Name = "MainWindow";
            this.Text = "Pong Alone";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyUp);
            this.playfield.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox batter;
        private System.Windows.Forms.Panel playfield;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.TextBox tb_Status;
        private System.Windows.Forms.Timer ballTimer;
        private System.Windows.Forms.TextBox tb_Score;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.TextBox tb_Lives;
        private System.Windows.Forms.Label lbl_Lives;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Timer statusTimer;
        private System.Windows.Forms.Label lbl_header_highscore;
        private System.Windows.Forms.Label lbl_highscore;
        private System.Windows.Forms.CheckBox cb_cheatmode;
    }
}

