/*
 * An ability is like a stand
 * or a pokemon move
 * Its linked to a person
 * and can not be simply
 * traded. It also consumes
 * XP
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_DiscordBot.GameCore
{
    class Ability
    {
        public string Name { get; set; } // You will be seeing this a lot
        public string Desc { get; set; } //

        public int XPdrain { get; set; }

        //public string RPGBIScript { get; set; }
        //public string LuaScript { get; set; }
    }
}
