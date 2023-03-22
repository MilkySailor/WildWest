namespace MetiorGame
{
    partial class Win
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win));
            this.winLabel = new System.Windows.Forms.Label();
            this.retryButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.gif = new System.Windows.Forms.PictureBox();
            this.gifTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gif)).BeginInit();
            this.SuspendLayout();
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.winLabel.Location = new System.Drawing.Point(120, 34);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(279, 63);
            this.winLabel.TabIndex = 5;
            this.winLabel.Text = "You Win";
            // 
            // retryButton
            // 
            this.retryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.retryButton.Location = new System.Drawing.Point(79, 494);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(151, 50);
            this.retryButton.TabIndex = 7;
            this.retryButton.Text = "Restart";
            this.retryButton.UseVisualStyleBackColor = true;
            this.retryButton.Click += new System.EventHandler(this.retryButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.menuButton.Location = new System.Drawing.Point(310, 494);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(151, 50);
            this.menuButton.TabIndex = 8;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // gif
            // 
            this.gif.BackColor = System.Drawing.Color.Transparent;
            this.gif.Image = ((System.Drawing.Image)(resources.GetObject("gif.Image")));
            this.gif.InitialImage = ((System.Drawing.Image)(resources.GetObject("gif.InitialImage")));
            this.gif.Location = new System.Drawing.Point(68, 100);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(408, 388);
            this.gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gif.TabIndex = 9;
            this.gif.TabStop = false;
            // 
            // gifTimer
            // 
            this.gifTimer.Tick += new System.EventHandler(this.gifTimer_Tick);
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.gif);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.winLabel);
            this.Name = "Win";
            this.Size = new System.Drawing.Size(545, 634);
            ((System.ComponentModel.ISupportInitialize)(this.gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Button retryButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.PictureBox gif;
        private System.Windows.Forms.Timer gifTimer;
    }
}
