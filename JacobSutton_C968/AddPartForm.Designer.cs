namespace JacobSutton_C968
{
    partial class AddPartForm
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
            InHouse_Button = new RadioButton();
            Outsourced_Button = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            ID_box = new TextBox();
            Name_box = new TextBox();
            Inventory_box = new TextBox();
            Price_box = new TextBox();
            Max_box = new TextBox();
            Min_box = new TextBox();
            Machine_txt = new TextBox();
            ID_Label = new Label();
            Name_Label = new Label();
            Inventoy_Label = new Label();
            Price_Label = new Label();
            Max_Label = new Label();
            Min_label = new Label();
            Machine_Label = new Label();
            SuspendLayout();
            // 
            // InHouse_Button
            // 
            InHouse_Button.AutoSize = true;
            InHouse_Button.Location = new Point(77, 55);
            InHouse_Button.Name = "InHouse_Button";
            InHouse_Button.Size = new Size(74, 19);
            InHouse_Button.TabIndex = 0;
            InHouse_Button.TabStop = true;
            InHouse_Button.Text = "In-House";
            InHouse_Button.UseVisualStyleBackColor = true;
            InHouse_Button.CheckedChanged += InHouse_Button_CheckedChanged;
            // 
            // Outsourced_Button
            // 
            Outsourced_Button.AutoSize = true;
            Outsourced_Button.Location = new Point(203, 55);
            Outsourced_Button.Name = "Outsourced_Button";
            Outsourced_Button.Size = new Size(87, 19);
            Outsourced_Button.TabIndex = 1;
            Outsourced_Button.TabStop = true;
            Outsourced_Button.Text = "Outsourced";
            Outsourced_Button.UseVisualStyleBackColor = true;
            Outsourced_Button.CheckedChanged += Outsourced_Button_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(134, 332);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Save_Button;
            // 
            // button2
            // 
            button2.Location = new Point(215, 332);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Cancel_Button;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 4;
            label1.Text = "Add Part";
            // 
            // ID_box
            // 
            ID_box.Location = new Point(134, 99);
            ID_box.Name = "ID_box";
            ID_box.ReadOnly = true;
            ID_box.Size = new Size(100, 23);
            ID_box.TabIndex = 5;
            // 
            // Name_box
            // 
            Name_box.Location = new Point(134, 128);
            Name_box.Name = "Name_box";
            Name_box.Size = new Size(100, 23);
            Name_box.TabIndex = 6;
            // 
            // Inventory_box
            // 
            Inventory_box.Location = new Point(134, 157);
            Inventory_box.Name = "Inventory_box";
            Inventory_box.Size = new Size(100, 23);
            Inventory_box.TabIndex = 7;
            // 
            // Price_box
            // 
            Price_box.Location = new Point(134, 186);
            Price_box.Name = "Price_box";
            Price_box.Size = new Size(100, 23);
            Price_box.TabIndex = 8;
            // 
            // Max_box
            // 
            Max_box.Location = new Point(134, 215);
            Max_box.Name = "Max_box";
            Max_box.Size = new Size(66, 23);
            Max_box.TabIndex = 9;
            // 
            // Min_box
            // 
            Min_box.Location = new Point(235, 215);
            Min_box.Name = "Min_box";
            Min_box.Size = new Size(65, 23);
            Min_box.TabIndex = 10;
            // 
            // Machine_txt
            // 
            Machine_txt.Location = new Point(134, 244);
            Machine_txt.Name = "Machine_txt";
            Machine_txt.Size = new Size(100, 23);
            Machine_txt.TabIndex = 11;
            // 
            // ID_Label
            // 
            ID_Label.AutoSize = true;
            ID_Label.Location = new Point(98, 102);
            ID_Label.Name = "ID_Label";
            ID_Label.Size = new Size(18, 15);
            ID_Label.TabIndex = 12;
            ID_Label.Text = "ID";
            // 
            // Name_Label
            // 
            Name_Label.AutoSize = true;
            Name_Label.Location = new Point(77, 136);
            Name_Label.Name = "Name_Label";
            Name_Label.Size = new Size(39, 15);
            Name_Label.TabIndex = 13;
            Name_Label.Text = "Name";
            // 
            // Inventoy_Label
            // 
            Inventoy_Label.AutoSize = true;
            Inventoy_Label.Location = new Point(59, 160);
            Inventoy_Label.Name = "Inventoy_Label";
            Inventoy_Label.Size = new Size(57, 15);
            Inventoy_Label.TabIndex = 14;
            Inventoy_Label.Text = "Inventory";
            // 
            // Price_Label
            // 
            Price_Label.AutoSize = true;
            Price_Label.Location = new Point(48, 189);
            Price_Label.Name = "Price_Label";
            Price_Label.Size = new Size(68, 15);
            Price_Label.TabIndex = 15;
            Price_Label.Text = "Price / Cost";
            // 
            // Max_Label
            // 
            Max_Label.AutoSize = true;
            Max_Label.Location = new Point(87, 223);
            Max_Label.Name = "Max_Label";
            Max_Label.Size = new Size(29, 15);
            Max_Label.TabIndex = 16;
            Max_Label.Text = "Max";
            // 
            // Min_label
            // 
            Min_label.AutoSize = true;
            Min_label.Location = new Point(201, 218);
            Min_label.Name = "Min_label";
            Min_label.Size = new Size(28, 15);
            Min_label.TabIndex = 17;
            Min_label.Text = "Min";
            // 
            // Machine_Label
            // 
            Machine_Label.AutoSize = true;
            Machine_Label.Location = new Point(24, 252);
            Machine_Label.Name = "Machine_Label";
            Machine_Label.Size = new Size(67, 15);
            Machine_Label.TabIndex = 18;
            Machine_Label.Text = "Machine ID";
            // 
            // AddPartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(381, 429);
            Controls.Add(Machine_Label);
            Controls.Add(Min_label);
            Controls.Add(Max_Label);
            Controls.Add(Price_Label);
            Controls.Add(Inventoy_Label);
            Controls.Add(Name_Label);
            Controls.Add(ID_Label);
            Controls.Add(Machine_txt);
            Controls.Add(Min_box);
            Controls.Add(Max_box);
            Controls.Add(Inventory_box);
            Controls.Add(Price_box);
            Controls.Add(Name_box);
            Controls.Add(ID_box);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Outsourced_Button);
            Controls.Add(InHouse_Button);
            Name = "AddPartForm";
            Text = "AddPartForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton InHouse_Button;
        private RadioButton Outsourced_Button;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox ID_box;
        private TextBox Name_box;
        private TextBox Price_box;
        private TextBox Inventory_box;
        private TextBox Max_box;
        private TextBox Min_box;
        private TextBox Machine_txt;
        private Label ID_Label;
        private Label Name_Label;
        private Label Inventoy_Label;
        private Label Price_Label;
        private Label Max_Label;
        private Label Min_label;
        private Label Machine_Label;
    }
}