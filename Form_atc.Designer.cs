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
            this.bt_buy_now = new System.Windows.Forms.Button();
            this.lb_back = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cheapDealsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheapDealsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(-2, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(412, 408);
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
            this.Delete.Location = new System.Drawing.Point(12, 540);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(106, 51);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // bt_buy_now
            // 
            this.bt_buy_now.Location = new System.Drawing.Point(259, 540);
            this.bt_buy_now.Name = "bt_buy_now";
            this.bt_buy_now.Size = new System.Drawing.Size(106, 51);
            this.bt_buy_now.TabIndex = 2;
            this.bt_buy_now.Text = "Buy Now";
            this.bt_buy_now.UseVisualStyleBackColor = true;
            this.bt_buy_now.Click += new System.EventHandler(this.bt_buy_now_Click);
            // 
            // lb_back
            // 
            this.lb_back.AutoSize = true;
            this.lb_back.Location = new System.Drawing.Point(9, 26);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(38, 16);
            this.lb_back.TabIndex = 3;
            this.lb_back.Text = "Back";
            this.lb_back.Click += new System.EventHandler(this.lb_back_Click);
            // 
            // Form_atc
            // 
            this.ClientSize = new System.Drawing.Size(410, 751);
            this.Controls.Add(this.lb_back);
            this.Controls.Add(this.bt_buy_now);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_atc";
            this.Load += new System.EventHandler(this.Form_atc_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.cheapDealsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheapDealsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn debutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button bt_buy_now;
        private System.Windows.Forms.Label lb_back;
    }
}