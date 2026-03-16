using JacobSutton_C968.Models;
using System.ComponentModel;
using System.Web;

namespace JacobSutton_C968
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        //Data Grid View Setup
        private void Main_Load(object sender, EventArgs e)
        {
           PartsDataGrid.DataSource = Inventory.AllParts;
           ProductDataView.DataSource = Inventory.Products;
        }

        //Exit the application
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Add Part Click
        private void Add_Part_Click(object sender, EventArgs e)
        {
            AddPartForm newForm = new AddPartForm();
            newForm.Show();
        }

        //Add Product Click
        private void Add_Product_Click(object sender, EventArgs e)
        {
            AddProductForm newForm = new AddProductForm();
            newForm.Show();
        }

        //Modify Part Click
        private void Modify_Part_Click(object sender, EventArgs e)
        {
            if (PartsDataGrid.CurrentRow == null)
            {
                MessageBox.Show("Please select a part.");
                return;
            }

            Part selectedPart = (Part)PartsDataGrid.CurrentRow.DataBoundItem;
            ModifyPartForm modifiedPart = new ModifyPartForm(selectedPart);
            modifiedPart.ShowDialog();
            ProductDataView.Refresh();
            PartsDataGrid.Refresh();
         
        }

        //Modify Product Click
        private void Modify_Product_Click(object sender, EventArgs e)
        {
            if(ProductDataView.CurrentRow == null)
            {
                MessageBox.Show("Please select a Product from the list.");
                return;
            }
            Product selectedProduct = (Product)ProductDataView.CurrentRow.DataBoundItem;
            ModifyProductForm modifedProduct = new ModifyProductForm(selectedProduct);
            modifedProduct.ShowDialog();
            ProductDataView.Refresh();
            PartsDataGrid.Refresh();

        }

        //Remove Part Click
        private void Delete_Part_Click(object sender, EventArgs e)
        {
            if (PartsDataGrid.CurrentRow != null)
            {
                Part associatedPart = (Part)PartsDataGrid.CurrentRow.DataBoundItem;

                bool isAssociated = Inventory.Products.Any(p => p.AssociatedParts.Contains(associatedPart));

                if (isAssociated)
                {
                    MessageBox.Show("This part is associated with a product and can't be deleted", "Error");
                }
                else
                {
                    var message = "Are you sure you want to remove this part?";

                    var caption = "Attention!";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Part selctedPart = (Part)PartsDataGrid.CurrentRow.DataBoundItem;
                        Inventory.AllParts.Remove(selctedPart);
                    }
                }
            }
        }

        //Remove Product Click
        private void Delete_Product_Click(object sender, EventArgs e)
        {
            
            if (ProductDataView.CurrentRow != null)
            {
                Product associatedPart = (Product)ProductDataView.CurrentRow.DataBoundItem;
                if(associatedPart.AssociatedParts.Count > 0)
                {
                    var message = "This product can't be deleted because it has parts associated to it.";
                    var caption = "Attention!";

                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    var message = "Are you sure you want to remove this product?";

                    var caption = "Attention!";
                    var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        Product selctedPart = (Product)ProductDataView.CurrentRow.DataBoundItem;
                        Inventory.Products.Remove(selctedPart);
                    }
                }
                
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
                        foreach (Part match  in matching)
                        {
                            if(part.PartID == match.PartID)
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
                MessageBox.Show("No parts were found with this search.");
            }
        }

        //Search Parts
        private void Search_Product_Click(Object sender, EventArgs e)
        {
            //Blank Search Bar
            ProductDataView.ClearSelection();
            var searchValue = Product_Search_txt.Text;

            if (string.IsNullOrEmpty(searchValue))
            {
                return;
            }

            bool found = false;

            //Seach by ID Check
            if (int.TryParse(searchValue, out int ID))
            {
                Product matching = Inventory.LookupProduct(ID);
                if (matching != null)
                {
                    foreach (DataGridViewRow row in ProductDataView.Rows)
                    {
                        Product product = (Product)row.DataBoundItem;
                        if (product.ProductID == ID)
                        {
                            row.Selected = true;
                            ProductDataView.FirstDisplayedScrollingRowIndex = row.Index;
                            found = true;
                            break;
                        }
                    }
                }
            }

            //Search by Name
            if (!found)
            {
                BindingList<Product> matching = Inventory.LookupProduct(searchValue);
                if (matching.Count > 0)
                {
                    foreach (DataGridViewRow row in ProductDataView.Rows)
                    {
                        Product product = (Product)row.DataBoundItem;
                        foreach (Product match in matching)
                        {
                            if (product.ProductID == match.ProductID)
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
                MessageBox.Show("No products were found with this search.");
            }
        }
    }
}
