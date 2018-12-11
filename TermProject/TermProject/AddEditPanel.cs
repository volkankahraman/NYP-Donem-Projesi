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
                if((string.IsNullOrEmpty(txtFilePath.Text)))
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddEditPanel_Shown(object sender, EventArgs e)
        {
            this.ControlBox = false;
            txtId.Enabled = false;
            if (string.IsNullOrEmpty(txtId.Text))
            {
                txtId.Text = admin.itemCount.ToString();
            }
        }
        public void onEditItem(ListViewItem selectedItem)
        {
            txtId.Text = selectedItem.Text;
            txtName.Text = selectedItem.SubItems[1].Text;
            txtPrice.Text = selectedItem.SubItems[2].Text;
            txtWeight.Text = selectedItem.SubItems[3].Text;
            txtDescription.Text = selectedItem.SubItems[4].Text;
            txtFilePath.Text = selectedItem.SubItems[1].Text;
            path = selectedItem.SubItems[5].Text;
            productPicture.ImageLocation = selectedItem.SubItems[5].Text;
        }
    }
}
