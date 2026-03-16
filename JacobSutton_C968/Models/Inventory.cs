using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Text;

namespace JacobSutton_C968.Models
{
    internal class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();
        

        private static int partIDCounter = 1;
        private static int productIDCounter = 1;

        public static int GeneratePartID()
        {
            return partIDCounter++; 
        }

        public static int GenerateProductID()
        { 
            return productIDCounter++; 
        }

        
        //Add Product
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }


        //Add Part
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }


        //Remove Product
        public static bool RemoveProduct(Product product)
        {
            return Products.Remove(product);
        }


        //Remove Part
        public static bool RemovePart(Part part)
        {
            return AllParts.Remove(part); 
        }

        
        //Lookup Part by ID
        public static Part LookupPart(int id)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == id) return part;

            }
            return null;
        }

        //Lookup Part by Name
        public static BindingList<Part> LookupPart(string name)
        {
            BindingList<Part> results = new BindingList<Part>();

          
            foreach (Part part in AllParts)
            {
                if (part.Name.ToLower().Contains(name.ToLower()))
                {
                    results.Add(part); 
                }

            }
            return results;
        
        }


        //Lookup Product by ID
        public static Product LookupProduct(int id)
        {
            foreach (Product product in Products)
            {
                if (product.ProductID == id) return product;
            }
            return null;
        }

        public static BindingList<Product> LookupProduct(string name)
        {
            BindingList<Product> result = new BindingList<Product>();


            foreach (Product product in Products)
            {
                if (product.Name.ToLower().Contains(name.ToLower()))
                {
                    result.Add(product);
                }

            }
            return result;

        }





        //Update Product
        public static void UpdateProduct(int ProductID, Product UpdatedProduct)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == ProductID)
                {
                    Products[i] = UpdatedProduct;
                    return;
                }
            }
        }


        //Update Part
        public static void UpdatePart(int PartID, Part UpdatedPart)
        {
        
      
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == PartID)
                {
                    AllParts[i] = UpdatedPart;
                    return;
                }
            }
            
        }



    }
}
