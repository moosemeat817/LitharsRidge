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
