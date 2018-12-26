using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TermProject.Enums;

namespace TermProject.Models.OrderModels
{
    public class OrderDetail : Cart
    {
        public int OrderID { get; set; }
    }
}
