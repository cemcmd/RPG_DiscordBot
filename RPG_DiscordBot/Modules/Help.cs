using System;
using System.Collections.Generic;
using System.Text;
using Discord;
using Discord.Commands;
using System.Threading.Tasks;

namespace RPG_DiscordBot.Modules
{
    public class Help : ModuleBase<SocketCommandContext>
    {
        [Command("help")]
        public async Task SendHelp()
        {
            var embed = new EmbedBuilder();

            embed.WithTitle(Util.GetAlert("&ChatHelpTitle"))
                .WithDescription(Util.GetAlert("&ChatHelpDesc"))
                .WithColor(Color.Gold);

            await Context.User.SendMessageAsync("", false, embed.Build());
        }
    }
}
