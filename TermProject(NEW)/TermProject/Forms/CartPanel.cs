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
using TermProject.Models.OrderModels;

namespace TermProject.Forms
{
    public partial class CartPanel : Form
    {
        public CartPanel()
        {
            InitializeComponent();
        }
        private void Cart_Load(object sender, EventArgs e)
        {
            UpdateList();
        }
        public void UpdateList()
        {
            lvCart.Clear();
            lvCart.View = View.Details;
            lvCart.Columns.Add("Ürün Id", 0);
            lvCart.Columns.Add("Ürün İsmi", -1, HorizontalAlignment.Left);
            lvCart.Columns.Add("Ürün Adedi", -1, HorizontalAlignment.Left);
            lvCart.Columns.Add("Ürün Ağırlığı", -1, HorizontalAlignment.Left);
            lvCart.Columns.Add("Ürün Fiyatı", -1, HorizontalAlignment.Left);
            if (DataSourceSingleton.GetInstance().ActiveCustomer.Cart != null)
                for (int a = 0; a < DataSourceSingleton.GetInstance().ActiveCustomer.Cart.Count; a++)
                    lvCart.Items.Add(new ListViewItem(new string[] {
                    DataSourceSingleton.GetInstance().ActiveCustomer.Cart[a].Item.ID.ToString(),
                    DataSourceSingleton.GetInstance().ActiveCustomer.Cart[a].Item.Name,
                    DataSourceSingleton.GetInstance().ActiveCustomer.Cart[a].Quantity.ToString(),
                    DataSourceSingleton.GetInstance().ActiveCustomer.CalculateWeight().ToString() + "KG",
                    DataSourceSingleton.GetInstance().ActiveCustomer.CalculateTotal().ToString() + "₺"
                }));
            lvCart.FullRowSelect = true;
            for (int a = 1; a < 5; a++)
                lvCart.AutoResizeColumn(a, ColumnHeaderAutoResizeStyle.HeaderSize);
            CustomerPanel cp = (CustomerPanel)Application.OpenForms["CustomerPanel"];
            if (DataSourceSingleton.GetInstance().ActiveCustomer.Cart != null)
                if (DataSourceSingleton.GetInstance().ActiveCustomer.Cart.Count > 0)
                    cp.btnCartInfo.Text = "Sepet (" + DataSourceSingleton.GetInstance().ActiveCustomer.Cart.Count + ")";
                else
                    cp.btnCartInfo.Text = "Sepet";
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvCart.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt16(lvCart.SelectedItems[0].SubItems[0].Text);
                DialogResult removeControl = new DialogResult();
                removeControl = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (removeControl == DialogResult.Yes)
                {
                    Cart cartDetailToBeRemoved = DataSourceSingleton.GetInstance().ActiveCustomer.Cart.Where(x => x.Item.ID == id).FirstOrDefault();
                    DataSourceSingleton.GetInstance().ActiveCustomer.Cart.Remove(cartDetailToBeRemoved);
                }
                UpdateList();
            }
            else
                MessageBox.Show("Lütfen Bir Ürün Seçin");
        }
        private void btnChangeQuantity_Click(object sender, EventArgs e)
        {
            if (lvCart.SelectedItems.Count > 0)
            {
                int newQuantity, id = Convert.ToInt16(lvCart.SelectedItems[0].SubItems[0].Text);
                string _newQuantity = Microsoft.VisualBasic.Interaction.InputBox("Yeni adet sayısını giriniz.", "Güncelleme", "");
                if (int.TryParse(_newQuantity, out newQuantity) == true)
                {
                    Cart cartDetailToBeUpdated = DataSourceSingleton.GetInstance().ActiveCustomer.Cart.Where(x => x.Item.ID == id).FirstOrDefault();
                    cartDetailToBeUpdated.Quantity = newQuantity;
                    UpdateList();
                }
                else
                    MessageBox.Show("Bir hata oluştu tekrar deneyin.");
            }
            else
                MessageBox.Show("Lütfen Bir Ürün Seçin");
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.ShowDialog();
        }
    }
}
