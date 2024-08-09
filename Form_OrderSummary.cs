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
    public partial class Form_OrderSummary : Form
    {
        private Form_atc previousForm;
        public Form_OrderSummary(Form_atc formAtc)
        {
            InitializeComponent();
            previousForm = formAtc;
        }

        private void Form_OrderSummary_Load(object sender, EventArgs e)
        {

        }
        public void LoadOrderDetails(DataTable orderDetails)
        {
            // Assuming you have a DataGridView named 'dataGridViewOrder'
            dataGridViewOrder.DataSource = orderDetails;
        }

        private void lb_turn_back_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }
    }
}