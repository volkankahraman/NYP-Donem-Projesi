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
        BindingList<Item> ItemList = DataSourceSingleton.GetInstance().ItemList;
        CustomerPanel cp = (CustomerPanel)Application.OpenForms["CustomerPanel"];

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
                ItemList.Where(x => x.ID == ActiveCustomer.Cart[a].Item.ID).FirstOrDefault().Stock -= ActiveCustomer.Cart[a].Quantity;
            }
            ActiveCustomer.Cart.Clear();
            if (ActiveCustomer.Cart != null)
                if (ActiveCustomer.Cart.Count > 0)
                    cp.btnCartInfo.Text = "Sepet (" + ActiveCustomer.Cart.Count + ")";
                else
                    cp.btnCartInfo.Text = "Sepet";
            cp.UpdateList();
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
                check.Amount = Convert.ToInt32(ActiveCustomer.CalculateTotal());
                CheckAuthorize = check.Authorized();
                payment = check;
                PaymentSuccess();
            }
            if (rbCreditCard.Checked == true)
            {
                long CCNumber;
                int expMonth, expYear;
                MessageBox.Show(DataSourceSingleton.GetInstance().CreditCartList.Capacity.ToString());
                if (long.TryParse(txtCCNumber.Text, out CCNumber) == true && int.TryParse(txtExpMonth.Text, out expMonth) == true && int.TryParse(txtExpYear.Text, out expYear) == true)
                {
                    Credit credit = new Credit();
                    credit.Number = CCNumber;
                    if (credit.Authorized() == true)
                    {
                        credit.Number = CCNumber;
                        int a = cbCreditType.SelectedIndex;
                        credit.ExpirationDate = expMonth + "/" + expYear;
                        credit.Type = (CreditType)(a);
                        credit.Amount = Convert.ToInt32(ActiveCustomer.CalculateTotal());
                        payment = credit;
                        PaymentSuccess();
                    }
                    else
                    {
                        MessageBox.Show("Kredi Kartı Sistemde Bulunamadı");
                        txtCCNumber.Text = string.Empty;
                        txtExpMonth.Text = string.Empty;
                        txtExpYear.Text = string.Empty;
                        cbCreditType.Text = string.Empty;
                        txtCCNumber.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Kredi Kartı Bilgilerinizi Kontrol Ediniz.");
                    txtCCNumber.Text = string.Empty;
                    txtExpMonth.Text = string.Empty;
                    txtExpYear.Text = string.Empty;
                    cbCreditType.Text = string.Empty;
                    txtCCNumber.Focus();
                }
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
            txtExpMonth.Visible = true;
            txtExpYear.Visible = true;
            txtCVC.Visible = true;


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
            txtExpMonth.Visible = false;
            txtExpYear.Visible = false;
            txtCVC.Visible = false;


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
            txtExpMonth.Visible = false;
            txtExpYear.Visible = false;
            txtCVC.Visible = false;

        }


    }
}
