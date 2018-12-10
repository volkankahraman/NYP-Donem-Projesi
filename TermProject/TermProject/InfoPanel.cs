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
    public partial class InfoPanel : Form
    {
        public InfoPanel()
        {
            InitializeComponent();
        }

        


        private void InfoPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            CustomerPanel CustomerPanel = new CustomerPanel();
            CustomerPanel.Show();
        }
    }
}
