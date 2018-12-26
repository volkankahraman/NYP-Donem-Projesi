using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using TermProject.Enums;
using System.Threading.Tasks;
using System.Windows.Forms;
using TermProject.Models.PaymentModels;
using TermProject.Models.OrderModels;
using TermProject.DataSource;

namespace TermProject
{
    public partial class Payment : Form
    {
        private void Change()
        {
            MessageBox.Show("Para Üstünüz:" + (Convert.ToInt32(txtCashTendered.Text) - Convert.ToInt32(DataSourceSingleton.GetInstance().ActiveCustomer.CalculateTotal())));
        }
        public Payment()
        {
            InitializeComponent();

        }
        Order order;
        Models.PaymentModels.Payment payment;
        private void btnPay_Click(object sender, EventArgs e)
        {
            if (rbCash.Checked == true)
            {
                Cash cash = new Cash();
                cash.CashTendered = txtCashTendered.Text;
                cash.Amount = Convert.ToInt32(DataSourceSingleton.GetInstance().ActiveCustomer.CalculateTotal());
                payment = cash;
                Change();
            }
            if (rbCheck.Checked == true)
            {
                bool CheckAuthorize = false;
                Check check = new Check();
                check.Name = txtCheckName.Text;
                check.BankID = txtCheckNBR.Text;
                CheckAuthorize = check.Authorized();
                check.Amount = Convert.ToInt32(DataSourceSingleton.GetInstance().ActiveCustomer.CalculateTotal());
                payment = check;
            }
            if (rbCreditCard.Checked == true)
            {
                bool CreditCardAuthorize = false;
                Credit credit = new Credit();
                credit.ExpirationDate = txtExpDate.Text;
                int a = cbCreditType.SelectedIndex;
                credit.Type = (CreditType)(a);
                credit.Number = txtCCNumber.Text;
                CreditCardAuthorize = credit.Authorized();
                credit.Amount = Convert.ToInt32(DataSourceSingleton.GetInstance().ActiveCustomer.CalculateTotal());
                payment = credit;
            }
            order.Payment = payment;
            for (int a = 0; a < DataSourceSingleton.GetInstance().ActiveCustomer.Cart.Count; a++)
            {
                order.OrderDetails.Add(new OrderDetail()
                {
                    Item = DataSourceSingleton.GetInstance().ActiveCustomer.Cart[a].Item,
                    Quantity = DataSourceSingleton.GetInstance().ActiveCustomer.Cart[a].Quantity,
                    TaxStatus = DataSourceSingleton.GetInstance().ActiveCustomer.Cart[a].TaxStatus
                });
            }
            DataSourceSingleton.GetInstance().ActiveCustomer.Cart.Clear();
            this.Close();
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            order = new Order(DataSourceSingleton.GetInstance().OrderDetails);
            order.Date = DateTime.Now;
            order.Customer = DataSourceSingleton.GetInstance().ActiveCustomer;
            DataSourceSingleton.GetInstance().OrderList.Add(order);
            lblTotal.Text = "Toplam tutar:" + DataSourceSingleton.GetInstance().ActiveCustomer.CalculateTotal();
            lblTotalWeight.Text = "Toplam ağırlık:" + DataSourceSingleton.GetInstance().ActiveCustomer.CalculateWeight();
            lblTotalTax.Text = "Toplam Vergi:" + DataSourceSingleton.GetInstance().ActiveCustomer.CalculateTax();
        }
        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            gbCash.Visible = true;
            btnPay.Visible = true;
            gbCheck.Visible = false;
            gbCreditCard.Visible = false;
        }
        private void rbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            gbCash.Visible = false;
            btnPay.Visible = true;
            gbCheck.Visible = false;
            gbCreditCard.Visible = true;
        }
        private void rbCheck_CheckedChanged(object sender, EventArgs e)
        {

            gbCash.Visible = false;
            btnPay.Visible = true;
            gbCheck.Visible = true;
            gbCreditCard.Visible = false;
        }
    }
}
