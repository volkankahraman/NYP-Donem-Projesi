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
        public double CalculateTax(int id, int p)
        {
            double tax = 0;
            if (p == 0)
            {
                foreach (Cart cartDetail in Cart)
                    if (cartDetail.Item.ID == id)
                    {
                        tax += cartDetail.Quantity * (cartDetail.Item.Price * (Convert.ToDouble(cartDetail.Item.Tax) / Convert.ToDouble(100)));
                        break;
                    }
            }
            else if (p == 1)
            {
                foreach (Cart cartDetail1 in Cart)
                    tax += cartDetail1.Quantity * (cartDetail1.Item.Price * (Convert.ToDouble(cartDetail1.Item.Tax) / Convert.ToDouble(100)));
            }
            return tax;
        }
        public double CalculateTotal(int id, int p)
        {
            double total = 0;
            if (p == 0)
            {
                foreach (Cart cartDetail in Cart)
                    if (cartDetail.Item.ID == id)
                    {
                        total += cartDetail.Quantity * (cartDetail.Item.Price + (cartDetail.Item.Price * (Convert.ToDouble(cartDetail.Item.Tax) / Convert.ToDouble(100))));
                        break;
                    }
            }
            else if (p == 1)
            {
                foreach (Cart cartDetail1 in Cart)
                    total += cartDetail1.Quantity * (cartDetail1.Item.Price + (cartDetail1.Item.Price * (Convert.ToDouble(cartDetail1.Item.Tax) / Convert.ToDouble(100))));
            }
            return total;
        }
        public int CalculateWeight(int id, int p)
        {
            int weight = 0;
            if (p == 0)
            {
                foreach (Cart cartDetail in Cart)
                    if (cartDetail.Item.ID == id)
                    {
                        weight += cartDetail.Quantity * cartDetail.Item.Weight;
                        break;
                    }
            }
            else if (p == 1)
            {
                foreach (Cart cartDetail1 in Cart)
                    weight += cartDetail1.Quantity * cartDetail1.Item.Weight;
            }
            return weight;
        }
    }
}
