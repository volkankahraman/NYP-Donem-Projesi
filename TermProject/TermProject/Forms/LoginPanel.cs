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

        private void BtnGiris_Click(object sender, EventArgs e)
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
            else if (username == "" || password == "")
            {
                MessageBox.Show("\nLütfen hem kullanıcıadı hem şifrenızı giriniz.");
            }
            else
            {
                MessageBox.Show("\nkullanıcıadıniz veya şifrenızi yanlış giriyorsunuz.\nTekrar deneyınız.");
            }
        }

        private void LoginPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
