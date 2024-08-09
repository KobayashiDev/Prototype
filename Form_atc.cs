using System;
using System.Data;
using System.Windows.Forms;

namespace CheapDeals.comLTD
{
    public partial class Form_atc : Form
    {
        private product_detail previousForm;
        public Form_atc(product_detail formProductDetail)
        {
            InitializeComponent();
            previousForm = formProductDetail;
            this.Load += new EventHandler(Form_atc_Load);
            this.Delete.Click += new EventHandler(Delete_Click);
        }

        private void Form_atc_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }
        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();
            // Define and add columns
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Type", "Type");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("DebutDate", "Debut Date");
            dataGridView1.Columns.Add("Description", "Description");
        }
        public void AddProductDetail(string name, string type, string price, string debutDate, string description)
        {

            dataGridView1.Rows.Add(name, type, price, debutDate, description);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dataGridView1.Rows.Remove(row);
                    }
                }
                MessageBox.Show("Row deleted successfully.");
            }
        }
        public DataTable GetCartDetails()
        {
            DataTable dt = new DataTable();

            // Add columns to DataTable
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.Name, typeof(string)); // Assuming all columns are of string type
            }

            // Add rows to DataTable
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow) // Skip the new row placeholder
                {
                    DataRow dRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value?.ToString(); // Assign cell value
                    }
                    dt.Rows.Add(dRow);
                }
            }

            return dt;
        }
        private void bt_buy_now_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the cart details from the current form
                DataTable cartDetails = GetCartDetails();

                if (cartDetails.Rows.Count > 0)
                {
                    this.Hide();
                    // Create and show the order summary form
                    Form_OrderSummary formOrderSummary = new Form_OrderSummary(this);
                    formOrderSummary.LoadOrderDetails(cartDetails);
                    formOrderSummary.ShowDialog(); // Show the form as a modal dialog


                }
                else
                {
                    MessageBox.Show("Your cart is empty.", "No Items in Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_atc_Load_1(object sender, EventArgs e)
        {

        }

        private void lb_back_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}
