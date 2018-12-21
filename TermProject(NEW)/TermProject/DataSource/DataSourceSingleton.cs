using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TermProject.Enums;
using TermProject.Models;
using TermProject.Models.OrderModels;

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
        public List<Item> ItemList { get; set; }
        public List<Order> OrderList { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public Customer ActiveCustomer { get; set; }
        private void Initialize()
        {
            UserList = new List<User>();
            ItemList = new List<Item>();
            OrderList = new List<Order>();
            OrderDetails = new List<OrderDetail>();

            UserList.Add(new Admin()
            {
                UserType = UserType.ADMIN,
                Username = "ulasgokce",
                Password = "123"
            });
            UserList.Add(new Admin()
            {
                UserType = UserType.ADMIN,
                Username = "maho",
                Password = "123"
            });
            UserList.Add(new Customer()
            {
                Id = 0,
                UserType = UserType.CUSTOMER,
                Username = "123",
                Password = "123",
                Name = "Deniz Gökçe",
                Address = "Izmir"
            });
            UserList.Add(new Customer()
            {
                Id = 1,
                UserType = UserType.CUSTOMER,
                Username = "1234",
                Password = "1234",
                Name = "Deniz Gökçe",
                Address = "Izmir"
            });

            ItemList.Add(new Item()
            {
                ID = 0,
                Name = "Super Product",
                Weight = 1,
                Price = 100,
                Tax = 10,
                Stock = 5,
                Description = "Super Product"
            });
            ItemList.Add(new Item()
            {
                ID = 1,
                Name = "Mega Product",
                Weight = 6,
                Price = 1000,
                Tax = 5,
                Stock = 0,
                Description = "Mega Product"
            });
            ItemList.Add(new Item()
            {
                ID = 2,
                Name = "Uber Product",
                Weight = 35,
                Price = 10,
                Tax = 50,
                Stock = 7,
                Description = "Uber Product"
            });
        }
    }
}
