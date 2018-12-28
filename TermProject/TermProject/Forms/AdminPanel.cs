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
using TermProject.Enums;
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
            LoginPanel loginPanel = new LoginPanel();
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

        private void dataGridItems_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridItems.SelectedCells[0].ColumnIndex == 0)
            {
                MessageBox.Show("Id Değiştirilemez");
                e.Cancel = true;
            }
        }

        private void dataGridItems_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
             MessageBox.Show("Lütfen tüm değerleri dökümanda belirtildiği gibi giriniz.");
        }

        private void dataGridItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridItems.SelectedCells[0].ColumnIndex == 6)
            {
                UpdatePicturePanel updatePicturePanel = new UpdatePicturePanel(Convert.ToInt32(dataGridItems.Rows[dataGridItems.SelectedCells[0].RowIndex].Cells[0].Value));
                updatePicturePanel.ShowDialog();
            }
        }

        public bool canceled = false;
        private void dataGridOrders_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridOrders.SelectedCells[0].ColumnIndex == 1 && Convert.ToInt32(dataGridOrders.SelectedCells[0].Value) == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Siparişi onaylamak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    dataGridOrders.SelectedCells[0].Value = OrderStatus.ONAYLANDI;
                }
                else
                {
                    canceled = true;
                }
            }
        }

        private void dataGridOrders_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridOrders.SelectedCells[0].ColumnIndex != 1 || Convert.ToInt32(dataGridOrders.SelectedCells[0].Value) == 1 || canceled == true)
            {
                e.Cancel = true;
            }
        }
    }
}
