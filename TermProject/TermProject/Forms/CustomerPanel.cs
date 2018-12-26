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
using TermProject.Forms;
using TermProject.Models;

namespace TermProject
{
    public partial class CustomerPanel : Form
    {
        public CustomerPanel()
        {
            InitializeComponent();
        }

        BindingList<Item> ItemList = DataSourceSingleton.GetInstance().ItemList;
        Customer ActiveCustomer = DataSourceSingleton.GetInstance().ActiveCustomer;

        private void CustomerPanel_Load(object sender, EventArgs e)
        {
            lblCustomerName.Text = "Merhaba " + ActiveCustomer.Name;
            UpdateList();
        }

        public void UpdateList()
        {
            lvProductList.View = View.Details;
            lvProductList.Columns.Add("Id", 0);
            lvProductList.Columns.Add("Ürün İsmi", -2, HorizontalAlignment.Left);
            lvProductList.Columns.Add("Ürün Fiyatı", -2, HorizontalAlignment.Left);
            lvProductList.FullRowSelect = true;

            for (int a = 0; a < ItemList.Count; a++)
                if (ItemList[a].Stock > 0)
                    lvProductList.Items.Add(new ListViewItem(new string[] {
                        ItemList[a].ID.ToString(),
                        ItemList[a].Name,
                        ItemList[a].Price.ToString() + "₺"
                    }));

            if (ActiveCustomer.Cart != null)
                if (ActiveCustomer.Cart.Count > 0)
                    btnCartInfo.Text = "Sepet (" + ActiveCustomer.Cart.Count + ")";
                else
                    btnCartInfo.Text = "Sepet";

            for (int a = 1; a < 3; a++)
                lvProductList.AutoResizeColumn(a, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnCartInfo_Click(object sender, EventArgs e)
        {
            if (ActiveCustomer.Cart.Count != 0)
            {
                CartPanel cart = new CartPanel();
                cart.ShowDialog();
            }
            else
                MessageBox.Show("Sepette Ürün Yok");
        }

        private void CustomerPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginPanel login = new LoginPanel();
            login.Show();
        }

        private void lvProductList_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(lvProductList.SelectedItems[0].SubItems[0].Text);
            Item itemTobeAddedToCart = ItemList.Where(x => x.ID == id).FirstOrDefault();
            AddToCartPanel addToCartPanel = new AddToCartPanel(itemTobeAddedToCart);
            addToCartPanel.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrdersPanel op = new OrdersPanel();
            op.ShowDialog();
        }
    }
}