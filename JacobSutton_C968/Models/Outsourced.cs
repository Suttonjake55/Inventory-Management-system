using System;
using System.Collections.Generic;
using System.Text;

namespace JacobSutton_C968.Models
{
    internal class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(int id, string name, decimal price, int stock, int min, int max, string machineID) : base(id, name, price, stock, min, max)
        {
            CompanyName = machineID;
        }
    }
}
