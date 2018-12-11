using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProject
{
    class Admin
    {
        public List<Item> items = new List<Item>();
        //LG LB493LSD 49 inch 3D Akıllı Tv

        public void addItem(AdminPanel adminPanel,string id,string name,string price,string weight,string description)
        {
            Item item = new Item();
            
            item.Id = Convert.ToInt32(id);    
            item.Name = name;
            item.Price = float.Parse(price);
            item.Weight = float.Parse(weight);
            item.Description = description;
            items.Add(item);
            adminPanel.listUpdate(items);

        }

        public void editItem()
        {

        }

        public void delItem()
        {

        }

        
    }
}
