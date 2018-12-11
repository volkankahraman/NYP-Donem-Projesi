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
        AddEditPanel addEditPanel = new AddEditPanel();
        public AdminPanel()
        {
            InitializeComponent();
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addEditPanel.adminPanel = this;
            addEditPanel.admin = admin;
            addEditPanel.Show();

        }
        LoginPanel loginPanel = new LoginPanel();

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginPanel.Show();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            admin.delItem();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            admin.editItem();
        }

        public void listUpdate(List<Item> items)
        {
            lstItems.Items.Clear();
            foreach (Item item in items)
            {
                int i = 0;
                 string[] itemString = {item.Id.ToString(),item.Name,item.Price.ToString(),item.Weight.ToString(),item.Description,item.FilePath};
                 var lstViewItem = new ListViewItem(itemString[i]);
                 for(i = 1;i<6;i++)
                     lstViewItem.SubItems.Add(itemString[i]);
                 lstItems.Items.Add(lstViewItem);
                
            }
            
        }
    }
}
