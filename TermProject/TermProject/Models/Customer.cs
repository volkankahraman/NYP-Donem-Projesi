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
            List<Order> orders = DataSource.DataSourceSingleton.GetInstance().OrderList;
            if (orders.Count != 0)
                if (orders.Where(x => x.Customer.Id == id).ToList().Count != 0)
                    orders = DataSource.DataSourceSingleton.GetInstance().OrderList.Where(x => x.Customer.Id == id).ToList();
            return orders;
        }

        public double CalculateTax()
        {
            double tax = 0;
            foreach (Cart cartDetail in Cart)
                tax += cartDetail.Quantity * (cartDetail.Item.Price * (Convert.ToDouble(cartDetail.Item.Tax) / Convert.ToDouble(100)));
            return tax;
        }

        public double CalculateTotal()
        {
            double total = 0;
            foreach (Cart cartDetail in Cart)
                total += cartDetail.Quantity * (cartDetail.Item.Price + (cartDetail.Item.Price * (Convert.ToDouble(cartDetail.Item.Tax) / Convert.ToDouble(100))));
            return total;
        }

        public int CalculateWeight()
        {
            int weight = 0;
            foreach (Cart cartDetail in Cart)
                weight += cartDetail.Quantity * cartDetail.Item.Weight;
            return weight;
        }
    }
}
