using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TermProject.Models.PaymentModels;

namespace TermProject.Models.BankModel
{
    public class Bank
    {
        private Bank() { }

        public static bool Authorize(Credit credit)
        {
            return true;
        }
        public static bool Authorize(Check check)
        {
            return true;
        }
    }
}
