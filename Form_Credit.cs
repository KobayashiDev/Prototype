using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CheapDeals.comLTD
{
    public partial class Form_Credit : Form
    {
        public Form_Credit()
        {
            InitializeComponent();
        }

        private void bt_proceed_Click_1(object sender, EventArgs e)
        {
            string cardNumber = textBox1.Text.Trim();
            string expirationDate = textBox4.Text.Trim();

            if (ValidateCardDetails(cardNumber, expirationDate))
            {
                string encryptedCardNumber = SimpleEncrypt(cardNumber);

                // Process the "encrypted" card number (e.g., save to database, send to payment gateway, etc.)
                MessageBox.Show("Payment processed successfully!\nEncrypted Card Number: " + encryptedCardNumber);
                Form_OrderConfirm form_OrderConfirm = new Form_OrderConfirm();
                form_OrderConfirm.ShowDialog();
            }
            this.Hide();
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
    }
}
