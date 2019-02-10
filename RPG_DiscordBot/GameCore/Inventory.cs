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
        public List<Item> Items { get; set; }

        public bool InfiniteItemStack { get; set; } // Having multipul of the same item type wont fill up slots, only takes up one per type.
        public bool InfiniteSpace { get; set; }
    }
}
