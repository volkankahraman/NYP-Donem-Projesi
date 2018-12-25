using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProject.Models.PaymentModels
{
    public class Cash : Payment
    {
        public string CashTendered { get; set; }
    }
}
