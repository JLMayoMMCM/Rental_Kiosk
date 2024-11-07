namespace Rental_Kiosk.Views
{
    partial class ItemRentalView
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
            this.ItemGridRental = new System.Windows.Forms.DataGridView();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.SearchLbl = new System.Windows.Forms.Label();
            this.RentalDaysAmnt = new System.Windows.Forms.ComboBox();
            this.CboLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridRental)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemGridRental
            // 
            this.ItemGridRental.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemGridRental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ItemGridRental.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ItemGridRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGridRental.Location = new System.Drawing.Point(15, 45);
            this.ItemGridRental.Name = "ItemGridRental";
            this.ItemGridRental.Size = new System.Drawing.Size(765, 315);
            this.ItemGridRental.TabIndex = 0;
            // 
            // SearchInput
            // 
            this.SearchInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchInput.Location = new System.Drawing.Point(630, 15);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(145, 20);
            this.SearchInput.TabIndex = 1;
            // 
            // SearchLbl
            // 
            this.SearchLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.BackColor = System.Drawing.Color.Transparent;
            this.SearchLbl.Font = new System.Drawing.Font("McLaren", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLbl.Location = new System.Drawing.Point(570, 15);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(54, 16);
            this.SearchLbl.TabIndex = 2;
            this.SearchLbl.Text = "SEARCH";
            // 
            // RentalDaysAmnt
            // 
            this.RentalDaysAmnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RentalDaysAmnt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RentalDaysAmnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RentalDaysAmnt.FormattingEnabled = true;
            this.RentalDaysAmnt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.RentalDaysAmnt.Location = new System.Drawing.Point(660, 375);
            this.RentalDaysAmnt.Name = "RentalDaysAmnt";
            this.RentalDaysAmnt.Size = new System.Drawing.Size(121, 21);
            this.RentalDaysAmnt.TabIndex = 3;
            // 
            // CboLbl
            // 
            this.CboLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CboLbl.AutoSize = true;
            this.CboLbl.Font = new System.Drawing.Font("McLaren", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboLbl.Location = new System.Drawing.Point(420, 375);
            this.CboLbl.Name = "CboLbl";
            this.CboLbl.Size = new System.Drawing.Size(234, 23);
            this.CboLbl.TabIndex = 4;
            this.CboLbl.Text = "NUMBER OF DAYS TO RENT";
            // 
            // ItemRentalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CboLbl);
            this.Controls.Add(this.RentalDaysAmnt);
            this.Controls.Add(this.SearchLbl);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.ItemGridRental);
            this.Name = "ItemRentalView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ItemRentalView";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemGridRental;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.ComboBox RentalDaysAmnt;
        private System.Windows.Forms.Label CboLbl;
    }
}