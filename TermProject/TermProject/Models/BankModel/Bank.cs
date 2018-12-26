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
            List<Credit> CreditCartList = DataSource.DataSourceSingleton.GetInstance().CreditCartList;
            bool check = false;
            for (int i = 0; i < CreditCartList.Count; i++)
                if (credit.Number == CreditCartList[i].Number)
                {
                    check = true;
                    break;
                }
            return check;
        }
        public static bool Authorize(Check check)
        {
            return true;
        }
    }
}
