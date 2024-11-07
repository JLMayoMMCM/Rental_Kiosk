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
            this.BackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalCostDsply = new System.Windows.Forms.TextBox();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CartOrderSmmry)).BeginInit();
            this.SuspendLayout();
            // 
            // CartOrderSmmry
            // 
            this.CartOrderSmmry.AllowUserToAddRows = false;
            this.CartOrderSmmry.AllowUserToDeleteRows = false;
            this.CartOrderSmmry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CartOrderSmmry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.CartOrderSmmry.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CartOrderSmmry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartOrderSmmry.Location = new System.Drawing.Point(30, 75);
            this.CartOrderSmmry.Name = "CartOrderSmmry";
            this.CartOrderSmmry.ReadOnly = true;
            this.CartOrderSmmry.Size = new System.Drawing.Size(390, 270);
            this.CartOrderSmmry.TabIndex = 0;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteBtn.BackColor = System.Drawing.Color.Crimson;
            this.DeleteBtn.Font = new System.Drawing.Font("McLaren", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(450, 285);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(150, 38);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "DELETE ITEM";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteItem);
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackBtn.Font = new System.Drawing.Font("McLaren", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BackBtn.Location = new System.Drawing.Point(15, 405);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(165, 38);
            this.BackBtn.TabIndex = 3;
            this.BackBtn.Text = "BACK";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.ReturnToGrid);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("McLaren", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "TOTAL COST";
            // 
            // TotalCostDsply
            // 
            this.TotalCostDsply.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalCostDsply.Font = new System.Drawing.Font("McLaren", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostDsply.Location = new System.Drawing.Point(450, 165);
            this.TotalCostDsply.Name = "TotalCostDsply";
            this.TotalCostDsply.ReadOnly = true;
            this.TotalCostDsply.Size = new System.Drawing.Size(315, 99);
            this.TotalCostDsply.TabIndex = 5;
            this.TotalCostDsply.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConfirmBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.ConfirmBtn.Font = new System.Drawing.Font("McLaren", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmBtn.Location = new System.Drawing.Point(615, 285);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(150, 38);
            this.ConfirmBtn.TabIndex = 6;
            this.ConfirmBtn.Text = "CONFIRM RENT";
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.Complete_Order);
            // 
            // CheckoutScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rental_Kiosk.Properties.Resources.Intro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.TotalCostDsply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.CartOrderSmmry);
            this.Name = "CheckoutScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.CartOrderSmmry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CartOrderSmmry;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TotalCostDsply;
        private System.Windows.Forms.Button ConfirmBtn;
    }
}