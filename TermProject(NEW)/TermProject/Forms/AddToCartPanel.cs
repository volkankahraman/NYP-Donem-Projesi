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
        private int GetNextID()
        {
            int ID = 0;
            if (DataSourceSingleton.GetInstance().OrderDetails.Count > 0)
                ID = DataSourceSingleton.GetInstance().OrderDetails.OrderByDescending(x => x.OrderID).FirstOrDefault().OrderID + 1;
            return ID;
        }
        private void AddToCartPanel_Load(object sender, EventArgs e)
        {
            pbProductPicture.ImageLocation = Item.Picture;
            lblProductName.Text = "Ürün İsmi: " + Item.Name;
            lblProductPrice.Text = "Ürün Fiyatı: " + Item.Price + "₺";
            lblProductWeight.Text = "Ürün Ağırlığı: " + Item.Weight + "KG";
            lblProductTax.Text = "Vergi: %" + Item.Tax;
            lblProductDescription.Text = "Ürün Açıklaması\n" + Item.Description;
        }
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(txtQuantity.Text) <= this.Item.Stock)
            {
                //MessageBox.Show(DataSourceSingleton.GetInstance().OrderDetails.Where(x => x.Item == this.Item).ToList().Count.ToString());
                //DataSourceSingleton.GetInstance().OrderDetails.Add(new OrderDetail()
                //{
                //    OrderID = GetNextID(),
                //    Item = this.Item,
                //    TaxStatus = Enums.TaxStatus.UNTAXED,
                //    Quantity = Convert.ToInt32(txtQuantity.Text)
                //});
                if (DataSourceSingleton.GetInstance().ActiveCustomer.Cart.Where(x => x.Item == this.Item).ToList().Count == 0)
                {
                    DataSourceSingleton.GetInstance().ActiveCustomer.Cart.Add(new Cart()
                    {
                        Item = this.Item,
                        Quantity = Convert.ToInt32(txtQuantity.Text),
                        TaxStatus = (this.Item.Tax != 0 ? Enums.TaxStatus.TAXED : Enums.TaxStatus.UNTAXED)
                    });
                }
                else
                    DataSourceSingleton.GetInstance().ActiveCustomer.Cart.Find(x => x.Item == this.Item).Quantity += Convert.ToInt32(txtQuantity.Text);
                this.Close();
            }
            else
                MessageBox.Show("Stok Dışı Ürün Sipariş Edilimez.\nBu Ürün İçin Stok Durumu: " + this.Item.Stock);
            CustomerPanel cp = (CustomerPanel)Application.OpenForms["CustomerPanel"];
            if (DataSourceSingleton.GetInstance().ActiveCustomer.Cart != null)
                if (DataSourceSingleton.GetInstance().ActiveCustomer.Cart.Count > 0)
                    cp.btnCartInfo.Text = "Sepet (" + DataSourceSingleton.GetInstance().ActiveCustomer.Cart.Count + ")";
                else
                    cp.btnCartInfo.Text = "Sepet";
        }
    }
}
