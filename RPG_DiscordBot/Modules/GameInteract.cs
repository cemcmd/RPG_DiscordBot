using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using RPG_DiscordBot.GameCore;

namespace RPG_DiscordBot.Modules
{
    public class GameInteract : ModuleBase<SocketCommandContext>
    {
        [Command("register")]
        public async Task Register([Remainder] string name) //Creates player for the new player. [remainder] includes white space
        {
            if (SaveData.RegisterPlayer(Context.User.Id, name)) //this method returns true on sucess
                await Context.Channel.SendMessageAsync(Util.GetFormattedAlert("&ChatRegisterSucess", name));
            else
                await Context.Channel.SendMessageAsync(Util.GetAlert("&ChatRegisterFailed"));
        }
        [Command("deregister")]
        public async Task Deregister()
        {
            SaveData.DeregisterPlayer(Context.User.Id);

            await Context.Channel.SendMessageAsync("Deregistered lol");
        }

        [Command("skillset")]
        public async Task SetSkillSet(int skillSetIndx)
        {
            if (SaveData.SetSkillSet(Context.User.Id, skillSetIndx-1)) // 1 lower as the displayed indexes are +1ed
                await Context.Channel.SendMessageAsync(Util.GetFormattedAlert("&ChatSetSkillSetSucess",
                    SaveData.Players[Context.User.Id],
                    GameData.SkillSets[skillSetIndx].Name));
            else
                await Context.Channel.SendMessageAsync(Util.GetAlert("&ChatSetSkillSetFailed"));
        }

        [Command("playerinfo")]
        public async Task PlayerInfo()
        {
            await Context.Channel.SendMessageAsync("", false, ChatInfoRequest.GetPlayerInfo(Context.User.Id));
        }

        [Command("skillsets")]
        public async Task SkillSetInfo()
        {
            await Context.Channel.SendMessageAsync("", false, ChatInfoRequest.GetSkillSetList());
        }
    }
}
