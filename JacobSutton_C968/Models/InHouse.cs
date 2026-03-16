using System;
using System.Collections.Generic;
using System.Text;

namespace JacobSutton_C968.Models
{
    internal class InHouse : Part
    {
        public int MachineID { get; set; }
        public InHouse(int id, string name, decimal price, int stock, int min, int max, int machineID) : base(id, name, price, stock, min, max)
        {
            MachineID = machineID;
        }
    }
}