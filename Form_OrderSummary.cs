﻿using System;
using System.Data;
using System.Windows.Forms;

namespace CheapDeals.comLTD
{
    public partial class Form_OrderSummary : Form
    {
        private Form_atc previousForm; // Store reference to previous form
        private DataTable cartTable; // CartTable to store order details

        public Form_OrderSummary(Form_atc formAtc)
        {
            InitializeComponent();
            SetupDataGridView(); // Setup DataGridView when form is initialized
            previousForm = formAtc; // Initialize the reference
            cartTable = formAtc.cartTable; // Initialize cartTable with the data from previous form
        }

        private void Form_OrderSummary_Load(object sender, EventArgs e)
        {
            // Any additional setup if required when form loads
        }

        private void SetupDataGridView()
        {
            dataGridViewOrder.Columns.Clear(); // Clear existing columns
            // Define and add columns
            dataGridViewOrder.Columns.Add("Name", "Name");
            dataGridViewOrder.Columns.Add("Type", "Type");
            dataGridViewOrder.Columns.Add("Price", "Price");
            dataGridViewOrder.Columns.Add("DebutDate", "Debut Date");
            dataGridViewOrder.Columns.Add("FreeMinute", "Free Minute");
            dataGridViewOrder.Columns.Add("FreeSMS", "Free SMS");
            dataGridViewOrder.Columns.Add("FreeGB", "Free GB");
            dataGridViewOrder.Columns.Add("Request", "Request");
            dataGridViewOrder.Columns.Add("Description", "Description");
        }

        public void LoadOrderDetails(DataTable orderDetails)
        {
            dataGridViewOrder.Rows.Clear(); // Clear existing rows
            foreach (DataRow row in orderDetails.Rows)
            {
                dataGridViewOrder.Rows.Add(row["Name"], row["Type"], row["Price"], row["DebutDate"], row["Description"], row["FreeMinute"], 
                    row["FreeSMS"], row["FreeGB"], row["Request"]);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            // Show the previous form
            if (previousForm != null)
            {
                previousForm.Show(); // Show the previous form
            }
            this.Close(); // Close the current form
        }

        private void bt_proceed_Click(object sender, EventArgs e)
        {
            try
            {
                // Check which radio button is selected
                if (rb_phone.Checked)
                {
                    MessageBox.Show("Phone payment option selected. Proceeding with phone payment...");
                    Form_Billing form_Billing = new Form_Billing(cartTable);
                    form_Billing.ShowDialog();
                }
                else if (rb_credit.Checked)
                {
                    MessageBox.Show("Credit card payment option selected. Proceeding with credit card payment...");

                    // Pass the cart data to Form_Credit
                    Form_Credit form_Credit = new Form_Credit(cartTable); // Pass cartTable to Form_Credit
                    form_Credit.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a payment option.", "No Payment Option Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
