using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TermProject.Models.BankModel;

namespace TermProject.Models.PaymentModels
{
    public class Check : Payment
    {
        public string Name { get; set; }
        public string BankID { get; set; }

        public bool Authorized()
        {
            return Bank.Authorize(this);
        }
    }
}
