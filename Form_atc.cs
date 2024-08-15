using System;
using System.Data;
using System.Windows.Forms;

namespace CheapDeals.comLTD
{
    public partial class Form_atc : Form
    {
        private product_detail previousForm;
        public DataTable cartTable;  // DataTable to store cart items

        public Form_atc(product_detail formProductDetail)
        {
            InitializeComponent();
            previousForm = formProductDetail;
            cartTable = new DataTable(); // Initialize DataTable

            this.Load += new EventHandler(Form_atc_Load);
            this.Delete.Click += new EventHandler(Delete_Click);
            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);

            // Initialize DataTable columns to match DataGridView
            cartTable.Columns.Add("Name", typeof(string));
            cartTable.Columns.Add("Type", typeof(string));
            cartTable.Columns.Add("Price", typeof(string));
            cartTable.Columns.Add("DebutDate", typeof(string));
            cartTable.Columns.Add("FreeMinute", typeof(int));
            cartTable.Columns.Add("FreeSMS", typeof(int));
            cartTable.Columns.Add("FreeGB", typeof(int));
            cartTable.Columns.Add("Request", typeof(string));
            cartTable.Columns.Add("Description", typeof(string));
        }

        private void Form_atc_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            LoadCartData(); // Load existing cart data into the DataGridView
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();
            // Define and add columns
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Type", "Type");
            dataGridView1.Columns.Add("Price", "Price");
            dataGridView1.Columns.Add("DebutDate", "Debut Date");
            dataGridView1.Columns.Add("FreeMinute", "Free Minute");
            dataGridView1.Columns.Add("FreeSMS", "Free SMS");
            dataGridView1.Columns.Add("FreeGB", "Free GB");
            dataGridView1.Columns.Add("Request", "Request");
            dataGridView1.Columns.Add("Description", "Description");
        }

        // Method to add product details to the DataGridView
        public void AddProductDetail(string name, string type, string price, string debutDate, int freeMinute, int freeSMS, int freeGB, string request, string description)
        {
            // Add product to DataTable
            DataRow newRow = cartTable.NewRow();
            newRow["Name"] = name;
            newRow["Type"] = type;
            newRow["Price"] = price;
            newRow["DebutDate"] = debutDate;
            newRow["FreeMinute"] = freeMinute;
            newRow["FreeSMS"] = freeSMS;
            newRow["FreeGB"] = freeGB;
            newRow["Request"] = request;
            newRow["Description"] = description;
            cartTable.Rows.Add(newRow);

            // Add product to DataGridView
            dataGridView1.Rows.Add(name, type, price, debutDate, freeMinute, freeSMS, freeGB, request, description);

            
        }

        // Method to load the cart data into DataGridView when the form is loaded
        private void LoadCartData()
        {
            foreach (DataRow row in cartTable.Rows)
            {
                dataGridView1.Rows.Add(row["Name"], row["Type"], row["Price"], row["DebutDate"], row["FreeMinute"], row["FreeSMS"], row["FreeGB"], row["Request"], row["Description"]);
            }
        }

        // Delete selected rows from the DataGridView and DataTable
        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        // Remove row from DataTable
                        string nameToDelete = row.Cells["Name"].Value.ToString();
                        DataRow[] rowsToDelete = cartTable.Select($"Name = '{nameToDelete}'");
                        foreach (DataRow dr in rowsToDelete)
                        {
                            cartTable.Rows.Remove(dr);
                        }

                        // Remove row from DataGridView
                        dataGridView1.Rows.Remove(row);
                    }
                }
                MessageBox.Show("Row deleted successfully.");
            }
        }

        public DataTable GetCartDetails()
        {
            return cartTable.Copy(); // Return a copy of the cart data
        }



        private void pictureBox5_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Hide();
        }

        // In Form_atc
        private void bt_proceed_Click(object sender, EventArgs e)
        {
            DataTable cartDetails = GetCartDetails();
            if (cartDetails.Rows.Count > 0)
            {
                using (Form_OrderSummary formOrderSummary = new Form_OrderSummary(this))
                {
                    formOrderSummary.LoadOrderDetails(cartDetails);
                    formOrderSummary.ShowDialog(); // Show the form as a modal dialog

                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Your cart is empty.", "No Items in Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a valid row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate the textboxes with the values from the selected row
                cart_freeminute.Text = row.Cells["FreeMinute"].Value?.ToString();
                cart_freesms.Text = row.Cells["FreeSMS"].Value?.ToString();
                cart_freegb.Text = row.Cells["FreeGB"].Value?.ToString();
                cart_request.Text = row.Cells["Request"].Value?.ToString();
                cart_description.Text = row.Cells["Description"].Value?.ToString();
            }
        }
        private void btn_customize_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Update the selected row in the DataGridView with the new values from the textboxes
                selectedRow.Cells["FreeMinute"].Value = cart_freeminute.Text;
                selectedRow.Cells["FreeSMS"].Value = cart_freesms.Text;
                selectedRow.Cells["FreeGB"].Value = cart_freegb.Text;
                selectedRow.Cells["Request"].Value = cart_request.Text;
                selectedRow.Cells["Description"].Value = cart_description.Text;

                // Update the corresponding DataRow in the DataTable
                string nameToUpdate = selectedRow.Cells["Name"].Value.ToString();
                DataRow[] rowsToUpdate = cartTable.Select($"Name = '{nameToUpdate}'");
                if (rowsToUpdate.Length > 0)
                {
                    DataRow row = rowsToUpdate[0];
                    row["FreeMinute"] = cart_freeminute.Text;
                    row["FreeSMS"] = cart_freesms.Text;
                    row["FreeGB"] = cart_freegb.Text;
                    row["Request"] = cart_request.Text;
                    row["Description"] = cart_description.Text;
                }

                MessageBox.Show("Row updated successfully.");
            }
            else
            {
                MessageBox.Show("Please select a row to customize.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
