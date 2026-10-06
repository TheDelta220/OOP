using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swin_Adventure
{
    internal class Inventory
    {
        private List<Item> _items;

        public Inventory()
        {
            _items = new List<Item>();
        }
        public bool HasItem(string id)
        {
            foreach (Item item in _items)
            {
                if (item.Equals(id))
                {
                    return true;
                }
            }
            return false;

        }
        public void Put(Item item)
        {
            _items.Add(item);
        }
        public Item Take(string id)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    Item Found = item;
                    _items.Remove(item);
                    return Found;
                }
            }
            return null;
        }
        public Item Fetch(string id)
        {
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                { 
                    return item; 
                }

            }return null;

        }
        public string ItemList
        {
            get
            {
                string listItem = "";
                foreach (Item item in _items)
                {
                    listItem = listItem + item.ShortDescription + "\n";

                }
                return listItem;
            }
        }
    }
}
