using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PZChecklistLibrary
{
    public class ItemList : IEnumerable<Item>
    {
        [JsonInclude]
        public List<Item> Items { get; set; }

        [JsonConstructor]
        public ItemList(List<Item> items)
        {
            Items = items;
        }

        public ItemList() {
            Items = new List<Item>();
        }

        public void AddItem(Item item) {
            Items.Add(item);
        }

        public void RemoveItem(Item item) {
            Items.Remove(item);
        }

        public List<Item> GetByCategory(string category) {
            Regex regex = new Regex(category, RegexOptions.IgnoreCase);
            return Items.FindAll(item => Regex.IsMatch(item.Category.ToString(), category));
        }

        public List<Item> GetByName(string name) {
            Regex regex = new Regex(name, RegexOptions.IgnoreCase);
            return Items.FindAll(item => Regex.IsMatch(item.Name,name));
        }


        public IEnumerator<Item> GetEnumerator()
        {
            return Items.GetEnumerator(); // Zwracamy enumerator wbudowanej listy
        }

        IEnumerator IEnumerable.GetEnumerator() // Wymagana wersja dla niegenerycznego IEnumerable
        {
            return GetEnumerator();
        }
    }
}
