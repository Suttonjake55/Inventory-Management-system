using JacobSutton_C968.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JacobSutton_C968
{
    public partial class AddProductForm : Form
    {
        //New associated list
        BindingList<Part> associatedPart = new BindingList<Part>();

        public AddProductForm()
        {
            InitializeComponent();

            PartsDataGrid.DataSource = Inventory.AllParts;
            PartsAssociatedGrid.DataSource = associatedPart;

            ID_txt.Text = Inventory.GenerateProductID().ToString();

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

        //Add Part to associated DataGridView
        private void Add_Part_Click(object sender, EventArgs e)
        {
            if (PartsDataGrid.CurrentRow != null)
            {
                Part selectedPart = (Part)PartsDataGrid.CurrentRow.DataBoundItem;

                associatedPart.Add(selectedPart);
            }
            else
            {
                MessageBox.Show("A Part must be selected from the list.");
            }
        }

        //Submit form
        private void Submit_Button(object sender, EventArgs e)
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

              
                Product product = new Product
                (
                    int.Parse(ID_txt.Text),
                    Name_box.Text,
                    decimal.Parse(Price_box.Text),
                    int.Parse(Inventory_box.Text),
                    int.Parse(Min_box.Text),
                    int.Parse(Max_box.Text),
                    associatedPart
                );

                Inventory.AddProduct(product);
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "System Error");
            }
        }


        //Remove Associated Part Click
        private void Delete_Part_Click(object sender, EventArgs e)
        {
            if (PartsAssociatedGrid.CurrentRow != null)
            {
                var message = "Are you sure you want to remove this part from this product?";

                var caption = "Attention!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Part selectedPart = (Part)PartsAssociatedGrid.CurrentRow.DataBoundItem;
                    associatedPart.Remove(selectedPart);
                    
                }
               

            }
            else
            {
                MessageBox.Show("Please selecte a part to be removed from the associated list.");
            }

        }

        //Search Parts
        private void Search_Part_Click(Object sender, EventArgs e)
        {
            //Blank Search Bar
            PartsDataGrid.ClearSelection();
            var searchValue = Part_Search_txt.Text;

            if (string.IsNullOrEmpty(searchValue))
            {
                return;
            }

            bool found = false;

            //Seach by ID Check
            if (int.TryParse(searchValue, out int ID))
            {
                Part matching = Inventory.LookupPart(ID);
                if (matching != null)
                {
                    foreach (DataGridViewRow row in PartsDataGrid.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        if (part.PartID == ID)
                        {
                            row.Selected = true;
                            PartsDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                            found = true;
                            break;
                        }
                    }
                }
            }

            //Search by Name
            if (!found)
            {
                BindingList<Part> matching = Inventory.LookupPart(searchValue);
                if (matching.Count > 0)
                {
                    foreach (DataGridViewRow row in PartsDataGrid.Rows)
                    {
                        Part part = (Part)row.DataBoundItem;
                        foreach (Part match in matching)
                        {
                            if (part.PartID == match.PartID)
                            {
                                row.Selected = true;
                                found = true;
                            }
                        }
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("Not parts were found with this search.");
            }
        }
    }
}
