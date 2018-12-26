using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProject.Models
{
    public class Cart
    {
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public Enums.TaxStatus TaxStatus { get; set; }
        public int CalculateSubTotal()
        {
            return Quantity * Item.Price;
        }
        public int CalculateWeight()
        {
            return Quantity * Item.Weight;
        }
    }
}
