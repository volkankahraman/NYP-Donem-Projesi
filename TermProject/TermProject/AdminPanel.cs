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
    public partial class AdminPanel : Form
    {
        public Admin admin = new Admin();
        LoginPanel loginPanel = new LoginPanel();

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            admin.openMenu(this, admin, null);
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginPanel.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count > 0)
                admin.delItem(lstItems.SelectedItems[0]);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstItems.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstItems.SelectedItems[0];
                admin.openMenu(this, admin, selectedItem);
            }
            else
            {
                MessageBox.Show("Öncelikle bir ürün seçmelisiniz.");
            }
        }

        public void listUpdate()
        {
            lstItems.Items.Clear();
            foreach (Item item in admin.items)
            {
                int i = 0;
                string[] itemString = { item.Id.ToString(), item.Name, item.Price.ToString(), item.Weight.ToString(), item.Description, item.FilePath, item.Stock.ToString() };
                var lstViewItem = new ListViewItem(itemString[i]);
                for (i = 1; i < 7; i++)
                    lstViewItem.SubItems.Add(itemString[i]);
                lstItems.Items.Add(lstViewItem);
            }
        }

        private void AdminPanel_Shown(object sender, EventArgs e)
        {
            listUpdate();
        }
    }
}
