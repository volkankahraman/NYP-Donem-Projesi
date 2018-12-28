using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TermProject.Enums;
using TermProject.Models;
using TermProject.Models.OrderModels;
using TermProject.Models.PaymentModels;

namespace TermProject.DataSource
{
    public class DataSourceSingleton
    {
        #region SingletonPattern
        private static DataSourceSingleton instance = null;

        private DataSourceSingleton() { }

        public static DataSourceSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DataSourceSingleton();
                instance.Initialize();
            }
            return instance;
        }
        #endregion

        public List<User> UserList { get; set; }
        public BindingList<Item> ItemList { get; set; }
        public List<Order> OrderList { get; set; }
        public Customer ActiveCustomer { get; set; }
        public Admin ActiveAdmin { get; set; }

        private void Initialize()
        {
            UserList = new List<User>();
            ItemList = new BindingList<Item>();
            OrderList = new List<Order>();

            UserList.Add(new Admin()
            {
                UserType = UserType.ADMIN,
                Username = "volkan",
                Password = "admin"
            });
            UserList.Add(new Customer()
            {
                UserType = UserType.CUSTOMER,
                Username = "ulas",
                Password = "ulas123",
                Name = "Ulaş Gökçe",
                Address = "1671 sokak Tersane Mah. Karşıyaka / İzmir"
            });
            UserList.Add(new Customer()
            {
                Id = 0,
                UserType = UserType.CUSTOMER,
                Username = "ardanuc",
                Password = "123",
                Name = "Ardanuc Akar",
                Address = "5809 sokak Acarlar Mah. Turgutlu / Manisa"
            });
            UserList.Add(new Customer()
            {
                Id = 1,
                UserType = UserType.CUSTOMER,
                Username = "maho",
                Password = "maho123",
                Name = "Muhammed Mehdi",
                Address = "5694 sokak İnönü Cad. Karabağlar / İzmir"
            });

            ItemList.Add(new Item()
            {
                ID = 0,
                Name = "MSI Notebook",
                Weight = 2,
                Price = 4999,
                Tax = 18,
                Stock = 19,
                Description = "Intel Core i5 7300HQ 8GB 1TB GTX1050 Freedos 15.6' FHD Taşınabilir Bilgisayar",
                Picture = new Bitmap(Properties.Resources._9816549425202, new Size(300, 300))
            });
            ItemList.Add(new Item()
            {
                ID = 1,
                Name = "Mitsubishi Klima",
                Weight = 6,
                Price = 3870,
                Tax = 18,
                Stock = 6,
                Description = "12000 BTU Duvar Tipi Inverter Klima",
                Picture = new Bitmap(Properties.Resources._9863517470770, new Size(300, 300))
            });
        }
    }
}
