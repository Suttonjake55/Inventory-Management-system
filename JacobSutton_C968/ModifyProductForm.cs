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
    public partial class ModifyProductForm : Form
    {
        //New associated list
        private BindingList<Part> associatedPart = new BindingList<Part>();

        private Product modifiedProduct;

        
        private Product curProduct;


        public ModifyProductForm(Product productModify)
        {
            InitializeComponent();

            modifiedProduct = productModify;


            foreach (Part part in modifiedProduct.AssociatedParts)
            {
                associatedPart.Add(part);
            }


            PartsDataGrid.DataSource = Inventory.AllParts;
            PartsAssociatedGrid.DataSource = associatedPart;

            LoadProductData();

        }

        //Load data into the form
        private void LoadProductData()
        {
            ID_txt.Text = modifiedProduct.ProductID.ToString();
            Name_txt.Text = modifiedProduct.Name;
            Inventory_txt.Text = modifiedProduct.InStock.ToString();
            Price_txt.Text = modifiedProduct.Price.ToString();
            Max_txt.Text = modifiedProduct.Max.ToString();
            Min_txt.Text = modifiedProduct.Min.ToString();

            
        }

        //Cancel Button
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

        //Add Button
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

        //Delete Button
        private void Remove_Part(object sender, EventArgs e)
        {
            if (PartsAssociatedGrid.CurrentRow != null)
            {
                var message = "Do you want to remove this part from this product?";

                var caption = "Attention!";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
                
                if (result == DialogResult.Yes)
                {
                    Part selctedPart = (Part)PartsAssociatedGrid.CurrentRow.DataBoundItem;
                    associatedPart.Remove(selctedPart);
                }
                
            }

            else
            {
                MessageBox.Show("Please select a part from the associated part list.");
                }
        }

        //Save Button
        private void Submit_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Name_txt.Text))
                {

                    MessageBox.Show("Name is a required field");
                    return;
                }

                if (!decimal.TryParse(Price_txt.Text, out decimal price))
                {
                    MessageBox.Show("Price must be a decimal number.");
                    return;
                }

                if (!int.TryParse(Min_txt.Text, out int min) || !int.TryParse(Max_txt.Text, out int max))
                {
                    throw new Exception("Max and Min must be numbers.");
                }
                if (min > max)
                {
                    throw new Exception("Max must be greater than Min.");
                }

                if (!int.TryParse(Inventory_txt.Text, out int inventory) || inventory < min || inventory > max)
                {
                    throw new Exception($"Inventory must be within the range of {max} and {min}.");
                }

                Product updateProduct = new Product
                (
                int.Parse(ID_txt.Text),
                Name_txt.Text,
                decimal.Parse(Price_txt.Text),
                int.Parse(Inventory_txt.Text),
                int.Parse(Min_txt.Text),
                int.Parse(Max_txt.Text),
                associatedPart
                );

                Inventory.UpdateProduct(updateProduct.ProductID, updateProduct);
                this.Close();
            }
            catch (Exception err) 
            { 
                MessageBox.Show(err.Message, "System Error");
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

