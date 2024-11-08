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
            this.CboLbl = new System.Windows.Forms.Label();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.ViewCartBtn = new System.Windows.Forms.Button();
            this.DaysCBO = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridRental)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemGridRental
            // 
            this.ItemGridRental.AllowUserToAddRows = false;
            this.ItemGridRental.AllowUserToDeleteRows = false;
            this.ItemGridRental.AllowUserToResizeColumns = false;
            this.ItemGridRental.AllowUserToResizeRows = false;
            this.ItemGridRental.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemGridRental.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ItemGridRental.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ItemGridRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemGridRental.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ItemGridRental.Location = new System.Drawing.Point(15, 45);
            this.ItemGridRental.MultiSelect = false;
            this.ItemGridRental.Name = "ItemGridRental";
            this.ItemGridRental.ReadOnly = true;
            this.ItemGridRental.Size = new System.Drawing.Size(765, 300);
            this.ItemGridRental.TabIndex = 0;
            this.ItemGridRental.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelItemCart);
            // 
            // SearchInput
            // 
            this.SearchInput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchInput.Location = new System.Drawing.Point(630, 15);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(145, 20);
            this.SearchInput.TabIndex = 1;
            this.SearchInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchInput_TextChanged);
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
            // CboLbl
            // 
            this.CboLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CboLbl.AutoSize = true;
            this.CboLbl.Font = new System.Drawing.Font("McLaren", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboLbl.Location = new System.Drawing.Point(420, 360);
            this.CboLbl.Name = "CboLbl";
            this.CboLbl.Size = new System.Drawing.Size(234, 23);
            this.CboLbl.TabIndex = 4;
            this.CboLbl.Text = "NUMBER OF DAYS TO RENT";
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoutBtn.BackColor = System.Drawing.Color.Crimson;
            this.LogoutBtn.Font = new System.Drawing.Font("McLaren", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Location = new System.Drawing.Point(15, 405);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(120, 30);
            this.LogoutBtn.TabIndex = 5;
            this.LogoutBtn.Text = "LOGOUT";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // ViewCartBtn
            // 
            this.ViewCartBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewCartBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.ViewCartBtn.Font = new System.Drawing.Font("McLaren", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCartBtn.Location = new System.Drawing.Point(15, 360);
            this.ViewCartBtn.Name = "ViewCartBtn";
            this.ViewCartBtn.Size = new System.Drawing.Size(120, 30);
            this.ViewCartBtn.TabIndex = 6;
            this.ViewCartBtn.Text = "VIEW CART";
            this.ViewCartBtn.UseVisualStyleBackColor = false;
            this.ViewCartBtn.Click += new System.EventHandler(this.ViewCart);
            // 
            // DaysCBO
            // 
            this.DaysCBO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DaysCBO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DaysCBO.Font = new System.Drawing.Font("McLaren", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysCBO.FormattingEnabled = true;
            this.DaysCBO.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.DaysCBO.Location = new System.Drawing.Point(660, 360);
            this.DaysCBO.Name = "DaysCBO";
            this.DaysCBO.Size = new System.Drawing.Size(121, 24);
            this.DaysCBO.TabIndex = 7;
            // 
            // ItemRentalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DaysCBO);
            this.Controls.Add(this.ViewCartBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.CboLbl);
            this.Controls.Add(this.SearchLbl);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.ItemGridRental);
            this.Name = "ItemRentalView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ItemRentalView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ItemGridRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemGridRental;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.Label CboLbl;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ViewCartBtn;
        private System.Windows.Forms.ComboBox DaysCBO;
    }
}