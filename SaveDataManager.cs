using System;
using System.Collections.Generic;
using ModData;
using UnityEngine;
using UnityEngine.SceneManagement;
using MelonLoader;
using HarmonyLib;

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

        // Helper properties for easier access
        public static int endTable
        {
            get => furnitureData?.TryGetValue("endTable", out int value) == true ? value : 0;
            set { if (furnitureData != null) furnitureData["endTable"] = value; }
        }

        public static int foldingChair
        {
            get => furnitureData?.TryGetValue("foldingChair", out int value) == true ? value : 0;
            set { if (furnitureData != null) furnitureData["foldingChair"] = value; }
        }

        public static int stoveMetal
        {
            get => furnitureData?.TryGetValue("stoveMetal", out int value) == true ? value : 0;
            set { if (furnitureData != null) furnitureData["stoveMetal"] = value; }
        }

        public static int cornerCounter
        {
            get => furnitureData?.TryGetValue("cornerCounter", out int value) == true ? value : 0;
            set { if (furnitureData != null) furnitureData["cornerCounter"] = value; }
        }

        public static int baseCounter
        {
            get => furnitureData?.TryGetValue("baseCounter", out int value) == true ? value : 0;
            set { if (furnitureData != null) furnitureData["baseCounter"] = value; }
        }

        public static int regularBed
        {
            get => furnitureData?.TryGetValue("regularBed", out int value) == true ? value : 0;
            set { if (furnitureData != null) furnitureData["regularBed"] = value; }
        }

        // Harmony patch for saving
        [HarmonyPatch(typeof(SaveGameSystem), nameof(SaveGameSystem.SaveSceneData))]
        private static class SaveFurnitureData
        {
            internal static void Prefix()
            {
                try
                {
                    if (furnitureData == null)
                    {
                        MelonLogger.Warning("[LitharsRidge] FurnitureData is null during save - initializing defaults");
                        InitializeDefaults();
                    }

                    //MelonLogger.Msg($"[LitharsRidge] SAVING DATA - endTable: {endTable}, foldingChair: {foldingChair}, stoveMetal: {stoveMetal}, cornerCounter: {cornerCounter}, baseCounter: {baseCounter}, regularBed: {regularBed}");

                    // Create JSON format
                    string serializedSaveData = $"{{\"endTable\":{endTable},\"foldingChair\":{foldingChair},\"stoveMetal\":{stoveMetal},\"cornerCounter\":{cornerCounter},\"baseCounter\":{baseCounter},\"regularBed\":{regularBed}}}";

                    if (!string.IsNullOrEmpty(serializedSaveData))
                    {
                        //MelonLogger.Msg($"[LitharsRidge] Serialized data: {serializedSaveData}");
                        dataManager.Save(serializedSaveData, saveDataTag);
                        //MelonLogger.Msg("[LitharsRidge] Save completed");
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

        // Harmony patch for loading - fires AFTER the game has loaded the save data
        [HarmonyPatch(typeof(SaveGameSystem), nameof(SaveGameSystem.LoadSceneData))]
        private static class LoadFurnitureData
        {
            internal static void Postfix()
            {
                try
                {
                    MelonLogger.Msg($"[LitharsRidge] SaveGameSystem.LoadSceneData Postfix fired");
                    // Data loading and furniture creation now handled in LitharsRidge.OnSceneWasLoaded
                }
                catch (Exception ex)
                {
                    MelonLogger.Error($"[LitharsRidge] Error in SaveGameSystem postfix: {ex.Message}\n{ex.StackTrace}");
                }
            }
        }

        public static void LoadData()
        {
            try
            {
                MelonLogger.Msg("[LitharsRidge] Loading furniture data from save");

                string serializedSaveData = dataManager.Load(saveDataTag);

                if (!string.IsNullOrEmpty(serializedSaveData))
                {
                    //MelonLogger.Msg($"[LitharsRidge] Found saved data: {serializedSaveData}");
                    ParseAndApplyData(serializedSaveData);
                    return;
                }

                MelonLogger.Msg("[LitharsRidge] No saved data found - using defaults");
                InitializeDefaults();
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[LitharsRidge] Error loading data: {ex.Message}\n{ex.StackTrace}");
                InitializeDefaults();
            }
        }

        private static void ParseAndApplyData(string serializedSaveData)
        {
            try
            {
                // Parse JSON format
                string trimmed = serializedSaveData.Trim();
                if (!trimmed.StartsWith("{") || !trimmed.EndsWith("}"))
                {
                    MelonLogger.Warning("[LitharsRidge] Invalid data format - not valid JSON");
                    InitializeDefaults();
                    return;
                }

                trimmed = trimmed.Substring(1, trimmed.Length - 2); // Remove { }

                int parsedEndTable = 0;
                int parsedFoldingChair = 0;
                int parsedStoveMetal = 0;
                int parsedCornerCounter = 0;
                int parsedBaseCounter = 0;
                int parsedRegularBed = 0;

                // Parse each key-value pair
                string[] pairs = trimmed.Split(',');
                foreach (string pair in pairs)
                {
                    string[] keyValue = pair.Split(':');
                    if (keyValue.Length != 2) continue;

                    string key = keyValue[0].Trim().Trim('"');
                    string value = keyValue[1].Trim();

                    if (int.TryParse(value, out int intValue))
                    {
                        switch (key)
                        {
                            case "endTable":
                                parsedEndTable = intValue;
                                break;
                            case "foldingChair":
                                parsedFoldingChair = intValue;
                                break;
                            case "stoveMetal":
                                parsedStoveMetal = intValue;
                                break;
                            case "cornerCounter":
                                parsedCornerCounter = intValue;
                                break;
                            case "baseCounter":
                                parsedBaseCounter = intValue;
                                break;
                            case "regularBed":
                                parsedRegularBed = intValue;
                                break;
                        }
                    }
                }

                furnitureData["endTable"] = parsedEndTable;
                furnitureData["foldingChair"] = parsedFoldingChair;
                furnitureData["stoveMetal"] = parsedStoveMetal;
                furnitureData["cornerCounter"] = parsedCornerCounter;
                furnitureData["baseCounter"] = parsedBaseCounter;
                furnitureData["regularBed"] = parsedRegularBed;

                //MelonLogger.Msg($"[LitharsRidge] LOADED VALUES - endTable: {endTable}, foldingChair: {foldingChair}, stoveMetal: {stoveMetal}, cornerCounter: {cornerCounter}, baseCounter: {baseCounter}, regularBed: {regularBed}");
            }
            catch (Exception ex)
            {
                MelonLogger.Error($"[LitharsRidge] Error parsing data: {ex.Message}\n{ex.StackTrace}");
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
            MelonLogger.Msg($"[LitharsRidge] DEFAULT VALUES SET - all furniture values set to 0");
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

                string serializedSaveData = $"{{\"endTable\":{endTable},\"foldingChair\":{foldingChair},\"stoveMetal\":{stoveMetal},\"cornerCounter\":{cornerCounter},\"baseCounter\":{baseCounter},\"regularBed\":{regularBed}}}";

                if (!string.IsNullOrEmpty(serializedSaveData))
                {
                    dataManager.Save(serializedSaveData, saveDataTag);
                    //MelonLogger.Msg($"[LitharsRidge] Manual save completed: {serializedSaveData}");
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
    }
}