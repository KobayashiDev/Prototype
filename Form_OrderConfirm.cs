using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheapDeals.comLTD
{
    public partial class Form_OrderConfirm : Form
    {
        private DataTable cartTable;
        public Form_OrderConfirm()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Create a new instance of Form_Credit
            main_system main_System = new main_system();
            main_System.Show();

            // Close the current form
            this.Close();

        }
    }
}
