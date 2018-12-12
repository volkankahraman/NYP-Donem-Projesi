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
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
            txtUserName.Text = "customer";//silinecek
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.ToLower() == "admin")
            {
                AdminPanel adminPanel = new AdminPanel();
                this.Hide();
                adminPanel.Show();

            }
            else if (txtUserName.Text.ToLower() == "customer")
            {
                CustomerPanel cp = new CustomerPanel();
                this.Hide();
                cp.Show();
            }

        }
    }
}
