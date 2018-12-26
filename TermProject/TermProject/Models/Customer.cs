using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TermProject.Models.OrderModels;

namespace TermProject.Models
{
    public class Customer : User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Cart> Cart = new List<Cart>();

        public override string ToString()
        {
            return Name + " " + Address;
        }

        public List<Order> getOrders(int id)
        {
            List<Order> orders = (DataSource.DataSourceSingleton.GetInstance().OrderList.Where(a => a.Customer.Id == id).ToList().Count != 0 ? DataSource.DataSourceSingleton.GetInstance().OrderList.Where(x => x.Customer.Id == id).ToList() : null);
            return orders;
        }

        public double CalculateTax()
        {
            double tax = 0;
            foreach (Cart cartDetail1 in Cart)
                tax += cartDetail1.Quantity * (cartDetail1.Item.Price * (Convert.ToDouble(cartDetail1.Item.Tax) / Convert.ToDouble(100)));
            return tax;
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (Cart cartDetail1 in Cart)
                total += cartDetail1.Quantity * (cartDetail1.Item.Price + (cartDetail1.Item.Price * (Convert.ToDouble(cartDetail1.Item.Tax) / Convert.ToDouble(100))));
            return total;
        }

        public int CalculateWeight()
        {
            int weight = 0;
            foreach (Cart cartDetail1 in Cart)
                weight += cartDetail1.Quantity * cartDetail1.Item.Weight;
            return weight;
        }
    }
}
