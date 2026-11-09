namespace Capirig_Week05_Work04
{
    partial class Form1
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
            lblBarcodeStatus = new Label();
            lblName = new Label();
            lblDescription = new Label();
            lblCategory = new Label();
            lblOrigin = new Label();
            lblManufactured = new Label();
            lblStatus = new Label();
            lblCost = new Label();
            lblPrice = new Label();
            lblMarkup = new Label();
            txtBarcode = new TextBox();
            txtName = new TextBox();
            txtDescription = new TextBox();
            lblBarcodStatus = new Label();
            cmbCategory = new ComboBox();
            rdoLocal = new RadioButton();
            rdoAbroad = new RadioButton();
            chkActive = new CheckBox();
            txtCost = new TextBox();
            txtPrice = new TextBox();
            txtMarkup = new TextBox();
            btnCancel = new Button();
            btnClear = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblBarcodeStatus
            // 
            lblBarcodeStatus.AutoSize = true;
            lblBarcodeStatus.Location = new Point(144, 48);
            lblBarcodeStatus.Name = "lblBarcodeStatus";
            lblBarcodeStatus.Size = new Size(50, 15);
            lblBarcodeStatus.TabIndex = 0;
            lblBarcodeStatus.Text = "Barcode";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(144, 96);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(143, 138);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(144, 190);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category";
            // 
            // lblOrigin
            // 
            lblOrigin.AutoSize = true;
            lblOrigin.Location = new Point(143, 218);
            lblOrigin.Name = "lblOrigin";
            lblOrigin.Size = new Size(40, 15);
            lblOrigin.TabIndex = 4;
            lblOrigin.Text = "Origin";
            // 
            // lblManufactured
            // 
            lblManufactured.AutoSize = true;
            lblManufactured.Location = new Point(257, 218);
            lblManufactured.Name = "lblManufactured";
            lblManufactured.Size = new Size(82, 15);
            lblManufactured.TabIndex = 5;
            lblManufactured.Text = "Manufactured";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(142, 262);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.Location = new Point(144, 309);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(31, 15);
            lblCost.TabIndex = 7;
            lblCost.Text = "Cost";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(257, 309);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // lblMarkup
            // 
            lblMarkup.AutoSize = true;
            lblMarkup.Location = new Point(387, 309);
            lblMarkup.Name = "lblMarkup";
            lblMarkup.Size = new Size(69, 15);
            lblMarkup.TabIndex = 9;
            lblMarkup.Text = "Markup (%)";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(257, 45);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(199, 23);
            txtBarcode.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(257, 93);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 23);
            txtName.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(257, 122);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(199, 57);
            txtDescription.TabIndex = 12;
            // 
            // lblBarcodStatus
            // 
            lblBarcodStatus.AutoSize = true;
            lblBarcodStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBarcodStatus.Location = new Point(257, 75);
            lblBarcodStatus.Name = "lblBarcodStatus";
            lblBarcodStatus.Size = new Size(112, 15);
            lblBarcodStatus.TabIndex = 13;
            lblBarcodStatus.Text = "Barcode is available";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(259, 190);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(197, 23);
            cmbCategory.TabIndex = 14;
            // 
            // rdoLocal
            // 
            rdoLocal.AutoSize = true;
            rdoLocal.Location = new Point(259, 248);
            rdoLocal.Name = "rdoLocal";
            rdoLocal.Size = new Size(53, 19);
            rdoLocal.TabIndex = 15;
            rdoLocal.TabStop = true;
            rdoLocal.Text = "Local";
            rdoLocal.UseVisualStyleBackColor = true;
            // 
            // rdoAbroad
            // 
            rdoAbroad.AutoSize = true;
            rdoAbroad.Location = new Point(359, 248);
            rdoAbroad.Name = "rdoAbroad";
            rdoAbroad.Size = new Size(64, 19);
            rdoAbroad.TabIndex = 16;
            rdoAbroad.TabStop = true;
            rdoAbroad.Text = "Abroad";
            rdoAbroad.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(260, 284);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(59, 19);
            chkActive.TabIndex = 17;
            chkActive.Text = "Active";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(144, 336);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(100, 23);
            txtCost.TabIndex = 18;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(257, 336);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 19;
            // 
            // txtMarkup
            // 
            txtMarkup.Location = new Point(366, 336);
            txtMarkup.Name = "txtMarkup";
            txtMarkup.Size = new Size(100, 23);
            txtMarkup.TabIndex = 20;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(151, 391);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(282, 391);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(387, 391);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 23;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 454);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnCancel);
            Controls.Add(txtMarkup);
            Controls.Add(txtPrice);
            Controls.Add(txtCost);
            Controls.Add(chkActive);
            Controls.Add(rdoAbroad);
            Controls.Add(rdoLocal);
            Controls.Add(cmbCategory);
            Controls.Add(lblBarcodStatus);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtBarcode);
            Controls.Add(lblMarkup);
            Controls.Add(lblPrice);
            Controls.Add(lblCost);
            Controls.Add(lblStatus);
            Controls.Add(lblManufactured);
            Controls.Add(lblOrigin);
            Controls.Add(lblCategory);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(lblBarcodeStatus);
            Name = "Form1";
            Text = "Product Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBarcodeStatus;
        private Label lblName;
        private Label lblDescription;
        private Label lblCategory;
        private Label lblOrigin;
        private Label lblManufactured;
        private Label lblStatus;
        private Label lblCost;
        private Label lblPrice;
        private Label lblMarkup;
        private TextBox txtBarcode;
        private TextBox txtName;
        private TextBox txtDescription;
        private Label lblBarcodStatus;
        private ComboBox cmbCategory;
        private RadioButton rdoLocal;
        private RadioButton rdoAbroad;
        private CheckBox chkActive;
        private TextBox txtCost;
        private TextBox txtPrice;
        private TextBox txtMarkup;
        private Button btnCancel;
        private Button btnClear;
        private Button btnSave;
    }
}
