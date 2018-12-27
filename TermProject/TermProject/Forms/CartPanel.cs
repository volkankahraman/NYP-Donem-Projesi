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
            this.ActiveControl = lvCart;
        }

        BindingList<Item> ItemList = DataSourceSingleton.GetInstance().ItemList;
        Customer ActiveCustomer = DataSourceSingleton.GetInstance().ActiveCustomer;
        CustomerPanel cp = (CustomerPanel)Application.OpenForms["CustomerPanel"];

        private void Cart_Load(object sender, EventArgs e)
        {
            UpdateList();
            this.ActiveControl = btnPayment;
        }

        public void UpdateList()
        {
            lvCart.Clear();
            lvCart.View = View.Details;
            lvCart.Columns.Add("Ürün Id", 0);
            lvCart.Columns.Add("Ürün İsmi", 200, HorizontalAlignment.Left);
            lvCart.Columns.Add("Ürün Adedi", -2, HorizontalAlignment.Right);
            lvCart.Columns.Add("Ürün Ağırlığı", -2, HorizontalAlignment.Right);
            lvCart.Columns.Add("Ürün Fiyatı", -2, HorizontalAlignment.Left);
            lvCart.FullRowSelect = true;

            for (int a = 2; a < lvCart.Columns.Count; a++)
                lvCart.AutoResizeColumn(a, ColumnHeaderAutoResizeStyle.HeaderSize);

            if (ActiveCustomer.Cart != null)
                for (int a = 0; a < DataSourceSingleton.GetInstance().ActiveCustomer.Cart.Count; a++)
                    lvCart.Items.Add(new ListViewItem(new string[] {
                    ActiveCustomer.Cart[a].Item.ID.ToString(),
                    ActiveCustomer.Cart[a].Item.Name,
                    ActiveCustomer.Cart[a].Quantity.ToString(),
                    ActiveCustomer.Cart[a].CalculateWeight().ToString() + "KG",
                    ActiveCustomer.Cart[a].CalculateSubTotal().ToString() + "₺"
                }));

            if (ActiveCustomer.Cart != null)
                if (ActiveCustomer.Cart.Count > 0)
                    cp.btnCartInfo.Text = "Sepet (" + ActiveCustomer.Cart.Count + ")";
                else
                {
                    cp.btnCartInfo.Text = "Sepet";
                    MessageBox.Show("Sepette Ürün Kalmadı");
                    this.Close();
                }
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
                    Cart cartDetailToBeRemoved = ActiveCustomer.Cart.Where(x => x.Item.ID == id).FirstOrDefault();
                    ActiveCustomer.Cart.Remove(cartDetailToBeRemoved);
                    if (ActiveCustomer.Cart.Count == 0)
                    {
                        MessageBox.Show("Sepette Ürün Kalmadı");
                        this.Close();
                    }
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
                int newQuantity, id = Convert.ToInt16(lvCart.SelectedItems[0].SubItems[0].Text), stock = ItemList.Where(x => x.ID == id).ToList()[0].Stock;
                string _newQuantity = Microsoft.VisualBasic.Interaction.InputBox("Yeni adet sayısını giriniz.", "Güncelleme", "");
                if (int.TryParse(_newQuantity, out newQuantity) == true)
                {
                    if (newQuantity != 0)
                    {
                        if (newQuantity <= stock)
                        {
                            Cart cartDetailToBeUpdated = ActiveCustomer.Cart.Where(x => x.Item.ID == id).FirstOrDefault();
                            cartDetailToBeUpdated.Quantity = newQuantity;
                            UpdateList();
                        }
                        else
                            MessageBox.Show("Bu Ürün İçin Stok: " + stock + " Adettir");
                    }
                    else
                    {
                        DialogResult removeControl = new DialogResult();
                        removeControl = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo);

                        if (removeControl == DialogResult.Yes)
                        {
                            Cart cartDetailToBeRemoved = ActiveCustomer.Cart.Where(x => x.Item.ID == id).FirstOrDefault();
                            ActiveCustomer.Cart.Remove(cartDetailToBeRemoved);
                            if (ActiveCustomer.Cart.Count == 0)
                            {
                                MessageBox.Show("Sepette Ürün Kalmadı");
                                this.Close();
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Bir hata oluştu tekrar deneyin.");
            }
            else
                MessageBox.Show("Lütfen Bir Ürün Seçin");
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (ActiveCustomer.Cart.Count != 0)
            {
                Payment payment = new Payment();
                payment.ShowDialog();
                this.Close();
            }
        }

        private void CartPanel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C)
                btnChangeQuantity_Click(this, new EventArgs());
            else if (e.KeyCode == Keys.R)
                btnRemove_Click(this, new EventArgs());
            else if (e.KeyCode == Keys.P)
                btnPayment_Click(this, new EventArgs());
        }
    }
}