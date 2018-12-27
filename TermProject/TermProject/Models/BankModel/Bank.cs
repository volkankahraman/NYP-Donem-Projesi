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
            char[] number = credit.Number.ToString().ToCharArray();

            if (int.Parse(number[0].ToString()) == 4 && credit.Type == Enums.CreditType.VISA)
                return true;
            else if (int.Parse(number[0].ToString()) == 5 && credit.Type == Enums.CreditType.MASTERCARD)
                return true;
            return false;
        }

        public static bool Authorize(Check check)
        {
            return true;
        }
    }
}
