namespace Capirig_Week05_Work04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Button events
            btnSave.Click += btnSave_Click;
            btnClear.Click += btnClear_Click;
            btnCancel.Click += btnCancel_Click;

            // Input events
            txtCost.TextChanged += CalculateMarkup;
            txtPrice.TextChanged += CalculateMarkup;
            txtBarcode.TextChanged += txtBarcode_TextChanged;

            // Category options
            cmbCategory.Items.AddRange(new string[]
            {
                "Electronics",
                "Food",
                "Clothing",
                "Furniture",
                "Accessories",
                "Others"
            });

            txtMarkup.ReadOnly = true;
        }

        // Calculate markup percentage
        private void CalculateMarkup(object sender, EventArgs e)
        {
            decimal cost, price;

            if (decimal.TryParse(txtCost.Text, out cost) &&
                decimal.TryParse(txtPrice.Text, out price) &&
                cost > 0 && price >= 0)
            {
                decimal markup = ((price - cost) / cost) * 100;
                txtMarkup.Text = markup.ToString("0.00");
            }
            else
            {
                txtMarkup.Clear();
            }
        }

        // Barcode validation
        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                lblBarcodeStatus.Text = "Barcode is required";
                lblBarcodeStatus.ForeColor =
                    System.Drawing.Color.Red;
            }
            else
            {
                lblBarcodeStatus.Text = "Barcode is available";
                lblBarcodeStatus.ForeColor =
                    System.Drawing.Color.Green;
            }
        }

        // Save button
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Required fields
            if (string.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                MessageBox.Show("Please enter a barcode.");
                txtBarcode.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter the product name.");
                txtName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter a description.");
                txtDescription.Focus();
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.");
                cmbCategory.Focus();
                return;
            }

            if (!rdoLocal.Checked && !rdoAbroad.Checked)
            {
                MessageBox.Show("Please select the product origin.");
                return;
            }

            // Number validation
            decimal cost, price;

            if (!decimal.TryParse(txtCost.Text, out cost) || cost <= 0)
            {
                MessageBox.Show("Please enter a valid cost greater than zero.");
                txtCost.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.");
                txtPrice.Focus();
                return;
            }

            // Calculate markup
            decimal markup = ((price - cost) / cost) * 100;

            // Get origin
            string origin = rdoLocal.Checked ? "Local" : "Abroad";

            // Display saved information
            string productInfo =
                "PRODUCT SAVED SUCCESSFULLY!\n\n" +
                "Barcode: " + txtBarcode.Text + "\n" +
                "Name: " + txtName.Text + "\n" +
                "Description: " + txtDescription.Text + "\n" +
                "Category: " + cmbCategory.Text + "\n" +
                "Origin: " + origin + "\n" +
                "Status: " + (chkActive.Checked ? "Active" : "Inactive") + "\n" +
                "Cost: " + cost.ToString("N2") + "\n" +
                "Price: " + price.ToString("N2") + "\n" +
                "Markup: " + markup.ToString("0.00") + "%";

            MessageBox.Show(
                productInfo,
                "Product Information",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBarcode.Clear();
            txtName.Clear();
            txtDescription.Clear();
            cmbCategory.SelectedIndex = -1;

            rdoLocal.Checked = false;
            rdoAbroad.Checked = false;

            chkActive.Checked = false;

            txtCost.Clear();
            txtPrice.Clear();
            txtMarkup.Clear();

            txtBarcode.Focus();
        }

        // Cancel button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel?",
                "Confirm Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

        }
    }
}