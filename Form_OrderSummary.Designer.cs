namespace CheapDeals.comLTD
{
    partial class Form_OrderSummary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.lb_turn_back = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(3, 52);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(408, 311);
            this.dataGridViewOrder.TabIndex = 0;
            // 
            // lb_turn_back
            // 
            this.lb_turn_back.AutoSize = true;
            this.lb_turn_back.Location = new System.Drawing.Point(12, 20);
            this.lb_turn_back.Name = "lb_turn_back";
            this.lb_turn_back.Size = new System.Drawing.Size(67, 16);
            this.lb_turn_back.TabIndex = 1;
            this.lb_turn_back.Text = "Turn back";
            this.lb_turn_back.Click += new System.EventHandler(this.lb_turn_back_Click);
            // 
            // Form_OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 739);
            this.Controls.Add(this.lb_turn_back);
            this.Controls.Add(this.dataGridViewOrder);
            this.Name = "Form_OrderSummary";
            this.Text = "Form_OrderSummary";
            this.Load += new System.EventHandler(this.Form_OrderSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Label lb_turn_back;
    }
}