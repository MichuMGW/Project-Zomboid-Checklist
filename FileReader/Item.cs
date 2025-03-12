using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PZChecklistLibrary
{
    public class Item
    {
        public ItemCategory Category { get; set; }
        public string Name { get; set; }
        public bool IsObtained { get; set; } = false;

        public Item(ItemCategory category, string name)
        {
            Category = category;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} ({Category})";
        }
    }

    

}
