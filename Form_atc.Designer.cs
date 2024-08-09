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
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.Button();
            this.bt_proceed = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
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
            this.description});
            this.dataGridView1.Location = new System.Drawing.Point(0, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(289, 234);
            this.dataGridView1.TabIndex = 0;
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
            this.Delete.Location = new System.Drawing.Point(27, 369);
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
            this.bt_proceed.Location = new System.Drawing.Point(176, 369);
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
            // Form_atc
            // 
            this.ClientSize = new System.Drawing.Size(290, 533);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn debutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button bt_proceed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}