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
    public partial class OrdersPanel : Form
    {
        public OrdersPanel()
        {
            InitializeComponent();
        }

        Customer ActiveCustomer = DataSourceSingleton.GetInstance().ActiveCustomer;

        public void UpdateList()
        {
            lvOrders.View = View.Details;
            lvOrders.Columns.Add("Ürün İsmi", -1, HorizontalAlignment.Left);
            lvOrders.Columns.Add("Ürün Adedi", -1, HorizontalAlignment.Left);
            lvOrders.Columns.Add("Ürün Ağırlığı", -1, HorizontalAlignment.Left);
            lvOrders.Columns.Add("Ürün Fiyatı", -1, HorizontalAlignment.Left);
            lvOrders.Columns.Add("Ürün Durumu", -1, HorizontalAlignment.Left);
            lvOrders.FullRowSelect = true;

            for (int a = 0; a < lvOrders.Columns.Count; a++)
                lvOrders.AutoResizeColumn(a, ColumnHeaderAutoResizeStyle.HeaderSize);

            List<Order> orders = ActiveCustomer.getOrders(ActiveCustomer.Id);

            if (orders != null)
                for (int a = 0; a < orders.Count; a++)
                    lvOrders.Items.Add(new ListViewItem(new string[] {
                    orders[0].OrderDetails[a].Item.Name,
                    orders[0].OrderDetails[a].Quantity.ToString(),
                    orders[0].OrderDetails[a].CalculateWeight().ToString() + "KG",
                    orders[0].OrderDetails[a].CalculateSubTotal().ToString() + "₺",
                    orders[0].OrderStatus.ToString()
                }));
        }

        private void OrdersPanel_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
