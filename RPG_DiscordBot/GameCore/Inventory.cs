/*
 * Inventory contains items
 * 
 * to add: sorting
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_DiscordBot.GameCore
{
    class Inventory
    {
        public List<ItemData> Items { get; set; }

        public int MaxItems { get; set; }

        public bool InfiniteItemStack { get; set; } // Having multipul of the same item type wont fill up slots, only takes up one per type.
        public bool InfiniteSpace { get; set; } // Can have infinite items

        public Inventory()
        {
            Items = new List<ItemData>();
            MaxItems = 12;
            InfiniteItemStack = false;
            InfiniteSpace = false;
        }
    }
}
