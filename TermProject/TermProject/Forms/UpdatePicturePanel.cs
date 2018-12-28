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
using TermProject.Models.AdminModel;

namespace TermProject.Forms
{
    public partial class UpdatePicturePanel : Form
    {
        Admin admin = DataSourceSingleton.GetInstance().ActiveAdmin;
        int pictureId;
        public UpdatePicturePanel(int id)
        {
            InitializeComponent();
            pictureId = id;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            GetPicture picture = new GetPicture();
            if (picture.getPicture() != null)
                pictureItem.Image = picture.getPicture();
            admin.editPicture(pictureId, pictureItem.Image);
            this.Close();
        }

        private void UpdatePicturePanel_Load(object sender, EventArgs e)
        {
            pictureItem.Image = admin.getPicture(pictureId);
        }
    }
}
