namespace CheapDeals.comLTD
{
    partial class Form_Billing
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lb_bill_details = new System.Windows.Forms.ListBox();
            this.bt_proceed = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(56, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 86);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Billing";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CheapDeals.comLTD.Properties.Resources.icons8_bill_50;
            this.pictureBox3.Location = new System.Drawing.Point(29, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 59);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::CheapDeals.comLTD.Properties.Resources.icons8_left_arrow_20;
            this.pictureBox5.Location = new System.Drawing.Point(12, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 20);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // lb_bill_details
            // 
            this.lb_bill_details.FormattingEnabled = true;
            this.lb_bill_details.Location = new System.Drawing.Point(27, 192);
            this.lb_bill_details.Name = "lb_bill_details";
            this.lb_bill_details.Size = new System.Drawing.Size(248, 173);
            this.lb_bill_details.TabIndex = 16;
            this.lb_bill_details.SelectedIndexChanged += new System.EventHandler(this.lb_bill_details_SelectedIndexChanged);
            // 
            // bt_proceed
            // 
            this.bt_proceed.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_proceed.ForeColor = System.Drawing.Color.White;
            this.bt_proceed.Location = new System.Drawing.Point(110, 423);
            this.bt_proceed.Margin = new System.Windows.Forms.Padding(2);
            this.bt_proceed.Name = "bt_proceed";
            this.bt_proceed.Size = new System.Drawing.Size(76, 46);
            this.bt_proceed.TabIndex = 17;
            this.bt_proceed.Text = "Confirm";
            this.bt_proceed.UseVisualStyleBackColor = false;
            this.bt_proceed.Click += new System.EventHandler(this.bt_proceed_Click);
            // 
            // Form_Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 595);
            this.Controls.Add(this.bt_proceed);
            this.Controls.Add(this.lb_bill_details);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Billing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListBox lb_bill_details;
        private System.Windows.Forms.Button bt_proceed;
    }
}