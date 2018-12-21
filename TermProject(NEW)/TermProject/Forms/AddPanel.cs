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

namespace TermProject.Forms
{
    public partial class AddPanel : Form
    {
        public AdminPanel adminPanel { get; set; }

        public AddPanel(AdminPanel _adminPanel)
        {
            InitializeComponent();
            adminPanel = _adminPanel;
        }

        private int GetNextID()
        {
            int maxID = 0;
            if (DataSourceSingleton.GetInstance().ItemList.Count > 0)
            {
                maxID = DataSourceSingleton.GetInstance().ItemList.OrderByDescending(x => x.ID).FirstOrDefault().ID + 1;
            }
            return maxID;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bu ürünü eklemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {

                DataSourceSingleton.GetInstance().ItemList.Add(new Item()
                {
                    ID = GetNextID(),
                    Name = txtDescription.Text.ToString(),
                    Price = Convert.ToInt32(txtPrice.Text),
                    Tax = Convert.ToInt32(txtTax.Text),
                    Weight = Convert.ToInt32(txtWeight.Text)
                });
                this.Close();
            }


        }

        private void AddPanel_Load(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            txtID.Text = GetNextID().ToString();
            txtPrice.Text = "";
            txtTax.Text = "";
            txtWeight.Text = "";

        }

        private void AddPanel_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            adminPanel.UpdateList();
        }
    }
}
