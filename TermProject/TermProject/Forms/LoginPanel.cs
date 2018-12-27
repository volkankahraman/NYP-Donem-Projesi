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
using TermProject.Models;

namespace TermProject
{
    public partial class LoginPanel : Form
    {
        public LoginPanel()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtUserPassword.Text;

            User loginUser = DataSourceSingleton.GetInstance().UserList.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
            if (loginUser != null)
            {
                if (loginUser.UserType == UserType.ADMIN)
                {
                    DataSourceSingleton.GetInstance().ActiveAdmin = (Admin)loginUser;
                    AdminPanel adminPanel = new AdminPanel();
                    adminPanel.Show();
                }
                else if (loginUser.UserType == UserType.CUSTOMER)
                {
                    DataSourceSingleton.GetInstance().ActiveCustomer = (Customer)loginUser;
                    CustomerPanel customerPanel = new CustomerPanel();
                    customerPanel.Show();
                }
                this.Hide();
            }
            else if (username == string.Empty)
            {
                MessageBox.Show("Kullanıcı Adı Boş Geçilemez");
                txtUserName.Focus();
            }
            else if (password == string.Empty)
            {
                MessageBox.Show("Şifre Boş Geçilemez");
                txtUserPassword.Focus();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreniz Yanlıştır.\nTekrar Deneyiniz");
                txtUserPassword.Text = string.Empty;
                txtUserPassword.Focus();
            }
        }

        private void LoginPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginPanel_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserName;
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGiris_Click(this, new EventArgs());
        }
    }
}
