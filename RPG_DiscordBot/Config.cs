/*
Taken from discord bot tutorials
https://www.youtube.com/channel/UCmfZ6FWTHZjPrPP3dWQ1bHg/
*/
using System.IO;
using Newtonsoft.Json;

namespace RPG_DiscordBot
{
    class Config
    {
        private const string configDir = "Resources";
        private const string configFile = "config.json";
        private const string pathToFile = configDir + "/" + configFile;

        public static BotConfig bot;

        static Config()
        {
            if (!Directory.Exists(configDir)) // No config directory? Fix it
                Directory.CreateDirectory(configDir);

            if(!File.Exists(pathToFile)) // No config.json? Fix it
            {
                bot = new BotConfig();
                string json = JsonConvert.SerializeObject(bot, Formatting.Indented);
                File.WriteAllText(pathToFile, json);
            }
            else //Deserialize the file and store it in member bot
            {
                string json = File.ReadAllText(pathToFile);
                bot = JsonConvert.DeserializeObject<BotConfig>(json);
            }
        }
    }

    public struct BotConfig
    {
        public string token;
        public string cmdPrefix;
    }
}
