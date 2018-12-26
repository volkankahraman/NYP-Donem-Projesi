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
using TermProject.Models;

namespace TermProject
{
    public partial class Payment : Form
    {

        public Payment()
        {
            InitializeComponent();

        }
        Order order;
        Models.PaymentModels.Payment payment;
        Customer ActiveCustomer = DataSourceSingleton.GetInstance().ActiveCustomer;
        void PaymentSuccess()
        {
            order.Payment = payment;
            for (int a = 0; a < ActiveCustomer.Cart.Count; a++)
            {
                order.OrderDetails.Add(new OrderDetail()
                {
                    Item = ActiveCustomer.Cart[a].Item,
                    Quantity = ActiveCustomer.Cart[a].Quantity,
                    TaxStatus = ActiveCustomer.Cart[a].TaxStatus
                });
            }
            ActiveCustomer.Cart.Clear();
            this.Close();
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            string _CashTendered = txtCashTendered.Text;
            int CashTendered;

            if (rbCash.Checked == true)
            {
                if (int.TryParse(_CashTendered, out CashTendered) == true)
                {
                    if (CashTendered - Convert.ToInt32(ActiveCustomer.CalculateTotal()) >= 0)
                    {
                        Cash cash = new Cash();
                        cash.CashTendered = txtCashTendered.Text;
                        cash.Amount = Convert.ToInt32(ActiveCustomer.CalculateTotal());
                        payment = cash;
                        MessageBox.Show("Para Üstünüz:" + (Convert.ToInt32(txtCashTendered.Text) - Convert.ToInt32(ActiveCustomer.CalculateTotal())));
                        PaymentSuccess();
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz tutar girdiniz");
                        txtCashTendered.Text = string.Empty;
                        txtCashTendered.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen sayı giriniz");
                    txtCashTendered.Text = string.Empty;
                    txtCashTendered.Focus();
                }
            }
            if (rbCheck.Checked == true)
            {
                bool CheckAuthorize = false;
                Check check = new Check();
                check.Name = txtCheckName.Text;
                check.BankID = txtCheckNBR.Text;
                CheckAuthorize = check.Authorized();
                check.Amount = Convert.ToInt32(ActiveCustomer.CalculateTotal());
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
                credit.Amount = Convert.ToInt32(ActiveCustomer.CalculateTotal());
                payment = credit;
            }


        }
        private void Payment_Load(object sender, EventArgs e)
        {
            order = new Order(DataSourceSingleton.GetInstance().OrderDetails);
            order.Date = DateTime.Now;
            order.Customer = ActiveCustomer;
            DataSourceSingleton.GetInstance().OrderList.Add(order);
            lblTotal.Text = "Toplam tutar:" + ActiveCustomer.CalculateTotal();
            lblTotalWeight.Text = "Toplam ağırlık:" + ActiveCustomer.CalculateWeight();
            lblTotalTax.Text = "Toplam Vergi:" + ActiveCustomer.CalculateTax();
        }
        private void rbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            btnPay.Visible = true;

            lblCCNumber.Visible = true;
            lblCCType.Visible = true;
            lblExpDate.Visible = true;
            txtCCNumber.Visible = true;
            cbCreditType.Visible = true;
            txtExpDate.Visible = true;


            txtCheckName.Visible = false;
            txtCheckNBR.Visible = false;
            lblCheckName.Visible = false;
            lblCheckNBR.Visible = false;

            lblCashTendered.Visible = false;
            txtCashTendered.Visible = false;
        }
        private void rbCheck_CheckedChanged(object sender, EventArgs e)
        {
            btnPay.Visible = true;

            txtCheckNBR.Visible = true;
            lblCheckName.Visible = true;
            lblCheckNBR.Visible = true;
            txtCheckName.Visible = true;

            lblCCNumber.Visible = false;
            lblCCType.Visible = false;
            lblExpDate.Visible = false;
            txtCCNumber.Visible = false;
            cbCreditType.Visible = false;
            txtExpDate.Visible = false;

            lblCashTendered.Visible = false;
            txtCashTendered.Visible = false;

        }
        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            lblCashTendered.Visible = true;
            txtCashTendered.Visible = true;
            btnPay.Visible = true;

            txtCheckName.Visible = false;
            txtCheckNBR.Visible = false;
            lblCheckName.Visible = false;
            lblCheckNBR.Visible = false;


            lblCCNumber.Visible = false;
            lblCCType.Visible = false;
            lblExpDate.Visible = false;
            txtCCNumber.Visible = false;
            cbCreditType.Visible = false;
            txtExpDate.Visible = false;

        }


    }
}
