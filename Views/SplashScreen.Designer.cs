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
            this.ProgramLogo = new System.Windows.Forms.Label();
            this.LendBtn = new System.Windows.Forms.Button();
            this.RentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProgramLogo
            // 
            this.ProgramLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProgramLogo.AutoSize = true;
            this.ProgramLogo.BackColor = System.Drawing.Color.Transparent;
            this.ProgramLogo.Font = new System.Drawing.Font("McLaren", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramLogo.Location = new System.Drawing.Point(195, 75);
            this.ProgramLogo.Name = "ProgramLogo";
            this.ProgramLogo.Size = new System.Drawing.Size(408, 69);
            this.ProgramLogo.TabIndex = 1;
            this.ProgramLogo.Text = "RENT-A-THING";
            this.ProgramLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LendBtn
            // 
            this.LendBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LendBtn.Font = new System.Drawing.Font("McLaren", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LendBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LendBtn.Location = new System.Drawing.Point(295, 240);
            this.LendBtn.Name = "LendBtn";
            this.LendBtn.Size = new System.Drawing.Size(210, 68);
            this.LendBtn.TabIndex = 2;
            this.LendBtn.Text = "LEND";
            this.LendBtn.UseVisualStyleBackColor = false;
            this.LendBtn.Click += new System.EventHandler(this.LendBtn_Click);
            // 
            // RentBtn
            // 
            this.RentBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RentBtn.Font = new System.Drawing.Font("McLaren", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RentBtn.Location = new System.Drawing.Point(295, 330);
            this.RentBtn.Name = "RentBtn";
            this.RentBtn.Size = new System.Drawing.Size(210, 68);
            this.RentBtn.TabIndex = 3;
            this.RentBtn.Text = "RENT";
            this.RentBtn.UseVisualStyleBackColor = false;
            this.RentBtn.Click += new System.EventHandler(this.RentBtn_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rental_Kiosk.Properties.Resources.Intro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RentBtn);
            this.Controls.Add(this.LendBtn);
            this.Controls.Add(this.ProgramLogo);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rent-A-Thing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ProgramLogo;
        private System.Windows.Forms.Button LendBtn;
        private System.Windows.Forms.Button RentBtn;
    }
}