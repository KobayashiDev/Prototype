using System;
using System.Data;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Text;
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
                        string address = details[2];
                        string email = details[1];
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
                lb_bill_details.Items.Add($"FreeSMS: {row["FreeSMS"]}");
                lb_bill_details.Items.Add($"FreeMinute: {row["FreeMinute"]}");
                lb_bill_details.Items.Add($"FreeGB :{row["FreeGB"]}");
                lb_bill_details.Items.Add($"Request: {row["Request"]}");
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
            // Lấy và lọc nội dung từ ListBox theo từ khóa
            string filteredBillDetails = GetFilteredListBoxItems();

            // Kiểm tra nếu nội dung không rỗng
            if (string.IsNullOrEmpty(filteredBillDetails))
            {
                MessageBox.Show("No relevant billing details to send.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SendEmail(filteredBillDetails);

            Form_OrderConfirm form_OrderConfirm = new Form_OrderConfirm();
            form_OrderConfirm.ShowDialog();

            this.Hide();
        }

        private string GetFilteredListBoxItems()
        {
            StringBuilder sb = new StringBuilder();
            bool lastWasProductNameOrRequest = false;

            // Duyệt qua tất cả các mục trong ListBox
            foreach (var item in lb_bill_details.Items)
            {
                string itemText = item.ToString();

                // Kiểm tra nếu dòng chứa cả "Product Name" hoặc "Request"
                if (itemText.Contains("Product Name") || itemText.Contains("Request") || itemText.Contains("Name") || itemText.Contains("Email") || itemText.Contains("Phone"))
                {
                    // Thêm một dòng trắng nếu dòng trước đó cũng chứa "Product Name" hoặc "Request"
                    if (lastWasProductNameOrRequest)
                    {
                        sb.AppendLine(); // Thêm một dòng trắng để phân cách
                    }

                    sb.AppendLine(itemText);
                    lastWasProductNameOrRequest = true; // Đánh dấu dòng hiện tại là "Product Name" hoặc "Request"
                }
                else
                {
                    lastWasProductNameOrRequest = false; // Đánh dấu dòng hiện tại không phải là "Product Name" hoặc "Request"
                }
            }

            return sb.ToString();
        }





        private void SendEmail(string billDetails)
        {
            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress(UserSession.CurrentUserEmail), // Địa chỉ email của người gửi
                    Subject = "Customer request",
                    Body = billDetails,
                    IsBodyHtml = false // Đảm bảo nội dung email được gửi dưới dạng Plain Text
                };

                // Địa chỉ email người nhận
                mail.To.Add("doantheduong150902004@gmail.com");

                // Cấu hình SMTP server
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("trunghack999@gmail.com", "qdch rbza dwzy ottt"),
                    EnableSsl = true
                };

                // Gửi email
                smtpServer.Send(mail);

                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






    }
}
