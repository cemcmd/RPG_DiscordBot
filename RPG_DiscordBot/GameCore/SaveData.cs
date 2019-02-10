/*
 * This manages all save data
 * and variables that need saving
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace RPG_DiscordBot.GameCore
{
    class SaveData
    {
        public static Dictionary<ulong,Player> Players { get; set; } // Key: UserID, Value: Player Class. This might make choosing a specific player a bit harder when we dont know their id
        public WorldLocation Location { get; set; }

        private const string saveDataDir = "SavaData";
        private const string playerDataPath = saveDataDir + "/PlayerData.json";
        private const string worldDataPath = saveDataDir + "/WorldData.json";

        static SaveData()
        {
            if (!Directory.Exists(saveDataDir)) // Sava data file doesnt exist? Create it
                Directory.CreateDirectory(saveDataDir);

            LoadPlayers();
        }

        private static void LoadPlayers()
        {
            if (!File.Exists(playerDataPath)) // If file doesnt exist, create it
            {
                Players = new Dictionary<ulong, Player>(); // Init Players. Its going to be the same as the json anyway
                string jsonData = JsonConvert.SerializeObject(Players, Formatting.Indented); // Create serialized blank json
                File.WriteAllText(playerDataPath,jsonData);
            }
            else
            {
                string jsonData = File.ReadAllText(playerDataPath);
                Players = JsonConvert.DeserializeObject<Dictionary<ulong, Player>>(jsonData);
            }
        }

        public static void Save()
        {
            string jsonData = JsonConvert.SerializeObject(Players, Formatting.Indented);
            File.WriteAllText(playerDataPath, jsonData);
        }

        public static Player GetPlayer(ulong id)
        {
            return Players[id];
        }

        public static bool RegisterPlayer(ulong id, string name) // adds player to the list. false if failed
        {
            if (Players.ContainsKey(id))
                return false;
            Players.Add(id, new Player(name)); // nice and compact

            Save();
            return true;
        }
    }
}
