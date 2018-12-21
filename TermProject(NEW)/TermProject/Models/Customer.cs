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
        public List<OrderDetail> getOrders(int id)
        {
            List<OrderDetail> orders = (DataSource.DataSourceSingleton.GetInstance().OrderList.Where(a => a.Customer.Id == id).ToList().Count != 0 ? DataSource.DataSourceSingleton.GetInstance().OrderList.Find(x => x.Customer.Id == id).OrderDetails : null);
            return orders;
        }
        public double CalculateTax()
        {
            double tax = 0;
            foreach (Cart orderDetail in Cart)
                tax += orderDetail.Quantity * (orderDetail.Item.Price * (Convert.ToDouble(orderDetail.Item.Tax) / Convert.ToDouble(100)));
            return tax;
        }
        public double CalculateTotal()
        {
            double total = 0;
            foreach (Cart orderDetail in Cart)
                total += orderDetail.Quantity * (orderDetail.Item.Price + (orderDetail.Item.Price * (Convert.ToDouble(orderDetail.Item.Tax) / Convert.ToDouble(100))));
            return total;
        }
        public int CalculateWeight()
        {
            int weight = 0;
            foreach (Cart orderDetail in Cart)
                weight += orderDetail.Quantity * orderDetail.Item.Weight;
            return weight;
        }
    }
}
