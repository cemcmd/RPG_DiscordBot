using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_DiscordBot.GameCore
{
    class Player
    {
        public string Name { get; set; } // Players name

        public double Health { get; set; } // I dont know if I need to wory about float rounding errors, 
        public double MaxHealth { get; set; } // I guess we will find out later

        public int XP { get; set; } // uint would give problems if we try to take away more xp then we have
        public int Cents { get; set; } // Future config would allow currency to be displayed in either dollars or cents. So money is stored in cents

        public Inventory Backpack { get; set; }

        // 

        public Player(string Name)
        {
            this.Name = Name; // I think the "this.Name" makes it more readable

            Backpack = new Inventory();
        }
    }
}
