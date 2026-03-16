namespace JacobSutton_C968
{
    partial class ModifyPartForm
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
            label1 = new Label();
            ID_label = new Label();
            Name_label = new Label();
            Inventoy_label = new Label();
            Price_label = new Label();
            Max_label = new Label();
            Min_label = new Label();
            Machine_label = new Label();
            ID_box = new TextBox();
            Name_box = new TextBox();
            Inventory_box = new TextBox();
            Price_box = new TextBox();
            Max_box = new TextBox();
            Min_box = new TextBox();
            Machine_txt = new TextBox();
            InHouse_button = new RadioButton();
            Outsourced_button = new RadioButton();
            Cancel_button = new Button();
            Save_button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "Modify Part";
            // 
            // ID_label
            // 
            ID_label.AutoSize = true;
            ID_label.Location = new Point(131, 90);
            ID_label.Name = "ID_label";
            ID_label.Size = new Size(18, 15);
            ID_label.TabIndex = 1;
            ID_label.Text = "ID";
            // 
            // Name_label
            // 
            Name_label.AutoSize = true;
            Name_label.Location = new Point(110, 131);
            Name_label.Name = "Name_label";
            Name_label.Size = new Size(39, 15);
            Name_label.TabIndex = 2;
            Name_label.Text = "Name";
            // 
            // Inventoy_label
            // 
            Inventoy_label.AutoSize = true;
            Inventoy_label.Location = new Point(92, 165);
            Inventoy_label.Name = "Inventoy_label";
            Inventoy_label.Size = new Size(57, 15);
            Inventoy_label.TabIndex = 3;
            Inventoy_label.Text = "Inventory";
            // 
            // Price_label
            // 
            Price_label.AutoSize = true;
            Price_label.Location = new Point(81, 198);
            Price_label.Name = "Price_label";
            Price_label.Size = new Size(68, 15);
            Price_label.TabIndex = 4;
            Price_label.Text = "Price / Cost";
            // 
            // Max_label
            // 
            Max_label.AutoSize = true;
            Max_label.Location = new Point(120, 227);
            Max_label.Name = "Max_label";
            Max_label.Size = new Size(29, 15);
            Max_label.TabIndex = 5;
            Max_label.Text = "Max";
            // 
            // Min_label
            // 
            Min_label.AutoSize = true;
            Min_label.Location = new Point(251, 227);
            Min_label.Name = "Min_label";
            Min_label.Size = new Size(26, 21);
            Min_label.TabIndex = 6;
            Min_label.Text = "Min";
            Min_label.UseCompatibleTextRendering = true;
            // 
            // Machine_label
            // 
            Machine_label.AutoSize = true;
            Machine_label.Location = new Point(62, 268);
            Machine_label.Name = "Machine_label";
            Machine_label.Size = new Size(67, 15);
            Machine_label.TabIndex = 7;
            Machine_label.Text = "Machine ID";
            // 
            // ID_box
            // 
            ID_box.Location = new Point(155, 87);
            ID_box.Name = "ID_box";
            ID_box.ReadOnly = true;
            ID_box.Size = new Size(100, 23);
            ID_box.TabIndex = 8;
            // 
            // Name_box
            // 
            Name_box.Location = new Point(155, 131);
            Name_box.Name = "Name_box";
            Name_box.Size = new Size(100, 23);
            Name_box.TabIndex = 9;
            // 
            // Inventory_box
            // 
            Inventory_box.Location = new Point(155, 165);
            Inventory_box.Name = "Inventory_box";
            Inventory_box.Size = new Size(100, 23);
            Inventory_box.TabIndex = 10;
            // 
            // Price_box
            // 
            Price_box.Location = new Point(155, 198);
            Price_box.Name = "Price_box";
            Price_box.Size = new Size(100, 23);
            Price_box.TabIndex = 11;
            // 
            // Max_box
            // 
            Max_box.Location = new Point(155, 227);
            Max_box.Name = "Max_box";
            Max_box.Size = new Size(74, 23);
            Max_box.TabIndex = 12;
            // 
            // Min_box
            // 
            Min_box.Location = new Point(283, 227);
            Min_box.Name = "Min_box";
            Min_box.Size = new Size(81, 23);
            Min_box.TabIndex = 13;
            // 
            // Machine_txt
            // 
            Machine_txt.Location = new Point(155, 268);
            Machine_txt.Name = "Machine_txt";
            Machine_txt.Size = new Size(100, 23);
            Machine_txt.TabIndex = 14;
            // 
            // InHouse_button
            // 
            InHouse_button.AutoSize = true;
            InHouse_button.Location = new Point(95, 56);
            InHouse_button.Name = "InHouse_button";
            InHouse_button.Size = new Size(74, 19);
            InHouse_button.TabIndex = 15;
            InHouse_button.TabStop = true;
            InHouse_button.Text = "In-House";
            InHouse_button.UseVisualStyleBackColor = true;
            InHouse_button.CheckedChanged += InHouse_button_Check;
            // 
            // Outsourced_button
            // 
            Outsourced_button.AutoSize = true;
            Outsourced_button.Location = new Point(228, 56);
            Outsourced_button.Name = "Outsourced_button";
            Outsourced_button.Size = new Size(87, 19);
            Outsourced_button.TabIndex = 16;
            Outsourced_button.TabStop = true;
            Outsourced_button.Text = "Outsourced";
            Outsourced_button.UseVisualStyleBackColor = true;
            Outsourced_button.CheckedChanged += Outsourced_button_Check;
            // 
            // Cancel_button
            // 
            Cancel_button.Location = new Point(283, 368);
            Cancel_button.Name = "Cancel_button";
            Cancel_button.Size = new Size(75, 23);
            Cancel_button.TabIndex = 17;
            Cancel_button.Text = "Cancel";
            Cancel_button.UseVisualStyleBackColor = true;
            Cancel_button.Click += Cancel_button_Click_Click;
            // 
            // Save_button
            // 
            Save_button.Location = new Point(202, 368);
            Save_button.Name = "Save_button";
            Save_button.Size = new Size(75, 23);
            Save_button.TabIndex = 18;
            Save_button.Text = "Save";
            Save_button.UseVisualStyleBackColor = true;
            Save_button.Click += Save_Button;
            // 
            // ModifyPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 451);
            Controls.Add(Save_button);
            Controls.Add(Cancel_button);
            Controls.Add(Outsourced_button);
            Controls.Add(InHouse_button);
            Controls.Add(Machine_txt);
            Controls.Add(Min_box);
            Controls.Add(Max_box);
            Controls.Add(Price_box);
            Controls.Add(Inventory_box);
            Controls.Add(Name_box);
            Controls.Add(ID_box);
            Controls.Add(Machine_label);
            Controls.Add(Min_label);
            Controls.Add(Max_label);
            Controls.Add(Price_label);
            Controls.Add(Inventoy_label);
            Controls.Add(Name_label);
            Controls.Add(ID_label);
            Controls.Add(label1);
            Name = "ModifyPartForm";
            Text = "ModifyPartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label ID_label;
        private Label Name_label;
        private Label Inventoy_label;
        private Label Price_label;
        private Label Max_label;
        private Label Min_label;
        private Label Machine_label;
        private TextBox ID_box;
        private TextBox Name_box;
        private TextBox Inventory_box;
        private TextBox Price_box;
        private TextBox Max_box;
        private TextBox Min_box;
        private TextBox Machine_txt;
        private RadioButton InHouse_button;
        private RadioButton Outsourced_button;
        private Button Cancel_button;
        private Button Save_button;
    }
}