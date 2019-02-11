using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using RPG_DiscordBot.GameCore;
using System.IO;
using Newtonsoft.Json;

namespace RPG_DiscordBot.Modules
{
    [Group("debug")]
    public class Debug : ModuleBase<SocketCommandContext>
    {
        [Command("createSkillSet")]
        public async Task CreateSkillSet()
        {
            List<SkillSet> slist = new List<SkillSet>
            {
                new SkillSet
                {
                    Name = "Example SkillSet",
                    Desc = "The default set",
                    InventoryMaxItems = 12,
                    Luck = 1,
                    MaxHealth = 133.7
                },
                new SkillSet
                {
                    Name = "The Second example SkillSet",
                    Desc = "The second default set",
                    InventoryMaxItems = 6,
                    Luck = 2,
                    MaxHealth = 76.0
                }
            }; // Thank you intelisence

            string JsonData = JsonConvert.SerializeObject(slist, Formatting.Indented);
            await Context.Channel.SendMessageAsync(JsonData);
        }
    }
}
