/*
 * A secter is like a room
 * it contains info about
 * whats near bye, and what
 * paths are aviable
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_DiscordBot.GameCore.World
{
    class Secter
    {
        public string Name { get; set; }
        public string Desc { get; set; }

        public List<Path> Paths { get; set; }
        public List<Commodity> Commodities { get; set; }

    }
}
