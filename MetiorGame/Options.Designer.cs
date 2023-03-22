﻿namespace MetiorGame
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.menuButton = new System.Windows.Forms.Button();
            this.solvietButton = new System.Windows.Forms.Button();
            this.englishButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(192, 492);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(156, 75);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "Back";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // solvietButton
            // 
            this.solvietButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solvietButton.Location = new System.Drawing.Point(189, 80);
            this.solvietButton.Name = "solvietButton";
            this.solvietButton.Size = new System.Drawing.Size(159, 71);
            this.solvietButton.TabIndex = 2;
            this.solvietButton.Text = "Soviet Mode";
            this.solvietButton.UseVisualStyleBackColor = true;
            this.solvietButton.Click += new System.EventHandler(this.solvietButton_Click);
            // 
            // englishButton
            // 
            this.englishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishButton.Location = new System.Drawing.Point(189, 197);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(159, 49);
            this.englishButton.TabIndex = 3;
            this.englishButton.Text = "English";
            this.englishButton.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.englishButton);
            this.Controls.Add(this.solvietButton);
            this.Controls.Add(this.menuButton);
            this.Name = "Options";
            this.Size = new System.Drawing.Size(545, 634);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button solvietButton;
        private System.Windows.Forms.Button englishButton;
    }
}
