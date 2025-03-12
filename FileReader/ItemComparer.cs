using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZChecklistLibrary
{
    public class ItemComparer : IEqualityComparer<Item>
    {
        public bool Equals(Item? x, Item? y)
        {
            //Compare the names of the items
            if (x == null || y == null) return false;
            return x.Name == y.Name;
        }

        public int GetHashCode(Item item)
        {
            return item.Name.GetHashCode();
        }
    }

}
