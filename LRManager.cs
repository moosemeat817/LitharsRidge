using MelonLoader.Utils;
using UnityEngine.AddressableAssets;
using Il2CppSystem;
using UnityEngine.UIElements;
using UnityEngine;
using Il2Cpp;


namespace LitharsRidge
{
    public class LRManager :MonoBehaviour
    {

        public void PlaceTerrain()
        {
            string scene = GameManager.m_ActiveScene;


            if (scene == "CanneryRegion")
            {

                // Cliff Filler
                GameObject cliffFiller = GameObject.Find("TRN_RockCliffBig07_Prefab (1)");

                Vector3 position = new Vector3(-1220.84f, 145.0792f, 394.2591f);
                Vector3 rotation = new Vector3(1.5827f, 227.0001f, 35.4366f);
                Vector3 scale = new Vector3(1, 1, 1);

                SceneUtils.InstantiateObjectInScene(cliffFiller, position, rotation, scale);



                GameObject cliffFiller1 = GameObject.Find("TRN_RockCliffBig07_Prefab (1)");

                Vector3 position1 = new Vector3(-1241.232f, 150.0792f, 323.6899f);
                Vector3 rotation1 = new Vector3(8.346f, 137.1516f, 358.2192f);
                Vector3 scale1 = new Vector3(0.9f, 0.8f, 0.6f);

                SceneUtils.InstantiateObjectInScene(cliffFiller1, position1, rotation1, scale1);


                GameObject cliffFiller2 = GameObject.Find("TRN_RockCliffBig07_Prefab (1)");

                Vector3 position2 = new Vector3(-1292.493f, 112.9728f, 252.3085f);
                Vector3 rotation2 = new Vector3(-0f, 191.4707f, 0f);
                Vector3 scale2 = new Vector3(1, 1, .7f);

                SceneUtils.InstantiateObjectInScene(cliffFiller2, position2, rotation2, scale2);


                GameObject cliffFiller3 = GameObject.Find("TRN_RockCliffBig07_Prefab (1)");

                Vector3 position3 = new Vector3(-1279.614f, 107.6824f, 332.0807f);
                Vector3 rotation3 = new Vector3(358.3674f, 216.1458f, 15.4372f);
                Vector3 scale3 = new Vector3(1, 1, 1);

                SceneUtils.InstantiateObjectInScene(cliffFiller3, position3, rotation3, scale3);





                //Expansion

                GameObject cliffFiller4 = GameObject.Find("TRN_RockCliffBig07_Prefab (1)");

                Vector3 position4 = new Vector3(-1348.58f, 120.3229f, 325.41f);
                Vector3 rotation4 = new Vector3(5f, 0f, 19f);
                Vector3 scale4 = new Vector3(0.8f, 0.9f, 0.5f);

                SceneUtils.InstantiateObjectInScene(cliffFiller4, position4, rotation4, scale4);

                
                GameObject cliffFiller5 = GameObject.Find("TRN_RockCliffBig07_Prefab (1)");

                Vector3 position5 = new Vector3(-1272.009f, 114.3229f, 202.8889f);
                Vector3 rotation5 = new Vector3(357f, 108.1157f, 11.0001f);
                Vector3 scale5 = new Vector3(0.7f, 1f, 0.5f);

                SceneUtils.InstantiateObjectInScene(cliffFiller5, position5, rotation5, scale5);


                GameObject cliffFiller6 = GameObject.Find("TRN_RockCliffBig07_Prefab (1)");

                Vector3 position6 = new Vector3(-1197.558f, 110.3229f, 188.9807f);
                Vector3 rotation6 = new Vector3(0f, 215.8855f, 0.0001f);
                Vector3 scale6 = new Vector3(0.7f, 1f, 0.7f);

                SceneUtils.InstantiateObjectInScene(cliffFiller6, position6, rotation6, scale6);


                GameObject cliffFiller7 = GameObject.Find("TRN_RockCliffBig07_Prefab (1)");

                Vector3 position7 = new Vector3(-1284.261f, 177.3995f, 526.1157f);
                Vector3 rotation7 = new Vector3(0f, 23.1733f, 0.0001f);
                Vector3 scale7 = new Vector3(1f, 1f, 0.7f);

                SceneUtils.InstantiateObjectInScene(cliffFiller7, position7, rotation7, scale7);


                /*
                GameObject logBridge = GameObject.Find("OBJ_LogBridgeB_Prefab");

                Vector3 position9 = new Vector3(-940.8369f, 168.6308f, 667.1737f);
                Vector3 rotation9 = new Vector3(-0f, 289.6303f, 327.7559f);
                Vector3 scale9 = new Vector3(1.4f, 0.8f, 1.2f);

                SceneUtils.InstantiateObjectInScene(logBridge, position9, rotation9, scale9);


                GameObject logBridge2 = GameObject.Find("OBJ_LogBridgeB_Prefab");

                Vector3 position10 = new Vector3(-924.5732f, 150.8154f, 696.0595f);
                Vector3 rotation10 = new Vector3(-0f, 306.1407f, 331.7559f);
                Vector3 scale10 = new Vector3(1.7f, 0.8f, 1.3f);

                SceneUtils.InstantiateObjectInScene(logBridge2, position10, rotation10, scale10);
                */




                // Tree Filler
                GameObject treeFiller = GameObject.Find("TRN_PineTree_SingleH_Prefab_428");

                Vector3 position20 = new Vector3(-1365.031f, 178.5533f, 191.3372f);
                Vector3 rotation20 = new Vector3(0f, 0f, 0f);
                Vector3 scale20 = new Vector3(1, 1, 1);

                SceneUtils.InstantiateObjectInScene(treeFiller, position20, rotation20, scale20);


                GameObject treeFiller2 = GameObject.Find("TRN_PineTree_SingleH_Prefab_428");

                Vector3 position21 = new Vector3(-1357.031f, 177.5533f, 213.3372f);
                Vector3 rotation21 = new Vector3(0f, 0f, 0f);
                Vector3 scale21 = new Vector3(.8f, .8f, .8f);

                SceneUtils.InstantiateObjectInScene(treeFiller2, position21, rotation21, scale21);


                GameObject treeFiller3 = GameObject.Find("TRN_PineTree_SingleH_Prefab_428");

                Vector3 position22 = new Vector3(-1366.031f, 178.5533f, 202.9208f);
                Vector3 rotation22 = new Vector3(0f, 0f, 0f);
                Vector3 scale22 = new Vector3(1.2f, 1.2f, 1.7f);

                SceneUtils.InstantiateObjectInScene(treeFiller3, position22, rotation22, scale22);


                GameObject treeFiller4 = GameObject.Find("TRN_PineTree_SingleH_Prefab_428");

                Vector3 position23 = new Vector3(-1311.737f, 181.5533f, 166.522f);
                Vector3 rotation23 = new Vector3(0f, 0f, 0f);
                Vector3 scale23 = new Vector3(.9f, .9f, 1.2f);

                SceneUtils.InstantiateObjectInScene(treeFiller4, position23, rotation23, scale23);



                // Expansion

                GameObject treeFiller5 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position24 = new Vector3(-1022.12f, 219.78f, 549.40f);
                Vector3 rotation24 = new Vector3(0f, 0f, 0f);
                Vector3 scale24 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller5, position24, rotation24, scale24);

                GameObject treeFiller6 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position25 = new Vector3(-1022.88f, 219.41f, 552.92f);
                Vector3 rotation25 = new Vector3(0f, 0f, 0f);
                Vector3 scale25 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller6, position25, rotation25, scale25);

                GameObject treeFiller7 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position26 = new Vector3(-1017.67f, 218.98f, 553.86f);
                Vector3 rotation26 = new Vector3(0f, 0f, 0f);
                Vector3 scale26 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller7, position26, rotation26, scale26);

                GameObject treeFiller8 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position27 = new Vector3(-1034.94f, 218.38f, 558.12f);
                Vector3 rotation27 = new Vector3(0f, 0f, 0f);
                Vector3 scale27 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller8, position27, rotation27, scale27);

                GameObject treeFiller9 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position28 = new Vector3(-1055.51f, 212.72f, 536.77f);
                Vector3 rotation28 = new Vector3(0f, 0f, 0f);
                Vector3 scale28 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller9, position28, rotation28, scale28);

                GameObject treeFiller10 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position29 = new Vector3(-1059.94f, 206.01f, 510.48f);
                Vector3 rotation29 = new Vector3(0f, 0f, 0f);
                Vector3 scale29 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller10, position29, rotation29, scale29);

                GameObject treeFiller11 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position30 = new Vector3(-1101.92f, 194.97f, 512.75f);
                Vector3 rotation30 = new Vector3(0f, 0f, 0f);
                Vector3 scale30 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller11, position30, rotation30, scale30);

                GameObject treeFiller12 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position31 = new Vector3(-1104.11f, 192.39f, 500.11f);
                Vector3 rotation31 = new Vector3(0f, 0f, 0f);
                Vector3 scale31 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller12, position31, rotation31, scale31);

                GameObject treeFiller13 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position32 = new Vector3(-1103.51f, 185.05f, 446.72f);
                Vector3 rotation32 = new Vector3(0f, 0f, 0f);
                Vector3 scale32 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller13, position32, rotation32, scale32);

                GameObject treeFiller14 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position33 = new Vector3(-1070.04f, 178.35f, 452.77f);
                Vector3 rotation33 = new Vector3(0f, 0f, 0f);
                Vector3 scale33 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller14, position33, rotation33, scale33);

                GameObject treeFiller15 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position34 = new Vector3(-1153.23f, 188.10f, 442.55f);
                Vector3 rotation34 = new Vector3(0f, 0f, 0f);
                Vector3 scale34 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller15, position34, rotation34, scale34);

                GameObject treeFiller16 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position35 = new Vector3(-1181.75f, 193.74f, 411.25f);
                Vector3 rotation35 = new Vector3(0f, 0f, 0f);
                Vector3 scale35 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller16, position35, rotation35, scale35);

                GameObject treeFiller17 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position36 = new Vector3(-1315.92f, 194.58f, 430.15f);
                Vector3 rotation36 = new Vector3(0f, 0f, 0f);
                Vector3 scale36 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller17, position36, rotation36, scale36);

                GameObject treeFiller18 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position37 = new Vector3(-1395.49f, 205.00f, 391.66f);
                Vector3 rotation37 = new Vector3(0f, 0f, 0f);
                Vector3 scale37 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller18, position37, rotation37, scale37);

                GameObject treeFiller19 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position38 = new Vector3(-1410.64f, 213.29f, 335.99f);
                Vector3 rotation38 = new Vector3(0f, 0f, 0f);
                Vector3 scale38 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller19, position38, rotation38, scale38);

                GameObject treeFiller20 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position39 = new Vector3(-1353.64f, 174.69f, 188.73f);
                Vector3 rotation39 = new Vector3(0f, 0f, 0f);
                Vector3 scale39 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller20, position39, rotation39, scale39);

                GameObject treeFiller21 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position40 = new Vector3(-1306.05f, 178.37f, 218.59f);
                Vector3 rotation40 = new Vector3(0f, 0f, 0f);
                Vector3 scale40 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller21, position40, rotation40, scale40);

                GameObject treeFiller22 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position41 = new Vector3(-1265.72f, 197.20f, 226.07f);
                Vector3 rotation41 = new Vector3(0f, 0f, 0f);
                Vector3 scale41 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller22, position41, rotation41, scale41);

                GameObject treeFiller23 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position42 = new Vector3(-1281.86f, 179.83f, 289.45f);
                Vector3 rotation42 = new Vector3(0f, 0f, 0f);
                Vector3 scale42 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller23, position42, rotation42, scale42);

                GameObject treeFiller24 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position43 = new Vector3(-1364.58f, 184.50f, 335.41f);
                Vector3 rotation43 = new Vector3(0f, 0f, 0f);
                Vector3 scale43 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller24, position43, rotation43, scale43);





                GameObject treeFiller25 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position44 = new Vector3(-1203.67f, 216.55f, 339.95f);
                Vector3 rotation44 = new Vector3(0f, 0f, 0f);
                Vector3 scale44 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller25, position44, rotation44, scale44);

                GameObject treeFiller26 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position45 = new Vector3(-1207.16f, 220.53f, 325.03f);
                Vector3 rotation45 = new Vector3(0f, 0f, 0f);
                Vector3 scale45 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller26, position45, rotation45, scale45);

                GameObject treeFiller27 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position46 = new Vector3(-1222.41f, 220.73f, 314.49f);
                Vector3 rotation46 = new Vector3(0f, 0f, 0f);
                Vector3 scale46 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller27, position46, rotation46, scale46);

                GameObject treeFiller28 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position47 = new Vector3(-1243.32f, 218.86f, 288.07f);
                Vector3 rotation47 = new Vector3(0f, 0f, 0f);
                Vector3 scale47 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller28, position47, rotation47, scale47);

                GameObject treeFiller29 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position48 = new Vector3(-1255.51f, 206.91f, 266.86f);
                Vector3 rotation48 = new Vector3(0f, 0f, 0f);
                Vector3 scale48 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller29, position48, rotation48, scale48);

                GameObject treeFiller30 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position49 = new Vector3(-1362.96f, 198.78f, 475.38f);
                Vector3 rotation49 = new Vector3(0f, 0f, 0f);
                Vector3 scale49 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller30, position49, rotation49, scale49);

                GameObject treeFiller31 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position50 = new Vector3(-1381.17f, 200.48f, 471.60f);
                Vector3 rotation50 = new Vector3(0f, 0f, 0f);
                Vector3 scale50 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller31, position50, rotation50, scale50);

                GameObject treeFiller32 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position51 = new Vector3(-1000.21f, 218.67f, 520.33f);
                Vector3 rotation51 = new Vector3(0f, 0f, 0f);
                Vector3 scale51 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller32, position51, rotation51, scale51);

                GameObject treeFiller33 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position52 = new Vector3(-1061.17f, 198.58f, 493.84f);
                Vector3 rotation52 = new Vector3(0f, 0f, 0f);
                Vector3 scale52 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller33, position52, rotation52, scale52);

                GameObject treeFiller34 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position53 = new Vector3(-1094.02f, 191.00f, 484.24f);
                Vector3 rotation53 = new Vector3(0f, 0f, 0f);
                Vector3 scale53 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller34, position53, rotation53, scale53);

                GameObject treeFiller35 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position54 = new Vector3(-1089.71f, 185.97f, 463.17f);
                Vector3 rotation54 = new Vector3(0f, 0f, 0f);
                Vector3 scale54 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller35, position54, rotation54, scale54);

                GameObject treeFiller36 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position55 = new Vector3(-1007.88f, 217.41f, 554.11f);
                Vector3 rotation55 = new Vector3(0f, 0f, 0f);
                Vector3 scale55 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller36, position55, rotation55, scale55);








                GameObject treeFiller37 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position56 = new Vector3(-1000.46f, 204.79f, 632.30f);
                Vector3 rotation56 = new Vector3(0f, 0f, 0f);
                Vector3 scale56 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller37, position56, rotation56, scale56);

                GameObject treeFiller38 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position57 = new Vector3(-1015.95f, 210.71f, 613.37f);
                Vector3 rotation57 = new Vector3(0f, 0f, 0f);
                Vector3 scale57 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller38, position57, rotation57, scale57);

                GameObject treeFiller39 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position58 = new Vector3(-1058.40f, 213.49f, 557.95f);
                Vector3 rotation58 = new Vector3(0f, 0f, 0f);
                Vector3 scale58 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller39, position58, rotation58, scale58);

                GameObject treeFiller40 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position59 = new Vector3(-1076.55f, 204.50f, 524.40f);
                Vector3 rotation59 = new Vector3(0f, 0f, 0f);
                Vector3 scale59 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller40, position59, rotation59, scale59);

                GameObject treeFiller41 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position60 = new Vector3(-1170.89f, 193.89f, 416.98f);
                Vector3 rotation60 = new Vector3(0f, 0f, 0f);
                Vector3 scale60 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller41, position60, rotation60, scale60);

                GameObject treeFiller42 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position61 = new Vector3(-1316.93f, 195.41f, 417.29f);
                Vector3 rotation61 = new Vector3(0f, 0f, 0f);
                Vector3 scale61 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller42, position61, rotation61, scale61);





                GameObject treeFiller43 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position62 = new Vector3(-1230.93f, 159.24f, 117.94f);
                Vector3 rotation62 = new Vector3(0f, 0f, 0f);
                Vector3 scale62 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller43, position62, rotation62, scale62);

                GameObject treeFiller44 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position63 = new Vector3(-1228.44f, 166.63f, 170.34f);
                Vector3 rotation63 = new Vector3(0f, 0f, 0f);
                Vector3 scale63 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller44, position63, rotation63, scale63);

                GameObject treeFiller45 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position64 = new Vector3(-1235.45f, 166.45f, 178.02f);
                Vector3 rotation64 = new Vector3(0f, 0f, 0f);
                Vector3 scale64 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller45, position64, rotation64, scale64);

                GameObject treeFiller46 = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
                Vector3 position65 = new Vector3(-1249.93f, 183.27f, 204.43f);
                Vector3 rotation65 = new Vector3(0f, 0f, 0f);
                Vector3 scale65 = new Vector3(.6f, .6f, .6f);
                SceneUtils.InstantiateObjectInScene(treeFiller46, position65, rotation65, scale65);



                






                GameObject cliffFiller8 = GameObject.Find("TRN_RockCliffBig07_Prefab (1)");

                Vector3 position8 = new Vector3(-1034.031f, 218.6338f, 709.848f);
                Vector3 rotation8 = new Vector3(0f, 26.2916f, 0f);
                Vector3 scale8 = new Vector3(1f, .8f, 1f);

                SceneUtils.InstantiateObjectInScene(cliffFiller8, position8, rotation8, scale8);


                GameObject cliffFiller9 = GameObject.Find("TRN_RockCliffBig07_Prefab (1)");

                Vector3 position9 = new Vector3(-1062.611f, 205.6338f, 681.2704f);
                Vector3 rotation9 = new Vector3(332.9352f, 52.2261f, 357.2191f);
                Vector3 scale9 = new Vector3(1.2f, 0.8f, 1.2f);

                SceneUtils.InstantiateObjectInScene(cliffFiller9, position9, rotation9, scale9);


                GameObject cliffFiller10 = GameObject.Find("TRN_RockCliffBig07_Prefab (1)");

                Vector3 position10 = new Vector3(-1004.095f, 210.657f, 789.6373f);
                Vector3 rotation10 = new Vector3(-0, 322.6287f, 0f);
                Vector3 scale10 = new Vector3(1, 1, 0.9f);

                SceneUtils.InstantiateObjectInScene(cliffFiller10, position10, rotation10, scale10);

                GameObject cliffFiller11 = GameObject.Find("TRN_RockCliffBig07_Prefab (1)");

                Vector3 position11 = new Vector3(-981.4315f, 204.657f, 724.1172f);
                Vector3 rotation11 = new Vector3(-0, 39.5419f, 0f);
                Vector3 scale11 = new Vector3(1, 1, 1f);

                SceneUtils.InstantiateObjectInScene(cliffFiller11, position11, rotation11, scale11);

                GameObject cliffFiller12 = GameObject.Find("TRN_RockCliffBig07_Prefab (1)");

                Vector3 position12 = new Vector3(-999.9818f, 251.428f, 800.2368f);
                Vector3 rotation12 = new Vector3(-0, 173.4816f, 0f);
                Vector3 scale12 = new Vector3(1, 1, 1f);

                SceneUtils.InstantiateObjectInScene(cliffFiller12, position12, rotation12, scale12);


                GameObject cliffFiller13 = GameObject.Find("TRN_RockCliffBig07_Prefab (1)");

                Vector3 position13 = new Vector3(-1061.374f, 243.7888f, 729.8143f);
                Vector3 rotation13 = new Vector3(-0, 232.903f, 0f);
                Vector3 scale13 = new Vector3(1, 1, 1f);

                SceneUtils.InstantiateObjectInScene(cliffFiller13, position13, rotation13, scale13);


                GameObject cliffFiller14 = GameObject.Find("TRN_RockCliffBig07_Prefab (1)");

                Vector3 position14 = new Vector3(-965.4373f, 243.7888f, 729.8143f);
                Vector3 rotation14 = new Vector3(-0, 14.8149f, 0f);
                Vector3 scale14 = new Vector3(.8f, 1, .9f);

                SceneUtils.InstantiateObjectInScene(cliffFiller14, position14, rotation14, scale14);


            }

   

        }






        public void PlaceAssets()
        {
            string scene = GameManager.m_ActiveScene;


            if (scene == "CanneryRegion")
            {

                // Workshop Bridge Plank
                Vector3 position2 = new Vector3(-409.6051f, 31.8377f, -567.3127f);
                Vector3 rotation2 = new Vector3(1.4751f, 37.5107f, 359.649f);
                Vector3 scale2 = new Vector3(2.8f, 2f, 3f);

                SceneUtils.PlaceAssetsInScene("OBJ_WoodPlankSingle", position2, rotation2, scale2);
            }

        }

    }
}
