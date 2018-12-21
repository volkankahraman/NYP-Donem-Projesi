using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TermProject.Enums;
using TermProject.Models.BankModel;

namespace TermProject.Models.PaymentModels
{
    public class Credit : Payment
    {
        public string Number { get; set; }
        public CreditType Type { get; set; }
        public string ExpirationDate { get; set; }

        public bool Authorized()
        {
            return Bank.Authorize(this);
        }
    }
}
