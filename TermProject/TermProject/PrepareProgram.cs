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
        }
       
        
    }
}
