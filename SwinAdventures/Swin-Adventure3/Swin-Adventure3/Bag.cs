using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swin_Adventure3
{
    public class Bag : Item
    {
        private Inventory _Inventory;

        public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _Inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            return _Inventory.Fetch(id);
        }
        public override string FullDescription
        {
            get
            {
                return $"{this.Name}, containing:\n" + _Inventory.ItemList;
            }


        }
        public Inventory Inventory
        {
            get
            {
                return _Inventory;
            }
        }
    }
}
