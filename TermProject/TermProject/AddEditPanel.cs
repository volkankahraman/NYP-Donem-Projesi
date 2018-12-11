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

namespace TermProject
{
    public partial class AddEditPanel : Form
    {
        public AdminPanel adminPanel;
        public Admin admin;
        private string path;
        public AddEditPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG(*.PNG)|*.png";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.SafeFileName;
                path = Path.GetTempFileName();
                Image.FromFile(openFileDialog.FileName).Save(path);
                productPicture.Image = Image.FromFile(path);
            }
        }
        public void itemMenuClear()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtWeight.Text = "";
            txtDescription.Text = "";
            txtFilePath.Text = "";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtWeight.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Lütfen Tüm Bilgileri Doldurunuz");
            }
            else
            {
                if(string.IsNullOrEmpty(txtFilePath.Text))
                {
                    MessageBox.Show("Lütfen ürünün resmini yükleyiniz.");
                }
                else
                {
                    admin.addItem(adminPanel, txtId.Text, txtName.Text, txtPrice.Text, txtWeight.Text, txtDescription.Text, path);
                    itemMenuClear();
                    this.Hide();
                }
                
            }

            
      
        }
    }
}
