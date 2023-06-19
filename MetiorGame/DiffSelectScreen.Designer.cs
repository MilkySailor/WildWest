namespace MetiorGame
{
    partial class DiffSelectScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiffSelectScreen));
            this.hardButton = new System.Windows.Forms.Button();
            this.easyButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.tutorialButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.Color.Cornsilk;
            this.hardButton.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.Location = new System.Drawing.Point(935, 82);
            this.hardButton.Margin = new System.Windows.Forms.Padding(2);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(159, 71);
            this.hardButton.TabIndex = 1;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.Color.Cornsilk;
            this.easyButton.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.Location = new System.Drawing.Point(83, 82);
            this.easyButton.Margin = new System.Windows.Forms.Padding(2);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(159, 71);
            this.easyButton.TabIndex = 2;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click_1);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = System.Drawing.Color.Cornsilk;
            this.mediumButton.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.Location = new System.Drawing.Point(513, 82);
            this.mediumButton.Margin = new System.Windows.Forms.Padding(2);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(159, 71);
            this.mediumButton.TabIndex = 3;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click_1);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Cornsilk;
            this.backButton.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(439, 483);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(159, 75);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // tutorialButton
            // 
            this.tutorialButton.BackColor = System.Drawing.Color.Cornsilk;
            this.tutorialButton.Font = new System.Drawing.Font("Poor Richard", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorialButton.Location = new System.Drawing.Point(633, 483);
            this.tutorialButton.Margin = new System.Windows.Forms.Padding(2);
            this.tutorialButton.Name = "tutorialButton";
            this.tutorialButton.Size = new System.Drawing.Size(159, 75);
            this.tutorialButton.TabIndex = 5;
            this.tutorialButton.Text = "Tutorial";
            this.tutorialButton.UseVisualStyleBackColor = false;
            this.tutorialButton.Click += new System.EventHandler(this.tutorialButton_Click);
            // 
            // DiffSelectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tutorialButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.hardButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DiffSelectScreen";
            this.Size = new System.Drawing.Size(1212, 630);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button tutorialButton;
    }
}
