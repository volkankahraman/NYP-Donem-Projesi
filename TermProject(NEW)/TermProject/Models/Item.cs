using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProject.Models
{
    public class Item
    {
        public int ID { get; set; }
        //In type of Percentage
        public int Tax { get; set; }
        //In type of Turkish Liras (₺)
        public int Price { get; set; }
        //In type of Kilograms
        public int Weight { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public int GetPriceForQuantity()
        {
            return Price;
        }
        public int GetWeight()
        {
            return Weight;
        }
        public override string ToString()
        {
            return ID + " " + Name;
        }
    }
}
