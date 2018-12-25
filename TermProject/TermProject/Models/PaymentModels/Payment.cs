using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TermProject.Models.OrderModels;

namespace TermProject.Models.PaymentModels
{
    public abstract class Payment
    {
        protected Payment()
        {
        }

        public int Amount { get; set; }

        public List<Order> Orders{ get; set; }
        public override string ToString()
        {
            return Amount.ToString();
        }
    }
}
