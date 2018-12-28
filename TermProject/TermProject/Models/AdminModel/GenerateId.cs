using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TermProject.DataSource;

namespace TermProject.Models
{
    class GeneratedID
    {
        int maxID = 0;
        public int getNextId()
        {
            if (DataSourceSingleton.GetInstance().ItemList.Count > 0)
            {
                maxID = DataSourceSingleton.GetInstance().ItemList.OrderByDescending(x => x.ID).FirstOrDefault().ID + 1;
            }
            return maxID;
        }
    }
}
