/*
 * This is for the json serializer/deserializer
 * Not ment for save data, but to load from
 * game data
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_DiscordBot.GameCore
{
    struct SkillSet
    {
        public string Name; // its going to be in a list
        public string Desc;
        public int InventoryMaxItems;
        public double MaxHealth; // Health is set to this as well
        public int Luck;
    }

    struct GameConfig
    {
        public bool DispDollarFormat;
       
    }
}
