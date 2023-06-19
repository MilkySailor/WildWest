namespace MetiorGame
{
    partial class Tutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutorial));
            this.tutorialLabel = new System.Windows.Forms.Label();
            this.retryButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.playerWinBox = new System.Windows.Forms.PictureBox();
            this.playerDeathBox = new System.Windows.Forms.PictureBox();
            this.threeSecondTimerLabel = new System.Windows.Forms.Label();
            this.readyLabel = new System.Windows.Forms.Label();
            this.drawLabel = new System.Windows.Forms.Label();
            this.holdLabel = new System.Windows.Forms.Label();
            this.typingBox = new System.Windows.Forms.TextBox();
            this.incomingWordsBox = new System.Windows.Forms.Label();
            this.enemyWinBox = new System.Windows.Forms.PictureBox();
            this.enemyBox = new System.Windows.Forms.PictureBox();
            this.playerBox = new System.Windows.Forms.PictureBox();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.enemyDeathPictureBox = new System.Windows.Forms.PictureBox();
            this.gameEngine = new System.Windows.Forms.Timer(this.components);
            this.typingTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.endTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tutSkipButton1 = new System.Windows.Forms.Button();
            this.tutSkipButton2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerWinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDeathBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyWinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDeathPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tutorialLabel
            // 
            this.tutorialLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.tutorialLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tutorialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialLabel.Location = new System.Drawing.Point(518, 31);
            this.tutorialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tutorialLabel.Name = "tutorialLabel";
            this.tutorialLabel.Size = new System.Drawing.Size(218, 96);
            this.tutorialLabel.TabIndex = 46;
            this.tutorialLabel.Text = "Welcome to the tutorial";
            // 
            // retryButton
            // 
            this.retryButton.BackColor = System.Drawing.Color.Cornsilk;
            this.retryButton.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retryButton.Location = new System.Drawing.Point(1060, 421);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(118, 56);
            this.retryButton.TabIndex = 45;
            this.retryButton.Text = "Retry";
            this.retryButton.UseVisualStyleBackColor = false;
            this.retryButton.Visible = false;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click_1);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Cornsilk;
            this.menuButton.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(1060, 526);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(118, 56);
            this.menuButton.TabIndex = 44;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Visible = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click_1);
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.endLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endLabel.Font = new System.Drawing.Font("Poor Richard", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(482, 101);
            this.endLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(274, 92);
            this.endLabel.TabIndex = 43;
            this.endLabel.Text = "DRAW";
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.endLabel.Visible = false;
            // 
            // playerWinBox
            // 
            this.playerWinBox.BackColor = System.Drawing.Color.Transparent;
            this.playerWinBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerWinBox.Image = global::MetiorGame.Properties.Resources.CowBoyShoot_1_;
            this.playerWinBox.Location = new System.Drawing.Point(258, 349);
            this.playerWinBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerWinBox.Name = "playerWinBox";
            this.playerWinBox.Size = new System.Drawing.Size(269, 251);
            this.playerWinBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.playerWinBox.TabIndex = 42;
            this.playerWinBox.TabStop = false;
            this.playerWinBox.Visible = false;
            // 
            // playerDeathBox
            // 
            this.playerDeathBox.BackColor = System.Drawing.Color.Transparent;
            this.playerDeathBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerDeathBox.Image = global::MetiorGame.Properties.Resources.CowBoyArmChop;
            this.playerDeathBox.Location = new System.Drawing.Point(258, 349);
            this.playerDeathBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerDeathBox.Name = "playerDeathBox";
            this.playerDeathBox.Size = new System.Drawing.Size(269, 251);
            this.playerDeathBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.playerDeathBox.TabIndex = 41;
            this.playerDeathBox.TabStop = false;
            this.playerDeathBox.Visible = false;
            // 
            // threeSecondTimerLabel
            // 
            this.threeSecondTimerLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.threeSecondTimerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threeSecondTimerLabel.Font = new System.Drawing.Font("Poor Richard", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeSecondTimerLabel.Location = new System.Drawing.Point(248, 261);
            this.threeSecondTimerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.threeSecondTimerLabel.Name = "threeSecondTimerLabel";
            this.threeSecondTimerLabel.Size = new System.Drawing.Size(41, 41);
            this.threeSecondTimerLabel.TabIndex = 39;
            this.threeSecondTimerLabel.Text = "4";
            this.threeSecondTimerLabel.Visible = false;
            // 
            // readyLabel
            // 
            this.readyLabel.AutoSize = true;
            this.readyLabel.BackColor = System.Drawing.Color.Transparent;
            this.readyLabel.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyLabel.Location = new System.Drawing.Point(564, 37);
            this.readyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readyLabel.Name = "readyLabel";
            this.readyLabel.Size = new System.Drawing.Size(109, 35);
            this.readyLabel.TabIndex = 35;
            this.readyLabel.Text = "READY";
            this.readyLabel.Visible = false;
            // 
            // drawLabel
            // 
            this.drawLabel.AutoSize = true;
            this.drawLabel.BackColor = System.Drawing.Color.Transparent;
            this.drawLabel.Font = new System.Drawing.Font("Poor Richard", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawLabel.Location = new System.Drawing.Point(484, 122);
            this.drawLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drawLabel.Name = "drawLabel";
            this.drawLabel.Size = new System.Drawing.Size(272, 90);
            this.drawLabel.TabIndex = 34;
            this.drawLabel.Text = "DRAW";
            this.drawLabel.Visible = false;
            // 
            // holdLabel
            // 
            this.holdLabel.AutoSize = true;
            this.holdLabel.BackColor = System.Drawing.Color.Transparent;
            this.holdLabel.Font = new System.Drawing.Font("Poor Richard", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdLabel.Location = new System.Drawing.Point(545, 73);
            this.holdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.holdLabel.Name = "holdLabel";
            this.holdLabel.Size = new System.Drawing.Size(153, 49);
            this.holdLabel.TabIndex = 33;
            this.holdLabel.Text = "HOLD...";
            this.holdLabel.Visible = false;
            // 
            // typingBox
            // 
            this.typingBox.BackColor = System.Drawing.Color.Cornsilk;
            this.typingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typingBox.Location = new System.Drawing.Point(24, 349);
            this.typingBox.Margin = new System.Windows.Forms.Padding(4);
            this.typingBox.Name = "typingBox";
            this.typingBox.Size = new System.Drawing.Size(216, 41);
            this.typingBox.TabIndex = 32;
            this.typingBox.Text = "type here";
            this.typingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.typingBox.Visible = false;
            // 
            // incomingWordsBox
            // 
            this.incomingWordsBox.BackColor = System.Drawing.Color.Cornsilk;
            this.incomingWordsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incomingWordsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomingWordsBox.Location = new System.Drawing.Point(18, 17);
            this.incomingWordsBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incomingWordsBox.Name = "incomingWordsBox";
            this.incomingWordsBox.Size = new System.Drawing.Size(222, 313);
            this.incomingWordsBox.TabIndex = 31;
            this.incomingWordsBox.Text = "lamb";
            this.incomingWordsBox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.incomingWordsBox.Visible = false;
            // 
            // enemyWinBox
            // 
            this.enemyWinBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyWinBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemyWinBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyWinBox.Image")));
            this.enemyWinBox.Location = new System.Drawing.Point(446, 329);
            this.enemyWinBox.Margin = new System.Windows.Forms.Padding(4);
            this.enemyWinBox.Name = "enemyWinBox";
            this.enemyWinBox.Size = new System.Drawing.Size(278, 286);
            this.enemyWinBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyWinBox.TabIndex = 29;
            this.enemyWinBox.TabStop = false;
            this.enemyWinBox.Visible = false;
            // 
            // enemyBox
            // 
            this.enemyBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemyBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyBox.Image")));
            this.enemyBox.Location = new System.Drawing.Point(761, 334);
            this.enemyBox.Margin = new System.Windows.Forms.Padding(4);
            this.enemyBox.Name = "enemyBox";
            this.enemyBox.Size = new System.Drawing.Size(276, 281);
            this.enemyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyBox.TabIndex = 28;
            this.enemyBox.TabStop = false;
            // 
            // playerBox
            // 
            this.playerBox.BackColor = System.Drawing.Color.Transparent;
            this.playerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerBox.Image = ((System.Drawing.Image)(resources.GetObject("playerBox.Image")));
            this.playerBox.Location = new System.Drawing.Point(258, 349);
            this.playerBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(269, 251);
            this.playerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.playerBox.TabIndex = 27;
            this.playerBox.TabStop = false;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.distanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.distanceLabel.Location = new System.Drawing.Point(18, 51);
            this.distanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(0, 22);
            this.distanceLabel.TabIndex = 26;
            // 
            // enemyDeathPictureBox
            // 
            this.enemyDeathPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyDeathPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemyDeathPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyDeathPictureBox.Image")));
            this.enemyDeathPictureBox.Location = new System.Drawing.Point(784, 385);
            this.enemyDeathPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.enemyDeathPictureBox.Name = "enemyDeathPictureBox";
            this.enemyDeathPictureBox.Size = new System.Drawing.Size(338, 302);
            this.enemyDeathPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyDeathPictureBox.TabIndex = 30;
            this.enemyDeathPictureBox.TabStop = false;
            this.enemyDeathPictureBox.Visible = false;
            // 
            // gameEngine
            // 
            this.gameEngine.Enabled = true;
            this.gameEngine.Interval = 20;
            this.gameEngine.Tick += new System.EventHandler(this.gameEngine_Tick_1);
            // 
            // typingTimer
            // 
            this.typingTimer.Enabled = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Cornsilk;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 102);
            this.label1.TabIndex = 47;
            this.label1.Text = "<-- This is the count down, When it reaches 0 your words will be revealed";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Cornsilk;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 69);
            this.label2.TabIndex = 48;
            this.label2.Text = "<-- Your words will appear here";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Cornsilk;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(436, 108);
            this.label3.TabIndex = 49;
            this.label3.Text = "<-- This is the typing box, when the words are revealed you will need to type all" +
    " of them out here.";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 462);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 39);
            this.label4.TabIndex = 50;
            this.label4.Text = "<-- This is you";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Cornsilk;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(518, 501);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 39);
            this.label5.TabIndex = 51;
            this.label5.Text = "This is your enemy -->";
            // 
            // tutSkipButton1
            // 
            this.tutSkipButton1.BackColor = System.Drawing.Color.Cornsilk;
            this.tutSkipButton1.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutSkipButton1.Location = new System.Drawing.Point(928, 307);
            this.tutSkipButton1.Name = "tutSkipButton1";
            this.tutSkipButton1.Size = new System.Drawing.Size(118, 56);
            this.tutSkipButton1.TabIndex = 52;
            this.tutSkipButton1.Text = "Next";
            this.tutSkipButton1.UseVisualStyleBackColor = false;
            this.tutSkipButton1.Click += new System.EventHandler(this.tutSkipButton1_Click);
            // 
            // tutSkipButton2
            // 
            this.tutSkipButton2.BackColor = System.Drawing.Color.Cornsilk;
            this.tutSkipButton2.Enabled = false;
            this.tutSkipButton2.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutSkipButton2.Location = new System.Drawing.Point(928, 307);
            this.tutSkipButton2.Name = "tutSkipButton2";
            this.tutSkipButton2.Size = new System.Drawing.Size(118, 56);
            this.tutSkipButton2.TabIndex = 53;
            this.tutSkipButton2.Text = "Next";
            this.tutSkipButton2.UseVisualStyleBackColor = false;
            this.tutSkipButton2.Visible = false;
            this.tutSkipButton2.Click += new System.EventHandler(this.tutSkipButton2_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Cornsilk;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(730, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 101);
            this.label6.TabIndex = 54;
            this.label6.Text = "When you are ready hit next and the game will start";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Cornsilk;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(258, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(334, 181);
            this.label7.TabIndex = 55;
            this.label7.Text = "You have as much time as you need to type out your words, but normaly you are lim" +
    "ited to about 10 seconds";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-21, -6);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1263, 650);
            this.label8.TabIndex = 56;
            this.label8.Text = "Welcome to the tutorial";
            this.label8.Visible = false;
            // 
            // Tutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tutSkipButton2);
            this.Controls.Add(this.tutSkipButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tutorialLabel);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.playerWinBox);
            this.Controls.Add(this.playerDeathBox);
            this.Controls.Add(this.threeSecondTimerLabel);
            this.Controls.Add(this.readyLabel);
            this.Controls.Add(this.drawLabel);
            this.Controls.Add(this.holdLabel);
            this.Controls.Add(this.typingBox);
            this.Controls.Add(this.incomingWordsBox);
            this.Controls.Add(this.enemyWinBox);
            this.Controls.Add(this.enemyBox);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.enemyDeathPictureBox);
            this.Controls.Add(this.label8);
            this.DoubleBuffered = true;
            this.Name = "Tutorial";
            this.Size = new System.Drawing.Size(1212, 630);
            ((System.ComponentModel.ISupportInitialize)(this.playerWinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDeathBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyWinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDeathPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tutorialLabel;
        private System.Windows.Forms.Button retryButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.PictureBox playerWinBox;
        private System.Windows.Forms.PictureBox playerDeathBox;
        private System.Windows.Forms.Label threeSecondTimerLabel;
        private System.Windows.Forms.Label readyLabel;
        private System.Windows.Forms.Label drawLabel;
        private System.Windows.Forms.Label holdLabel;
        private System.Windows.Forms.TextBox typingBox;
        private System.Windows.Forms.Label incomingWordsBox;
        private System.Windows.Forms.PictureBox enemyWinBox;
        private System.Windows.Forms.PictureBox enemyBox;
        private System.Windows.Forms.PictureBox playerBox;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.PictureBox enemyDeathPictureBox;
        private System.Windows.Forms.Timer gameEngine;
        private System.Windows.Forms.Timer typingTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer endTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button tutSkipButton1;
        private System.Windows.Forms.Button tutSkipButton2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
