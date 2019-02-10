using System;
using System.Collections.Generic;
using System.Text;
using Discord;

namespace RPG_DiscordBot.GameCore
{
    class ChatInfoRequest
    {
        public static Embed GetPlayerInfo(ulong id) // Returns formated embed with player info
        {
            Player player = SaveData.GetPlayer(id);

            if (player is null) return null; // if it doesnt exist

            EmbedBuilder embedbuild = new EmbedBuilder();

            string title = Util.GetAlert("&ChatPlayerInfoTitle");
            string desc = Util.GetFormattedAlert("&ChatPlayerInfoDesc",
                player.Name,
                player.Health,
                player.MaxHealth,
                player.XP,
                player.Cents );

            embedbuild
                .WithTitle(title)
                .WithDescription(desc)
                .WithColor(Color.DarkRed);

            return embedbuild.Build();
        }
    }
}
