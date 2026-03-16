using System;
using System.Collections.Generic;
using System.Text;

namespace JacobSutton_C968.Models
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min {  get; set; }
        public int Max { get; set; }


        public Part(int id, string name, decimal price, int stock, int min, int max)
        {
            PartID = id;
            Name = name;
            Price = price;
            InStock = stock;
            Min = min;
            Max = max;
        }
    }
}
