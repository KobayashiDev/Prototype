namespace CheapDeals.comLTD
{
    partial class Form_atc
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cheapDealsDataSet = new CheapDeals.comLTD.CheapDealsDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new CheapDeals.comLTD.CheapDealsDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new CheapDeals.comLTD.CheapDealsDataSetTableAdapters.TableAdapterManager();
            this.cheapDealsDataSet1 = new CheapDeals.comLTD.CheapDealsDataSet1();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartTableAdapter = new CheapDeals.comLTD.CheapDealsDataSet1TableAdapters.CartTableAdapter();
            this.tableAdapterManager1 = new CheapDeals.comLTD.CheapDealsDataSet1TableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.free_minute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.free_sms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.free_gb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.Button();
            this.bt_proceed = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_customize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cart_freeminute = new System.Windows.Forms.TextBox();
            this.cart_freesms = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cart_freegb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cart_request = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cart_description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cheapDealsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheapDealsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // cheapDealsDataSet
            // 
            this.cheapDealsDataSet.DataSetName = "CheapDealsDataSet";
            this.cheapDealsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.cheapDealsDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Package_ProductTableAdapter = null;
            this.tableAdapterManager.PackageTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.UpdateOrder = CheapDeals.comLTD.CheapDealsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cheapDealsDataSet1
            // 
            this.cheapDealsDataSet1.DataSetName = "CheapDealsDataSet1";
            this.cheapDealsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataMember = "Cart";
            this.cartBindingSource.DataSource = this.cheapDealsDataSet1;
            // 
            // cartTableAdapter
            // 
            this.cartTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CartTableAdapter = this.cartTableAdapter;
            this.tableAdapterManager1.Package_ProductTableAdapter = null;
            this.tableAdapterManager1.PackageTableAdapter = null;
            this.tableAdapterManager1.ProductTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = CheapDeals.comLTD.CheapDealsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.type,
            this.price,
            this.debutDate,
            this.free_minute,
            this.free_sms,
            this.free_gb,
            this.request,
            this.description});
            this.dataGridView1.Location = new System.Drawing.Point(0, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(298, 234);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            // 
            // debutDate
            // 
            this.debutDate.HeaderText = "DebutDate";
            this.debutDate.MinimumWidth = 6;
            this.debutDate.Name = "debutDate";
            // 
            // free_minute
            // 
            this.free_minute.HeaderText = "Free Minute";
            this.free_minute.Name = "free_minute";
            // 
            // free_sms
            // 
            this.free_sms.HeaderText = "Free SMS";
            this.free_sms.Name = "free_sms";
            // 
            // free_gb
            // 
            this.free_gb.HeaderText = "Free GB ";
            this.free_gb.Name = "free_gb";
            // 
            // request
            // 
            this.request.HeaderText = "Request";
            this.request.Name = "request";
            // 
            // description
            // 
            this.description.HeaderText = "description";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Firebrick;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Delete.Location = new System.Drawing.Point(12, 466);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(76, 46);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // bt_proceed
            // 
            this.bt_proceed.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bt_proceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_proceed.ForeColor = System.Drawing.Color.White;
            this.bt_proceed.Location = new System.Drawing.Point(203, 466);
            this.bt_proceed.Margin = new System.Windows.Forms.Padding(2);
            this.bt_proceed.Name = "bt_proceed";
            this.bt_proceed.Size = new System.Drawing.Size(76, 46);
            this.bt_proceed.TabIndex = 9;
            this.bt_proceed.Text = "Proceed";
            this.bt_proceed.UseVisualStyleBackColor = false;
            this.bt_proceed.Click += new System.EventHandler(this.bt_proceed_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(82, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 50);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Cart";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CheapDeals.comLTD.Properties.Resources.cart12;
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // btn_customize
            // 
            this.btn_customize.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_customize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customize.ForeColor = System.Drawing.Color.White;
            this.btn_customize.Location = new System.Drawing.Point(109, 466);
            this.btn_customize.Margin = new System.Windows.Forms.Padding(2);
            this.btn_customize.Name = "btn_customize";
            this.btn_customize.Size = new System.Drawing.Size(76, 46);
            this.btn_customize.TabIndex = 12;
            this.btn_customize.Text = "Customize";
            this.btn_customize.UseVisualStyleBackColor = false;
            this.btn_customize.Click += new System.EventHandler(this.btn_customize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Free Minute:";
            // 
            // cart_freeminute
            // 
            this.cart_freeminute.Location = new System.Drawing.Point(89, 329);
            this.cart_freeminute.Name = "cart_freeminute";
            this.cart_freeminute.Size = new System.Drawing.Size(155, 20);
            this.cart_freeminute.TabIndex = 14;
            // 
            // cart_freesms
            // 
            this.cart_freesms.Location = new System.Drawing.Point(89, 355);
            this.cart_freesms.Name = "cart_freesms";
            this.cart_freesms.Size = new System.Drawing.Size(155, 20);
            this.cart_freesms.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Free SMS:";
            // 
            // cart_freegb
            // 
            this.cart_freegb.Location = new System.Drawing.Point(89, 381);
            this.cart_freegb.Name = "cart_freegb";
            this.cart_freegb.Size = new System.Drawing.Size(155, 20);
            this.cart_freegb.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Free GB:";
            // 
            // cart_request
            // 
            this.cart_request.Location = new System.Drawing.Point(89, 407);
            this.cart_request.Name = "cart_request";
            this.cart_request.Size = new System.Drawing.Size(155, 20);
            this.cart_request.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Request:";
            // 
            // cart_description
            // 
            this.cart_description.Location = new System.Drawing.Point(89, 433);
            this.cart_description.Name = "cart_description";
            this.cart_description.Size = new System.Drawing.Size(155, 20);
            this.cart_description.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Description:";
            // 
            // Form_atc
            // 
            this.ClientSize = new System.Drawing.Size(298, 533);
            this.Controls.Add(this.cart_description);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cart_request);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cart_freegb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cart_freesms);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cart_freeminute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_customize);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bt_proceed);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_atc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.cheapDealsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheapDealsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private CheapDealsDataSet cheapDealsDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private CheapDealsDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private CheapDealsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CheapDealsDataSet1 cheapDealsDataSet1;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private CheapDealsDataSet1TableAdapters.CartTableAdapter cartTableAdapter;
        private CheapDealsDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button bt_proceed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_customize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cart_freeminute;
        private System.Windows.Forms.TextBox cart_freesms;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cart_freegb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cart_request;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn debutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn free_minute;
        private System.Windows.Forms.DataGridViewTextBoxColumn free_sms;
        private System.Windows.Forms.DataGridViewTextBoxColumn free_gb;
        private System.Windows.Forms.DataGridViewTextBoxColumn request;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.TextBox cart_description;
        private System.Windows.Forms.Label label6;
    }
}