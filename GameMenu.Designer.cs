namespace Car_Racing
{
    partial class GameMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameMenu));
            this.Screen = new System.Windows.Forms.Panel();
            this.Explosion = new System.Windows.Forms.PictureBox();
            this.Award = new System.Windows.Forms.PictureBox();
            this.AI_Car2 = new System.Windows.Forms.PictureBox();
            this.AI_Car1 = new System.Windows.Forms.PictureBox();
            this.PlayerCar = new System.Windows.Forms.PictureBox();
            this.RoadTrackContinuation = new System.Windows.Forms.PictureBox();
            this.RoadTrack = new System.Windows.Forms.PictureBox();
            this.GameScore = new System.Windows.Forms.Label();
            this.Manual = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.TopDesignPanel = new System.Windows.Forms.Panel();
            this.LeftDesignPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RecordPanel = new System.Windows.Forms.Panel();
            this.PlayAgainButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.FinalScore = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.GameTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI_Car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI_Car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrackContinuation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack)).BeginInit();
            this.RecordPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.Color.Black;
            this.Screen.Controls.Add(this.Explosion);
            this.Screen.Controls.Add(this.Award);
            this.Screen.Controls.Add(this.AI_Car2);
            this.Screen.Controls.Add(this.AI_Car1);
            this.Screen.Controls.Add(this.PlayerCar);
            this.Screen.Controls.Add(this.RoadTrackContinuation);
            this.Screen.Controls.Add(this.RoadTrack);
            this.Screen.Location = new System.Drawing.Point(12, 12);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(491, 549);
            this.Screen.TabIndex = 0;
            // 
            // Explosion
            // 
            this.Explosion.Image = global::Car_Racing.Properties.Resources.Explosion;
            this.Explosion.Location = new System.Drawing.Point(64, 378);
            this.Explosion.Name = "Explosion";
            this.Explosion.Size = new System.Drawing.Size(49, 47);
            this.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Explosion.TabIndex = 2;
            this.Explosion.TabStop = false;
            this.Explosion.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Award
            // 
            this.Award.Image = global::Car_Racing.Properties.Resources.bronze;
            this.Award.Location = new System.Drawing.Point(129, 239);
            this.Award.Name = "Award";
            this.Award.Size = new System.Drawing.Size(242, 92);
            this.Award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Award.TabIndex = 2;
            this.Award.TabStop = false;
            this.Award.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // AI_Car2
            // 
            this.AI_Car2.Image = global::Car_Racing.Properties.Resources.police_car;
            this.AI_Car2.Location = new System.Drawing.Point(388, 47);
            this.AI_Car2.Name = "AI_Car2";
            this.AI_Car2.Size = new System.Drawing.Size(49, 93);
            this.AI_Car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI_Car2.TabIndex = 2;
            this.AI_Car2.TabStop = false;
            this.AI_Car2.Tag = "CarRight";
            this.AI_Car2.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // AI_Car1
            // 
            this.AI_Car1.Image = global::Car_Racing.Properties.Resources.red_pickup;
            this.AI_Car1.Location = new System.Drawing.Point(61, 47);
            this.AI_Car1.Name = "AI_Car1";
            this.AI_Car1.Size = new System.Drawing.Size(52, 92);
            this.AI_Car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI_Car1.TabIndex = 2;
            this.AI_Car1.TabStop = false;
            this.AI_Car1.Tag = "CarLeft";
            this.AI_Car1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PlayerCar
            // 
            this.PlayerCar.Image = ((System.Drawing.Image)(resources.GetObject("PlayerCar.Image")));
            this.PlayerCar.Location = new System.Drawing.Point(227, 431);
            this.PlayerCar.Name = "PlayerCar";
            this.PlayerCar.Size = new System.Drawing.Size(51, 100);
            this.PlayerCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PlayerCar.TabIndex = 2;
            this.PlayerCar.TabStop = false;
            this.PlayerCar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // RoadTrackContinuation
            // 
            this.RoadTrackContinuation.Image = global::Car_Racing.Properties.Resources.blackroad;
            this.RoadTrackContinuation.Location = new System.Drawing.Point(0, 0);
            this.RoadTrackContinuation.Name = "RoadTrackContinuation";
            this.RoadTrackContinuation.Size = new System.Drawing.Size(491, 549);
            this.RoadTrackContinuation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoadTrackContinuation.TabIndex = 1;
            this.RoadTrackContinuation.TabStop = false;
            // 
            // RoadTrack
            // 
            this.RoadTrack.Image = global::Car_Racing.Properties.Resources.blackroad;
            this.RoadTrack.Location = new System.Drawing.Point(0, -549);
            this.RoadTrack.Name = "RoadTrack";
            this.RoadTrack.Size = new System.Drawing.Size(491, 549);
            this.RoadTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RoadTrack.TabIndex = 0;
            this.RoadTrack.TabStop = false;
            // 
            // GameScore
            // 
            this.GameScore.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameScore.Location = new System.Drawing.Point(12, 567);
            this.GameScore.Name = "GameScore";
            this.GameScore.Size = new System.Drawing.Size(491, 29);
            this.GameScore.TabIndex = 2;
            this.GameScore.Text = "SCORE: 0";
            this.GameScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Manual
            // 
            this.Manual.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manual.Location = new System.Drawing.Point(12, 652);
            this.Manual.Name = "Manual";
            this.Manual.Size = new System.Drawing.Size(491, 148);
            this.Manual.TabIndex = 3;
            this.Manual.Text = "CONTROLS:\r\nLeft Arrow - Move the car to the left\r\nRigh Arrow - Move the car to th" +
    "e right\r\n\r\nRULES:\r\nIf you hit any car, you lose.\r\nSurvive for as long as you can" +
    ".\r\n";
            this.Manual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // TopDesignPanel
            // 
            this.TopDesignPanel.BackColor = System.Drawing.Color.Yellow;
            this.TopDesignPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopDesignPanel.Location = new System.Drawing.Point(0, 0);
            this.TopDesignPanel.Name = "TopDesignPanel";
            this.TopDesignPanel.Size = new System.Drawing.Size(515, 12);
            this.TopDesignPanel.TabIndex = 4;
            // 
            // LeftDesignPanel
            // 
            this.LeftDesignPanel.BackColor = System.Drawing.Color.Yellow;
            this.LeftDesignPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftDesignPanel.Location = new System.Drawing.Point(0, 12);
            this.LeftDesignPanel.Name = "LeftDesignPanel";
            this.LeftDesignPanel.Size = new System.Drawing.Size(12, 808);
            this.LeftDesignPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(502, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 808);
            this.panel1.TabIndex = 6;
            // 
            // RecordPanel
            // 
            this.RecordPanel.Controls.Add(this.PlayAgainButton);
            this.RecordPanel.Controls.Add(this.ExitButton);
            this.RecordPanel.Controls.Add(this.ClearButton);
            this.RecordPanel.Controls.Add(this.SubmitButton);
            this.RecordPanel.Controls.Add(this.FinalScore);
            this.RecordPanel.Controls.Add(this.NameTextBox);
            this.RecordPanel.Controls.Add(this.NameLabel);
            this.RecordPanel.Controls.Add(this.GameOverLabel);
            this.RecordPanel.Location = new System.Drawing.Point(18, 567);
            this.RecordPanel.Name = "RecordPanel";
            this.RecordPanel.Size = new System.Drawing.Size(478, 241);
            this.RecordPanel.TabIndex = 7;
            // 
            // PlayAgainButton
            // 
            this.PlayAgainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PlayAgainButton.FlatAppearance.BorderSize = 0;
            this.PlayAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayAgainButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgainButton.Location = new System.Drawing.Point(3, 209);
            this.PlayAgainButton.Name = "PlayAgainButton";
            this.PlayAgainButton.Size = new System.Drawing.Size(139, 29);
            this.PlayAgainButton.TabIndex = 1;
            this.PlayAgainButton.Text = "PLAY AGAIN";
            this.PlayAgainButton.UseVisualStyleBackColor = false;
            this.PlayAgainButton.Click += new System.EventHandler(this.StartGame);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(336, 209);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(139, 29);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClearButton.FlatAppearance.BorderSize = 0;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(168, 169);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(139, 29);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(168, 134);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(139, 29);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "SUBMIT";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // FinalScore
            // 
            this.FinalScore.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalScore.Location = new System.Drawing.Point(58, 94);
            this.FinalScore.Name = "FinalScore";
            this.FinalScore.Size = new System.Drawing.Size(359, 37);
            this.FinalScore.TabIndex = 8;
            this.FinalScore.Text = "SCORE: 0";
            this.FinalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(163, 63);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(254, 26);
            this.NameTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Stencil", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(11, 55);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(195, 43);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "NAME: ";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel.Location = new System.Drawing.Point(3, 10);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(472, 43);
            this.GameOverLabel.TabIndex = 2;
            this.GameOverLabel.Text = "GAME OVER";
            this.GameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTitle
            // 
            this.GameTitle.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameTitle.Location = new System.Drawing.Point(140, 598);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(234, 41);
            this.GameTitle.TabIndex = 12;
            this.GameTitle.Text = "TAXI RUSH";
            this.GameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(12, 810);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 10);
            this.panel2.TabIndex = 13;
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 820);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RecordPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LeftDesignPanel);
            this.Controls.Add(this.TopDesignPanel);
            this.Controls.Add(this.Manual);
            this.Controls.Add(this.GameScore);
            this.Controls.Add(this.Screen);
            this.Controls.Add(this.GameTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.Screen.ResumeLayout(false);
            this.Screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI_Car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI_Car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrackContinuation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoadTrack)).EndInit();
            this.RecordPanel.ResumeLayout(false);
            this.RecordPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.Label Manual;
        private System.Windows.Forms.PictureBox RoadTrack;
        private System.Windows.Forms.PictureBox RoadTrackContinuation;
        private System.Windows.Forms.PictureBox Explosion;
        private System.Windows.Forms.PictureBox AI_Car2;
        private System.Windows.Forms.PictureBox AI_Car1;
        private System.Windows.Forms.PictureBox PlayerCar;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Panel TopDesignPanel;
        private System.Windows.Forms.Panel LeftDesignPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Award;
        public System.Windows.Forms.Label GameScore;
        private System.Windows.Forms.Panel RecordPanel;
        private System.Windows.Forms.Button PlayAgainButton;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SubmitButton;
        public System.Windows.Forms.Label FinalScore;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label GameTitle;
        private System.Windows.Forms.Panel panel2;
    }
}

