using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_DiscordBot.GameCore
{
    class Item
    {
        public string Name { get; set; } // You will be seeing this a lot
        public string Desc { get; set; } //

        public ItemGrade Grade { get; set; } // Works like TF2. Genuine, Unusual, Vintage etc..

        public int Durrability { get; set; } // if -1 it cant take damage

        //public string RPGBIScript { get; set; }
        //public string LuaScript { get; set; }

    }
    struct ItemData // For storing the save data for the item
    {
        public int ItemID; // GameData will have a List<Item> ID is just the key
        public int Damage; // Set this to Durrability

        // I need to make a way to store special types. Like if an item needed a charge var etc...
    }
    enum ItemGrade // Only items are going to be using this
    {
        COMMON,
        UNCOMMON,
        RARE,
        VERYRARE
    }
}
