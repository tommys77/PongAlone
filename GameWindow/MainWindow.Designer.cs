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
            this.Score = new System.Windows.Forms.Label();
            this.tb_Lives = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.playfield = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.PictureBox();
            this.batter = new System.Windows.Forms.PictureBox();
            this.playfield.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batter)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Status
            // 
            this.tb_Status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Status.Enabled = false;
            this.tb_Status.ForeColor = System.Drawing.Color.OrangeRed;
            this.tb_Status.Location = new System.Drawing.Point(606, 338);
            this.tb_Status.Name = "tb_Status";
            this.tb_Status.Size = new System.Drawing.Size(155, 13);
            this.tb_Status.TabIndex = 6;
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
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(566, 25);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(35, 13);
            this.Score.TabIndex = 8;
            this.Score.Text = "Score";
            // 
            // tb_Lives
            // 
            this.tb_Lives.Enabled = false;
            this.tb_Lives.Location = new System.Drawing.Point(606, 80);
            this.tb_Lives.Name = "tb_Lives";
            this.tb_Lives.Size = new System.Drawing.Size(35, 20);
            this.tb_Lives.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lives";
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
            this.batter.Location = new System.Drawing.Point(214, 378);
            this.batter.Name = "batter";
            this.batter.Size = new System.Drawing.Size(118, 24);
            this.batter.TabIndex = 0;
            this.batter.TabStop = false;
            this.batter.MouseEnter += new System.EventHandler(this.WhenTheMouseEnter);
            this.batter.MouseLeave += new System.EventHandler(this.WhenTheMouseLeave);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Lives);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.tb_Score);
            this.Controls.Add(this.tb_Status);
            this.Controls.Add(this.playfield);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainWindow_KeyPress);
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
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.TextBox tb_Lives;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Restart;
    }
}

