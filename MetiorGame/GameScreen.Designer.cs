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
            this.typingTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.distanceLabel = new System.Windows.Forms.Label();
            this.endTimer = new System.Windows.Forms.Timer(this.components);
            this.enemyBox = new System.Windows.Forms.PictureBox();
            this.playerBox = new System.Windows.Forms.PictureBox();
            this.enemyWinBox = new System.Windows.Forms.PictureBox();
            this.enemyDeathPictureBox = new System.Windows.Forms.PictureBox();
            this.incomingWordsBox = new System.Windows.Forms.Label();
            this.typingBox = new System.Windows.Forms.TextBox();
            this.holdLabel = new System.Windows.Forms.Label();
            this.drawLabel = new System.Windows.Forms.Label();
            this.readyLabel = new System.Windows.Forms.Label();
            this.blackBar1 = new System.Windows.Forms.Label();
            this.blackBar2 = new System.Windows.Forms.Label();
            this.threeSecondTimerLabel = new System.Windows.Forms.Label();
            this.blackBox = new System.Windows.Forms.Label();
            this.playerDeathBox = new System.Windows.Forms.PictureBox();
            this.playerWinBox = new System.Windows.Forms.PictureBox();
            this.endLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.retryButton = new System.Windows.Forms.Button();
            this.offscreentypingbox = new System.Windows.Forms.TextBox();
            this.reaperBox = new System.Windows.Forms.PictureBox();
            this.reaperWinBox = new System.Windows.Forms.PictureBox();
            this.kingWinBox = new System.Windows.Forms.PictureBox();
            this.adventBox = new System.Windows.Forms.PictureBox();
            this.adventWinBox = new System.Windows.Forms.PictureBox();
            this.adventDeathBox = new System.Windows.Forms.PictureBox();
            this.gobBox = new System.Windows.Forms.PictureBox();
            this.gobWinBox = new System.Windows.Forms.PictureBox();
            this.gobDeathBox = new System.Windows.Forms.PictureBox();
            this.kingBox = new System.Windows.Forms.PictureBox();
            this.kingDeathBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyWinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDeathPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDeathBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerWinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reaperBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reaperWinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingWinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventWinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventDeathBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gobBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gobWinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gobDeathBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingDeathBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameEngine
            // 
            this.gameEngine.Enabled = true;
            this.gameEngine.Interval = 20;
            this.gameEngine.Tick += new System.EventHandler(this.gameEngine_Tick);
            // 
            // typingTimer
            // 
            this.typingTimer.Enabled = true;
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
            this.distanceLabel.Location = new System.Drawing.Point(12, 48);
            this.distanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(0, 22);
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
            this.enemyBox.Location = new System.Drawing.Point(752, 325);
            this.enemyBox.Margin = new System.Windows.Forms.Padding(4);
            this.enemyBox.Name = "enemyBox";
            this.enemyBox.Size = new System.Drawing.Size(279, 258);
            this.enemyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyBox.TabIndex = 6;
            this.enemyBox.TabStop = false;
            // 
            // playerBox
            // 
            this.playerBox.BackColor = System.Drawing.Color.Transparent;
            this.playerBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerBox.Image = ((System.Drawing.Image)(resources.GetObject("playerBox.Image")));
            this.playerBox.Location = new System.Drawing.Point(252, 346);
            this.playerBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(269, 251);
            this.playerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.playerBox.TabIndex = 5;
            this.playerBox.TabStop = false;
            // 
            // enemyWinBox
            // 
            this.enemyWinBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyWinBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemyWinBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyWinBox.Image")));
            this.enemyWinBox.Location = new System.Drawing.Point(440, 331);
            this.enemyWinBox.Margin = new System.Windows.Forms.Padding(4);
            this.enemyWinBox.Name = "enemyWinBox";
            this.enemyWinBox.Size = new System.Drawing.Size(269, 266);
            this.enemyWinBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemyWinBox.TabIndex = 7;
            this.enemyWinBox.TabStop = false;
            this.enemyWinBox.Visible = false;
            // 
            // enemyDeathPictureBox
            // 
            this.enemyDeathPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.enemyDeathPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enemyDeathPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("enemyDeathPictureBox.Image")));
            this.enemyDeathPictureBox.Location = new System.Drawing.Point(737, 372);
            this.enemyDeathPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.enemyDeathPictureBox.Name = "enemyDeathPictureBox";
            this.enemyDeathPictureBox.Size = new System.Drawing.Size(338, 207);
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
            this.incomingWordsBox.Location = new System.Drawing.Point(12, 14);
            this.incomingWordsBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incomingWordsBox.Name = "incomingWordsBox";
            this.incomingWordsBox.Size = new System.Drawing.Size(222, 313);
            this.incomingWordsBox.TabIndex = 9;
            this.incomingWordsBox.Text = "lamb";
            this.incomingWordsBox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.incomingWordsBox.Visible = false;
            // 
            // typingBox
            // 
            this.typingBox.BackColor = System.Drawing.Color.Cornsilk;
            this.typingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typingBox.Location = new System.Drawing.Point(18, 346);
            this.typingBox.Margin = new System.Windows.Forms.Padding(4);
            this.typingBox.Name = "typingBox";
            this.typingBox.Size = new System.Drawing.Size(216, 41);
            this.typingBox.TabIndex = 10;
            this.typingBox.Text = "type here";
            this.typingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.typingBox.Visible = false;
            this.typingBox.TextChanged += new System.EventHandler(this.typingBox_TextChanged);
            // 
            // holdLabel
            // 
            this.holdLabel.AutoSize = true;
            this.holdLabel.BackColor = System.Drawing.Color.Transparent;
            this.holdLabel.Font = new System.Drawing.Font("Poor Richard", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holdLabel.Location = new System.Drawing.Point(539, 70);
            this.holdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.holdLabel.Name = "holdLabel";
            this.holdLabel.Size = new System.Drawing.Size(153, 49);
            this.holdLabel.TabIndex = 11;
            this.holdLabel.Text = "HOLD...";
            this.holdLabel.Visible = false;
            // 
            // drawLabel
            // 
            this.drawLabel.AutoSize = true;
            this.drawLabel.BackColor = System.Drawing.Color.Transparent;
            this.drawLabel.Font = new System.Drawing.Font("Poor Richard", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawLabel.Location = new System.Drawing.Point(478, 119);
            this.drawLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drawLabel.Name = "drawLabel";
            this.drawLabel.Size = new System.Drawing.Size(272, 90);
            this.drawLabel.TabIndex = 12;
            this.drawLabel.Text = "DRAW";
            this.drawLabel.Visible = false;
            // 
            // readyLabel
            // 
            this.readyLabel.AutoSize = true;
            this.readyLabel.BackColor = System.Drawing.Color.Transparent;
            this.readyLabel.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyLabel.Location = new System.Drawing.Point(558, 34);
            this.readyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readyLabel.Name = "readyLabel";
            this.readyLabel.Size = new System.Drawing.Size(109, 35);
            this.readyLabel.TabIndex = 13;
            this.readyLabel.Text = "READY";
            this.readyLabel.Visible = false;
            // 
            // blackBar1
            // 
            this.blackBar1.Location = new System.Drawing.Point(-3, 0);
            this.blackBar1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blackBar1.Name = "blackBar1";
            this.blackBar1.Size = new System.Drawing.Size(1230, 126);
            this.blackBar1.TabIndex = 16;
            this.blackBar1.Text = "label1";
            // 
            // blackBar2
            // 
            this.blackBar2.Location = new System.Drawing.Point(-29, 519);
            this.blackBar2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blackBar2.Name = "blackBar2";
            this.blackBar2.Size = new System.Drawing.Size(1242, 111);
            this.blackBar2.TabIndex = 17;
            this.blackBar2.Text = "label2";
            // 
            // threeSecondTimerLabel
            // 
            this.threeSecondTimerLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.threeSecondTimerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threeSecondTimerLabel.Font = new System.Drawing.Font("Poor Richard", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threeSecondTimerLabel.Location = new System.Drawing.Point(242, 286);
            this.threeSecondTimerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.threeSecondTimerLabel.Name = "threeSecondTimerLabel";
            this.threeSecondTimerLabel.Size = new System.Drawing.Size(41, 41);
            this.threeSecondTimerLabel.TabIndex = 18;
            this.threeSecondTimerLabel.Text = "4";
            this.threeSecondTimerLabel.Visible = false;
            // 
            // blackBox
            // 
            this.blackBox.Location = new System.Drawing.Point(-29, -59);
            this.blackBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.blackBox.Name = "blackBox";
            this.blackBox.Size = new System.Drawing.Size(1294, 689);
            this.blackBox.TabIndex = 19;
            this.blackBox.Text = "label1";
            this.blackBox.Visible = false;
            // 
            // playerDeathBox
            // 
            this.playerDeathBox.BackColor = System.Drawing.Color.Transparent;
            this.playerDeathBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerDeathBox.Image = global::MetiorGame.Properties.Resources.CowBoyArmChop;
            this.playerDeathBox.Location = new System.Drawing.Point(252, 346);
            this.playerDeathBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerDeathBox.Name = "playerDeathBox";
            this.playerDeathBox.Size = new System.Drawing.Size(269, 251);
            this.playerDeathBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.playerDeathBox.TabIndex = 20;
            this.playerDeathBox.TabStop = false;
            this.playerDeathBox.Visible = false;
            // 
            // playerWinBox
            // 
            this.playerWinBox.BackColor = System.Drawing.Color.Transparent;
            this.playerWinBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerWinBox.Image = global::MetiorGame.Properties.Resources.CowBoyShoot_1_;
            this.playerWinBox.Location = new System.Drawing.Point(252, 346);
            this.playerWinBox.Margin = new System.Windows.Forms.Padding(4);
            this.playerWinBox.Name = "playerWinBox";
            this.playerWinBox.Size = new System.Drawing.Size(269, 251);
            this.playerWinBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.playerWinBox.TabIndex = 21;
            this.playerWinBox.TabStop = false;
            this.playerWinBox.Visible = false;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.BackColor = System.Drawing.Color.Cornsilk;
            this.endLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endLabel.Font = new System.Drawing.Font("Poor Richard", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(476, 98);
            this.endLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(274, 92);
            this.endLabel.TabIndex = 22;
            this.endLabel.Text = "DRAW";
            this.endLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.endLabel.Visible = false;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Cornsilk;
            this.menuButton.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(1054, 523);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(118, 56);
            this.menuButton.TabIndex = 23;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Visible = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // retryButton
            // 
            this.retryButton.BackColor = System.Drawing.Color.Cornsilk;
            this.retryButton.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retryButton.Location = new System.Drawing.Point(1054, 418);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(118, 56);
            this.retryButton.TabIndex = 24;
            this.retryButton.Text = "Retry";
            this.retryButton.UseVisualStyleBackColor = false;
            this.retryButton.Visible = false;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // offscreentypingbox
            // 
            this.offscreentypingbox.BackColor = System.Drawing.Color.Black;
            this.offscreentypingbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offscreentypingbox.Location = new System.Drawing.Point(1215, 298);
            this.offscreentypingbox.Margin = new System.Windows.Forms.Padding(4);
            this.offscreentypingbox.Name = "offscreentypingbox";
            this.offscreentypingbox.Size = new System.Drawing.Size(112, 41);
            this.offscreentypingbox.TabIndex = 26;
            this.offscreentypingbox.Text = "type here";
            this.offscreentypingbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reaperBox
            // 
            this.reaperBox.BackColor = System.Drawing.Color.Transparent;
            this.reaperBox.BackgroundImage = global::MetiorGame.Properties.Resources.idleReaper;
            this.reaperBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reaperBox.Image = ((System.Drawing.Image)(resources.GetObject("reaperBox.Image")));
            this.reaperBox.Location = new System.Drawing.Point(792, 401);
            this.reaperBox.Margin = new System.Windows.Forms.Padding(4);
            this.reaperBox.Name = "reaperBox";
            this.reaperBox.Size = new System.Drawing.Size(192, 178);
            this.reaperBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reaperBox.TabIndex = 27;
            this.reaperBox.TabStop = false;
            this.reaperBox.Visible = false;
            // 
            // reaperWinBox
            // 
            this.reaperWinBox.BackColor = System.Drawing.Color.Transparent;
            this.reaperWinBox.BackgroundImage = global::MetiorGame.Properties.Resources.HostileAttackReaper_Sheet;
            this.reaperWinBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reaperWinBox.Location = new System.Drawing.Point(440, 401);
            this.reaperWinBox.Margin = new System.Windows.Forms.Padding(4);
            this.reaperWinBox.Name = "reaperWinBox";
            this.reaperWinBox.Size = new System.Drawing.Size(192, 178);
            this.reaperWinBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reaperWinBox.TabIndex = 28;
            this.reaperWinBox.TabStop = false;
            this.reaperWinBox.Visible = false;
            // 
            // kingWinBox
            // 
            this.kingWinBox.BackColor = System.Drawing.Color.Transparent;
            this.kingWinBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kingWinBox.Image = global::MetiorGame.Properties.Resources.Attack1;
            this.kingWinBox.Location = new System.Drawing.Point(440, 361);
            this.kingWinBox.Margin = new System.Windows.Forms.Padding(4);
            this.kingWinBox.Name = "kingWinBox";
            this.kingWinBox.Size = new System.Drawing.Size(243, 239);
            this.kingWinBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kingWinBox.TabIndex = 29;
            this.kingWinBox.TabStop = false;
            this.kingWinBox.Visible = false;
            // 
            // adventBox
            // 
            this.adventBox.BackColor = System.Drawing.Color.Transparent;
            this.adventBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adventBox.Image = global::MetiorGame.Properties.Resources.adventurerIdle;
            this.adventBox.Location = new System.Drawing.Point(777, 384);
            this.adventBox.Margin = new System.Windows.Forms.Padding(4);
            this.adventBox.Name = "adventBox";
            this.adventBox.Size = new System.Drawing.Size(234, 211);
            this.adventBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adventBox.TabIndex = 32;
            this.adventBox.TabStop = false;
            this.adventBox.Visible = false;
            // 
            // adventWinBox
            // 
            this.adventWinBox.BackColor = System.Drawing.Color.Transparent;
            this.adventWinBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adventWinBox.ErrorImage = global::MetiorGame.Properties.Resources.adventurerAttack;
            this.adventWinBox.Image = global::MetiorGame.Properties.Resources.adventurerAttack;
            this.adventWinBox.Location = new System.Drawing.Point(425, 384);
            this.adventWinBox.Margin = new System.Windows.Forms.Padding(4);
            this.adventWinBox.Name = "adventWinBox";
            this.adventWinBox.Size = new System.Drawing.Size(284, 211);
            this.adventWinBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adventWinBox.TabIndex = 33;
            this.adventWinBox.TabStop = false;
            this.adventWinBox.Visible = false;
            // 
            // adventDeathBox
            // 
            this.adventDeathBox.BackColor = System.Drawing.Color.Transparent;
            this.adventDeathBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.adventDeathBox.ErrorImage = null;
            this.adventDeathBox.Image = global::MetiorGame.Properties.Resources.adventurerDeath;
            this.adventDeathBox.Location = new System.Drawing.Point(792, 361);
            this.adventDeathBox.Margin = new System.Windows.Forms.Padding(4);
            this.adventDeathBox.Name = "adventDeathBox";
            this.adventDeathBox.Size = new System.Drawing.Size(202, 211);
            this.adventDeathBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adventDeathBox.TabIndex = 34;
            this.adventDeathBox.TabStop = false;
            this.adventDeathBox.Visible = false;
            // 
            // gobBox
            // 
            this.gobBox.BackColor = System.Drawing.Color.Transparent;
            this.gobBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gobBox.Image = global::MetiorGame.Properties.Resources.gobIdle;
            this.gobBox.Location = new System.Drawing.Point(768, 384);
            this.gobBox.Margin = new System.Windows.Forms.Padding(4);
            this.gobBox.Name = "gobBox";
            this.gobBox.Size = new System.Drawing.Size(243, 211);
            this.gobBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gobBox.TabIndex = 35;
            this.gobBox.TabStop = false;
            this.gobBox.Visible = false;
            // 
            // gobWinBox
            // 
            this.gobWinBox.BackColor = System.Drawing.Color.Transparent;
            this.gobWinBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gobWinBox.Image = global::MetiorGame.Properties.Resources.gobAttack;
            this.gobWinBox.Location = new System.Drawing.Point(440, 318);
            this.gobWinBox.Margin = new System.Windows.Forms.Padding(4);
            this.gobWinBox.Name = "gobWinBox";
            this.gobWinBox.Size = new System.Drawing.Size(329, 306);
            this.gobWinBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gobWinBox.TabIndex = 36;
            this.gobWinBox.TabStop = false;
            this.gobWinBox.Visible = false;
            // 
            // gobDeathBox
            // 
            this.gobDeathBox.BackColor = System.Drawing.Color.Transparent;
            this.gobDeathBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gobDeathBox.Image = global::MetiorGame.Properties.Resources.gobDeath;
            this.gobDeathBox.Location = new System.Drawing.Point(752, 361);
            this.gobDeathBox.Margin = new System.Windows.Forms.Padding(4);
            this.gobDeathBox.Name = "gobDeathBox";
            this.gobDeathBox.Size = new System.Drawing.Size(288, 249);
            this.gobDeathBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gobDeathBox.TabIndex = 37;
            this.gobDeathBox.TabStop = false;
            this.gobDeathBox.Visible = false;
            // 
            // kingBox
            // 
            this.kingBox.BackColor = System.Drawing.Color.Transparent;
            this.kingBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kingBox.Image = global::MetiorGame.Properties.Resources.Idle;
            this.kingBox.Location = new System.Drawing.Point(777, 361);
            this.kingBox.Margin = new System.Windows.Forms.Padding(4);
            this.kingBox.Name = "kingBox";
            this.kingBox.Size = new System.Drawing.Size(232, 222);
            this.kingBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kingBox.TabIndex = 38;
            this.kingBox.TabStop = false;
            this.kingBox.Visible = false;
            // 
            // kingDeathBox
            // 
            this.kingDeathBox.BackColor = System.Drawing.Color.Transparent;
            this.kingDeathBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kingDeathBox.Image = global::MetiorGame.Properties.Resources.Death;
            this.kingDeathBox.Location = new System.Drawing.Point(808, 357);
            this.kingDeathBox.Margin = new System.Windows.Forms.Padding(4);
            this.kingDeathBox.Name = "kingDeathBox";
            this.kingDeathBox.Size = new System.Drawing.Size(232, 222);
            this.kingDeathBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kingDeathBox.TabIndex = 39;
            this.kingDeathBox.TabStop = false;
            this.kingDeathBox.Visible = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.blackBar1);
            this.Controls.Add(this.blackBar2);
            this.Controls.Add(this.reaperWinBox);
            this.Controls.Add(this.kingDeathBox);
            this.Controls.Add(this.offscreentypingbox);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.threeSecondTimerLabel);
            this.Controls.Add(this.readyLabel);
            this.Controls.Add(this.drawLabel);
            this.Controls.Add(this.holdLabel);
            this.Controls.Add(this.typingBox);
            this.Controls.Add(this.incomingWordsBox);
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.enemyWinBox);
            this.Controls.Add(this.kingBox);
            this.Controls.Add(this.gobDeathBox);
            this.Controls.Add(this.gobBox);
            this.Controls.Add(this.reaperBox);
            this.Controls.Add(this.enemyBox);
            this.Controls.Add(this.enemyDeathPictureBox);
            this.Controls.Add(this.adventBox);
            this.Controls.Add(this.adventDeathBox);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.adventWinBox);
            this.Controls.Add(this.kingWinBox);
            this.Controls.Add(this.gobWinBox);
            this.Controls.Add(this.playerWinBox);
            this.Controls.Add(this.playerDeathBox);
            this.Controls.Add(this.blackBox);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(1209, 628);
            ((System.ComponentModel.ISupportInitialize)(this.enemyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyWinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyDeathPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDeathBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerWinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reaperBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reaperWinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingWinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventWinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventDeathBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gobBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gobWinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gobDeathBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingDeathBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameEngine;
        private System.Windows.Forms.Timer typingTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.Timer endTimer;
        private System.Windows.Forms.PictureBox enemyBox;
        private System.Windows.Forms.PictureBox playerBox;
        private System.Windows.Forms.PictureBox enemyWinBox;
        private System.Windows.Forms.PictureBox enemyDeathPictureBox;
        private System.Windows.Forms.Label incomingWordsBox;
        private System.Windows.Forms.TextBox typingBox;
        private System.Windows.Forms.Label holdLabel;
        private System.Windows.Forms.Label drawLabel;
        private System.Windows.Forms.Label readyLabel;
        private System.Windows.Forms.Label blackBar1;
        private System.Windows.Forms.Label blackBar2;
        private System.Windows.Forms.Label threeSecondTimerLabel;
        private System.Windows.Forms.Label blackBox;
        private System.Windows.Forms.PictureBox playerDeathBox;
        private System.Windows.Forms.PictureBox playerWinBox;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button retryButton;
        private System.Windows.Forms.TextBox offscreentypingbox;
        private System.Windows.Forms.PictureBox reaperBox;
        private System.Windows.Forms.PictureBox reaperWinBox;
        private System.Windows.Forms.PictureBox kingWinBox;
        private System.Windows.Forms.PictureBox adventBox;
        private System.Windows.Forms.PictureBox adventWinBox;
        private System.Windows.Forms.PictureBox adventDeathBox;
        private System.Windows.Forms.PictureBox gobBox;
        private System.Windows.Forms.PictureBox gobWinBox;
        private System.Windows.Forms.PictureBox gobDeathBox;
        private System.Windows.Forms.PictureBox kingBox;
        private System.Windows.Forms.PictureBox kingDeathBox;
    }
}
