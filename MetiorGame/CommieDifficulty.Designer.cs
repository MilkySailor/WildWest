namespace MetiorGame
{
    partial class CommieDifficulty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommieDifficulty));
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.medButton = new System.Windows.Forms.Button();
            this.easyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(134, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 63);
            this.label1.TabIndex = 9;
            this.label1.Text = "медиорит";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(366, 538);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(103, 39);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.Location = new System.Drawing.Point(194, 406);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(153, 64);
            this.hardButton.TabIndex = 7;
            this.hardButton.Text = "жесткий";
            this.hardButton.UseVisualStyleBackColor = true;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click);
            // 
            // medButton
            // 
            this.medButton.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medButton.Location = new System.Drawing.Point(194, 276);
            this.medButton.Name = "medButton";
            this.medButton.Size = new System.Drawing.Size(153, 64);
            this.medButton.TabIndex = 6;
            this.medButton.Text = "середина";
            this.medButton.UseVisualStyleBackColor = true;
            this.medButton.Click += new System.EventHandler(this.medButton_Click);
            // 
            // easyButton
            // 
            this.easyButton.Font = new System.Drawing.Font("OCR A Extended", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.Location = new System.Drawing.Point(194, 156);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(153, 64);
            this.easyButton.TabIndex = 5;
            this.easyButton.Text = "легкий";
            this.easyButton.UseVisualStyleBackColor = true;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // CommieDifficulty
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
            this.Name = "CommieDifficulty";
            this.Size = new System.Drawing.Size(545, 634);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button medButton;
        private System.Windows.Forms.Button easyButton;
    }
}
