﻿namespace Rental_Kiosk.Views
{
    partial class EndScreen
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
            this.ProgramLogo = new System.Windows.Forms.Label();
            this.NextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProgramLogo
            // 
            this.ProgramLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProgramLogo.AutoSize = true;
            this.ProgramLogo.BackColor = System.Drawing.Color.Transparent;
            this.ProgramLogo.Font = new System.Drawing.Font("McLaren", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramLogo.Location = new System.Drawing.Point(75, 120);
            this.ProgramLogo.Name = "ProgramLogo";
            this.ProgramLogo.Size = new System.Drawing.Size(596, 552);
            this.ProgramLogo.TabIndex = 2;
            this.ProgramLogo.Text = "Thank you for choosing\r\nour servies!\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.ProgramLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProgramLogo.Click += new System.EventHandler(this.ProgramLogo_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NextBtn.Font = new System.Drawing.Font("McLaren", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NextBtn.Location = new System.Drawing.Point(675, 390);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(105, 38);
            this.NextBtn.TabIndex = 3;
            this.NextBtn.Text = "RETURN";
            this.NextBtn.UseVisualStyleBackColor = false;
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rental_Kiosk.Properties.Resources.Intro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.ProgramLogo);
            this.Name = "EndScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EndScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProgramLogo;
        private System.Windows.Forms.Button NextBtn;
    }
}