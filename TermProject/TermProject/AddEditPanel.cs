using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProject
{
    public partial class AddEditPanel : Form
    {
        public AdminPanel adminPanel;
        Admin admin = new Admin();
        public AddEditPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text) || string.IsNullOrEmpty(txtWeight.Text) || string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Lütfen Tüm Bilgileri Doldurunuz");
            }
            else
            {
                admin.addItem(adminPanel, txtId.Text, txtName.Text, txtPrice.Text, txtWeight.Text, txtDescription.Text);
                this.Close();
            }

            
      
        }
    }
}
