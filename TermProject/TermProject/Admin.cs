using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProject
{
    public class Admin : User
    {
        AdminPanel adminPanel;
        public int itemCount = 1;
        public Admin()
        {
            foreach (Item item in items)
            {
                itemCount++;
            }
        }

        public void addItem(AdminPanel adminPanel, int id, string name, float price, float weight, string description, string fileName, int stock)
        {
            Item editItem = items.Find(item => item.Id == id);
            if (editItem != null)
            {
                editItem.Name = name;
                editItem.Price = price;
                editItem.Weight = weight;
                editItem.Description = description;
                editItem.FilePath = fileName;
                editItem.Stock = stock;
                items[items.IndexOf(editItem)] = editItem;
            }
            else
            {
                Item item = new Item();
                item.Id = itemCount;
                item.Name = name;
                item.Price = price;
                item.Weight = weight;
                item.Description = description;
                item.FilePath = fileName;
                item.Stock = stock;
                items.Add(item);
                itemCount++;
            }
            adminPanel.listUpdate();
        }

        public void openMenu(AdminPanel adminsPanel, Admin admin, ListViewItem selectedItem)
        {
            adminPanel = adminsPanel;
            AddEditPanel addEditPanel = new AddEditPanel();
            addEditPanel.adminPanel = adminPanel;
            addEditPanel.admin = admin;
            addEditPanel.Show();

            if (selectedItem != null)
            {
                addEditPanel.onEditItem(selectedItem);
            }
        }

        public void delItem(ListViewItem delItem)
        {
            DialogResult dialogResult = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz ?", "Sipariş Otomasyonu", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Item deleteItem = items.Find(item => item.Id == Convert.ToInt32(delItem.Text));
                items.RemoveAt(items.IndexOf(deleteItem));
                adminPanel.listUpdate();
            }
        }

        public void listOrders()
        {
            //Burada Siparişler Listelenecek
        }
    }
}
