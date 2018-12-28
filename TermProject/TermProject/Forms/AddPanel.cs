using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TermProject.DataSource;
using TermProject.Models;
using TermProject.Models.AdminModel;

namespace TermProject.Forms
{
    public partial class AddPanel : Form
    {
        Id id = new Id();
        Admin admin = DataSourceSingleton.GetInstance().ActiveAdmin;

        public AddPanel()
        {
            InitializeComponent();
        }

        private void AddPanel_Load(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            txtID.Text = id.getNextId().ToString();
            txtPrice.Text = "";
            txtTax.Text = "";
            txtWeight.Text = "";


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ürün eklemek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtWeight.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtTax.Text) || string.IsNullOrEmpty(txtStock.Text) || string.IsNullOrEmpty(txtDescription.Text) || (productPicture.Image == Properties.Resources.default_product))
                {
                    MessageBox.Show("Lütfen tüm boş alanları doldurunuz.");
                    
                }
                else
                {
                    try
                    {
                        admin.addItem(new Item
                        {
                            ID = id.getNextId(),
                            Name = txtName.Text,
                            Weight = Convert.ToInt32(txtWeight.Text),
                            Price = Convert.ToInt32(txtPrice.Text),
                            Tax = Convert.ToInt32(txtTax.Text),
                            Stock = Convert.ToInt32(txtStock.Text),
                            Description = txtDescription.Text,
                            Picture = productPicture.Image
                        });
                        this.Close();
                    }catch(Exception)
                    {
                        MessageBox.Show("Lütfen tüm değerleri dökümanda belirtildiği gibi giriniz.");
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            GetPicture picture = new GetPicture();
            if(picture.getPicture() != null)
                productPicture.Image = picture.getPicture();
        }
    }
}
