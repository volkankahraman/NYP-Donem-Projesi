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
    public partial class ItemDetail : Form
    {
        public ItemDetail()
        {
            InitializeComponent();
        }
        public Item Detail = new Item();

        private void ItemDetail_Load(object sender, EventArgs e)
        {
            lblProductName.Text = "Ürün İsmi: " + Detail.Name;
            lblProductPrice.Text = "Ürün Fiyatı: " + Detail.Price.ToString() + "₺";
            lblProductDescription.Text = "Ürün Açıklaması: \n" + Detail.Description;
            lblProductWeight.Text = "Ürün Ağırlığı: " + Detail.Weight.ToString() + "KG";
            pbProductPicture.ImageLocation = Detail.FilePath;
        }
    }
}
