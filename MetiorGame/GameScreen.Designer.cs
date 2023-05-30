namespace MetiorGame
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.gameEngine = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.distanceLabel = new System.Windows.Forms.Label();
            this.endTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyBox = new System.Windows.Forms.PictureBox();
            this.playerBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enemyDeathPictureBox = new System.Windows.Forms.PictureBox();
            this.incomingWordsBox = new System.Windows.Forms.Label();
            this.typingBox = new System.Windows.Forms.TextBox();
            this.holdLabel = new System.Windows.Forms.Label();
            this.drawLabel = new System.Windows.Forms.Label();
            this.readyLabel = new System.Windows.Forms.Label();
            this.streakLabel = new System.Windows.Forms.Label();
            this.spellcheckLabel = new System.Windows.Forms.Label();
            this.blackBar1 = new System.Windows.Forms.Label();
            this.blackBar2 = new System.Windows.Forms.Label();
            this.threeSecondTimerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDeathPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameEngine
            // 
            this.gameEngine.Enabled = true;
            this.gameEngine.Interval = 20;
            this.gameEngine.Tick += new System.EventHandler(this.gameEngine_Tick);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.distanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.distanceLabel.Location = new System.Drawing.Point(10, 38);
            this.distanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(0, 18);
            this.distanceLabel.TabIndex = 4;
            // 
            // endTimer
            // 
            this.endTimer.Tick += new System.EventHandler(this.endTimer_Tick);
            // 
            // enemyBox
            // 
            this.enemyBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemyBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyBox.Image")));
            this.enemyBox.Location = new System.Drawing.Point(566, 269);
            this.enemyBox.Name = "enemyBox";
            this.enemyBox.Size = new System.Drawing.Size(207, 228);
            this.enemyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyBox.TabIndex = 6;
            this.enemyBox.TabStop = false;
            // 
            // playerBox
            // 
            this.playerBox.BackColor = System.Drawing.Color.Transparent;
            this.playerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playerBox.Image = ((System.Drawing.Image)(resources.GetObject("playerBox.Image")));
            this.playerBox.Location = new System.Drawing.Point(190, 281);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(202, 204);
            this.playerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.playerBox.TabIndex = 5;
            this.playerBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(330, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // enemyDeathPictureBox
            // 
            this.enemyDeathPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyDeathPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemyDeathPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyDeathPictureBox.Image")));
            this.enemyDeathPictureBox.Location = new System.Drawing.Point(583, 310);
            this.enemyDeathPictureBox.Name = "enemyDeathPictureBox";
            this.enemyDeathPictureBox.Size = new System.Drawing.Size(253, 245);
            this.enemyDeathPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyDeathPictureBox.TabIndex = 8;
            this.enemyDeathPictureBox.TabStop = false;
            this.enemyDeathPictureBox.Visible = false;
            // 
            // incomingWordsBox
            // 
            this.incomingWordsBox.BackColor = System.Drawing.Color.Cornsilk;
            this.incomingWordsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incomingWordsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomingWordsBox.Location = new System.Drawing.Point(10, 11);
            this.incomingWordsBox.Name = "incomingWordsBox";
            this.incomingWordsBox.Size = new System.Drawing.Size(166, 255);
            this.incomingWordsBox.TabIndex = 9;
            this.incomingWordsBox.Text = "lamb";
            this.incomingWordsBox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.incomingWordsBox.Visible = false;
            // 
            // typingBox
            // 
            this.typingBox.BackColor = System.Drawing.Color.Cornsilk;
            this.typingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typingBox.Location = new System.Drawing.Point(13, 281);
            this.typingBox.Name = "typingBox";
            this.typingBox.Size = new System.Drawing.Size(163, 35);
            this.typingBox.TabIndex = 10;
            this.typingBox.Text = "lamb";
            this.typingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.typingBox.Visible = false;
            // 
            // holdLabel
            // 
            this.holdLabel.AutoSize = true;
            this.holdLabel.BackColor = System.Drawing.Color.Transparent;
            this.holdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdLabel.Location = new System.Drawing.Point(405, 43);
            this.holdLabel.Name = "holdLabel";
            this.holdLabel.Size = new System.Drawing.Size(143, 39);
            this.holdLabel.TabIndex = 11;
            this.holdLabel.Text = "HOLD...";
            this.holdLabel.Visible = false;
            // 
            // drawLabel
            // 
            this.drawLabel.AutoSize = true;
            this.drawLabel.BackColor = System.Drawing.Color.Transparent;
            this.drawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawLabel.Location = new System.Drawing.Point(359, 82);
            this.drawLabel.Name = "drawLabel";
            this.drawLabel.Size = new System.Drawing.Size(227, 73);
            this.drawLabel.TabIndex = 12;
            this.drawLabel.Text = "DRAW";
            this.drawLabel.Visible = false;
            // 
            // readyLabel
            // 
            this.readyLabel.AutoSize = true;
            this.readyLabel.BackColor = System.Drawing.Color.Transparent;
            this.readyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyLabel.Location = new System.Drawing.Point(418, 11);
            this.readyLabel.Name = "readyLabel";
            this.readyLabel.Size = new System.Drawing.Size(94, 29);
            this.readyLabel.TabIndex = 13;
            this.readyLabel.Text = "READY";
            this.readyLabel.Visible = false;
            // 
            // streakLabel
            // 
            this.streakLabel.AutoSize = true;
            this.streakLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.streakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streakLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.streakLabel.Location = new System.Drawing.Point(812, 11);
            this.streakLabel.Name = "streakLabel";
            this.streakLabel.Size = new System.Drawing.Size(73, 20);
            this.streakLabel.TabIndex = 14;
            this.streakLabel.Text = "Streak: 0";
            this.streakLabel.Visible = false;
            // 
            // spellcheckLabel
            // 
            this.spellcheckLabel.AutoSize = true;
            this.spellcheckLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.spellcheckLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spellcheckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellcheckLabel.Location = new System.Drawing.Point(27, 319);
            this.spellcheckLabel.Name = "spellcheckLabel";
            this.spellcheckLabel.Size = new System.Drawing.Size(126, 31);
            this.spellcheckLabel.TabIndex = 15;
            this.spellcheckLabel.Text = "MISTAKE!";
            this.spellcheckLabel.Visible = false;
            // 
            // blackBar1
            // 
            this.blackBar1.Location = new System.Drawing.Point(0, 0);
            this.blackBar1.Name = "blackBar1";
            this.blackBar1.Size = new System.Drawing.Size(910, 11);
            this.blackBar1.TabIndex = 16;
            this.blackBar1.Text = "label1";
            // 
            // blackBar2
            // 
            this.blackBar2.Location = new System.Drawing.Point(-22, 470);
            this.blackBar2.Name = "blackBar2";
            this.blackBar2.Size = new System.Drawing.Size(932, 42);
            this.blackBar2.TabIndex = 17;
            this.blackBar2.Text = "label2";
            // 
            // threeSecondTimerLabel
            // 
            this.threeSecondTimerLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.threeSecondTimerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threeSecondTimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeSecondTimerLabel.Location = new System.Drawing.Point(182, 232);
            this.threeSecondTimerLabel.Name = "threeSecondTimerLabel";
            this.threeSecondTimerLabel.Size = new System.Drawing.Size(31, 34);
            this.threeSecondTimerLabel.TabIndex = 18;
            this.threeSecondTimerLabel.Text = "3";
            this.threeSecondTimerLabel.Visible = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.threeSecondTimerLabel);
            this.Controls.Add(this.blackBar2);
            this.Controls.Add(this.blackBar1);
            this.Controls.Add(this.spellcheckLabel);
            this.Controls.Add(this.streakLabel);
            this.Controls.Add(this.readyLabel);
            this.Controls.Add(this.drawLabel);
            this.Controls.Add(this.holdLabel);
            this.Controls.Add(this.typingBox);
            this.Controls.Add(this.incomingWordsBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enemyBox);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.enemyDeathPictureBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(910, 512);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.enemyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDeathPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameEngine;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Timer endTimer;
        private System.Windows.Forms.PictureBox enemyBox;
        private System.Windows.Forms.PictureBox playerBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox enemyDeathPictureBox;
        private System.Windows.Forms.Label incomingWordsBox;
        private System.Windows.Forms.TextBox typingBox;
        private System.Windows.Forms.Label holdLabel;
        private System.Windows.Forms.Label drawLabel;
        private System.Windows.Forms.Label readyLabel;
        private System.Windows.Forms.Label streakLabel;
        private System.Windows.Forms.Label spellcheckLabel;
        private System.Windows.Forms.Label blackBar1;
        private System.Windows.Forms.Label blackBar2;
        private System.Windows.Forms.Label threeSecondTimerLabel;
    }
}
