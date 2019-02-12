/*
 * A commodity exist only in secters
 * they can contain items or an event
 * they can also require a key or a
 * combo to be oppened
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_DiscordBot.GameCore.World
{
    class Commodity
    {
        public bool HasLock { get; set; }

        // Should I have an inventory or a list of items?
        // If its an inventory I could have the player
        // take in and out items from a commodity
    }
}
