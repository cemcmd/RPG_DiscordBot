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
                player.Cents,
                player.Luck );

            embedbuild
                .WithTitle(title)
                .WithDescription(desc)
                .WithColor(Color.DarkRed);

            return embedbuild.Build();
        }

        public static Embed GetSkillSetList()
        {
            EmbedBuilder embedBuild = new EmbedBuilder();

            string title = Util.GetAlert("&ChatSkillSetInfoTitle");
            //string desc = Util.GetAlert("&ChatSkillSetInfoDesc");
            embedBuild
                .WithTitle(title)
                .WithColor(Color.DarkBlue);

            for(int i = 0; i < GameData.SkillSets.Count; i++) // finaly a loop
            {
                embedBuild.AddField(
                    (i+1) + ") " + GameData.SkillSets[i].Name,
                    GameData.SkillSets[i].Desc);
            }

            return embedBuild.Build();
        }
    }
}
