namespace Inventory_Management
{
    partial class frmInvMgmt
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
            this.lstBoxAnimals = new System.Windows.Forms.ListBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTotalPriceOutput = new System.Windows.Forms.TextBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxAnimals
            // 
            this.lstBoxAnimals.FormattingEnabled = true;
            this.lstBoxAnimals.ItemHeight = 20;
            this.lstBoxAnimals.Location = new System.Drawing.Point(18, 46);
            this.lstBoxAnimals.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstBoxAnimals.Name = "lstBoxAnimals";
            this.lstBoxAnimals.Size = new System.Drawing.Size(648, 244);
            this.lstBoxAnimals.TabIndex = 0;
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(14, 14);
            this.lblAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(65, 20);
            this.lblAnimal.TabIndex = 1;
            this.lblAnimal.Text = "Animals";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 326);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 63);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Animal";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(168, 326);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 63);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear All Animals";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(18, 429);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 63);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Total";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(168, 429);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 63);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTotalPriceOutput
            // 
            this.txtTotalPriceOutput.Location = new System.Drawing.Point(466, 446);
            this.txtTotalPriceOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalPriceOutput.Name = "txtTotalPriceOutput";
            this.txtTotalPriceOutput.ReadOnly = true;
            this.txtTotalPriceOutput.Size = new System.Drawing.Size(148, 26);
            this.txtTotalPriceOutput.TabIndex = 6;
            this.txtTotalPriceOutput.TabStop = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(350, 451);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(83, 20);
            this.lblTotalPrice.TabIndex = 7;
            this.lblTotalPrice.Text = "Total Price";
            // 
            // frmInvMgmt
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(688, 538);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.txtTotalPriceOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.lstBoxAnimals);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInvMgmt";
            this.Text = "Inventory Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxAnimals;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTotalPriceOutput;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}

