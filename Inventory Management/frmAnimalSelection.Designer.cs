namespace Inventory_Management
{
    partial class frmAnimalSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnimalSelection));
            this.lblAnimalType = new System.Windows.Forms.Label();
            this.lstPets = new System.Windows.Forms.ListBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboMonths = new System.Windows.Forms.ComboBox();
            this.lblPickUp = new System.Windows.Forms.Label();
            this.cboYears = new System.Windows.Forms.ComboBox();
            this.lblCatPrice = new System.Windows.Forms.Label();
            this.lblDogPrice = new System.Windows.Forms.Label();
            this.lblLizardPrice = new System.Windows.Forms.Label();
            this.lblSnakePrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAnimalType
            // 
            this.lblAnimalType.AutoSize = true;
            this.lblAnimalType.BackColor = System.Drawing.Color.Transparent;
            this.lblAnimalType.Location = new System.Drawing.Point(16, 28);
            this.lblAnimalType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnimalType.Name = "lblAnimalType";
            this.lblAnimalType.Size = new System.Drawing.Size(86, 17);
            this.lblAnimalType.TabIndex = 0;
            this.lblAnimalType.Text = "Animal Type";
            // 
            // lstPets
            // 
            this.lstPets.FormattingEnabled = true;
            this.lstPets.ItemHeight = 16;
            this.lstPets.Location = new System.Drawing.Point(16, 62);
            this.lstPets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstPets.Name = "lstPets";
            this.lstPets.Size = new System.Drawing.Size(159, 116);
            this.lstPets.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(223, 62);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(132, 22);
            this.txtQuantity.TabIndex = 2;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.Location = new System.Drawing.Point(221, 28);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(51, 318);
            this.btnAdd2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(100, 28);
            this.btnAdd2.TabIndex = 5;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(223, 318);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboMonths
            // 
            this.cboMonths.FormattingEnabled = true;
            this.cboMonths.Location = new System.Drawing.Point(223, 141);
            this.cboMonths.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMonths.Name = "cboMonths";
            this.cboMonths.Size = new System.Drawing.Size(132, 24);
            this.cboMonths.TabIndex = 3;
            // 
            // lblPickUp
            // 
            this.lblPickUp.AutoSize = true;
            this.lblPickUp.BackColor = System.Drawing.Color.Transparent;
            this.lblPickUp.Location = new System.Drawing.Point(223, 100);
            this.lblPickUp.Name = "lblPickUp";
            this.lblPickUp.Size = new System.Drawing.Size(90, 17);
            this.lblPickUp.TabIndex = 7;
            this.lblPickUp.Text = "Pick Up Date";
            // 
            // cboYears
            // 
            this.cboYears.FormattingEnabled = true;
            this.cboYears.Location = new System.Drawing.Point(223, 192);
            this.cboYears.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboYears.Name = "cboYears";
            this.cboYears.Size = new System.Drawing.Size(132, 24);
            this.cboYears.TabIndex = 4;
            // 
            // lblCatPrice
            // 
            this.lblCatPrice.AutoSize = true;
            this.lblCatPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblCatPrice.Location = new System.Drawing.Point(16, 198);
            this.lblCatPrice.Name = "lblCatPrice";
            this.lblCatPrice.Size = new System.Drawing.Size(81, 17);
            this.lblCatPrice.TabIndex = 9;
            this.lblCatPrice.Text = "Cat: $25.00";
            // 
            // lblDogPrice
            // 
            this.lblDogPrice.AutoSize = true;
            this.lblDogPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblDogPrice.Location = new System.Drawing.Point(16, 224);
            this.lblDogPrice.Name = "lblDogPrice";
            this.lblDogPrice.Size = new System.Drawing.Size(86, 17);
            this.lblDogPrice.TabIndex = 10;
            this.lblDogPrice.Text = "Dog: $25.00";
            // 
            // lblLizardPrice
            // 
            this.lblLizardPrice.AutoSize = true;
            this.lblLizardPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblLizardPrice.Location = new System.Drawing.Point(16, 250);
            this.lblLizardPrice.Name = "lblLizardPrice";
            this.lblLizardPrice.Size = new System.Drawing.Size(99, 17);
            this.lblLizardPrice.TabIndex = 11;
            this.lblLizardPrice.Text = "Lizard: $15.00";
            // 
            // lblSnakePrice
            // 
            this.lblSnakePrice.AutoSize = true;
            this.lblSnakePrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSnakePrice.Location = new System.Drawing.Point(16, 275);
            this.lblSnakePrice.Name = "lblSnakePrice";
            this.lblSnakePrice.Size = new System.Drawing.Size(100, 17);
            this.lblSnakePrice.TabIndex = 12;
            this.lblSnakePrice.Text = "Snake: $10.00";
            // 
            // frmAnimalSelection
            // 
            this.AcceptButton = this.btnAdd2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(405, 364);
            this.Controls.Add(this.lblSnakePrice);
            this.Controls.Add(this.lblLizardPrice);
            this.Controls.Add(this.lblDogPrice);
            this.Controls.Add(this.lblCatPrice);
            this.Controls.Add(this.cboYears);
            this.Controls.Add(this.lblPickUp);
            this.Controls.Add(this.cboMonths);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd2);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lstPets);
            this.Controls.Add(this.lblAnimalType);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAnimalSelection";
            this.Text = "Animal Selection";
            this.Load += new System.EventHandler(this.frmAnimalSelection_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimalType;
        private System.Windows.Forms.ListBox lstPets;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboMonths;
        private System.Windows.Forms.Label lblPickUp;
        private System.Windows.Forms.ComboBox cboYears;
        private System.Windows.Forms.Label lblCatPrice;
        private System.Windows.Forms.Label lblDogPrice;
        private System.Windows.Forms.Label lblLizardPrice;
        private System.Windows.Forms.Label lblSnakePrice;
    }
}