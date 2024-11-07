namespace Rental_Kiosk.Views
{
    partial class CheckoutScreen
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
            this.CartOrderSmmry = new System.Windows.Forms.DataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ProceedBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CartOrderSmmry)).BeginInit();
            this.SuspendLayout();
            // 
            // CartOrderSmmry
            // 
            this.CartOrderSmmry.AllowUserToAddRows = false;
            this.CartOrderSmmry.AllowUserToDeleteRows = false;
            this.CartOrderSmmry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartOrderSmmry.Location = new System.Drawing.Point(210, 75);
            this.CartOrderSmmry.Name = "CartOrderSmmry";
            this.CartOrderSmmry.ReadOnly = true;
            this.CartOrderSmmry.Size = new System.Drawing.Size(375, 240);
            this.CartOrderSmmry.TabIndex = 0;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(225, 330);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(165, 38);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "DELETE ITEM";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteItem);
            // 
            // ProceedBtn
            // 
            this.ProceedBtn.Location = new System.Drawing.Point(405, 330);
            this.ProceedBtn.Name = "ProceedBtn";
            this.ProceedBtn.Size = new System.Drawing.Size(165, 38);
            this.ProceedBtn.TabIndex = 2;
            this.ProceedBtn.Text = "CONFIRM RENTAL";
            this.ProceedBtn.UseVisualStyleBackColor = true;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(15, 405);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(165, 38);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "BACK";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.ReturnToGrid);
            // 
            // CheckoutScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rental_Kiosk.Properties.Resources.Intro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.ProceedBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CartOrderSmmry);
            this.Name = "CheckoutScreen";
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.CartOrderSmmry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CartOrderSmmry;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ProceedBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}