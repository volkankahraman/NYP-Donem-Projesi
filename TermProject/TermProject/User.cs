using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProject
{
    public class User
    {
        public List<Item> items = new List<Item>();
        public PrepareProgram prepareProgram = new PrepareProgram ();
        public User()
        {
            prepareProgram.itemlist = items;
            prepareProgram.loadDefaults();
        }
    }
}
