/*
Taken from discord bot tutorials
https://www.youtube.com/channel/UCmfZ6FWTHZjPrPP3dWQ1bHg/
*/
using System;
using Discord;
using Discord.WebSocket;
using System.Threading.Tasks;

namespace RPG_DiscordBot
{
    class Program
    {
        private DiscordSocketClient _client;
        private CommandHandler _handler;

        static void Main(string[] args)
        {
            new Program().StartAsync().GetAwaiter().GetResult();
        }

        public async Task StartAsync()
        {
            if(Config.bot.token == "" || Config.bot.token == null)
            {
                Console.WriteLine("No token. Can not start.");
                return;
            }

            _client = new DiscordSocketClient(new DiscordSocketConfig
            {
                LogLevel = LogSeverity.Debug
            });
            _client.Log += Log;
            await _client.LoginAsync(TokenType.Bot, Config.bot.token);
            await _client.StartAsync();

            _handler = new CommandHandler();
            await _handler.InitAsync(_client);
            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.Message);
            return Task.CompletedTask;
        }
    }
}
