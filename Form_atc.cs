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

            // Initialize DataTable columns to match DataGridView
            cartTable.Columns.Add("Name", typeof(string));
            cartTable.Columns.Add("Type", typeof(string));
            cartTable.Columns.Add("Price", typeof(string));
            cartTable.Columns.Add("DebutDate", typeof(string));
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
            dataGridView1.Columns.Add("Description", "Description");
        }

        // Method to add product details to the DataGridView
        public void AddProductDetail(string name, string type, string price, string debutDate, string description)
        {
            // Add product to DataTable
            DataRow newRow = cartTable.NewRow();
            newRow["Name"] = name;
            newRow["Type"] = type;
            newRow["Price"] = price;
            newRow["DebutDate"] = debutDate;
            newRow["Description"] = description;
            cartTable.Rows.Add(newRow);

            // Add product to DataGridView
            dataGridView1.Rows.Add(name, type, price, debutDate, description);

            
        }

        // Method to load the cart data into DataGridView when the form is loaded
        private void LoadCartData()
        {
            foreach (DataRow row in cartTable.Rows)
            {
                dataGridView1.Rows.Add(row["Name"], row["Type"], row["Price"], row["DebutDate"], row["Description"]);
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


    }
}
