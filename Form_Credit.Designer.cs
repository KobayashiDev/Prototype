namespace CheapDeals.comLTD
{
    partial class Form_Credit
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bt_proceed = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(27, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 45);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CheapDeals.comLTD.Properties.Resources.icons8_card_20;
            this.pictureBox1.Location = new System.Drawing.Point(3, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(27, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 45);
            this.panel2.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(29, 15);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(222, 20);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "MM/YY";
            this.textBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CheapDeals.comLTD.Properties.Resources.icons8_calendar_20;
            this.pictureBox2.Location = new System.Drawing.Point(3, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // bt_proceed
            // 
            this.bt_proceed.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_proceed.ForeColor = System.Drawing.Color.White;
            this.bt_proceed.Location = new System.Drawing.Point(167, 335);
            this.bt_proceed.Margin = new System.Windows.Forms.Padding(2);
            this.bt_proceed.Name = "bt_proceed";
            this.bt_proceed.Size = new System.Drawing.Size(76, 46);
            this.bt_proceed.TabIndex = 8;
            this.bt_proceed.Text = "Proceed";
            this.bt_proceed.UseVisualStyleBackColor = false;
            this.bt_proceed.Click += new System.EventHandler(this.bt_proceed_Click_1);
            // 
            // bt_reset
            // 
            this.bt_reset.BackColor = System.Drawing.Color.Red;
            this.bt_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_reset.ForeColor = System.Drawing.Color.White;
            this.bt_reset.Location = new System.Drawing.Point(68, 335);
            this.bt_reset.Margin = new System.Windows.Forms.Padding(2);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(76, 46);
            this.bt_reset.TabIndex = 9;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = false;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::CheapDeals.comLTD.Properties.Resources.icons8_left_arrow_20;
            this.pictureBox5.Location = new System.Drawing.Point(12, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 20);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::CheapDeals.comLTD.Properties.Resources.icons8_mastercard_100;
            this.pictureBox4.Location = new System.Drawing.Point(167, 83);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(101, 88);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CheapDeals.comLTD.Properties.Resources.icons8_visa_100;
            this.pictureBox3.Location = new System.Drawing.Point(43, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(101, 88);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // Form_Credit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 634);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_proceed);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Credit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Credit";
            this.Load += new System.EventHandler(this.Form_Credit_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button bt_proceed;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}