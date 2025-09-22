using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace LitharsRidge
{
    public class Clones : MonoBehaviour
    {


        public static string[,] itemDataArray =
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


        };

        public static void ChangeObjects()
        {

            GameObject findTargetGO = new GameObject();



            for (int i = 1; i < itemDataArray.GetLength(0); i++)
            {
                // ----- Find Name -----------------------------------------------------------------
                if (GameObject.Find(itemDataArray[i, 1]) == null)
                {
                    //MelonLogger.Msg("ChangeObject is null.");
                    continue;
                }
                else
                {
                    findTargetGO = GameObject.Find(itemDataArray[i, 1]);
                    // GameObject.Find cannot find for already inactive game objects. So this needs to be reloaded after confermation.
                }
                // -------------------------------------------------------------------------------------


                if (findTargetGO != null)
                {
                    // ----- Scene check -----------------------------------------------------------------
                    if (findTargetGO.scene.name != itemDataArray[i, 0]) // Scene 
                    {
                        //MelonLogger.Msg("Scene name does not match.");
                        continue;
                    }
                    // -------------------------------------------------------------------------------------




                    if (itemDataArray[i, 0] == "CanneryRegion")
                    {




                        // ==============================================================================================================
                        // Lithar's Hut 
                        // ==============================================================================================================



                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "STR_SecurityHutB_Prefab" && !GameObject.Find("STR_SecurityHutB_Prefab(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-978.9719f, 215.9389f, 554.1555f),
                                Quaternion.Euler(-0f, 288.2261f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(2.5f, 1f, 2f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "STR_MetalDoorInt_A_Double_Prefab" && !GameObject.Find("STR_MetalDoorInt_A_Double_Prefab(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-979.0769f, 216.1889f, 560.3068f),
                                Quaternion.Euler(-0f, 288.6f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1.07f, 1.03f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "ParticleKiller" && !GameObject.Find("ParticleKiller(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-980.4878f, 217.5962f, 557.0328f),
                                Quaternion.Euler(0, 288.2261f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(7f, 5f, 7f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "IndoorSpace" && !GameObject.Find("IndoorSpace(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-980.4878f, 217.5962f, 557.0328f),
                                Quaternion.Euler(0, 288.2261f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(8, 1, 6f);


                        }
                        // ------------------------------------------------------------------------------------------




                        // ==============================================================================================================
                        // Lithar's Hut Dressing 
                        // ==============================================================================================================


                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_FencePicketB_Prefab Variant" && !GameObject.Find("OBJ_FencePicketB_Prefab Variant(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-972.5098f, 215.0389f, 549.4567f),
                                Quaternion.Euler(-0f, 104.9999f, 354f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_FencePicketA_Prefab Variant (2)" && !GameObject.Find("OBJ_FencePicketA_Prefab Variant (2)(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-971.61f, 215.0389f, 553.1998f),
                                Quaternion.Euler(-0f, 102.9999f, 4f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_FencePicketB_Prefab Variant" && !GameObject.Find("OBJ_FencePicketB_Prefab Variant2(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-969.9105f, 215.0389f, 560.6606f),
                                Quaternion.Euler(0f, 104.9999f, 6f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_FencePicketA_Prefab Variant (2)" && !GameObject.Find("OBJ_FencePicketA_Prefab Variant (2)2(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-970.8102f, 215.0389f, 556.9512f),
                                Quaternion.Euler(-0f, 102.9999f, 357.1f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------






                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_FencePicketB_Prefab Variant" && !GameObject.Find("OBJ_FencePicketB_Prefab Variant3(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-989.7441f, 215.7389f, 554.6132f),
                                Quaternion.Euler(-0f, 289.9999f, 354f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_FencePicketA_Prefab Variant (2)" && !GameObject.Find("OBJ_FencePicketA_Prefab Variant (2)3(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-988.3363f, 215.4389f, 558.5093f),
                                Quaternion.Euler(0f, 289.3456f, 2f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_FencePicketB_Prefab Variant" && !GameObject.Find("OBJ_FencePicketB_Prefab Variant4(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-985.8287f, 215.4589f, 565.6301f),
                                Quaternion.Euler(-0f, 290.1033f, 354f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_FencePicketA_Prefab Variant (2)" && !GameObject.Find("OBJ_FencePicketA_Prefab Variant (2)4(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-987.1818f, 215.3389f, 561.9567f),
                                Quaternion.Euler(0f, 290.1998f, 2f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------








                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_FencePicketB_Prefab Variant" && !GameObject.Find("OBJ_FencePicketB_Prefab Variant5(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-988.1439f, 215.7389f, 551.9509f),
                                Quaternion.Euler(0f, 199.7167f, 354f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_FencePicketA_Prefab Variant (2)" && !GameObject.Find("OBJ_FencePicketA_Prefab Variant (2)5(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-984.3171f, 215.8389f, 550.7737f),
                                Quaternion.Euler(-0f, 15.9355f, 2f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_FencePicketB_Prefab Variant" && !GameObject.Find("OBJ_FencePicketB_Prefab Variant6(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-976.4664f, 215.5589f, 548.3965f),
                                Quaternion.Euler(314.1478f, 40.5644f, 354f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_FencePicketA_Prefab Variant (2)" && !GameObject.Find("OBJ_FencePicketA_Prefab Variant (2)6(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-980.7463f, 215.7389f, 549.787f),
                                Quaternion.Euler(0f, 15.4423f, 356f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------






                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_FencePicketA_Prefab Variant (2)" && !GameObject.Find("OBJ_FencePicketA_Prefab Variant (2)7(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-983.1174f, 215.7389f, 567.3823f),
                                Quaternion.Euler(0f, 15.9355f, 359.4f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_FencePicketB_Prefab Variant" && !GameObject.Find("OBJ_FencePicketB_Prefab Variant7(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-971.6973f, 215.3589f, 563.7303f),
                                Quaternion.Euler(-0f, 20f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------





                        // ==============================================================================================================
                        // Lithar's Cliffs
                        // ==============================================================================================================


                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "TRN_RockCliffBig06_ClimbA_Prefab" && !GameObject.Find("TRN_RockCliffBig06_ClimbA_Prefab(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1241.056f, 104.3214f, 29.1159f),
                                Quaternion.Euler(0f, 341.4941f, 8f)
                            );
                            cloneObject.transform.localScale = new Vector3(1.4f, 1f, 1.2f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "TRN_RockCliffBig07_Prefab (1)" && !GameObject.Find("TRN_RockCliffBig07_Prefab (1)(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1331.647f, 136.4019f, 130.9256f),
                                Quaternion.Euler(-0f, 298.4787f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1.2f, 1f, 1.6f);


                        }
                        // ------------------------------------------------------------------------------------------





                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "TRN_RockCliff_01_Win_Prefab (1" && !GameObject.Find("TRN_RockCliff_01_Win_Prefab (1(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-2.92f, 6.9236f, 94.273f),
                                Quaternion.Euler(7.6338f, 61.4907f, 331.7526f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1.2f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "TRN_RockCliffBig07_Left_Prefab (1)" && !GameObject.Find("TRN_RockCliffBig07_Left_Prefab (1)(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1455.424f, 169.2333f, 375.2659f),
                                Quaternion.Euler(-0f, 12.8914f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1.2f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "TRN_RockCliffBig06_ClimbA_Right_Prefab (1)" && !GameObject.Find("TRN_RockCliffBig06_ClimbA_Right_Prefab (1)(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1371.333f, 178.203f, 531.3458f),
                                Quaternion.Euler(-0f, 240.2402f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1.4f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "TRN_RockCliffBig06_ClimbA_Left_Prefab (1)" && !GameObject.Find("TRN_RockCliffBig06_ClimbA_Left_Prefab (1)(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1434.528f, 169.038f, 456.6173f),
                                Quaternion.Euler(-0f, 22.4907f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1.3f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "TRN_RockCliffBig07_Prefab (1)" && !GameObject.Find("TRN_RockCliffBig07_Prefab (1)2(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1446.907f, 171.6911f, 296.1601f),
                                Quaternion.Euler(-0f, 328.4941f, 8f)
                            );
                            cloneObject.transform.localScale = new Vector3(1.4f, 1f, 1.2f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "TRN_RockCliffBig07_Prefab (1)" && !GameObject.Find("TRN_RockCliffBig07_Prefab (1)3(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1295.423f, 200.3109f, 591.1105f),
                                Quaternion.Euler(8f, 243.0605f, 7.9999f)
                            );
                            cloneObject.transform.localScale = new Vector3(1.4f, 1f, 1.2f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "TRN_RockCliffBig07_Prefab (1)" && !GameObject.Find("TRN_RockCliffBig07_Prefab (1)4(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1232.381f, 179.9483f, 511.4074f),
                                Quaternion.Euler(8f, 227.1605f, 7.9999f)
                            );
                            cloneObject.transform.localScale = new Vector3(1.3f, .9f, .9f);


                        }
                        // ------------------------------------------------------------------------------------------


                        // Roof------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "TRN_RockCliffBig07_Prefab (1)" && !GameObject.Find("TRN_RockCliffBig07_Prefab (1)5(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1197.889F, 147.8651F, 230.4266f),
                                Quaternion.Euler(8F, 242.1604F, 7.9999f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, .9f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "TRN_RockCliffBig07_Prefab (1)" && !GameObject.Find("TRN_RockCliffBig07_Prefab (1)6(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1010.227F, 102.2723F, 431.6479f),
                                Quaternion.Euler(8F, 19.1602F, 7.9999f)
                            );
                            cloneObject.transform.localScale = new Vector3(1.2f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------



                        // ==============================================================================================================
                        // Lithar's Bridges 
                        // ==============================================================================================================



                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_LogBridgeC_Prefab (1)" && !GameObject.Find("OBJ_LogBridgeC_Prefab (1)(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1200.037f, 66.7343f, -56.4575f),
                                Quaternion.Euler(-0f, 111.3983f, 323.4378f)
                            );
                            cloneObject.transform.localScale = new Vector3(1.2f, 0.7f, 1.2f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_LogBridgeB_Prefab" && !GameObject.Find("OBJ_LogBridgeB_Prefab(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1189.217f, 101.9387f, 37.5554f),
                                Quaternion.Euler(0, 320.3147f, 333.7559f)
                            );
                            cloneObject.transform.localScale = new Vector3(1.4f, 0.8f, 1.2f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "STR_BridgeB_small_Prefab" && !GameObject.Find("STR_BridgeB_small_Prefab(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1003.511f, 174.2705f, 301.6757f),
                                Quaternion.Euler(-0f, 50.1659f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1.4f, 0.8f, 1.2f);


                        }
                        // ------------------------------------------------------------------------------------------



                        // ==============================================================================================================
                        // Lithar's Fallen Trees 
                        // ==============================================================================================================



                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "TRN_PineTreeLog_SingleC1_Prefab (1)" && !GameObject.Find("TRN_PineTreeLog_SingleC1_Prefab (1)(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1247.719f, 186.9158f, 348.5462f),
                                Quaternion.Euler(4.3555f, 47.5904f, 8.9997f)
                            );
                            cloneObject.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "TRN_PineTreeLog_SingleC1_Prefab (1)" && !GameObject.Find("TRN_PineTreeLog_SingleC1_Prefab (1)2(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1349.591f, 136.5935f, 259.6367f),
                                Quaternion.Euler(356.088f, 323.489f, 300.9095f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "TRN_PineTreeLog_SingleC1_Prefab (1)" && !GameObject.Find("TRN_PineTreeLog_SingleC1_Prefab (1)3(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1260.956f, 190.4553f, 293.9123f),
                                Quaternion.Euler(278.1299f, 348.0007f, 358.0372f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------


                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_TreeCedarFelledC_Prefab" && !GameObject.Find("OBJ_TreeCedarFelledC_Prefab(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1334.171f, 188.9158f, 383.0728f),
                                Quaternion.Euler(0f, 65.4628f, 324.471f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_TreeCedarFelledC_Prefab" && !GameObject.Find("OBJ_TreeCedarFelledC_Prefab2(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1270.137f, 180.5533f, 310.3075f),
                                Quaternion.Euler(-0f, 50.1659f, 46.3665f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------





                        // ==============================================================================================================
                        // Lithar's Ribbons
                        // ==============================================================================================================





                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_Blizzard_Line_C_Prefab" && !GameObject.Find("OBJ_Blizzard_Line_C_Prefab(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1073.756f, 210.5606f, 564.1599f),
                                Quaternion.Euler(-0f, 211.9293f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------





                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_Blizzard_Line_C_Prefab" && !GameObject.Find("OBJ_Blizzard_Line_C_Prefab2(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1111.946f, 193.47f, 518.5984f),
                                Quaternion.Euler(-0f, 211.9293f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------


                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_Blizzard_Line_C_Prefab" && !GameObject.Find("OBJ_Blizzard_Line_C_Prefab3(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1249.857f, 174.6725f, 409.2403f),
                                Quaternion.Euler(-0f, 211.9293f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------





                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_Blizzard_Line_C_Prefab" && !GameObject.Find("OBJ_Blizzard_Line_C_Prefab4(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1257.436f, 167.6932f, 160.4258f),
                                Quaternion.Euler(-0f, 211.9293f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------


                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_Blizzard_Line_C_Prefab" && !GameObject.Find("OBJ_Blizzard_Line_C_Prefab5(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1205.726F, 134.2555F, 72.4452f),
                                Quaternion.Euler(-0f, 211.9293f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------


                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_Blizzard_Line_C_Prefab" && !GameObject.Find("OBJ_Blizzard_Line_C_Prefab6(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1171.994f, 89.5405f, 38.2518f),
                                Quaternion.Euler(0, 211.9293f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------


                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_Blizzard_Line_C_Prefab" && !GameObject.Find("OBJ_Blizzard_Line_C_Prefab7(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1205.843f, 43.4112f, -106.05f),
                                Quaternion.Euler(-0f, 211.9293f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------


                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_Blizzard_Line_C_Prefab" && !GameObject.Find("OBJ_Blizzard_Line_C_Prefab8(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1219.208F, 158.5155F, 116.0638f),
                                Quaternion.Euler(-0f, 211.9293f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------


                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_Blizzard_Line_C_Prefab" && !GameObject.Find("OBJ_Blizzard_Line_C_Prefab9(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1297.569F, 177.8825F, 206.336f),
                                Quaternion.Euler(-0f, 211.9293f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_Blizzard_Line_C_Prefab" && !GameObject.Find("OBJ_Blizzard_Line_C_Prefab10(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1078.58f, 172.16f, 333.87f),
                                Quaternion.Euler(-0f, 211.9293f, 0f)
                            );
                            cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);


                        }
                        // ------------------------------------------------------------------------------------------



                    }


                    if (itemDataArray[i, 0] == "CanneryRegion_SANDBOX")
                    {




                        // ==============================================================================================================
                        // Lithar's Hut 
                        // ==============================================================================================================

                        /*
                        // Location Label ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "TRIGGER_LocationLabel (2)" && !GameObject.Find("TRIGGER_LocationLabel (2)(Clone)"))
                        {
                            GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-1297.569f, 177.8825f, 206.336f),
                                Quaternion.Euler(-0f, 0f, 0f)
                            );

                            Debug.Log("Attempting to modify DisplayLocationLabel component...");

                            // Try to find the component
                            DisplayLocationLabel displayLabel = cloneObject.GetComponent<DisplayLocationLabel>();
                            if (displayLabel != null)
                            {
                                Debug.Log($"Component found! Current label: '{displayLabel.m_Label}'");

                                // Try reflection to modify the field
                                var labelField = displayLabel.GetType().GetField("m_Label", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
                                if (labelField != null)
                                {
                                    labelField.SetValue(displayLabel, "Lithar's Ridge");
                                    Debug.Log("Reflection assignment successful!");
                                }
                                else
                                {
                                    Debug.Log("Could not find m_Label field via reflection");
                                }
                            }
                            else
                            {
                                Debug.Log("DisplayLocationLabel component NOT found!");
                            }
                        }
                        // ------------------------------------------------------------------------------------------
                        */




                        // ==============================================================================================================
                        // Lithar's Furnishings
                        // ==============================================================================================================


                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_EndTableA_Prefab" && !GameObject.Find("OBJ_EndTableA_Prefab(Clone)"))
                        {

                            if (SaveDataManager.endTable == 0)
                            {
                                GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-978.4924f, 216.2242f, 555.0944f),
                                Quaternion.Euler(0f, 289.2248f, 0f)
                            );
                                cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);

                                SaveDataManager.endTable = 1;
                                SaveDataManager.SaveData();
                            }
                            else { return; }

                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof ------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_ChairFoldng_A_Open_Prefab (4)" && !GameObject.Find("OBJ_ChairFoldng_A_Open_Prefab (4)(Clone)"))
                        {

                            if (SaveDataManager.foldingChair == 0)
                            {
                                GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-978.9299f, 216.2242f, 556.5074f),
                                Quaternion.Euler(0f, 66.283f, 0f)
                            );
                                cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);

                                SaveDataManager.foldingChair = 1;
                                SaveDataManager.SaveData();
                            }
                            else { return; }

                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_CounterCorner_Prefab" && !GameObject.Find("OBJ_CounterCorner_Prefab(Clone)"))
                        {

                            if (SaveDataManager.cornerCounter == 0)
                            {
                                GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-983.743f, 216.2242f, 553.5212f),
                                Quaternion.Euler(0f, 17.3176f, 0f)
                            );
                                cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);

                                SaveDataManager.cornerCounter = 1;
                                SaveDataManager.SaveData();
                            }
                            else { return; };

                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "OBJ_CounterShort_Prefab" && !GameObject.Find("OBJ_CounterShort_Prefab(Clone)"))
                        {

                            if (SaveDataManager.baseCounter == 0)
                            {
                                GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-979.6249f, 216.2242f, 552.4581f),
                                Quaternion.Euler(0f, 19.1539f, 0f)
                            );
                                cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);

                                SaveDataManager.baseCounter = 1;
                                SaveDataManager.SaveData();
                            }
                            else { return; }

                        }
                        // ------------------------------------------------------------------------------------------

                        // Roof------------------------------------------------------------------------------------------
                        if (itemDataArray[i, 1] == "INTERACTIVE_BedMattressB" && !GameObject.Find("INTERACTIVE_BedMattressB(Clone)"))
                        {

                            if (SaveDataManager.regularBed == 0)
                            {
                                GameObject cloneObject = Instantiate(
                                findTargetGO,
                                new Vector3(-982.1937f, 216.2242f, 558.2231f),
                                Quaternion.Euler(0f, 197.1676f, 0f)
                            );
                                cloneObject.transform.localScale = new Vector3(1f, 1f, 1f);

                                SaveDataManager.regularBed = 1;
                                SaveDataManager.SaveData();
                            }
                            else { return; }

                        }
                        // ------------------------------------------------------------------------------------------

                    }

                }
            }

        }

    }
}
