namespace Inventory
{
    partial class Form1
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
            this.product_name_label = new System.Windows.Forms.Label();
            this.product_name_txt = new System.Windows.Forms.TextBox();
            this.product_id_txt = new System.Windows.Forms.TextBox();
            this.product_id_label = new System.Windows.Forms.Label();
            this.quantity_label = new System.Windows.Forms.Label();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.price_per_unit_txt = new System.Windows.Forms.TextBox();
            this.supplier_txt = new System.Windows.Forms.TextBox();
            this.price_per_unit_label = new System.Windows.Forms.Label();
            this.supplier_label = new System.Windows.Forms.Label();
            this.inventory_db_view_grid = new System.Windows.Forms.DataGridView();
            this.add_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.show_table_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_db_view_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // product_name_label
            // 
            this.product_name_label.AutoSize = true;
            this.product_name_label.Location = new System.Drawing.Point(13, 13);
            this.product_name_label.Name = "product_name_label";
            this.product_name_label.Size = new System.Drawing.Size(90, 16);
            this.product_name_label.TabIndex = 0;
            this.product_name_label.Text = "Product name";
            // 
            // product_name_txt
            // 
            this.product_name_txt.Location = new System.Drawing.Point(19, 32);
            this.product_name_txt.Name = "product_name_txt";
            this.product_name_txt.Size = new System.Drawing.Size(170, 22);
            this.product_name_txt.TabIndex = 1;
            // 
            // product_id_txt
            // 
            this.product_id_txt.Location = new System.Drawing.Point(19, 93);
            this.product_id_txt.Name = "product_id_txt";
            this.product_id_txt.Size = new System.Drawing.Size(170, 22);
            this.product_id_txt.TabIndex = 2;
            // 
            // product_id_label
            // 
            this.product_id_label.AutoSize = true;
            this.product_id_label.Location = new System.Drawing.Point(16, 74);
            this.product_id_label.Name = "product_id_label";
            this.product_id_label.Size = new System.Drawing.Size(69, 16);
            this.product_id_label.TabIndex = 3;
            this.product_id_label.Text = "Product ID";
            // 
            // quantity_label
            // 
            this.quantity_label.AutoSize = true;
            this.quantity_label.Location = new System.Drawing.Point(16, 135);
            this.quantity_label.Name = "quantity_label";
            this.quantity_label.Size = new System.Drawing.Size(55, 16);
            this.quantity_label.TabIndex = 4;
            this.quantity_label.Text = "Quantity";
            // 
            // quantity_txt
            // 
            this.quantity_txt.Location = new System.Drawing.Point(19, 155);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(167, 22);
            this.quantity_txt.TabIndex = 5;
            // 
            // price_per_unit_txt
            // 
            this.price_per_unit_txt.Location = new System.Drawing.Point(19, 217);
            this.price_per_unit_txt.Name = "price_per_unit_txt";
            this.price_per_unit_txt.Size = new System.Drawing.Size(167, 22);
            this.price_per_unit_txt.TabIndex = 6;
            // 
            // supplier_txt
            // 
            this.supplier_txt.Location = new System.Drawing.Point(19, 277);
            this.supplier_txt.Name = "supplier_txt";
            this.supplier_txt.Size = new System.Drawing.Size(167, 22);
            this.supplier_txt.TabIndex = 7;
            // 
            // price_per_unit_label
            // 
            this.price_per_unit_label.AutoSize = true;
            this.price_per_unit_label.Location = new System.Drawing.Point(16, 198);
            this.price_per_unit_label.Name = "price_per_unit_label";
            this.price_per_unit_label.Size = new System.Drawing.Size(84, 16);
            this.price_per_unit_label.TabIndex = 8;
            this.price_per_unit_label.Text = "Price per unit";
            // 
            // supplier_label
            // 
            this.supplier_label.AutoSize = true;
            this.supplier_label.Location = new System.Drawing.Point(16, 258);
            this.supplier_label.Name = "supplier_label";
            this.supplier_label.Size = new System.Drawing.Size(57, 16);
            this.supplier_label.TabIndex = 9;
            this.supplier_label.Text = "Supplier";
            // 
            // inventory_db_view_grid
            // 
            this.inventory_db_view_grid.AllowUserToOrderColumns = true;
            this.inventory_db_view_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventory_db_view_grid.Location = new System.Drawing.Point(204, 13);
            this.inventory_db_view_grid.Name = "inventory_db_view_grid";
            this.inventory_db_view_grid.RowHeadersWidth = 51;
            this.inventory_db_view_grid.RowTemplate.Height = 24;
            this.inventory_db_view_grid.Size = new System.Drawing.Size(747, 400);
            this.inventory_db_view_grid.TabIndex = 10;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.add_btn.Location = new System.Drawing.Point(9, 324);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(91, 33);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "Add Product";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.delete_btn.Location = new System.Drawing.Point(9, 380);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(91, 33);
            this.delete_btn.TabIndex = 12;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.update_btn.Location = new System.Drawing.Point(107, 324);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(91, 33);
            this.update_btn.TabIndex = 13;
            this.update_btn.Text = "Update ";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.search_btn.Location = new System.Drawing.Point(112, 380);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(86, 33);
            this.search_btn.TabIndex = 14;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // show_table_btn
            // 
            this.show_table_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.show_table_btn.Location = new System.Drawing.Point(70, 419);
            this.show_table_btn.Name = "show_table_btn";
            this.show_table_btn.Size = new System.Drawing.Size(75, 23);
            this.show_table_btn.TabIndex = 15;
            this.show_table_btn.Text = "view table";
            this.show_table_btn.UseVisualStyleBackColor = false;
            this.show_table_btn.Click += new System.EventHandler(this.show_table_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.show_table_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.inventory_db_view_grid);
            this.Controls.Add(this.supplier_label);
            this.Controls.Add(this.price_per_unit_label);
            this.Controls.Add(this.supplier_txt);
            this.Controls.Add(this.price_per_unit_txt);
            this.Controls.Add(this.quantity_txt);
            this.Controls.Add(this.quantity_label);
            this.Controls.Add(this.product_id_label);
            this.Controls.Add(this.product_id_txt);
            this.Controls.Add(this.product_name_txt);
            this.Controls.Add(this.product_name_label);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.inventory_db_view_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label product_name_label;
        private System.Windows.Forms.TextBox product_name_txt;
        private System.Windows.Forms.TextBox product_id_txt;
        private System.Windows.Forms.Label product_id_label;
        private System.Windows.Forms.Label quantity_label;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.TextBox price_per_unit_txt;
        private System.Windows.Forms.TextBox supplier_txt;
        private System.Windows.Forms.Label price_per_unit_label;
        private System.Windows.Forms.Label supplier_label;
        private System.Windows.Forms.DataGridView inventory_db_view_grid;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button show_table_btn;
    }
}

