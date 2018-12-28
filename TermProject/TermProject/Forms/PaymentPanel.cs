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
        List<OrderDetail> orderDetails = new List<OrderDetail>();
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
            DataSourceSingleton.GetInstance().OrderList.Add(order);

            string list = "";
            for (int a = 0; a < order.OrderDetails.Count; a++)
                list += order.OrderDetails[a].Item.Name + Environment.NewLine;
            order.OrderList = list;

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
            order = new Order(orderDetails);
            order.Date = DateTime.Now;
            order.Customer = ActiveCustomer;
            if (rbCash.Checked == true)
            {
                string _CashTendered = txtCashTendered.Text;
                int CashTendered;
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
            this.Size = new Size(450, 150);
            lblTotal.Text = "Toplam Tutar  : " + ActiveCustomer.CalculateTotal() + " ₺";
            lblTotalWeight.Text = "Toplam Ağırlık : " + ActiveCustomer.CalculateWeight() + " KG";
            lblTotalTax.Text = "Toplam Vergi  : " + ActiveCustomer.CalculateTax() + " ₺";
        }

        private void rbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(450, 311);
            gbCredit.Location = new Point(12, 110);
            btnPay.Location = new Point(347, 242);
            gbCredit.Visible = true;
            gbCash.Visible = false;
            gbCheck.Visible = false;
            btnPay.Visible = true;
            txtCCNumber.Focus();
        }

        private void rbCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(450, 261);
            gbCheck.Location = new Point(12, 110);
            btnPay.Location = new Point(347, 192);
            gbCredit.Visible = false;
            gbCash.Visible = false;
            gbCheck.Visible = true;
            btnPay.Visible = true;
            txtCheckName.Focus();
        }

        private void rbCash_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(450, 240);
            gbCash.Location = new Point(12, 110);
            btnPay.Location = new Point(347, 171);
            gbCredit.Visible = false;
            gbCash.Visible = true;
            gbCheck.Visible = false;
            btnPay.Visible = true;
            txtCashTendered.Focus();
        }
    }
}
