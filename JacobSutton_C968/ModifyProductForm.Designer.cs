namespace JacobSutton_C968
{
    partial class ModifyProductForm
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
            Modify_Product_Label = new Label();
            ID_label = new Label();
            Name_label = new Label();
            Inventory_label = new Label();
            Price_label = new Label();
            Max_label = new Label();
            Min_label = new Label();
            ID_txt = new TextBox();
            Name_txt = new TextBox();
            Inventory_txt = new TextBox();
            Price_txt = new TextBox();
            Min_txt = new TextBox();
            Max_txt = new TextBox();
            Add_button = new Button();
            PartsDataGrid = new DataGridView();
            PartsAssociatedGrid = new DataGridView();
            Submit_button = new Button();
            Cancel_button = new Button();
            Delete_button = new Button();
            Part_Search = new Button();
            Part_Search_txt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PartsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PartsAssociatedGrid).BeginInit();
            SuspendLayout();
            // 
            // Modify_Product_Label
            // 
            Modify_Product_Label.AutoSize = true;
            Modify_Product_Label.Location = new Point(31, 33);
            Modify_Product_Label.Name = "Modify_Product_Label";
            Modify_Product_Label.Size = new Size(90, 15);
            Modify_Product_Label.TabIndex = 0;
            Modify_Product_Label.Text = "Modify Product";
            // 
            // ID_label
            // 
            ID_label.AutoSize = true;
            ID_label.Location = new Point(67, 122);
            ID_label.Name = "ID_label";
            ID_label.Size = new Size(18, 15);
            ID_label.TabIndex = 1;
            ID_label.Text = "ID";
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Location = new Point(46, 167);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(39, 15);
            Name_label.TabIndex = 2;
            Name_label.Text = "Name";
            // 
            // Inventory_label
            // 
            Inventory_label.AutoSize = true;
            Inventory_label.Location = new Point(28, 205);
            Inventory_label.Name = "Inventory_label";
            Inventory_label.Size = new Size(57, 15);
            Inventory_label.TabIndex = 3;
            Inventory_label.Text = "Inventory";
            // 
            // Price_label
            // 
            Price_label.AutoSize = true;
            Price_label.Location = new Point(52, 242);
            Price_label.Name = "Price_label";
            Price_label.Size = new Size(33, 15);
            Price_label.TabIndex = 4;
            Price_label.Text = "Price";
            // 
            // Max_label
            // 
            Max_label.AutoSize = true;
            Max_label.Location = new Point(56, 276);
            Max_label.Name = "Max_label";
            Max_label.Size = new Size(29, 15);
            Max_label.TabIndex = 5;
            Max_label.Text = "Max";
            // 
            // Min_label
            // 
            Min_label.AutoSize = true;
            Min_label.Location = new Point(182, 276);
            Min_label.Name = "Min_label";
            Min_label.Size = new Size(28, 15);
            Min_label.TabIndex = 6;
            Min_label.Text = "Min";
            // 
            // ID_txt
            // 
            ID_txt.Location = new Point(110, 119);
            ID_txt.Name = "ID_txt";
            ID_txt.ReadOnly = true;
            ID_txt.Size = new Size(100, 23);
            ID_txt.TabIndex = 7;
            // 
            // Name_txt
            // 
            Name_txt.Location = new Point(110, 164);
            Name_txt.Name = "Name_txt";
            Name_txt.Size = new Size(100, 23);
            Name_txt.TabIndex = 8;
            // 
            // Inventory_txt
            // 
            Inventory_txt.Location = new Point(110, 205);
            Inventory_txt.Name = "Inventory_txt";
            Inventory_txt.Size = new Size(100, 23);
            Inventory_txt.TabIndex = 9;
            // 
            // Price_txt
            // 
            Price_txt.Location = new Point(110, 242);
            Price_txt.Name = "Price_txt";
            Price_txt.Size = new Size(100, 23);
            Price_txt.TabIndex = 10;
            // 
            // Min_txt
            // 
            Min_txt.Location = new Point(216, 276);
            Min_txt.Name = "Min_txt";
            Min_txt.Size = new Size(52, 23);
            Min_txt.TabIndex = 11;
            // 
            // Max_txt
            // 
            Max_txt.Location = new Point(110, 276);
            Max_txt.Name = "Max_txt";
            Max_txt.Size = new Size(52, 23);
            Max_txt.TabIndex = 12;
            // 
            // Add_button
            // 
            Add_button.Location = new Point(678, 276);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(63, 41);
            Add_button.TabIndex = 13;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = true;
            Add_button.Click += Add_Part_Click;
            // 
            // PartsDataGrid
            // 
            PartsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsDataGrid.Location = new Point(354, 82);
            PartsDataGrid.Name = "PartsDataGrid";
            PartsDataGrid.Size = new Size(398, 183);
            PartsDataGrid.TabIndex = 14;
            // 
            // PartsAssociatedGrid
            // 
            PartsAssociatedGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsAssociatedGrid.Location = new Point(354, 345);
            PartsAssociatedGrid.Name = "PartsAssociatedGrid";
            PartsAssociatedGrid.Size = new Size(398, 183);
            PartsAssociatedGrid.TabIndex = 15;
            // 
            // Submit_button
            // 
            Submit_button.Location = new Point(67, 331);
            Submit_button.Name = "Submit_button";
            Submit_button.Size = new Size(75, 23);
            Submit_button.TabIndex = 16;
            Submit_button.Text = "Save";
            Submit_button.UseVisualStyleBackColor = true;
            Submit_button.Click += Submit_Button_Click;
            // 
            // Cancel_button
            // 
            Cancel_button.Location = new Point(166, 331);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new Size(75, 23);
            Cancel_button.TabIndex = 17;
            Cancel_button.Text = "Cancel";
            Cancel_button.UseVisualStyleBackColor = true;
            Cancel_button.Click += Cancel_Button;
            // 
            // Delete_button
            // 
            Delete_button.Location = new Point(678, 534);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(63, 41);
            Delete_button.TabIndex = 18;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = true;
            Delete_button.Click += Remove_Part;
            // 
            // Part_Search
            // 
            Part_Search.Location = new Point(528, 53);
            Part_Search.Name = "Part_Search";
            Part_Search.Size = new Size(75, 23);
            Part_Search.TabIndex = 19;
            Part_Search.Text = "Search";
            Part_Search.UseVisualStyleBackColor = true;
            Part_Search.Click += Search_Part_Click;
            // 
            // Part_Search_txt
            // 
            Part_Search_txt.Location = new Point(609, 54);
            Part_Search_txt.Name = "Part_Search_txt";
            Part_Search_txt.Size = new Size(143, 23);
            Part_Search_txt.TabIndex = 20;
            // 
            // ModifyProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 631);
            Controls.Add(Part_Search_txt);
            Controls.Add(Part_Search);
            Controls.Add(Delete_button);
            Controls.Add(Cancel_button);
            Controls.Add(Submit_button);
            Controls.Add(PartsAssociatedGrid);
            Controls.Add(PartsDataGrid);
            Controls.Add(Add_button);
            Controls.Add(Max_txt);
            Controls.Add(Min_txt);
            Controls.Add(Price_txt);
            Controls.Add(Inventory_txt);
            Controls.Add(Name_txt);
            Controls.Add(ID_txt);
            Controls.Add(Min_label);
            Controls.Add(Max_label);
            Controls.Add(Price_label);
            Controls.Add(Inventory_label);
            Controls.Add(Name_label);
            Controls.Add(ID_label);
            Controls.Add(Modify_Product_Label);
            Name = "ModifyProductForm";
            Text = "ModifyProductForm";
            ((System.ComponentModel.ISupportInitialize)PartsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)PartsAssociatedGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Modify_Product_Label;
        private Label ID_label;
        private Label Name_label;
        private Label Inventory_label;
        private Label Price_label;
        private Label Max_label;
        private Label Min_label;
        private TextBox ID_txt;
        private TextBox Name_txt;
        private TextBox Inventory_txt;
        private TextBox Price_txt;
        private TextBox Min_txt;
        private TextBox Max_txt;
        private Button Add_button;
        private DataGridView PartsDataGrid;
        private DataGridView PartsAssociatedGrid;
        private Button Submit_button;
        private Button Cancel_button;
        private Button Delete_button;
        private Button Part_Search;
        private TextBox Part_Search_txt;
    }
}