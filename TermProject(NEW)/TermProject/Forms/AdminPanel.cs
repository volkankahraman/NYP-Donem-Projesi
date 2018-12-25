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
        Admin admin = DataSourceSingleton.GetInstance().ActiveAdmin;

        public AdminPanel()
        {
            InitializeComponent();
        }
        LoginPanel loginPanel = new LoginPanel();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPanel add = new AddPanel();
            add.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seçtiğiniz itemi silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.Yes)
            {
                admin.delItem(dataGridItems.CurrentCell.RowIndex);
            }
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginPanel.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            dataGridItems.RowTemplate.Height = 60;
            admin.dataGridItems = dataGridItems;
            admin.dataGridOrders = dataGridOrders;
            admin.setDataSource();
            ((DataGridViewImageColumn)dataGridItems.Columns[6]).ImageLayout = DataGridViewImageCellLayout.Zoom; ;


        }

        private void dataGridItems_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           if(dataGridItems.SelectedCells[0].ColumnIndex == 6){
                UpdatePicturePanel updataPicturePanel = new UpdatePicturePanel(Convert.ToInt32(dataGridItems.Rows[dataGridItems.SelectedCells[0].RowIndex].Cells[0].Value));
                updataPicturePanel.ShowDialog();
            }
            
        }
    }
}
