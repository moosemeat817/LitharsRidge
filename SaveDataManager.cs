using System;
using System.Collections.Generic;
using ModData;
using UnityEngine;
using MelonLoader;
using MelonLoader.TinyJSON;

namespace LitharsRidge
{
    internal class SaveDataManager
    {
        public static readonly string saveDataTag = "litharsRidgeData";
        public static ModDataManager dataManager = new ModDataManager("LitharsRidge");

        // Your data variables - using Dictionary to match the corpse burial mod pattern
        public static Dictionary<string, int> furnitureData = new Dictionary<string, int>
        {
            ["endTable"] = 0,
            ["foldingChair"] = 0,
            ["stoveMetal"] = 0,
            ["cornerCounter"] = 0,
            ["baseCounter"] = 0,
            ["regularBed"] = 0
        };

        // Helper properties for easier access
        public static int endTable
        {
            get => furnitureData.TryGetValue("endTable", out int value) ? value : 0;
            set => furnitureData["endTable"] = value;
        }

        public static int foldingChair
        {
            get => furnitureData.TryGetValue("foldingChair", out int value) ? value : 0;
            set => furnitureData["foldingChair"] = value;
        }

        public static int stoveMetal
        {
            get => furnitureData.TryGetValue("stoveMetal", out int value) ? value : 0;
            set => furnitureData["stoveMetal"] = value;
        }

        public static int cornerCounter
        {
            get => furnitureData.TryGetValue("cornerCounter", out int value) ? value : 0;
            set => furnitureData["cornerCounter"] = value;
        }

        public static int baseCounter
        {
            get => furnitureData.TryGetValue("baseCounter", out int value) ? value : 0;
            set => furnitureData["baseCounter"] = value;
        }

        public static int regularBed
        {
            get => furnitureData.TryGetValue("regularBed", out int value) ? value : 0;
            set => furnitureData["regularBed"] = value;
        }

        [HarmonyPatch(typeof(SaveGameSystem), nameof(SaveGameSystem.SaveSceneData))]
        private static class SaveFurnitureData
        {
            internal static void Prefix(ref SlotData slot)
            {
                MelonLogger.Msg($"[LitharsRidge] SAVING DATA - endTable: {endTable}, foldingChair: {foldingChair}, stoveMetal: {stoveMetal}, cornerCounter: {cornerCounter}, baseCounter: {baseCounter}, baseCounter: {regularBed}");
                string serializedSaveData = JSON.Dump(furnitureData);
                MelonLogger.Msg($"[LitharsRidge] Serialized data: {serializedSaveData}");
                dataManager.Save(serializedSaveData, saveDataTag);
                MelonLogger.Msg("[LitharsRidge] Save completed");
            }
        }

        [HarmonyPatch(typeof(SaveGameSystem), nameof(SaveGameSystem.LoadSceneData))]
        private static class LoadFurnitureData
        {
            internal static void Postfix(ref string name)
            {
                MelonLogger.Msg($"[LitharsRidge] LOADING DATA for scene: {name}");
                LoadData();
            }
        }

        // Also try hooking into GameManager.LoadScene as backup
        [HarmonyPatch(typeof(GameManager), nameof(GameManager.LoadScene))]
        private static class LoadFurnitureDataBackup
        {
            internal static void Postfix(string sceneName)
            {
                MelonLogger.Msg($"[LitharsRidge] BACKUP LOADING DATA for scene: {sceneName}");
                LoadData();
            }
        }

        // Separate load method to avoid duplication
        public static void LoadData()
        {
            string serializedSaveData = dataManager.Load(saveDataTag);

            if (!string.IsNullOrEmpty(serializedSaveData))
            {
                MelonLogger.Msg($"[LitharsRidge] Found saved data: {serializedSaveData}");
                JSON.MakeInto(JSON.Load(serializedSaveData), out furnitureData);
                MelonLogger.Msg($"[LitharsRidge] LOADED VALUES - endTable: {endTable}, foldingChair: {foldingChair}, stoveMetal: {stoveMetal}, cornerCounter: {cornerCounter}, baseCounter: {baseCounter}, baseCounter: {regularBed}");
            }
            else
            {
                MelonLogger.Msg("[LitharsRidge] No saved data found - resetting to defaults");
                // Reset to defaults for new games
                furnitureData = new Dictionary<string, int>
                {
                    ["endTable"] = 0,
                    ["foldingChair"] = 0,
                    ["stoveMetal"] = 0,
                    ["cornerCounter"] = 0,
                    ["baseCounter"] = 0,
                    ["regularBed"] = 0
                };
                MelonLogger.Msg($"[LitharsRidge] DEFAULT VALUES SET - endTable: {endTable}, foldingChair: {foldingChair}, stoveMetal: {stoveMetal}, cornerCounter: {cornerCounter}, baseCounter: {baseCounter}, baseCounter: {regularBed}");
            }
        }

        // Optional: Manual save method if needed
        public static void SaveData()
        {
            MelonLogger.Msg($"[LitharsRidge] MANUAL SAVE - endTable: {endTable}, foldingChair: {foldingChair}, stoveMetal: {stoveMetal}, cornerCounter: {cornerCounter}, baseCounter: {baseCounter}, baseCounter: {regularBed}");
            string serializedSaveData = JSON.Dump(furnitureData);
            dataManager.Save(serializedSaveData, saveDataTag);
        }

        // Optional: Reset method for debugging
        public static void ResetData()
        {
            MelonLogger.Msg("[LitharsRidge] RESETTING DATA to defaults");
            furnitureData = new Dictionary<string, int>
            {
                ["endTable"] = 0,
                ["foldingChair"] = 0,
                ["stoveMetal"] = 0,
                ["cornerCounter"] = 0,
                ["baseCounter"] = 0,
                ["regularBed"] = 0
            };
            MelonLogger.Msg($"[LitharsRidge] RESET COMPLETE - endTable: {endTable}, foldingChair: {foldingChair}, stoveMetal: {stoveMetal}, cornerCounter: {cornerCounter}, baseCounter: {baseCounter}, baseCounter: {regularBed}");
        }
    }
}