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

        // Furniture placement data
        public static Dictionary<string, int> furnitureData = new Dictionary<string, int>
        {
            ["endTable"] = 0,
            ["foldingChair"] = 0,
            ["stoveMetal"] = 0,
            ["cornerCounter"] = 0,
            ["baseCounter"] = 0,
            ["regularBed"] = 0
        };

        // Helper properties for easier access with null safety
        public static int endTable
        {
            get => furnitureData?.TryGetValue("endTable", out int value) == true ? value : 0;
            set
            {
                if (furnitureData != null)
                    furnitureData["endTable"] = value;
            }
        }

        public static int foldingChair
        {
            get => furnitureData?.TryGetValue("foldingChair", out int value) == true ? value : 0;
            set
            {
                if (furnitureData != null)
                    furnitureData["foldingChair"] = value;
            }
        }

        public static int stoveMetal
        {
            get => furnitureData?.TryGetValue("stoveMetal", out int value) == true ? value : 0;
            set
            {
                if (furnitureData != null)
                    furnitureData["stoveMetal"] = value;
            }
        }

        public static int cornerCounter
        {
            get => furnitureData?.TryGetValue("cornerCounter", out int value) == true ? value : 0;
            set
            {
                if (furnitureData != null)
                    furnitureData["cornerCounter"] = value;
            }
        }

        public static int baseCounter
        {
            get => furnitureData?.TryGetValue("baseCounter", out int value) == true ? value : 0;
            set
            {
                if (furnitureData != null)
                    furnitureData["baseCounter"] = value;
            }
        }

        public static int regularBed
        {
            get => furnitureData?.TryGetValue("regularBed", out int value) == true ? value : 0;
            set
            {
                if (furnitureData != null)
                    furnitureData["regularBed"] = value;
            }
        }

        [HarmonyPatch(typeof(SaveGameSystem), nameof(SaveGameSystem.SaveSceneData))]
        private static class SaveFurnitureData
        {
            internal static void Prefix(ref SlotData slot)
            {
                try
                {
                    if (furnitureData == null)
                    {
                        MelonLogger.Warning("[LitharsRidge] FurnitureData is null during save - initializing defaults");
                        InitializeDefaults();
                    }

                    MelonLogger.Msg($"[LitharsRidge] SAVING DATA - endTable: {endTable}, foldingChair: {foldingChair}, stoveMetal: {stoveMetal}, cornerCounter: {cornerCounter}, baseCounter: {baseCounter}, regularBed: {regularBed}");

                    string serializedSaveData = JSON.Dump(furnitureData);
                    if (!string.IsNullOrEmpty(serializedSaveData))
                    {
                        MelonLogger.Msg($"[LitharsRidge] Serialized data: {serializedSaveData}");
                        dataManager.Save(serializedSaveData, saveDataTag);
                        MelonLogger.Msg("[LitharsRidge] Save completed");
                    }
                    else
                    {
                        MelonLogger.Warning("[LitharsRidge] Failed to serialize save data");
                    }
                }
                catch (Exception ex)
                {
                    MelonLogger.Error($"[LitharsRidge] Error saving data: {ex.Message}");
                }
            }
        }

        [HarmonyPatch(typeof(SaveGameSystem), nameof(SaveGameSystem.LoadSceneData))]
        private static class LoadFurnitureData
        {
            internal static void Postfix(ref string name)
            {
                try
                {
                    MelonLogger.Msg($"[LitharsRidge] LOADING DATA for scene: {name}");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MelonLogger.Error($"[LitharsRidge] Error loading data for scene {name}: {ex.Message}");
                    InitializeDefaults();
                }
            }
        }

        // Backup load hook
        [HarmonyPatch(typeof(GameManager), nameof(GameManager.LoadScene))]
        private static class LoadFurnitureDataBackup
        {
            internal static void Postfix(string sceneName)
            {
                try
                {
                    MelonLogger.Msg($"[LitharsRidge] BACKUP LOADING DATA for scene: {sceneName}");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MelonLogger.Error($"[LitharsRidge] Error in backup load for scene {sceneName}: {ex.Message}");
                    InitializeDefaults();
                }
            }
        }

        public static void LoadData()
        {
            try
            {
                if (dataManager == null)
                {
                    MelonLogger.Warning("[LitharsRidge] DataManager is null - cannot load data");
                    InitializeDefaults();
                    return;
                }

                string serializedSaveData = dataManager.Load(saveDataTag);

                if (!string.IsNullOrEmpty(serializedSaveData))
                {
                    MelonLogger.Msg($"[LitharsRidge] Found saved data: {serializedSaveData}");

                    var loadedData = JSON.Load(serializedSaveData);
                    if (loadedData != null)
                    {
                        JSON.MakeInto(loadedData, out furnitureData);

                        // Ensure all required keys exist
                        EnsureAllKeysExist();

                        MelonLogger.Msg($"[LitharsRidge] LOADED VALUES - endTable: {endTable}, foldingChair: {foldingChair}, stoveMetal: {stoveMetal}, cornerCounter: {cornerCounter}, baseCounter: {baseCounter}, regularBed: {regularBed}");
                    }
                    else
                    {
                        MelonLogger.Warning("[LitharsRidge] Failed to parse saved data - using defaults");
                        InitializeDefaults();
                    }
                }
                else
                {
                    MelonLogger.Msg("[LitharsRidge] No saved data found - resetting to defaults");
                    InitializeDefaults();
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[LitharsRidge] Error loading data: {ex.Message}");
                InitializeDefaults();
            }
        }

        private static void InitializeDefaults()
        {
            furnitureData = new Dictionary<string, int>
            {
                ["endTable"] = 0,
                ["foldingChair"] = 0,
                ["stoveMetal"] = 0,
                ["cornerCounter"] = 0,
                ["baseCounter"] = 0,
                ["regularBed"] = 0
            };
            MelonLogger.Msg($"[LitharsRidge] DEFAULT VALUES SET - endTable: {endTable}, foldingChair: {foldingChair}, stoveMetal: {stoveMetal}, cornerCounter: {cornerCounter}, baseCounter: {baseCounter}, regularBed: {regularBed}");
        }

        private static void EnsureAllKeysExist()
        {
            if (furnitureData == null)
            {
                InitializeDefaults();
                return;
            }

            var requiredKeys = new[] { "endTable", "foldingChair", "stoveMetal", "cornerCounter", "baseCounter", "regularBed" };

            foreach (var key in requiredKeys)
            {
                if (!furnitureData.ContainsKey(key))
                {
                    furnitureData[key] = 0;
                    MelonLogger.Msg($"[LitharsRidge] Added missing key: {key}");
                }
            }
        }

        // Manual save method for immediate saving
        public static void SaveData()
        {
            try
            {
                if (furnitureData == null)
                {
                    MelonLogger.Warning("[LitharsRidge] Cannot save - furnitureData is null");
                    return;
                }

                if (dataManager == null)
                {
                    MelonLogger.Warning("[LitharsRidge] Cannot save - dataManager is null");
                    return;
                }

                MelonLogger.Msg($"[LitharsRidge] MANUAL SAVE - endTable: {endTable}, foldingChair: {foldingChair}, stoveMetal: {stoveMetal}, cornerCounter: {cornerCounter}, baseCounter: {baseCounter}, regularBed: {regularBed}");

                string serializedSaveData = JSON.Dump(furnitureData);
                if (!string.IsNullOrEmpty(serializedSaveData))
                {
                    dataManager.Save(serializedSaveData, saveDataTag);
                    MelonLogger.Msg("[LitharsRidge] Manual save completed");
                }
                else
                {
                    MelonLogger.Warning("[LitharsRidge] Failed to serialize data for manual save");
                }
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[LitharsRidge] Error during manual save: {ex.Message}");
            }
        }

        // Reset method for debugging
        public static void ResetData()
        {
            try
            {
                MelonLogger.Msg("[LitharsRidge] RESETTING DATA to defaults");
                InitializeDefaults();
                SaveData(); // Persist the reset
                MelonLogger.Msg($"[LitharsRidge] RESET COMPLETE - endTable: {endTable}, foldingChair: {foldingChair}, stoveMetal: {stoveMetal}, cornerCounter: {cornerCounter}, baseCounter: {baseCounter}, regularBed: {regularBed}");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[LitharsRidge] Error during reset: {ex.Message}");
            }
        }
    }
}