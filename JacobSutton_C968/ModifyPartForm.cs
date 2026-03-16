using JacobSutton_C968.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Windows.Forms;

namespace JacobSutton_C968
{
    public partial class ModifyPartForm : Form
    {
        private Part modifiedPart;
        public ModifyPartForm()
        {
            InitializeComponent();
        }

        public ModifyPartForm(Part part)
        { 
            InitializeComponent();
            modifiedPart = part;

            LoadPartData();
        }

        //Check if Inhouse Radio Button was selected
        private void InHouse_button_Check(object sender, EventArgs e)
        {
            if (InHouse_button.Checked)
            {
                Machine_label.Text = "Machine ID";
                Machine_txt.Clear();
            }
        }

        //Check if Outsourced Radio Button was selected
        private void Outsourced_button_Check(object sender, EventArgs e)
        {
            if (Outsourced_button.Checked)
            {
                Machine_label.Text = "Company Name";
                Machine_txt.Clear();

            }
        }


        //Load existing data into the text fields on the form
        private void LoadPartData()
        {
            
            ID_box.Text = modifiedPart.PartID.ToString();
            Name_box.Text = modifiedPart.Name;
            Price_box.Text = modifiedPart.Price.ToString();
            Inventory_box.Text = modifiedPart.InStock.ToString();
            Max_box.Text = modifiedPart.Max.ToString();
            Min_box.Text = modifiedPart.Min.ToString();
            

            
            if (modifiedPart is InHouse inHousePart)
            {
                InHouse_button.Checked = true;
                Machine_label.Text = "Machine ID";
                Machine_txt.Text = inHousePart.MachineID.ToString();
                
            }
            else if (modifiedPart is Outsourced outsourcedPart)
            {
                Outsourced_button.Checked = true;
                Machine_label.Text = "Company Name";
                Machine_txt.Text = outsourcedPart.CompanyName;
                
            }
            

        }

        //Save Button
        private void Save_Button(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Name_box.Text))
                {
                    
                    MessageBox.Show("Name is a required field");
                    return;
                }

                if (!decimal.TryParse(Price_box.Text, out decimal price))
                {
                    MessageBox.Show("Price must be a decimal number.");
                    return;
                }

                if (!int.TryParse(Min_box.Text, out int min) || !int.TryParse(Max_box.Text, out int max))
                {
                    throw new Exception("Max and Min must be numbers.");
                }
                if (min > max)
                {
                    throw new Exception("Max must be greater than Min.");
                }

                if (!int.TryParse(Inventory_box.Text, out int inventory) || inventory < min || inventory > max)
                {
                    throw new Exception($"Inventory must be within the range of {max} and {min}.");
                }
                if (string.IsNullOrEmpty(Machine_txt.Text)) 
                {
                    var err = Machine_label.Text;
                    throw new Exception($"{err} is a required field.");
                }



                if (InHouse_button.Checked)
                {
                    int machineID = int.Parse(Machine_txt.Text);
                    InHouse updatedPart = new InHouse(
                        modifiedPart.PartID,
                        Name_box.Text,
                        decimal.Parse(Price_box.Text),
                        int.Parse(Inventory_box.Text),
                        int.Parse(Min_box.Text),
                        int.Parse(Max_box.Text),
                        machineID = int.Parse(Machine_txt.Text)
                        );
                    Inventory.UpdatePart(modifiedPart.PartID, updatedPart);
                    this.Close();
                }
                else
                {
                    string companyName = Machine_txt.Text;
                    Outsourced updatedPart = new Outsourced(
                        modifiedPart.PartID,
                        Name_box.Text,
                        decimal.Parse(Price_box.Text),
                        int.Parse(Inventory_box.Text),
                        int.Parse(Min_box.Text),
                        int.Parse(Max_box.Text),
                        companyName = CompanyName
                        );
                    Inventory.UpdatePart(modifiedPart.PartID, updatedPart);
                    this.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "System Error");
            }
        }

        //Cancel Button
        private void Cancel_button_Click_Click(object sender, EventArgs e)
        {
            var message = "Are you sure you wish to close this form, unsaved data will be lost.";
            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var caption = "Attention!";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
