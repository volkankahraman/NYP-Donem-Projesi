using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TermProject.DataSource;
using TermProject.Models;
using TermProject.Models.AdminModel;

namespace TermProject.Models
{
    public class Admin : User
    {
        BindingList<Item> Itemlist = DataSourceSingleton.GetInstance().ItemList;

        public DataGridView dataGridItems { get; set; }
        public DataGridView dataGridOrders { get; set; }

        public void addItem(Item ıtem)
        {
            Itemlist.Add(ıtem);
        }

        public void setDataSource()
        {
            dataGridItems.DataSource = DataSourceSingleton.GetInstance().ItemList;
            dataGridOrders.DataSource = DataSourceSingleton.GetInstance().OrderList;
        }

        public Image getPicture(int id)
        {
            return Itemlist[id].Picture;
        }

        public void editPicture(int id,Image image)
        {
            dataGridItems.Rows[id].Cells[6].Value = image;
        }

        public void delItem(int id)
        {
            dataGridItems.Rows.RemoveAt(id);
        }
    }
}
