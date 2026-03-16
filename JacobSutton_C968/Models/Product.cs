using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace JacobSutton_C968.Models
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();
        public int ProductID { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min {  get; set; }
        public int Max { get; set; }

        

        public Product(int productID, string? name, decimal price, int inStock, int min, int max, BindingList<Part> associatedParts)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            AssociatedParts = associatedParts;
        }
    }
}
