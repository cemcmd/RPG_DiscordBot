/*
Taken from discord bot tutorials
https://www.youtube.com/channel/UCmfZ6FWTHZjPrPP3dWQ1bHg/
*/
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace RPG_DiscordBot
{
    class Util
    {
        private const string systemLangDir = "SystemLang";
        private const string alertsFile = "alerts.json";

        private static Dictionary<string, string> alerts;

        static Util() // Read alerts.json
        {
            string json = File.ReadAllText("SystemLang/alerts.json");
            var data = JsonConvert.DeserializeObject<dynamic>(json);
            alerts = data.ToObject<Dictionary<string, string>>();
        }

        public static string GetAlert(string key) // In key, Out value
        {
            if (alerts.ContainsKey(key)) return alerts[key];
            return "%GetAlert-" + key;
        }
        
        public static string GetFormattedAlert(string key, params object[] parameter) // For those alerts that take in multipul strings
        {
            if(alerts.ContainsKey(key))
            {
                return string.Format(alerts[key], parameter);
            }
            return "%GetAlertFormatted-" + key;
        }

        public static string ConstructProfilePictureURL(ulong id, string avid) // get profile picture
        {
            return string.Format("https://cdn.discordapp.com/avatars/{0}/{1}.png", id, avid);
        }
    }
}
