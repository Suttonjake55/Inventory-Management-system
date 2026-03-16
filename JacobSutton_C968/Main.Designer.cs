using System.Drawing.Text;

namespace JacobSutton_C968
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Inventory_system = new Label();
            Exit = new Button();
            Add_Part = new Button();
            Add_Product = new Button();
            Modify_Part = new Button();
            Modify_Product = new Button();
            Delete_Part = new Button();
            Delete_Product = new Button();
            PartsDataGrid = new DataGridView();
            ProductDataView = new DataGridView();
            PartTable_label = new Label();
            ProductTable_Label = new Label();
            Part_Search = new Button();
            Product_Search = new Button();
            Part_Search_txt = new TextBox();
            Product_Search_txt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PartsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataView).BeginInit();
            SuspendLayout();
            // 
            // Inventory_system
            // 
            Inventory_system.AutoSize = true;
            Inventory_system.Font = new Font("Segoe UI", 12F);
            Inventory_system.Location = new Point(12, 9);
            Inventory_system.Name = "Inventory_system";
            Inventory_system.Size = new Size(227, 21);
            Inventory_system.TabIndex = 0;
            Inventory_system.Text = "Inventory Management System";
            // 
            // Exit
            // 
            Exit.BackColor = SystemColors.ControlLight;
            Exit.Font = new Font("Segoe UI", 12F);
            Exit.Location = new Point(1326, 420);
            Exit.Name = "Exit";
            Exit.Size = new Size(71, 48);
            Exit.TabIndex = 7;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Add_Part
            // 
            Add_Part.BackColor = SystemColors.ControlLight;
            Add_Part.Font = new Font("Segoe UI", 12F);
            Add_Part.Location = new Point(385, 348);
            Add_Part.Name = "Add_Part";
            Add_Part.Size = new Size(84, 48);
            Add_Part.TabIndex = 8;
            Add_Part.Text = "Add Part";
            Add_Part.UseVisualStyleBackColor = false;
            Add_Part.Click += Add_Part_Click;
            // 
            // Add_Product
            // 
            Add_Product.BackColor = SystemColors.ControlLight;
            Add_Product.Font = new Font("Segoe UI", 12F);
            Add_Product.Location = new Point(1008, 348);
            Add_Product.Name = "Add_Product";
            Add_Product.Size = new Size(112, 48);
            Add_Product.TabIndex = 9;
            Add_Product.Text = "Add Product";
            Add_Product.UseVisualStyleBackColor = false;
            Add_Product.Click += Add_Product_Click;
            // 
            // Modify_Part
            // 
            Modify_Part.BackColor = SystemColors.ControlLight;
            Modify_Part.Font = new Font("Segoe UI", 12F);
            Modify_Part.Location = new Point(475, 348);
            Modify_Part.Name = "Modify_Part";
            Modify_Part.Size = new Size(98, 48);
            Modify_Part.TabIndex = 10;
            Modify_Part.Text = "Modify Part";
            Modify_Part.UseVisualStyleBackColor = false;
            Modify_Part.Click += Modify_Part_Click;
            // 
            // Modify_Product
            // 
            Modify_Product.BackColor = SystemColors.ControlLight;
            Modify_Product.Font = new Font("Segoe UI", 12F);
            Modify_Product.Location = new Point(1126, 348);
            Modify_Product.Name = "Modify_Product";
            Modify_Product.Size = new Size(135, 48);
            Modify_Product.TabIndex = 11;
            Modify_Product.Text = "Modify Product";
            Modify_Product.UseVisualStyleBackColor = false;
            Modify_Product.Click += Modify_Product_Click;
            // 
            // Delete_Part
            // 
            Delete_Part.BackColor = SystemColors.ControlLight;
            Delete_Part.Font = new Font("Segoe UI", 12F);
            Delete_Part.Location = new Point(579, 348);
            Delete_Part.Name = "Delete_Part";
            Delete_Part.Size = new Size(98, 48);
            Delete_Part.TabIndex = 12;
            Delete_Part.Text = "Delete Part";
            Delete_Part.UseVisualStyleBackColor = false;
            Delete_Part.Click += Delete_Part_Click;
            // 
            // Delete_Product
            // 
            Delete_Product.BackColor = SystemColors.ControlLight;
            Delete_Product.Font = new Font("Segoe UI", 12F);
            Delete_Product.Location = new Point(1277, 348);
            Delete_Product.Name = "Delete_Product";
            Delete_Product.Size = new Size(120, 48);
            Delete_Product.TabIndex = 13;
            Delete_Product.Text = "Delete Product";
            Delete_Product.UseVisualStyleBackColor = false;
            Delete_Product.Click += Delete_Product_Click;
            // 
            // PartsDataGrid
            // 
            PartsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsDataGrid.Location = new Point(36, 105);
            PartsDataGrid.Name = "PartsDataGrid";
            PartsDataGrid.Size = new Size(646, 228);
            PartsDataGrid.TabIndex = 14;
            // 
            // ProductDataView
            // 
            ProductDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDataView.Location = new Point(749, 105);
            ProductDataView.Name = "ProductDataView";
            ProductDataView.Size = new Size(648, 228);
            ProductDataView.TabIndex = 15;
            // 
            // PartTable_label
            // 
            PartTable_label.AutoSize = true;
            PartTable_label.Font = new Font("Segoe UI", 12F);
            PartTable_label.Location = new Point(58, 67);
            PartTable_label.Name = "PartTable_label";
            PartTable_label.Size = new Size(44, 21);
            PartTable_label.TabIndex = 16;
            PartTable_label.Text = "Parts";
            // 
            // ProductTable_Label
            // 
            ProductTable_Label.AutoSize = true;
            ProductTable_Label.Font = new Font("Segoe UI", 12F);
            ProductTable_Label.Location = new Point(749, 69);
            ProductTable_Label.Name = "ProductTable_Label";
            ProductTable_Label.Size = new Size(71, 21);
            ProductTable_Label.TabIndex = 17;
            ProductTable_Label.Text = "Products";
            // 
            // Part_Search
            // 
            Part_Search.Location = new Point(425, 66);
            Part_Search.Name = "Part_Search";
            Part_Search.Size = new Size(75, 23);
            Part_Search.TabIndex = 18;
            Part_Search.Text = "Search";
            Part_Search.UseVisualStyleBackColor = true;
            Part_Search.Click += Search_Part_Click;
            // 
            // Product_Search
            // 
            Product_Search.Location = new Point(1117, 70);
            Product_Search.Name = "Product_Search";
            Product_Search.Size = new Size(75, 23);
            Product_Search.TabIndex = 19;
            Product_Search.Text = "Search";
            Product_Search.UseVisualStyleBackColor = true;
            Product_Search.Click += Search_Product_Click;
            // 
            // Part_Search_txt
            // 
            Part_Search_txt.Location = new Point(509, 66);
            Part_Search_txt.Name = "Part_Search_txt";
            Part_Search_txt.Size = new Size(168, 23);
            Part_Search_txt.TabIndex = 20;
            // 
            // Product_Search_txt
            // 
            Product_Search_txt.Location = new Point(1212, 71);
            Product_Search_txt.Name = "Product_Search_txt";
            Product_Search_txt.Size = new Size(168, 23);
            Product_Search_txt.TabIndex = 21;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1441, 553);
            Controls.Add(Product_Search_txt);
            Controls.Add(Part_Search_txt);
            Controls.Add(Product_Search);
            Controls.Add(Part_Search);
            Controls.Add(ProductTable_Label);
            Controls.Add(PartTable_label);
            Controls.Add(ProductDataView);
            Controls.Add(PartsDataGrid);
            Controls.Add(Delete_Product);
            Controls.Add(Delete_Part);
            Controls.Add(Modify_Product);
            Controls.Add(Modify_Part);
            Controls.Add(Add_Product);
            Controls.Add(Add_Part);
            Controls.Add(Exit);
            Controls.Add(Inventory_system);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)PartsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductDataView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Inventory_system;
        private Button Exit;
        private Button Add_Part;
        private Button Add_Product;
        private Button Modify_Part;
        private Button Modify_Product;
        private Button Delete_Part;
        private Button Delete_Product;
        private DataGridView PartsDataGrid;
        private DataGridView ProductDataView;
        private Label PartTable_label;
        private Label ProductTable_Label;
        private Button Part_Search;
        private Button Product_Search;
        private TextBox Part_Search_txt;
        private TextBox Product_Search_txt;
    }
}
