using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TermProject.Enums;
using TermProject.Models.PaymentModels;

namespace TermProject.Models.OrderModels
{
    public class Order
    {
        public Order(List<OrderDetail> _OrderDetails)
        {
            OrderDetails = _OrderDetails;
        }
        public DateTime Date { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Customer Customer { get; set; }
        public PaymentModels.Payment Payment { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
