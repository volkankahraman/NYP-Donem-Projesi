using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TermProject.Enums;
using TermProject.Models.PaymentModels;

namespace TermProject.Models.BankModel
{
    public class Bank
    {
        private Bank() { }

        public static bool Authorize(Credit credit)
        {
        //    int a = 1;
        //    if (credit.ExpirationDate=="12/24"&& credit.Number== "1111111111111111" && credit.Type = (CreditType)(a) )
        //    { return true; }
            return true;
        }
        public static bool Authorize(Check check)
        {
            return true;
        }
    }
}
