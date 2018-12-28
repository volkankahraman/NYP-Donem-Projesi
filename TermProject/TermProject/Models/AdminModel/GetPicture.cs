using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TermProject.Models.AdminModel
{
    class GetPicture
    {
        Image image;

        public GetPicture()
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (file.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(file.FileName);
            }
        }
        public Image getPicture()
        {
            return image;
        }
    }
}
