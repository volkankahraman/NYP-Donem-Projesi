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
            if (ActiveCustomer.getOrders(ActiveCustomer.Id) != null)
                for (int a = 0; a < ActiveCustomer.getOrders(ActiveCustomer.Id).Count; a++)
                    lvOrders.Items.Add(new ListViewItem(new string[] {
                    ActiveCustomer.getOrders(ActiveCustomer.Id)[a].Item.Name,
                    ActiveCustomer.getOrders(ActiveCustomer.Id)[a].Quantity.ToString(),
                    ActiveCustomer.CalculateWeight((ActiveCustomer.getOrders(ActiveCustomer.Id)[a].Item.ID), 0).ToString() + " KG",
                    ActiveCustomer.CalculateTotal((ActiveCustomer.getOrders(ActiveCustomer.Id)[a].Item.ID), 0).ToString() + " ₺"
                }));
            lvOrders.FullRowSelect = true;
            for (int a = 0; a < 3; a++)
                lvOrders.AutoResizeColumn(a, ColumnHeaderAutoResizeStyle.HeaderSize);
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
