namespace Assignment2
{
    partial class Form1
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
            this.LocalGroceryApplicationlabel = new System.Windows.Forms.Label();
            this.outputGroceryListBox = new System.Windows.Forms.ListBox();
            this.loadingDataGroupBox = new System.Windows.Forms.GroupBox();
            this.loadGroceryDataButton = new System.Windows.Forms.Button();
            this.updateDataGroupBox = new System.Windows.Forms.GroupBox();
            this.updateSoldQtyTextBox = new System.Windows.Forms.TextBox();
            this.soldQtyLabel = new System.Windows.Forms.Label();
            this.updateSoldQtyButton = new System.Windows.Forms.Button();
            this.restockedQtyLabel = new System.Windows.Forms.Label();
            this.restockedQtyTextBox = new System.Windows.Forms.TextBox();
            this.updateRestockedQtyButton = new System.Windows.Forms.Button();
            this.savingDataGroupBox = new System.Windows.Forms.GroupBox();
            this.saveGroceryDataButton = new System.Windows.Forms.Button();
            this.saveSalesReportButton = new System.Windows.Forms.Button();
            this.saveRestockNeedReportsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.loadingDataGroupBox.SuspendLayout();
            this.updateDataGroupBox.SuspendLayout();
            this.savingDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocalGroceryApplicationlabel
            // 
            this.LocalGroceryApplicationlabel.Location = new System.Drawing.Point(568, 19);
            this.LocalGroceryApplicationlabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.LocalGroceryApplicationlabel.Name = "LocalGroceryApplicationlabel";
            this.LocalGroceryApplicationlabel.Size = new System.Drawing.Size(325, 35);
            this.LocalGroceryApplicationlabel.TabIndex = 0;
            this.LocalGroceryApplicationlabel.Text = "Local Grocery Application";
            this.LocalGroceryApplicationlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputGroceryListBox
            // 
            this.outputGroceryListBox.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputGroceryListBox.FormattingEnabled = true;
            this.outputGroceryListBox.ItemHeight = 18;
            this.outputGroceryListBox.Location = new System.Drawing.Point(2, 98);
            this.outputGroceryListBox.Name = "outputGroceryListBox";
            this.outputGroceryListBox.Size = new System.Drawing.Size(1796, 184);
            this.outputGroceryListBox.TabIndex = 1;
            // 
            // loadingDataGroupBox
            // 
            this.loadingDataGroupBox.BackColor = System.Drawing.Color.Coral;
            this.loadingDataGroupBox.Controls.Add(this.loadGroceryDataButton);
            this.loadingDataGroupBox.Location = new System.Drawing.Point(84, 319);
            this.loadingDataGroupBox.Name = "loadingDataGroupBox";
            this.loadingDataGroupBox.Size = new System.Drawing.Size(279, 160);
            this.loadingDataGroupBox.TabIndex = 2;
            this.loadingDataGroupBox.TabStop = false;
            this.loadingDataGroupBox.Text = "Loading Data";
            // 
            // loadGroceryDataButton
            // 
            this.loadGroceryDataButton.Location = new System.Drawing.Point(17, 51);
            this.loadGroceryDataButton.Name = "loadGroceryDataButton";
            this.loadGroceryDataButton.Size = new System.Drawing.Size(205, 47);
            this.loadGroceryDataButton.TabIndex = 0;
            this.loadGroceryDataButton.Text = "Load Grocery Data";
            this.loadGroceryDataButton.UseVisualStyleBackColor = true;
            this.loadGroceryDataButton.Click += new System.EventHandler(this.loadGroceryDataButton_Click);
            // 
            // updateDataGroupBox
            // 
            this.updateDataGroupBox.BackColor = System.Drawing.Color.Coral;
            this.updateDataGroupBox.Controls.Add(this.deleteItemButton);
            this.updateDataGroupBox.Controls.Add(this.updateRestockedQtyButton);
            this.updateDataGroupBox.Controls.Add(this.restockedQtyTextBox);
            this.updateDataGroupBox.Controls.Add(this.restockedQtyLabel);
            this.updateDataGroupBox.Controls.Add(this.updateSoldQtyButton);
            this.updateDataGroupBox.Controls.Add(this.soldQtyLabel);
            this.updateDataGroupBox.Controls.Add(this.updateSoldQtyTextBox);
            this.updateDataGroupBox.Location = new System.Drawing.Point(422, 319);
            this.updateDataGroupBox.Name = "updateDataGroupBox";
            this.updateDataGroupBox.Size = new System.Drawing.Size(627, 188);
            this.updateDataGroupBox.TabIndex = 3;
            this.updateDataGroupBox.TabStop = false;
            this.updateDataGroupBox.Text = "Update Data";
            // 
            // updateSoldQtyTextBox
            // 
            this.updateSoldQtyTextBox.Location = new System.Drawing.Point(131, 38);
            this.updateSoldQtyTextBox.Name = "updateSoldQtyTextBox";
            this.updateSoldQtyTextBox.Size = new System.Drawing.Size(100, 26);
            this.updateSoldQtyTextBox.TabIndex = 0;
            // 
            // soldQtyLabel
            // 
            this.soldQtyLabel.Location = new System.Drawing.Point(10, 38);
            this.soldQtyLabel.Name = "soldQtyLabel";
            this.soldQtyLabel.Size = new System.Drawing.Size(115, 23);
            this.soldQtyLabel.TabIndex = 1;
            this.soldQtyLabel.Text = "Quantity Sold";
            // 
            // updateSoldQtyButton
            // 
            this.updateSoldQtyButton.Location = new System.Drawing.Point(27, 74);
            this.updateSoldQtyButton.Name = "updateSoldQtyButton";
            this.updateSoldQtyButton.Size = new System.Drawing.Size(213, 63);
            this.updateSoldQtyButton.TabIndex = 2;
            this.updateSoldQtyButton.Text = "Update Sold Quantity For Selected Item";
            this.updateSoldQtyButton.UseVisualStyleBackColor = true;
            this.updateSoldQtyButton.Click += new System.EventHandler(this.updateSoldQtyButton_Click);
            // 
            // restockedQtyLabel
            // 
            this.restockedQtyLabel.AutoSize = true;
            this.restockedQtyLabel.Location = new System.Drawing.Point(293, 38);
            this.restockedQtyLabel.Name = "restockedQtyLabel";
            this.restockedQtyLabel.Size = new System.Drawing.Size(142, 20);
            this.restockedQtyLabel.TabIndex = 3;
            this.restockedQtyLabel.Text = "restockedQtyLabel";
            // 
            // restockedQtyTextBox
            // 
            this.restockedQtyTextBox.Location = new System.Drawing.Point(475, 35);
            this.restockedQtyTextBox.Name = "restockedQtyTextBox";
            this.restockedQtyTextBox.Size = new System.Drawing.Size(100, 26);
            this.restockedQtyTextBox.TabIndex = 4;
            // 
            // updateRestockedQtyButton
            // 
            this.updateRestockedQtyButton.Location = new System.Drawing.Point(359, 74);
            this.updateRestockedQtyButton.Name = "updateRestockedQtyButton";
            this.updateRestockedQtyButton.Size = new System.Drawing.Size(227, 63);
            this.updateRestockedQtyButton.TabIndex = 5;
            this.updateRestockedQtyButton.Text = "Update Restocked Quantity For Selected Item";
            this.updateRestockedQtyButton.UseVisualStyleBackColor = true;
            this.updateRestockedQtyButton.Click += new System.EventHandler(this.updateRestockedQtyButton_Click);
            // 
            // savingDataGroupBox
            // 
            this.savingDataGroupBox.BackColor = System.Drawing.Color.Coral;
            this.savingDataGroupBox.Controls.Add(this.saveRestockNeedReportsButton);
            this.savingDataGroupBox.Controls.Add(this.saveSalesReportButton);
            this.savingDataGroupBox.Controls.Add(this.saveGroceryDataButton);
            this.savingDataGroupBox.Location = new System.Drawing.Point(1104, 319);
            this.savingDataGroupBox.Name = "savingDataGroupBox";
            this.savingDataGroupBox.Size = new System.Drawing.Size(289, 188);
            this.savingDataGroupBox.TabIndex = 4;
            this.savingDataGroupBox.TabStop = false;
            this.savingDataGroupBox.Text = "Saving Data";
            // 
            // saveGroceryDataButton
            // 
            this.saveGroceryDataButton.Location = new System.Drawing.Point(29, 38);
            this.saveGroceryDataButton.Name = "saveGroceryDataButton";
            this.saveGroceryDataButton.Size = new System.Drawing.Size(254, 38);
            this.saveGroceryDataButton.TabIndex = 0;
            this.saveGroceryDataButton.Text = "Save Grocery Data";
            this.saveGroceryDataButton.UseVisualStyleBackColor = true;
            this.saveGroceryDataButton.Click += new System.EventHandler(this.saveGroceryDataButton_Click);
            // 
            // saveSalesReportButton
            // 
            this.saveSalesReportButton.Location = new System.Drawing.Point(29, 94);
            this.saveSalesReportButton.Name = "saveSalesReportButton";
            this.saveSalesReportButton.Size = new System.Drawing.Size(234, 27);
            this.saveSalesReportButton.TabIndex = 1;
            this.saveSalesReportButton.Text = "Save Sales Report";
            this.saveSalesReportButton.UseVisualStyleBackColor = true;
            this.saveSalesReportButton.Click += new System.EventHandler(this.saveSalesReportButton_Click);
            // 
            // saveRestockNeedReportsButton
            // 
            this.saveRestockNeedReportsButton.Location = new System.Drawing.Point(29, 137);
            this.saveRestockNeedReportsButton.Name = "saveRestockNeedReportsButton";
            this.saveRestockNeedReportsButton.Size = new System.Drawing.Size(234, 45);
            this.saveRestockNeedReportsButton.TabIndex = 2;
            this.saveRestockNeedReportsButton.Text = "Save Restock Need Report";
            this.saveRestockNeedReportsButton.UseVisualStyleBackColor = true;
            this.saveRestockNeedReportsButton.Click += new System.EventHandler(this.saveRestockNeedReportsButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(611, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(8, 8);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.SkyBlue;
            this.statusLabel.Location = new System.Drawing.Point(381, 521);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(787, 65);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Operation Status Update Displayed Here";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(144, 144);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(355, 38);
            this.deleteItemButton.TabIndex = 6;
            this.deleteItemButton.Text = "Delete Selected Grocery Item";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1810, 604);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.savingDataGroupBox);
            this.Controls.Add(this.updateDataGroupBox);
            this.Controls.Add(this.loadingDataGroupBox);
            this.Controls.Add(this.outputGroceryListBox);
            this.Controls.Add(this.LocalGroceryApplicationlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.loadingDataGroupBox.ResumeLayout(false);
            this.updateDataGroupBox.ResumeLayout(false);
            this.updateDataGroupBox.PerformLayout();
            this.savingDataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LocalGroceryApplicationlabel;
        private System.Windows.Forms.ListBox outputGroceryListBox;
        private System.Windows.Forms.GroupBox loadingDataGroupBox;
        private System.Windows.Forms.Button loadGroceryDataButton;
        private System.Windows.Forms.GroupBox updateDataGroupBox;
        private System.Windows.Forms.Button updateRestockedQtyButton;
        private System.Windows.Forms.TextBox restockedQtyTextBox;
        private System.Windows.Forms.Label restockedQtyLabel;
        private System.Windows.Forms.Button updateSoldQtyButton;
        private System.Windows.Forms.Label soldQtyLabel;
        private System.Windows.Forms.TextBox updateSoldQtyTextBox;
        private System.Windows.Forms.GroupBox savingDataGroupBox;
        private System.Windows.Forms.Button saveRestockNeedReportsButton;
        private System.Windows.Forms.Button saveSalesReportButton;
        private System.Windows.Forms.Button saveGroceryDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button deleteItemButton;
    }
}

