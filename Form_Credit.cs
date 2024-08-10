using System;
using System.Data;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CheapDeals.comLTD
{
    public partial class Form_Credit : Form
    {
        private DataTable cartTable;

        public Form_Credit(DataTable cart)
        {
            InitializeComponent();
            this.cartTable = cart ?? throw new ArgumentNullException(nameof(cart), "Cart data cannot be null.");
        }



        private void bt_proceed_Click_1(object sender, EventArgs e)
        {
            try
            {
                string cardNumber = textBox1.Text.Trim();
                string expirationDate = textBox4.Text.Trim(); // Ensure textBox4 contains expiration date

                if (ValidateCardDetails(cardNumber, expirationDate))
                {
                    string encryptedCardNumber = SimpleEncrypt(cardNumber);

                    // Process the "encrypted" card number
                    MessageBox.Show("Payment processed successfully!\nEncrypted Card Number: " + encryptedCardNumber);

                    // Show the billing form with the cart details
                    Form_Billing form_Billing = new Form_Billing(cartTable);
                    form_Billing.ShowDialog();

                    // Hide the current form
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid card details. Please check and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private bool ValidateCardDetails(string cardNumber, string expirationDate)
        {
            if (!IsValidCardNumber(cardNumber))
            {
                MessageBox.Show("Invalid card number.");
                return false;
            }

            if (!IsValidExpirationDate(expirationDate))
            {
                MessageBox.Show("Invalid or expired expiration date.");
                return false;
            }

            return true;
        }

        private bool IsValidCardNumber(string cardNumber)
        {
            cardNumber = cardNumber.Replace(" ", "").Replace("-", "");

            if (!Regex.IsMatch(cardNumber, @"^\d{16}$"))
                return false;

            int sum = 0;
            bool alternate = false;
            for (int i = cardNumber.Length - 1; i >= 0; i--)
            {
                int n = int.Parse(cardNumber[i].ToString());
                if (alternate)
                {
                    n *= 2;
                    if (n > 9)
                        n -= 9;
                }
                sum += n;
                alternate = !alternate;
            }

            return (sum % 10 == 0);
        }

        private bool IsValidExpirationDate(string expirationDate)
        {
            if (DateTime.TryParseExact(expirationDate, "MM/yy", null, System.Globalization.DateTimeStyles.None, out DateTime expDate))
            {
                if (expDate > DateTime.Now)
                    return true;
            }

            return false;
        }

        private string SimpleEncrypt(string data)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            return Convert.ToBase64String(dataBytes);
        }

        private void bt_reset_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
        }

        private void textBox1_Click(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "Card Number")
            {
                textBox1.Clear();
            }
        }

        private void textBox2_Click(object sender, MouseEventArgs e)
        {
            if (textBox4.Text == "MM/YY")
            {
                textBox4.Clear();
            }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Credit_Load_1(object sender, EventArgs e)
        {
            try
            {
                // Load user details from 'DataUser.txt'
                string[] userLines = File.ReadAllLines("DataUser.txt");

                if (userLines.Length > 0)
                {
                    string[] details = userLines[0].Split(',');
                    if (details.Length >= 5)
                    {
                        string name = details[0];
                        string address = details[1];
                        string email = details[2];
                        string phone = details[3];
                        string card = details[4];

                        // Display the card number in textBox1
                        textBox1.Text = card;
                    }
                    else
                    {
                        MessageBox.Show("Incorrect format in DataUser.txt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No user data found in DataUser.txt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("DataUser.txt file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
