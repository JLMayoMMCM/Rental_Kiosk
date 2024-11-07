namespace Rental_Kiosk.Views
{
    partial class Reminders
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
            this.NextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NextBtn
            // 
            this.NextBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NextBtn.Font = new System.Drawing.Font("McLaren", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NextBtn.Location = new System.Drawing.Point(690, 405);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(105, 38);
            this.NextBtn.TabIndex = 1;
            this.NextBtn.Text = "NEXT";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // Reminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rental_Kiosk.Properties.Resources.Intro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextBtn);
            this.Name = "Reminders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RENT-A-THING";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NextBtn;
    }
}