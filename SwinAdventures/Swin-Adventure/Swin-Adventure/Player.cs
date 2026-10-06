using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swin_Adventure
{
    internal class Player : GameObject
    {
        private Inventory _Inventory;
        

        public Player(string name, string desc) : base(new string [] { "me", "inventory" }, name, desc) 
        {
            _Inventory = new Inventory();
        }

        public GameObject Locate(string id) 
        {
            if (AreYou(id))
            {
                return this;
            }return _Inventory.Fetch(id);
        }
        public override string FullDescription
        {
            get
            {
             return $"{Name}, you are carrying: \n" + _Inventory.ItemList;
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
