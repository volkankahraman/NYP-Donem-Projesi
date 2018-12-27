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
            lvOrders.Columns.Add("Ürün İsmi", 200, HorizontalAlignment.Left);
            lvOrders.Columns.Add("Ürün Adedi", -1, HorizontalAlignment.Right);
            lvOrders.Columns.Add("Ürün Ağırlığı", -1, HorizontalAlignment.Right);
            lvOrders.Columns.Add("Ürün Fiyatı", -1, HorizontalAlignment.Right);
            lvOrders.Columns.Add("Ürün Durumu", -2, HorizontalAlignment.Right);

            for (int a = 1; a <= 4; a++)
                lvOrders.AutoResizeColumn(a, ColumnHeaderAutoResizeStyle.HeaderSize);

            lvOrders.FullRowSelect = true;

            ImageList imageList = new ImageList();
            List<Order> orders = ActiveCustomer.getOrders(ActiveCustomer.Id);

            imageList.ImageSize = new Size(50, 50);

            if (orders != null)
                for (int a = 0; a < orders.Count; a++)
                {
                    List<OrderDetail> orderDetails = orders[a].OrderDetails;
                    for (int b = 0; b < orderDetails.Count; b++)
                    {
                        imageList.Images.Add(orderDetails[b].Item.ID.ToString(), orderDetails[b].Item.Picture);
                        lvOrders.SmallImageList = imageList;
                        lvOrders.Items.Add(new ListViewItem(new string[] {
                            orderDetails[b].Item.Name,
                            orderDetails[b].Quantity.ToString(),
                            orderDetails[b].CalculateWeight().ToString() + "KG",
                            orderDetails[b].CalculateSubTotal().ToString() + "₺",
                            orders[a].OrderStatus.ToString()
                        })
                        { ImageKey = orderDetails[b].Item.ID.ToString() });
                    }
                }
        }

        private void OrdersPanel_Load(object sender, EventArgs e)
        {
            UpdateList();
            this.ActiveControl = btnClose;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
