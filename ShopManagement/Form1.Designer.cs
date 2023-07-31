namespace ShopManagement
{
    partial class frmTaxCollector
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTaxNo = new System.Windows.Forms.Label();
            this.txtTaxNo = new System.Windows.Forms.TextBox();
            this.lblTaxSlab = new System.Windows.Forms.Label();
            this.cmbTaxSlab = new System.Windows.Forms.ComboBox();
            this.lblIncome = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.lblFinalTax = new System.Windows.Forms.Label();
            this.lblTaxResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTaxNo
            // 
            this.lblTaxNo.AutoSize = true;
            this.lblTaxNo.Location = new System.Drawing.Point(27, 31);
            this.lblTaxNo.Name = "lblTaxNo";
            this.lblTaxNo.Size = new System.Drawing.Size(184, 20);
            this.lblTaxNo.TabIndex = 0;
            this.lblTaxNo.Text = "Enter Tax Identification No";
            // 
            // txtTaxNo
            // 
            this.txtTaxNo.Location = new System.Drawing.Point(275, 31);
            this.txtTaxNo.MaxLength = 16;
            this.txtTaxNo.Name = "txtTaxNo";
            this.txtTaxNo.Size = new System.Drawing.Size(220, 27);
            this.txtTaxNo.TabIndex = 1;
            // 
            // lblTaxSlab
            // 
            this.lblTaxSlab.AutoSize = true;
            this.lblTaxSlab.Location = new System.Drawing.Point(27, 87);
            this.lblTaxSlab.Name = "lblTaxSlab";
            this.lblTaxSlab.Size = new System.Drawing.Size(89, 20);
            this.lblTaxSlab.TabIndex = 3;
            this.lblTaxSlab.Text = "Tax Slab (%)";
            // 
            // cmbTaxSlab
            // 
            this.cmbTaxSlab.FormattingEnabled = true;
            this.cmbTaxSlab.Items.AddRange(new object[] {
            "10",
            "20",
            "30"});
            this.cmbTaxSlab.Location = new System.Drawing.Point(275, 87);
            this.cmbTaxSlab.Name = "cmbTaxSlab";
            this.cmbTaxSlab.Size = new System.Drawing.Size(220, 28);
            this.cmbTaxSlab.TabIndex = 4;
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(27, 155);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(58, 20);
            this.lblIncome.TabIndex = 5;
            this.lblIncome.Text = "Income";
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(275, 152);
            this.txtIncome.MaxLength = 500;
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(220, 27);
            this.txtIncome.TabIndex = 6;
            // 
            // lblFinalTax
            // 
            this.lblFinalTax.AutoSize = true;
            this.lblFinalTax.Location = new System.Drawing.Point(27, 221);
            this.lblFinalTax.Name = "lblFinalTax";
            this.lblFinalTax.Size = new System.Drawing.Size(65, 20);
            this.lblFinalTax.TabIndex = 7;
            this.lblFinalTax.Text = "Final Tax";
            // 
            // lblTaxResult
            // 
            this.lblTaxResult.AutoSize = true;
            this.lblTaxResult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTaxResult.Location = new System.Drawing.Point(275, 204);
            this.lblTaxResult.Name = "lblTaxResult";
            this.lblTaxResult.Size = new System.Drawing.Size(129, 41);
            this.lblTaxResult.TabIndex = 8;
            this.lblTaxResult.Text = "Final Tax";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calculate Tax";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTaxCollector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTaxResult);
            this.Controls.Add(this.lblFinalTax);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.lblIncome);
            this.Controls.Add(this.cmbTaxSlab);
            this.Controls.Add(this.lblTaxSlab);
            this.Controls.Add(this.txtTaxNo);
            this.Controls.Add(this.lblTaxNo);
            this.Name = "frmTaxCollector";
            this.Text = "Tax Collector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTaxNo;
        private TextBox txtTaxNo;
        private Label lblTaxSlab;
        private ComboBox cmbTaxSlab;
        private Label lblIncome;
        private TextBox txtIncome;
        private Label lblFinalTax;
        private Label lblTaxResult;
        private Button button1;
    }
}