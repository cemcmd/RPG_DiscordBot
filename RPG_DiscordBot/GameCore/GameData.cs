﻿/*
 * Class for interacting
 * with the Game Data
 * Read Only data
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace RPG_DiscordBot.GameCore
{
    class GameData
    {
        private const string gameDataDir = "GameData";
        private const string skillSetsPath = gameDataDir + "/SkillSets.json";
        private const string itemsPath = gameDataDir + "/Items.json";

        public static GameConfig Config { get; set; }
        public static List<SkillSet> SkillSets { get; set; }
        public static List<Item> Items { get; set; }

        static GameData()
        {
            if (!Directory.Exists(gameDataDir)) // doesnt exist? Make it!
                Directory.CreateDirectory(gameDataDir);

            LoadItems();
            LoadSkillSets();
        }

        private static void LoadSkillSets()
        {
            if (!File.Exists(skillSetsPath))
                Console.WriteLine(Util.GetFormattedAlert("&ErrorFileNotFound", skillSetsPath));
            else
            {
                string JsonData = File.ReadAllText(skillSetsPath);
                SkillSets = JsonConvert.DeserializeObject<List<SkillSet>>(JsonData);
            }
        }

        private static void LoadItems()
        {
            if (!File.Exists(itemsPath))
                Console.WriteLine(Util.GetFormattedAlert("&ErrorFileNotFound", itemsPath));
            else
            {
                string JsonData = File.ReadAllText(itemsPath);
                Items = JsonConvert.DeserializeObject<List<Item>>(JsonData);
            }
        }
    }
}
