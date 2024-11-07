namespace Rental_Kiosk.Views
{
    partial class SplashScreen
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
            this.TapPrompt = new System.Windows.Forms.Label();
            this.ProgramLogo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TapPrompt
            // 
            this.TapPrompt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TapPrompt.AutoSize = true;
            this.TapPrompt.BackColor = System.Drawing.Color.Transparent;
            this.TapPrompt.Font = new System.Drawing.Font("McLaren", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TapPrompt.Location = new System.Drawing.Point(244, 319);
            this.TapPrompt.Name = "TapPrompt";
            this.TapPrompt.Size = new System.Drawing.Size(334, 46);
            this.TapPrompt.TabIndex = 0;
            this.TapPrompt.Text = "TAP TO CONTINUE";
            this.TapPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TapPrompt.Click += new System.EventHandler(this.LoginTransition);
            // 
            // ProgramLogo
            // 
            this.ProgramLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProgramLogo.AutoSize = true;
            this.ProgramLogo.BackColor = System.Drawing.Color.Transparent;
            this.ProgramLogo.Font = new System.Drawing.Font("McLaren", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramLogo.Location = new System.Drawing.Point(207, 75);
            this.ProgramLogo.Name = "ProgramLogo";
            this.ProgramLogo.Size = new System.Drawing.Size(408, 69);
            this.ProgramLogo.TabIndex = 1;
            this.ProgramLogo.Text = "RENT-A-THING";
            this.ProgramLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rental_Kiosk.Properties.Resources.Intro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProgramLogo);
            this.Controls.Add(this.TapPrompt);
            this.Name = "SplashScreen";
            this.Text = "Rent-A-Thing";
            this.Click += new System.EventHandler(this.LoginTransition);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TapPrompt;
        private System.Windows.Forms.Label ProgramLogo;
    }
}