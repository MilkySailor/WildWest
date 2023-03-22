namespace MetiorGame
{
    partial class difficulty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(difficulty));
            this.easyButton = new System.Windows.Forms.Button();
            this.medButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // easyButton
            // 
            this.easyButton.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.easyButton.Location = new System.Drawing.Point(188, 172);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(153, 64);
            this.easyButton.TabIndex = 0;
            this.easyButton.Text = "Easy";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // medButton
            // 
            this.medButton.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.medButton.Location = new System.Drawing.Point(188, 288);
            this.medButton.Name = "medButton";
            this.medButton.Size = new System.Drawing.Size(153, 64);
            this.medButton.TabIndex = 1;
            this.medButton.Text = "Medium";
            this.medButton.UseVisualStyleBackColor = true;
            this.medButton.Click += new System.EventHandler(this.medButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.Font = new System.Drawing.Font("OCR A Extended", 12F);
            this.hardButton.Location = new System.Drawing.Point(188, 404);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(153, 64);
            this.hardButton.TabIndex = 2;
            this.hardButton.Text = "Hard";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(391, 565);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(103, 39);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(100, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "Meteorite";
            // 
            // difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.medButton);
            this.Controls.Add(this.easyButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "difficulty";
            this.Size = new System.Drawing.Size(545, 634);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button medButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label1;
    }
}
