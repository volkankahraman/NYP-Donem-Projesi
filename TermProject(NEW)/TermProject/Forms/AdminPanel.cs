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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        LoginPanel loginPanel = new LoginPanel();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.ID = DataSourceSingleton.GetInstance().ItemList.Count + 1;
            AddPanel add = new AddPanel(this);
            add.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Item itemTobeRemoved = DataSourceSingleton.GetInstance().ItemList.Where(x => x.ID == ID).FirstOrDefault();
                if (itemTobeRemoved != null)
                {
                    DataSourceSingleton.GetInstance().ItemList.Remove(itemTobeRemoved);
                    UpdateList();
                    MessageBox.Show("Silme İşlemi Başarılı");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            Item itemTobeEdited = DataSourceSingleton.GetInstance().ItemList.Where(x => x.ID == ID).FirstOrDefault();
            if (itemTobeEdited != null)
            {
                UpdatePanel Update = new UpdatePanel(itemTobeEdited, this);
                Update.ShowDialog();
            }
        }

        public void UpdateList()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataSourceSingleton.GetInstance().ItemList;
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = DataSourceSingleton.GetInstance().OrderList;
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginPanel.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}
