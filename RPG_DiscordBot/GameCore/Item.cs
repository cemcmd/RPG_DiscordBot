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

        //public string RPGBIScript { get; set; }
        //public string LuaScript { get; set; }

    }
    enum ItemGrade // Only items are going to be using this
    {
        COMMON,
        UNCOMMON,
        RARE,
        VERYRARE
    }
}
