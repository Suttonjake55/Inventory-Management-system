using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging.Effects;
using System.Text;
using System.Windows.Forms;
using JacobSutton_C968.Models;


namespace JacobSutton_C968
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();

            ID_box.Text = Inventory.GeneratePartID().ToString();

        }

        //InHouse Radio Button
        private void InHouse_Button_CheckedChanged(object sender, EventArgs e)
        {
            if (InHouse_Button.Checked)
            {
                Machine_Label.Text = "Machine ID";
                Machine_txt.Clear();
            }
        }

        //Outsource Radio Button
        private void Outsourced_Button_CheckedChanged(object sender, EventArgs e)
        {
            if (Outsourced_Button.Checked)
            {
                Machine_Label.Text = "Company Name";
                Machine_txt.Clear();
            }
        }

        //Cancel Add Part Form
        private void Cancel_Button(object sender, EventArgs e)
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

        //Submit Form
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
                    var err = Machine_Label.Text;
                    throw new Exception($"{err} is a required field.");
                }

                //Check if In House button is clicked
                if (InHouse_Button.Checked)
                {
                    InHouse newPart = new InHouse
                        (
                            int.Parse(ID_box.Text),
                            Name_box.Text,
                            decimal.Parse(Price_box.Text),
                            int.Parse(Inventory_box.Text),
                            int.Parse(Min_box.Text),
                            int.Parse(Max_box.Text),
                            int.Parse(Machine_txt.Text)
                        );
                    Inventory.AddPart(newPart);
                    this.Close();

                }
                //Otherwise Outsourced button is clicked
                else
                {
                    Outsourced newPart = new Outsourced
                        (
                            Inventory.GeneratePartID(),
                            Name_box.Text,
                            decimal.Parse(Price_box.Text),
                            int.Parse(Inventory_box.Text),
                            int.Parse(Min_box.Text),
                            int.Parse(Max_box.Text),
                            Machine_txt.Text
                        );
                    Inventory.AddPart(newPart);
                    this.Close();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "System Error");
            }

            
        }
    }
}
