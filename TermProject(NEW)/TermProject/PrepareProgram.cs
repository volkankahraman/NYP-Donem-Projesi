using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProject
{
    public class PrepareProgram
    {
        public List<Item> itemlist;
        Item item = new Item();
        Item item1 = new Item();
        public void loadDefaults()
        {
            item.Id = 1;
            item.Name = "Ürün 1";
            item.Price = 500;
            item.Weight = 10;
            item.Stock = 5;
            item.Description = "Güzel bir tv";
            item.FilePath = Path.GetTempFileName();
            TermProject.Properties.Resources.lgtv.Save(item.FilePath);
            itemlist.Add(item);
            item1.Id = 2;
            item1.Name = "Ürün 2Ürün 2Ürün 2Ürün 2Ürün 2Ürün 2Ürün 2Ürün 2Ürün 2Ürün 2Ürün 2Ürün 2Ürün 2Ürün 2Ürün 2Ürün 2Ürün 2";
            item1.Price = 500;
            item1.Weight = 10;
            item1.Stock = 5;
            item1.Description = "Güzel bir tv";
            item1.FilePath = Path.GetTempFileName();
            TermProject.Properties.Resources.lgtv.Save(item1.FilePath);
            itemlist.Add(item1);
        }
    }
}
