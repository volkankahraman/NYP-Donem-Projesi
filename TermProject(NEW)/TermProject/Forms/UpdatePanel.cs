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
    public partial class UpdatePanel : Form
    {
        public Item Item { get; set; }
        public AdminPanel adminPanel { get; set; }

        public UpdatePanel(Item _item, AdminPanel _adminPanel)
        {
            InitializeComponent();
            Item = _item;
            adminPanel = _adminPanel;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {            
            DialogResult dialogResult = MessageBox.Show("Düzenlemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Item ItemToBeUpdated = DataSourceSingleton.GetInstance().ItemList.Where(x => x.ID == Item.ID).FirstOrDefault();
                ItemToBeUpdated.Price = Convert.ToInt32(txtPrice.Text);
                ItemToBeUpdated.Tax = Convert.ToInt32(txtTax.Text);
                ItemToBeUpdated.Weight = Convert.ToInt32(txtWeight.Text);
                ItemToBeUpdated.Name = txtDescription.Text;
            }
            else
            {

            }
            this.Close();
        }

        private void UpdatePanel_Load(object sender, EventArgs e)
        {
            txtID.Text = Item.ID.ToString();
            txtPrice.Text = Item.Price.ToString();
            txtTax.Text = Item.Tax.ToString();
            txtWeight.Text = Item.Weight.ToString();
            txtDescription.Text = Item.Name.ToString();

        }

        private void UpdatePanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            adminPanel.UpdateList();
        }
    }
}
