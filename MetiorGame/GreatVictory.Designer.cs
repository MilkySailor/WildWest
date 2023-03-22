namespace MetiorGame
{
    partial class GreatVictory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GreatVictory));
            this.winLabel = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.retryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.Yellow;
            this.winLabel.Location = new System.Drawing.Point(75, 16);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(377, 238);
            this.winLabel.TabIndex = 6;
            this.winLabel.Text = "ты заставил Сталина гордиться товарищ";
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.menuButton.Location = new System.Drawing.Point(301, 569);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(151, 50);
            this.menuButton.TabIndex = 10;
            this.menuButton.Text = "меню";
            this.menuButton.UseVisualStyleBackColor = true;
            // 
            // retryButton
            // 
            this.retryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.retryButton.Location = new System.Drawing.Point(70, 569);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(151, 50);
            this.retryButton.TabIndex = 9;
            this.retryButton.Text = "снова";
            this.retryButton.UseVisualStyleBackColor = true;
            // 
            // GreatVictory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.winLabel);
            this.Name = "GreatVictory";
            this.Size = new System.Drawing.Size(545, 634);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button retryButton;
    }
}
