using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TermProject.DataSource;
using TermProject.Models;
using TermProject.Models.OrderModels;

namespace TermProject.Forms
{
    public partial class AddToCartPanel : Form
    {
        public Item Item { get; set; }

        public AddToCartPanel(Item _item)
        {
            Item = _item;
            InitializeComponent();
        }

        Customer ActiveCustomer = DataSourceSingleton.GetInstance().ActiveCustomer;
        CustomerPanel cp = (CustomerPanel)Application.OpenForms["CustomerPanel"];

        private void AddToCartPanel_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtQuantity;
            pbProductPicture.Image = Item.Picture;
            lblProductName.Text = "Ürün İsmi: " + Item.Name;
            lblProductPrice.Text = "Ürün Fiyatı: " + Item.Price + "₺";
            lblProductWeight.Text = "Ürün Ağırlığı: " + Item.Weight + "KG";
            lblProductTax.Text = "Vergi: %" + Item.Tax;
            lblProductDescription.Text = "Ürün Açıklaması\n" + Item.Description;
        }

        void ClearAndFocus()
        {
            txtQuantity.Text = string.Empty;
            txtQuantity.Focus();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int quantity;
            if (txtQuantity.Text != string.Empty)
            {
                if (int.TryParse(txtQuantity.Text, out quantity) == true)
                {
                    if (quantity != 0)
                    {
                        if (quantity <= this.Item.Stock)
                        {
                            if (ActiveCustomer.Cart.Where(x => x.Item.ID == this.Item.ID).ToList().Count == 0)
                            {
                                ActiveCustomer.Cart.Add(new Cart()
                                {
                                    Item = this.Item,
                                    Quantity = quantity,
                                    TaxStatus = (this.Item.Tax != 0 ? Enums.TaxStatus.TAXED : Enums.TaxStatus.UNTAXED)
                                });
                            }
                            else
                                ActiveCustomer.Cart.Find(x => x.Item.ID == this.Item.ID).Quantity += quantity;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Stok Dışı Ürün Sipariş Edilimez.\nBu Ürün İçin Stok Durumu: " + this.Item.Stock);
                            txtQuantity.Text = string.Empty;
                            txtQuantity.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Adet Sayısı 0'dan Büyük Olmalıdır");
                        ClearAndFocus();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Sayı Girişi Yapınız");
                    ClearAndFocus();
                }
            }
            else
            {
                MessageBox.Show("Ürün Adedini Giriniz");
                ClearAndFocus();
            }

            if (ActiveCustomer.Cart != null)
                if (ActiveCustomer.Cart.Count > 0)
                    cp.btnCartInfo.Text = "Sepet (" + ActiveCustomer.Cart.Count + ")";
                else
                    cp.btnCartInfo.Text = "Sepet";
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnAddToCart_Click(this, new EventArgs());
        }
    }
}