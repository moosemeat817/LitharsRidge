using System;
using System.Collections.Generic;
using UnityEngine;

namespace LitharsRidge
{
    public class Clones : MonoBehaviour
    {
        public static readonly string[,] itemDataArray =
        {
            {"0_Scene",              "1_Name"},

            {"CanneryRegion",  "STR_LighthouseBridgeB_Prefab (2)"},
            {"CanneryRegion",  "BJ_BoardwalkShort_Prefab Variant"},
            {"CanneryRegion",  "OBJ_FenceWoodA1_Prefab (7)"},
            {"CanneryRegion",  "STR_BridgeB_small_Prefab"},

            {"CanneryRegion",  "STR_SecurityHutB_Prefab"},
            {"CanneryRegion",  "STR_MetalDoorInt_A_Double_Prefab"},
            {"CanneryRegion",  "ParticleKiller"},
            {"CanneryRegion",  "IndoorSpace"},
            {"CanneryRegion",  "OBJ_FencePicketB_Prefab Variant"},
            {"CanneryRegion",  "OBJ_FencePicketA_Prefab Variant (2)"},
            {"CanneryRegion",  "OBJ_FencePicketPost_Prefab Variant"},
            {"CanneryRegion",  "TRN_PineTree_StumpA_Prefab"},
            {"CanneryRegion",  "TRN_PineTree_SingleB_Prefab_721"},

            {"CanneryRegion",  "TRN_RockCliffBig06_ClimbA_Prefab"},
            {"CanneryRegion",  "TRN_RockCliffBig07_Right_Prefab (1)"},
            {"CanneryRegion",  "TRN_RockCliff_01_Win_Prefab (1)"},
            {"CanneryRegion",  "TRN_RockCliffBig07_Left_Prefab (1)"},
            {"CanneryRegion",  "TRN_RockCliffBig06_ClimbA_Right_Prefab (1)"},
            {"CanneryRegion",  "TRN_RockCliffBig06_ClimbA_Left_Prefab (1)"},
            {"CanneryRegion",  "TRN_RockCliffBig07_Prefab (1)"},

            {"CanneryRegion",  "OBJ_LogBridgeC_Prefab (1)"},
            {"CanneryRegion",  "OBJ_LogBridgeB_Prefab"},
            {"CanneryRegion",  "OBJ_Blizzard_Line_C_Prefab"},

            {"CanneryRegion_SANDBOX",  "TRIGGER_LocationLabel (2)"},

            {"CanneryRegion",  "OBJ_TreeCedarFelledC_Prefab"},
            {"CanneryRegion",  "TRN_PineTreeLog_SingleC1_Prefab (1)"},

            {"CanneryRegion",  "INTERACTIVE_StoveMetalA"},
            {"CanneryRegion_SANDBOX",  "OBJ_PicnicTableE_Prefab (1)"},
            {"CanneryRegion_SANDBOX",  "OBJ_EndTableA_Prefab"},
            {"CanneryRegion_SANDBOX",  "OBJ_ChairFoldng_A_Open_Prefab (4)"},
            {"CanneryRegion_SANDBOX",  "OBJ_CounterShort_Prefab"},
            {"CanneryRegion_SANDBOX",  "OBJ_CounterCorner_Prefab"},
            {"CanneryRegion_SANDBOX",  "INTERACTIVE_BedMattressB"},

            {"CanneryRegion",  "OBJ_HayShedA_Prefab (2)"},
            {"CanneryRegion",  "TRN_MountainDistantC_Prefab"},

            {"CanneryRegion",  "STR_BridgeA_Mid_Prefab"},
        };

        public static void ChangeObjects()
        {
            for (int i = 1; i < itemDataArray.GetLength(0); i++)
            {
                string sceneName = itemDataArray[i, 0];
                string objectName = itemDataArray[i, 1];

                if (string.IsNullOrEmpty(sceneName) || string.IsNullOrEmpty(objectName))
                    continue;

                GameObject findTargetGO = GameObject.Find(objectName);

                // Skip if object not found
                if (findTargetGO == null)
                    continue;

                // Check scene name match
                if (findTargetGO.scene.name != sceneName)
                    continue;

                if (sceneName == "CanneryRegion")
                {
                    ProcessCanneryRegionObjects(objectName, findTargetGO);
                }
                else if (sceneName == "CanneryRegion_SANDBOX")
                {
                    ProcessCanneryRegionSandboxObjects(objectName, findTargetGO);
                }
            }
        }

        private static void ProcessCanneryRegionObjects(string objectName, GameObject findTargetGO)
        {
            if (findTargetGO == null) return;

            switch (objectName)
            {
                // Lithar's Hut Main Structures
                case "STR_SecurityHutB_Prefab":
                    CreateCloneIfNotExists(findTargetGO, "STR_SecurityHutB_Prefab(Clone)",
                        new Vector3(-978.9719f, 215.9389f, 554.1555f),
                        Quaternion.Euler(-0f, 288.2261f, 0f),
                        new Vector3(2.5f, 1f, 2f));
                    break;

                case "STR_MetalDoorInt_A_Double_Prefab":
                    CreateCloneIfNotExists(findTargetGO, "STR_MetalDoorInt_A_Double_Prefab(Clone)",
                        new Vector3(-979.0769f, 216.1889f, 560.3068f),
                        Quaternion.Euler(-0f, 288.6f, 0f),
                        new Vector3(1f, 1.07f, 1.03f));
                    break;

                case "ParticleKiller":
                    CreateCloneIfNotExists(findTargetGO, "ParticleKiller(Clone)",
                        new Vector3(-980.4878f, 217.5962f, 557.0328f),
                        Quaternion.Euler(0, 288.2261f, 0f),
                        new Vector3(7f, 5f, 7f));
                    break;

                case "IndoorSpace":
                    CreateCloneIfNotExists(findTargetGO, "IndoorSpace(Clone)",
                        new Vector3(-980.4878f, 216.12f, 557.0328f),
                        Quaternion.Euler(0, 288.2261f, 0f),
                        new Vector3(8, 1, 6f));
                    break;

                // Fence decorations
                case "OBJ_FencePicketB_Prefab Variant":
                    CreateFencePosts(findTargetGO);
                    break;

                case "OBJ_FencePicketA_Prefab Variant (2)":
                    CreateFencePickets(findTargetGO);
                    break;

                // Cliffs
                case "TRN_RockCliffBig06_ClimbA_Prefab":
                    CreateCloneIfNotExists(findTargetGO, "TRN_RockCliffBig06_ClimbA_Prefab(Clone)",
                        new Vector3(-1241.056f, 104.3214f, 29.1159f),
                        Quaternion.Euler(0f, 341.4941f, 8f),
                        new Vector3(1.4f, 1f, 1.2f));
                    break;

                // Multiple cliff instances
                case "TRN_RockCliffBig07_Prefab (1)":
                    CreateMultipleCliffInstances(findTargetGO);
                    break;

                // Bridges
                case "OBJ_LogBridgeC_Prefab (1)":
                    CreateCloneIfNotExists(findTargetGO, "OBJ_LogBridgeC_Prefab (1)(Clone)",
                        new Vector3(-1200.037f, 66.7343f, -56.4575f),
                        Quaternion.Euler(-0f, 111.3983f, 323.4378f),
                        new Vector3(1.2f, 0.7f, 1.2f));
                    break;

                case "OBJ_LogBridgeB_Prefab":
                    CreateCloneIfNotExists(findTargetGO, "OBJ_LogBridgeB_Prefab(Clone)",
                        new Vector3(-1189.217f, 101.9387f, 37.5554f),
                        Quaternion.Euler(0, 320.3147f, 333.7559f),
                        new Vector3(1.4f, 0.8f, 1.2f));
                    break;

                case "STR_BridgeB_small_Prefab":
                    CreateSmallBridges(findTargetGO);
                    break;

      

                // Fallen trees
                case "TRN_PineTreeLog_SingleC1_Prefab (1)":
                    CreateFallenTrees(findTargetGO);
                    break;

                case "OBJ_TreeCedarFelledC_Prefab":
                    CreateFelledCedars(findTargetGO);
                    break;

                // Blizzard ribbons
                case "OBJ_Blizzard_Line_C_Prefab":
                    CreateBlizzardLines(findTargetGO);
                    break;

                // Expansion objects
                case "OBJ_HayShedA_Prefab (2)":
                    CreateCloneIfNotExists(findTargetGO, "OBJ_HayShedA_Prefab (2)(Clone)",
                        new Vector3(-975.4714f, 215.5354f, 551.1504f),
                        Quaternion.Euler(-0f, 108.4867f, 0f),
                        new Vector3(0.7f, 0.7f, 0.46f));
                    break;

                case "TRN_MountainDistantC_Prefab":
                    CreateCloneIfNotExists(findTargetGO, "TRN_MountainDistantC_Prefab(Clone)",
                        new Vector3(1479.908f, -50.0477f, -1418.622f),
                        Quaternion.Euler(-0f, 1.645f, 0f),
                        Vector3.one);
                    break;

                // Other cliff types
                case "TRN_RockCliff_01_Win_Prefab (1)":
                    CreateCloneIfNotExists(findTargetGO, "TRN_RockCliff_01_Win_Prefab (1(Clone)",
                        new Vector3(-2.92f, 6.9236f, 94.273f),
                        Quaternion.Euler(7.6338f, 61.4907f, 331.7526f),
                        new Vector3(1f, 1f, 1.2f));
                    break;

                case "TRN_RockCliffBig07_Left_Prefab (1)":
                    CreateCloneIfNotExists(findTargetGO, "TRN_RockCliffBig07_Left_Prefab (1)(Clone)",
                        new Vector3(-1455.424f, 169.2333f, 375.2659f),
                        Quaternion.Euler(-0f, 12.8914f, 0f),
                        new Vector3(1f, 1f, 1.2f));
                    break;

                case "TRN_RockCliffBig06_ClimbA_Right_Prefab (1)":
                    CreateCloneIfNotExists(findTargetGO, "TRN_RockCliffBig06_ClimbA_Right_Prefab (1)(Clone)",
                        new Vector3(-1371.333f, 178.203f, 531.3458f),
                        Quaternion.Euler(-0f, 240.2402f, 0f),
                        new Vector3(1f, 1f, 1.4f));
                    break;

                case "TRN_RockCliffBig06_ClimbA_Left_Prefab (1)":
                    CreateCloneIfNotExists(findTargetGO, "TRN_RockCliffBig06_ClimbA_Left_Prefab (1)(Clone)",
                        new Vector3(-1434.528f, 169.038f, 456.6173f),
                        Quaternion.Euler(-0f, 22.4907f, 0f),
                        new Vector3(1f, 1f, 1.3f));
                    break;
                case "STR_BridgeA_Mid_Prefab":
                    CreateCloneIfNotExists(findTargetGO, "STR_BridgeA_Mid_Prefab(Clone)",
                        new Vector3(-1022.463f, 36.0789f, -232.6028f),
                        Quaternion.Euler(-0f, 33.9096f, 1f),
                        new Vector3(1.33f, 2.35f, 1.25f));
                    break;
            }
        }

        private static void ProcessCanneryRegionSandboxObjects(string objectName, GameObject findTargetGO)
        {
            if (findTargetGO == null) return;

            switch (objectName)
            {
                case "OBJ_EndTableA_Prefab":
                    CreateFurnitureIfNotExists(findTargetGO, "OBJ_EndTableA_Prefab(Clone)",
                        new Vector3(-978.4924f, 216.2242f, 555.0944f),
                        Quaternion.Euler(0f, 289.2248f, 0f),
                        Vector3.one, "endTable");
                    break;

                case "OBJ_ChairFoldng_A_Open_Prefab (4)":
                    CreateFurnitureIfNotExists(findTargetGO, "OBJ_ChairFoldng_A_Open_Prefab (4)(Clone)",
                        new Vector3(-978.9299f, 216.2242f, 556.5074f),
                        Quaternion.Euler(0f, 66.283f, 0f),
                        Vector3.one, "foldingChair");
                    break;

                case "OBJ_CounterCorner_Prefab":
                    CreateFurnitureIfNotExists(findTargetGO, "OBJ_CounterCorner_Prefab(Clone)",
                        new Vector3(-983.743f, 216.2242f, 553.5212f),
                        Quaternion.Euler(0f, 17.3176f, 0f),
                        Vector3.one, "cornerCounter");
                    break;

                case "OBJ_CounterShort_Prefab":
                    CreateFurnitureIfNotExists(findTargetGO, "OBJ_CounterShort_Prefab(Clone)",
                        new Vector3(-979.6249f, 216.2242f, 552.4581f),
                        Quaternion.Euler(0f, 19.1539f, 0f),
                        Vector3.one, "baseCounter");
                    break;

                case "INTERACTIVE_BedMattressB":
                    CreateFurnitureIfNotExists(findTargetGO, "INTERACTIVE_BedMattressB(Clone)",
                        new Vector3(-982.1937f, 216.2242f, 558.2231f),
                        Quaternion.Euler(0f, 197.1676f, 0f),
                        Vector3.one, "regularBed");
                    break;
                
            }
        }

        private static void CreateCloneIfNotExists(GameObject source, string cloneName, Vector3 position, Quaternion rotation, Vector3 scale)
        {
            if (source == null || GameObject.Find(cloneName) != null)
                return;

            GameObject cloneObject = Instantiate(source, position, rotation);
            cloneObject.transform.localScale = scale;
        }

        private static void CreateFurnitureIfNotExists(GameObject source, string cloneName, Vector3 position, Quaternion rotation, Vector3 scale, string saveDataKey)
        {
            if (source == null || GameObject.Find(cloneName) != null)
                return;

            // Check if furniture has already been placed using save data
            bool shouldPlace = saveDataKey switch
            {
                "endTable" => SaveDataManager.endTable == 0,
                "foldingChair" => SaveDataManager.foldingChair == 0,
                "cornerCounter" => SaveDataManager.cornerCounter == 0,
                "baseCounter" => SaveDataManager.baseCounter == 0,
                "regularBed" => SaveDataManager.regularBed == 0,
                _ => false
            };

            if (shouldPlace)
            {
                GameObject cloneObject = Instantiate(source, position, rotation);
                cloneObject.transform.localScale = scale;

                // Mark as placed in save data
                switch (saveDataKey)
                {
                    case "endTable":
                        SaveDataManager.endTable = 1;
                        break;
                    case "foldingChair":
                        SaveDataManager.foldingChair = 1;
                        break;
                    case "cornerCounter":
                        SaveDataManager.cornerCounter = 1;
                        break;
                    case "baseCounter":
                        SaveDataManager.baseCounter = 1;
                        break;
                    case "regularBed":
                        SaveDataManager.regularBed = 1;
                        break;
                }

                SaveDataManager.SaveData();
            }
        }

        private static void CreateFencePosts(GameObject source)
        {
            var fencePostData = new[]
            {
                (name: "OBJ_FencePicketB_Prefab Variant(Clone)", pos: new Vector3(-972.5098f, 215.0389f, 549.4567f), rot: Quaternion.Euler(-0f, 104.9999f, 354f)),
                (name: "OBJ_FencePicketB_Prefab Variant2(Clone)", pos: new Vector3(-969.9105f, 215.0389f, 560.6606f), rot: Quaternion.Euler(0f, 104.9999f, 6f)),
                (name: "OBJ_FencePicketB_Prefab Variant3(Clone)", pos: new Vector3(-989.7441f, 215.7389f, 554.6132f), rot: Quaternion.Euler(-0f, 289.9999f, 354f)),
                (name: "OBJ_FencePicketB_Prefab Variant4(Clone)", pos: new Vector3(-985.8287f, 215.4589f, 565.6301f), rot: Quaternion.Euler(-0f, 290.1033f, 354f)),
                (name: "OBJ_FencePicketB_Prefab Variant5(Clone)", pos: new Vector3(-988.1439f, 215.7389f, 551.9509f), rot: Quaternion.Euler(0f, 199.7167f, 354f)),
                (name: "OBJ_FencePicketB_Prefab Variant6(Clone)", pos: new Vector3(-976.4664f, 215.5589f, 548.3965f), rot: Quaternion.Euler(314.1478f, 40.5644f, 354f)),
                (name: "OBJ_FencePicketB_Prefab Variant7(Clone)", pos: new Vector3(-971.6973f, 215.3589f, 563.7303f), rot: Quaternion.Euler(-0f, 20f, 0f))
            };

            foreach (var data in fencePostData)
            {
                CreateCloneIfNotExists(source, data.name, data.pos, data.rot, Vector3.one);
            }
        }

        private static void CreateFencePickets(GameObject source)
        {
            var fencePicketData = new[]
            {
                (name: "OBJ_FencePicketA_Prefab Variant (2)(Clone)", pos: new Vector3(-971.61f, 215.0389f, 553.1998f), rot: Quaternion.Euler(-0f, 102.9999f, 4f)),
                (name: "OBJ_FencePicketA_Prefab Variant (2)2(Clone)", pos: new Vector3(-970.8102f, 215.0389f, 556.9512f), rot: Quaternion.Euler(-0f, 102.9999f, 357.1f)),
                (name: "OBJ_FencePicketA_Prefab Variant (2)3(Clone)", pos: new Vector3(-988.3363f, 215.4389f, 558.5093f), rot: Quaternion.Euler(0f, 289.3456f, 2f)),
                (name: "OBJ_FencePicketA_Prefab Variant (2)4(Clone)", pos: new Vector3(-987.1818f, 215.3389f, 561.9567f), rot: Quaternion.Euler(0f, 290.1998f, 2f)),
                (name: "OBJ_FencePicketA_Prefab Variant (2)5(Clone)", pos: new Vector3(-984.3171f, 215.8389f, 550.7737f), rot: Quaternion.Euler(-0f, 15.9355f, 2f)),
                (name: "OBJ_FencePicketA_Prefab Variant (2)6(Clone)", pos: new Vector3(-980.7463f, 215.7389f, 549.787f), rot: Quaternion.Euler(0f, 15.4423f, 356f)),
                (name: "OBJ_FencePicketA_Prefab Variant (2)7(Clone)", pos: new Vector3(-983.1174f, 215.7389f, 567.3823f), rot: Quaternion.Euler(0f, 15.9355f, 359.4f))
            };

            foreach (var data in fencePicketData)
            {
                CreateCloneIfNotExists(source, data.name, data.pos, data.rot, Vector3.one);
            }
        }

        private static void CreateMultipleCliffInstances(GameObject source)
        {
            var cliffData = new[]
            {
                (name: "TRN_RockCliffBig07_Prefab (1)(Clone)", pos: new Vector3(-1331.647f, 136.4019f, 130.9256f), rot: Quaternion.Euler(-0f, 298.4787f, 0f), scale: new Vector3(1.2f, 1f, 1.6f)),
                (name: "TRN_RockCliffBig07_Prefab (1)2(Clone)", pos: new Vector3(-1446.907f, 171.6911f, 296.1601f), rot: Quaternion.Euler(-0f, 328.4941f, 8f), scale: new Vector3(1.4f, 1f, 1.2f)),
                (name: "TRN_RockCliffBig07_Prefab (1)3(Clone)", pos: new Vector3(-1295.423f, 200.3109f, 591.1105f), rot: Quaternion.Euler(8f, 243.0605f, 7.9999f), scale: new Vector3(1.4f, 1f, 1.2f)),
                (name: "TRN_RockCliffBig07_Prefab (1)4(Clone)", pos: new Vector3(-1232.381f, 179.9483f, 511.4074f), rot: Quaternion.Euler(8f, 227.1605f, 7.9999f), scale: new Vector3(1.3f, .9f, .9f)),
                (name: "TRN_RockCliffBig07_Prefab (1)5(Clone)", pos: new Vector3(-1197.889F, 147.8651F, 230.4266f), rot: Quaternion.Euler(8F, 242.1604F, 7.9999f), scale: new Vector3(1f, 1f, .9f)),
                (name: "TRN_RockCliffBig07_Prefab (1)6(Clone)", pos: new Vector3(-1010.227F, 102.2723F, 431.6479f), rot: Quaternion.Euler(8F, 19.1602F, 7.9999f), scale: new Vector3(1.2f, 1f, 1f))
            };

            foreach (var data in cliffData)
            {
                CreateCloneIfNotExists(source, data.name, data.pos, data.rot, data.scale);
            }
        }

        private static void CreateSmallBridges(GameObject source)
        {
            var bridgeData = new[]
            {
                (name: "STR_BridgeB_small_Prefab(Clone)", pos: new Vector3(-1003.511f, 174.2705f, 301.6757f), rot: Quaternion.Euler(-0f, 50.1659f, 0f), scale: new Vector3(1.4f, 0.8f, 1.2f)),
                (name: "STR_BridgeB_small_Prefab2(Clone)", pos: new Vector3(-950.4373f, 212.4587f, 582.2728f), rot: Quaternion.Euler(-0f, 154.4133f, 0f), scale: new Vector3(1f, 0.8f, 1f))
                
            };

            foreach (var data in bridgeData)
            {
                CreateCloneIfNotExists(source, data.name, data.pos, data.rot, data.scale);
            }
        }

        private static void CreateFallenTrees(GameObject source)
        {
            var treeData = new[]
            {
                (name: "TRN_PineTreeLog_SingleC1_Prefab (1)(Clone)", pos: new Vector3(-1247.719f, 186.9158f, 348.5462f), rot: Quaternion.Euler(4.3555f, 47.5904f, 8.9997f), scale: new Vector3(1.2f, 1.2f, 1.2f)),
                (name: "TRN_PineTreeLog_SingleC1_Prefab (1)2(Clone)", pos: new Vector3(-1349.591f, 136.5935f, 259.6367f), rot: Quaternion.Euler(356.088f, 323.489f, 300.9095f), scale: Vector3.one),
                (name: "TRN_PineTreeLog_SingleC1_Prefab (1)3(Clone)", pos: new Vector3(-1260.956f, 190.4553f, 293.9123f), rot: Quaternion.Euler(278.1299f, 348.0007f, 358.0372f), scale: Vector3.one)
            };

            foreach (var data in treeData)
            {
                CreateCloneIfNotExists(source, data.name, data.pos, data.rot, data.scale);
            }
        }

        private static void CreateFelledCedars(GameObject source)
        {
            var cedarData = new[]
            {
                (name: "OBJ_TreeCedarFelledC_Prefab(Clone)", pos: new Vector3(-1334.171f, 188.9158f, 383.0728f), rot: Quaternion.Euler(0f, 65.4628f, 324.471f)),
                (name: "OBJ_TreeCedarFelledC_Prefab2(Clone)", pos: new Vector3(-1270.137f, 180.5533f, 310.3075f), rot: Quaternion.Euler(-0f, 50.1659f, 46.3665f))
            };

            foreach (var data in cedarData)
            {
                CreateCloneIfNotExists(source, data.name, data.pos, data.rot, Vector3.one);
            }
        }

        private static void CreateBlizzardLines(GameObject source)
        {
            var blizzardLineData = new[]
            {
                (name: "OBJ_Blizzard_Line_C_Prefab(Clone)", pos: new Vector3(-1065.53f, 211.43f, 558.32f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab2(Clone)", pos: new Vector3(-1111.946f, 193.47f, 518.5984f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab3(Clone)", pos: new Vector3(-1237.43f, 176.50f, 394.25f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab4(Clone)", pos: new Vector3(-1257.436f, 167.6932f, 160.4258f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab5(Clone)", pos: new Vector3(-1205.726F, 134.2555F, 72.4452f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab6(Clone)", pos: new Vector3(-1171.994f, 89.5405f, 38.2518f), rot: Quaternion.Euler(0, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab7(Clone)", pos: new Vector3(-1205.843f, 43.4112f, -106.05f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab8(Clone)", pos: new Vector3(-1219.208F, 158.5155F, 116.0638f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab9(Clone)", pos: new Vector3(-1297.569F, 177.8825F, 206.336f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab10(Clone)", pos: new Vector3(-1078.58f, 172.16f, 333.87f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab11(Clone)", pos: new Vector3(-1194.13f, 186.19f, 422.48f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab12(Clone)", pos: new Vector3(-1117.74f, 188.24f, 407.38f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab13(Clone)", pos: new Vector3(-1279.21f, 164.31f, 350.00f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab14(Clone)", pos: new Vector3(-1309.78f, 157.63f, 296.26f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab15(Clone)", pos: new Vector3(-1135.91f, 185.99f, 479.66f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab16(Clone)", pos: new Vector3(-1032.27f, 217.68f, 565.50f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab17(Clone)", pos: new Vector3(-985.64f, 216.28f, 569.16f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab18(Clone)", pos: new Vector3(-968.35f, 215.48f, 563.57f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab19(Clone)", pos: new Vector3(-1166.98f, 186.46f, 443.46f), rot: Quaternion.Euler(-0f, 211.9293f, 0f)),
                (name: "OBJ_Blizzard_Line_C_Prefab20(Clone)", pos: new Vector3(-1114.57f, 238.00f, 604.67f), rot: Quaternion.Euler(-0f, 211.9293f, 0f))
            };

            foreach (var data in blizzardLineData)
            {
                CreateCloneIfNotExists(source, data.name, data.pos, data.rot, Vector3.one);
            }
        }
    }
}