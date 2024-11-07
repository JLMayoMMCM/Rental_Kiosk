namespace Rental_Kiosk.Views
{
    partial class LoginScreen
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
            this.LoginIDInput = new System.Windows.Forms.TextBox();
            this.LoginBoxLabel = new System.Windows.Forms.Label();
            this.LoginIDBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginIDInput
            // 
            this.LoginIDInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginIDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginIDInput.Location = new System.Drawing.Point(280, 317);
            this.LoginIDInput.MaxLength = 10;
            this.LoginIDInput.Name = "LoginIDInput";
            this.LoginIDInput.Size = new System.Drawing.Size(240, 31);
            this.LoginIDInput.TabIndex = 0;
            // 
            // LoginBoxLabel
            // 
            this.LoginBoxLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginBoxLabel.AutoSize = true;
            this.LoginBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBoxLabel.Location = new System.Drawing.Point(277, 300);
            this.LoginBoxLabel.Name = "LoginBoxLabel";
            this.LoginBoxLabel.Size = new System.Drawing.Size(108, 13);
            this.LoginBoxLabel.TabIndex = 1;
            this.LoginBoxLabel.Text = "ENTER ID HERE:";
            this.LoginBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginIDBtn
            // 
            this.LoginIDBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginIDBtn.Location = new System.Drawing.Point(280, 366);
            this.LoginIDBtn.Name = "LoginIDBtn";
            this.LoginIDBtn.Size = new System.Drawing.Size(240, 31);
            this.LoginIDBtn.TabIndex = 2;
            this.LoginIDBtn.Text = "LOGIN ID";
            this.LoginIDBtn.UseVisualStyleBackColor = true;
            this.LoginIDBtn.Click += new System.EventHandler(this.LoginIDBtn_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rental_Kiosk.Properties.Resources.Intro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LoginIDBtn);
            this.Controls.Add(this.LoginBoxLabel);
            this.Controls.Add(this.LoginIDInput);
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginIDInput;
        private System.Windows.Forms.Label LoginBoxLabel;
        private System.Windows.Forms.Button LoginIDBtn;
    }
}