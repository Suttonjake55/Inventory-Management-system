namespace JacobSutton_C968
{
    partial class AddProductForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ID_txt = new TextBox();
            Name_box = new TextBox();
            Price_box = new TextBox();
            Inventory_box = new TextBox();
            Max_box = new TextBox();
            Min_box = new TextBox();
            button1 = new Button();
            button2 = new Button();
            productBindingSource = new BindingSource(components);
            PartsDataGrid = new DataGridView();
            PartsAssociatedGrid = new DataGridView();
            Add_button = new Button();
            Part_Search = new Button();
            Part_Search_txt = new TextBox();
            Delete_button = new Button();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PartsDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PartsAssociatedGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 0;
            label1.Text = "Add Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 149);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 185);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 255);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(65, 222);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 6;
            label5.Text = "Price / Cost";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(104, 286);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 7;
            label6.Text = "Max";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(198, 286);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 8;
            label7.Text = "Min";
            // 
            // ID_txt
            // 
            ID_txt.Location = new Point(152, 149);
            ID_txt.Name = "ID_txt";
            ID_txt.ReadOnly = true;
            ID_txt.Size = new Size(100, 23);
            ID_txt.TabIndex = 11;
            // 
            // Name_box
            // 
            Name_box.Location = new Point(152, 185);
            Name_box.Name = "Name_box";
            Name_box.Size = new Size(100, 23);
            Name_box.TabIndex = 12;
            // 
            // Price_box
            // 
            Price_box.Location = new Point(152, 222);
            Price_box.Name = "Price_box";
            Price_box.Size = new Size(100, 23);
            Price_box.TabIndex = 13;
            // 
            // Inventory_box
            // 
            Inventory_box.Location = new Point(152, 252);
            Inventory_box.Name = "Inventory_box";
            Inventory_box.Size = new Size(100, 23);
            Inventory_box.TabIndex = 14;
            // 
            // Max_box
            // 
            Max_box.Location = new Point(152, 281);
            Max_box.Name = "Max_box";
            Max_box.Size = new Size(40, 23);
            Max_box.TabIndex = 15;
            // 
            // Min_box
            // 
            Min_box.Location = new Point(232, 283);
            Min_box.Name = "Min_box";
            Min_box.Size = new Size(40, 23);
            Min_box.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(115, 343);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Submit_Button;
            // 
            // button2
            // 
            button2.Location = new Point(218, 343);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Cancel_Button;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // PartsDataGrid
            // 
            PartsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsDataGrid.Location = new Point(407, 75);
            PartsDataGrid.Name = "PartsDataGrid";
            PartsDataGrid.Size = new Size(499, 224);
            PartsDataGrid.TabIndex = 19;
            // 
            // PartsAssociatedGrid
            // 
            PartsAssociatedGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsAssociatedGrid.Location = new Point(407, 370);
            PartsAssociatedGrid.Name = "PartsAssociatedGrid";
            PartsAssociatedGrid.Size = new Size(499, 202);
            PartsAssociatedGrid.TabIndex = 20;
            // 
            // Add_button
            // 
            Add_button.Location = new Point(832, 305);
            Add_button.Name = "Add_button";
            Add_button.Size = new Size(74, 44);
            Add_button.TabIndex = 21;
            Add_button.Text = "Add";
            Add_button.UseVisualStyleBackColor = true;
            Add_button.Click += Add_Part_Click;
            // 
            // Part_Search
            // 
            Part_Search.Location = new Point(663, 46);
            Part_Search.Name = "Part_Search";
            Part_Search.Size = new Size(75, 23);
            Part_Search.TabIndex = 22;
            Part_Search.Text = "Search";
            Part_Search.UseVisualStyleBackColor = true;
            Part_Search.Click += Search_Part_Click;
            // 
            // Part_Search_txt
            // 
            Part_Search_txt.Location = new Point(754, 46);
            Part_Search_txt.Name = "Part_Search_txt";
            Part_Search_txt.Size = new Size(152, 23);
            Part_Search_txt.TabIndex = 23;
            // 
            // Delete_button
            // 
            Delete_button.Location = new Point(832, 578);
            Delete_button.Name = "Delete_button";
            Delete_button.Size = new Size(74, 44);
            Delete_button.TabIndex = 24;
            Delete_button.Text = "Delete";
            Delete_button.UseVisualStyleBackColor = true;
            Delete_button.Click += Delete_Part_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1068, 777);
            Controls.Add(Delete_button);
            Controls.Add(Part_Search_txt);
            Controls.Add(Part_Search);
            Controls.Add(Add_button);
            Controls.Add(PartsAssociatedGrid);
            Controls.Add(PartsDataGrid);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Min_box);
            Controls.Add(Max_box);
            Controls.Add(Inventory_box);
            Controls.Add(Price_box);
            Controls.Add(Name_box);
            Controls.Add(ID_txt);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddProductForm";
            Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)PartsDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)PartsAssociatedGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox ID_txt;
        private TextBox Name_box;
        private TextBox Price_box;
        private TextBox Inventory_box;
        private TextBox Max_box;
        private TextBox Min_box;
        private Button button1;
        private Button button2;
        private BindingSource productBindingSource;
        private DataGridView PartsDataGrid;
        private DataGridView PartsAssociatedGrid;
        private Button Add_button;
        private Button Part_Search;
        private TextBox Part_Search_txt;
        private Button Delete_button;
    }
}