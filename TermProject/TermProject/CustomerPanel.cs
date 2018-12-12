using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProject
{
    public partial class CustomerPanel : Form
    {
        LoginPanel login = new LoginPanel();
        
        User user = new User();
        public CustomerPanel()
        {
            InitializeComponent();
        }

        private void CustomerPanel_Load(object sender, EventArgs e)
        {
            for (int a = 0; a < user.items.Count; a++)
                if (user.items[a].Stock != 0)
                    lvProducts.Items.Add(new ListViewItem(new string[] { user.items[a].Id.ToString(), user.items[a].FilePath, user.items[a].Name, user.items[a].Price.ToString() + "₺", user.items[a].Weight.ToString() + "KG", user.items[a].Stock.ToString() }));
            lvProducts.Columns[0].Dispose();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }

        private void CustomerPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }

        private void lvProducts_DoubleClick(object sender, EventArgs e)
        {
            Item item = user.items.Find(x => x.Id == Convert.ToInt16(lvProducts.SelectedItems[0].SubItems[0].Text));
            ItemDetail itemDetail = new ItemDetail();
            itemDetail.Detail = item;
            itemDetail.Show();
        }
    }
}
