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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_credit = new System.Windows.Forms.RadioButton();
            this.rb_phone = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_proceed = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(2, 109);
            this.dataGridViewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(317, 203);
            this.dataGridViewOrder.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.rb_credit);
            this.groupBox1.Controls.Add(this.rb_phone);
            this.groupBox1.Location = new System.Drawing.Point(28, 424);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 100);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Options";
            // 
            // rb_credit
            // 
            this.rb_credit.AutoSize = true;
            this.rb_credit.Location = new System.Drawing.Point(18, 64);
            this.rb_credit.Name = "rb_credit";
            this.rb_credit.Size = new System.Drawing.Size(107, 17);
            this.rb_credit.TabIndex = 1;
            this.rb_credit.TabStop = true;
            this.rb_credit.Text = "          Credit Card";
            this.rb_credit.UseVisualStyleBackColor = true;
            // 
            // rb_phone
            // 
            this.rb_phone.AutoSize = true;
            this.rb_phone.Location = new System.Drawing.Point(18, 32);
            this.rb_phone.Name = "rb_phone";
            this.rb_phone.Size = new System.Drawing.Size(86, 17);
            this.rb_phone.TabIndex = 0;
            this.rb_phone.TabStop = true;
            this.rb_phone.Text = "          Phone";
            this.rb_phone.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(67, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(170, 59);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Confirm";
            // 
            // bt_proceed
            // 
            this.bt_proceed.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_proceed.ForeColor = System.Drawing.Color.White;
            this.bt_proceed.Location = new System.Drawing.Point(193, 541);
            this.bt_proceed.Margin = new System.Windows.Forms.Padding(2);
            this.bt_proceed.Name = "bt_proceed";
            this.bt_proceed.Size = new System.Drawing.Size(76, 46);
            this.bt_proceed.TabIndex = 15;
            this.bt_proceed.Text = "Proceed";
            this.bt_proceed.UseVisualStyleBackColor = false;
            this.bt_proceed.Click += new System.EventHandler(this.bt_proceed_Click);
            // 
            // bt_back
            // 
            this.bt_back.BackColor = System.Drawing.Color.Red;
            this.bt_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_back.ForeColor = System.Drawing.Color.White;
            this.bt_back.Location = new System.Drawing.Point(46, 541);
            this.bt_back.Margin = new System.Windows.Forms.Padding(2);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(76, 46);
            this.bt_back.TabIndex = 16;
            this.bt_back.Text = "Back To Cart";
            this.bt_back.UseVisualStyleBackColor = false;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CheapDeals.comLTD.Properties.Resources.icons8_order_50;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 62);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CheapDeals.comLTD.Properties.Resources.icons8_phone_20;
            this.pictureBox2.Location = new System.Drawing.Point(39, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 20);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CheapDeals.comLTD.Properties.Resources.icons8_card_20;
            this.pictureBox1.Location = new System.Drawing.Point(39, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 20);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::CheapDeals.comLTD.Properties.Resources.icons8_left_arrow_20;
            this.pictureBox5.Location = new System.Drawing.Point(12, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 20);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // Form_OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 634);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_proceed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.dataGridViewOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_OrderSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_OrderSummary";
            this.Load += new System.EventHandler(this.Form_OrderSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rb_credit;
        private System.Windows.Forms.RadioButton rb_phone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button bt_proceed;
        private System.Windows.Forms.Button bt_back;
    }
}