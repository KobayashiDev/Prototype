using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CheapDeals.comLTD
{
    public partial class Form_Billing : Form
    {
        private DataTable cartTable;

        public Form_Billing(DataTable cart)
        {
            InitializeComponent();
            this.cartTable = cart ?? throw new ArgumentNullException(nameof(cart), "Cart data cannot be null.");
            LoadBillingDetails();
        }

        private void LoadBillingDetails()
        {
            try
            {
                // Load user details from 'DataUser.txt'
                string[] userLines = File.ReadAllLines("DataUser.txt");
                foreach (string line in userLines)
                {
                    string[] details = line.Split(',');
                    if (details.Length >= 5)
                    {
                        string name = details[0];
                        string address = details[1];
                        string email = details[2];
                        string phone = details[3];
                        string card = details[4];

                        lb_bill_details.Items.Add($"Name: {name}");
                        lb_bill_details.Items.Add($"Address: {address}");
                        lb_bill_details.Items.Add($"Email: {email}");
                        lb_bill_details.Items.Add($"Phone: {phone}");
                        lb_bill_details.Items.Add($"Card Number: {card}");
                        lb_bill_details.Items.Add("--------------------");  // Separator for readability
                    }
                    else
                    {
                        MessageBox.Show("Incorrect format in DataUser.txt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("DataUser.txt file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load user details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Load cart details into the ListBox
            foreach (DataRow row in cartTable.Rows)
            {
                lb_bill_details.Items.Add($"Product Name: {row["Name"]}");
                lb_bill_details.Items.Add($"Type: {row["Type"]}");
                lb_bill_details.Items.Add($"Price: {row["Price"]}");
                lb_bill_details.Items.Add($"Debut Date: {row["DebutDate"]}");
                lb_bill_details.Items.Add($"Description: {row["Description"]}");
                lb_bill_details.Items.Add("--------------------");  // Separator for readability
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        private void lb_bill_details_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle selection changes if necessary
        }

        private void bt_proceed_Click(object sender, EventArgs e)
        {
            Form_OrderConfirm form_OrderConfirm = new Form_OrderConfirm();
            form_OrderConfirm.ShowDialog();

            this.Hide();
        }
    }
}
