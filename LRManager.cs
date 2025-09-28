using System;
using UnityEngine;
using Il2Cpp;
using UnityEngine.UIElements;
using MelonLoader.Utils;

namespace LitharsRidge
{
    public class LRManager : MonoBehaviour
    {
        public void PlaceTerrain()
        {
            string scene = GameManager.m_ActiveScene;

            if (scene == "CanneryRegion")
            {
                PlaceCliffFillers();
                PlaceTreeFillers();
                PlaceExpansionCliffs();
                PlaceExpansionTrees();
                PlaceBirchTrees();
                PlaceAdditionalPineTrees();
            }
        }

        public void PlaceAssets()
        {
            string scene = GameManager.m_ActiveScene;

            if (scene == "CanneryRegion")
            {
                // Workshop Bridge Plank
                Vector3 position = new Vector3(-409.6051f, 31.8377f, -567.3127f);
                Vector3 rotation = new Vector3(1.4751f, 37.5107f, 359.649f);
                Vector3 scale = new Vector3(2.8f, 2f, 3f);

                SceneUtils.PlaceAssetsInScene("OBJ_WoodPlankSingle", position, rotation, scale);
            }
        }

        private void PlaceCliffFillers()
        {
            GameObject cliffPrefab = GameObject.Find("TRN_RockCliffBig07_Prefab (1)");
            if (cliffPrefab == null) return;

            var cliffFillerData = new[]
            {
                (pos: new Vector3(-1220.84f, 145.0792f, 394.2591f), rot: new Vector3(1.5827f, 227.0001f, 35.4366f), scale: Vector3.one),
                (pos: new Vector3(-1241.232f, 150.0792f, 323.6899f), rot: new Vector3(8.346f, 137.1516f, 358.2192f), scale: new Vector3(0.9f, 0.8f, 0.6f)),
                (pos: new Vector3(-1292.493f, 112.9728f, 252.3085f), rot: new Vector3(-0f, 191.4707f, 0f), scale: new Vector3(1, 1, 0.7f)),
                (pos: new Vector3(-1279.614f, 107.6824f, 332.0807f), rot: new Vector3(358.3674f, 216.1458f, 15.4372f), scale: Vector3.one)
            };

            foreach (var data in cliffFillerData)
            {
                SceneUtils.InstantiateObjectInScene(cliffPrefab, data.pos, data.rot, data.scale);
            }
        }

        private void PlaceExpansionCliffs()
        {
            GameObject cliffPrefab = GameObject.Find("TRN_RockCliffBig07_Prefab (1)");
            if (cliffPrefab == null) return;

            var expansionCliffData = new[]
            {
                (pos: new Vector3(-1348.58f, 120.3229f, 325.41f), rot: new Vector3(5f, 0f, 19f), scale: new Vector3(0.8f, 0.9f, 0.5f)),
                (pos: new Vector3(-1272.009f, 114.3229f, 202.8889f), rot: new Vector3(357f, 108.1157f, 11.0001f), scale: new Vector3(0.7f, 1f, 0.5f)),
                (pos: new Vector3(-1197.558f, 110.3229f, 188.9807f), rot: new Vector3(0f, 215.8855f, 0.0001f), scale: new Vector3(0.7f, 1f, 0.7f)),
                (pos: new Vector3(-1284.261f, 177.3995f, 526.1157f), rot: new Vector3(0f, 23.1733f, 0.0001f), scale: new Vector3(1f, 1f, 0.7f)),
                (pos: new Vector3(-1034.031f, 218.6338f, 709.848f), rot: new Vector3(0f, 26.2916f, 0f), scale: new Vector3(1f, 0.8f, 1f)),
                (pos: new Vector3(-1062.611f, 205.6338f, 681.2704f), rot: new Vector3(332.9352f, 52.2261f, 357.2191f), scale: new Vector3(1.2f, 0.8f, 1.2f)),
                (pos: new Vector3(-1004.095f, 210.657f, 789.6373f), rot: new Vector3(-0, 322.6287f, 0f), scale: new Vector3(1, 1, 0.9f)),
                (pos: new Vector3(-981.4315f, 204.657f, 724.1172f), rot: new Vector3(-0, 39.5419f, 0f), scale: Vector3.one),
                (pos: new Vector3(-999.9818f, 251.428f, 800.2368f), rot: new Vector3(-0, 173.4816f, 0f), scale: Vector3.one),
                (pos: new Vector3(-1061.374f, 243.7888f, 729.8143f), rot: new Vector3(-0, 232.903f, 0f), scale: Vector3.one),
                (pos: new Vector3(-965.4373f, 243.7888f, 729.8143f), rot: new Vector3(-0, 14.8149f, 0f), scale: new Vector3(0.8f, 1, 0.9f))
            };

            foreach (var data in expansionCliffData)
            {
                SceneUtils.InstantiateObjectInScene(cliffPrefab, data.pos, data.rot, data.scale);
            }
        }

        private void PlaceTreeFillers()
        {
            GameObject treePrefab = GameObject.Find("TRN_PineTree_SingleH_Prefab_428");
            if (treePrefab == null) return;

            var treeFillerData = new[]
            {
                (pos: new Vector3(-1365.031f, 178.5533f, 191.3372f), scale: Vector3.one),
                (pos: new Vector3(-1357.031f, 177.5533f, 213.3372f), scale: new Vector3(0.8f, 0.8f, 0.8f)),
                (pos: new Vector3(-1366.031f, 178.5533f, 202.9208f), scale: new Vector3(1.2f, 1.2f, 1.7f)),
                (pos: new Vector3(-1311.737f, 181.5533f, 166.522f), scale: new Vector3(0.9f, 0.9f, 1.2f))
            };

            foreach (var data in treeFillerData)
            {
                SceneUtils.InstantiateObjectInScene(treePrefab, data.pos, Vector3.zero, data.scale);
            }
        }

        private void PlaceExpansionTrees()
        {
            GameObject pinePrefab = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
            if (pinePrefab == null) return;

            var expansionTreePositions = new Vector3[]
            {
                new Vector3(-1022.12f, 219.78f, 549.40f),
                new Vector3(-1022.88f, 219.41f, 552.92f),
                new Vector3(-1017.67f, 218.98f, 553.86f),
                new Vector3(-1034.94f, 218.38f, 558.12f),
                new Vector3(-1055.51f, 212.72f, 536.77f),
                new Vector3(-1059.94f, 206.01f, 510.48f),
                new Vector3(-1101.92f, 194.97f, 512.75f),
                new Vector3(-1104.11f, 192.39f, 500.11f),
                new Vector3(-1103.51f, 185.05f, 446.72f),
                new Vector3(-1070.04f, 178.35f, 452.77f),
                new Vector3(-1153.23f, 188.10f, 442.55f),
                new Vector3(-1181.75f, 193.74f, 411.25f),
                new Vector3(-1315.92f, 194.58f, 430.15f),
                new Vector3(-1395.49f, 205.00f, 391.66f),
                new Vector3(-1410.64f, 213.29f, 335.99f),
                new Vector3(-1353.64f, 174.69f, 188.73f),
                new Vector3(-1306.05f, 178.37f, 218.59f),
                new Vector3(-1265.72f, 197.20f, 226.07f),
                new Vector3(-1281.86f, 179.83f, 289.45f),
                new Vector3(-1364.58f, 184.50f, 335.41f),
                new Vector3(-1203.67f, 216.55f, 339.95f),
                new Vector3(-1207.16f, 220.53f, 325.03f),
                new Vector3(-1222.41f, 220.73f, 314.49f),
                new Vector3(-1243.32f, 218.86f, 288.07f),
                new Vector3(-1255.51f, 206.91f, 266.86f),
                new Vector3(-1362.96f, 198.78f, 475.38f),
                new Vector3(-1381.17f, 200.48f, 471.60f),
                new Vector3(-1000.21f, 218.67f, 520.33f),
                new Vector3(-1061.17f, 198.58f, 493.84f),
                new Vector3(-1094.02f, 191.00f, 484.24f),
                new Vector3(-1089.71f, 185.97f, 463.17f),
                new Vector3(-1007.88f, 217.41f, 554.11f),
                new Vector3(-1000.46f, 204.79f, 632.30f),
                new Vector3(-1015.95f, 210.71f, 613.37f),
                new Vector3(-1058.40f, 213.49f, 557.95f),
                new Vector3(-1076.55f, 204.50f, 524.40f),
                new Vector3(-1170.89f, 193.89f, 416.98f),
                new Vector3(-1316.93f, 195.41f, 417.29f),
                new Vector3(-1230.93f, 159.24f, 117.94f),
                new Vector3(-1228.44f, 166.63f, 170.34f),
                new Vector3(-1235.45f, 166.45f, 178.02f),
                new Vector3(-1249.93f, 183.27f, 204.43f),
                new Vector3(-1095.41f, 178.20f, 407.86f),
                new Vector3(-1026.10f, 208.86f, 498.96f),
                new Vector3(-1188.99f, 212.71f, 364.55f),
                new Vector3(-1396.16f, 208.44f, 352.34f),
                new Vector3(-1396.82f, 207.32f, 362.49f),
                new Vector3(-1393.31f, 206.89f, 362.00f),
                new Vector3(-1305.42f, 185.68f, 395.82f),
                new Vector3(-1272.74f, 192.10f, 265.94f),
                new Vector3(-1406.33f, 213.89f, 292.12f),
                new Vector3(-1403.10f, 211.85f, 303.99f)
            };

            Vector3 scale = new Vector3(0.6f, 0.6f, 0.6f);

            foreach (var position in expansionTreePositions)
            {
                SceneUtils.InstantiateObjectInScene(pinePrefab, position, Vector3.zero, scale);
            }
        }

        private void PlaceBirchTrees()
        {
            GameObject birchPrefab = GameObject.Find("TRN_BirchTree_SingleB_Prefab_177");
            if (birchPrefab == null) return;

            var birchTreeData = new[]
            {
                (pos: new Vector3(-1016.22f, 220.26f, 535.36f), scale: new Vector3(0.6f, 0.6f, 0.6f)),
                (pos: new Vector3(-1022.37f, 219.89f, 537.55f), scale: new Vector3(0.6f, 0.6f, 0.6f)),
                (pos: new Vector3(-1021.38f, 220.23f, 544.53f), scale: new Vector3(0.7f, 0.7f, 0.7f)),
                (pos: new Vector3(-1013.36f, 219.72f, 543.78f), scale: new Vector3(0.6f, 0.6f, 0.6f)),
                (pos: new Vector3(-1023.10f, 218.76f, 529.91f), scale: new Vector3(0.8f, 0.8f, 0.8f)),
                (pos: new Vector3(-1017.25f, 219.94f, 531.00f), scale: new Vector3(0.6f, 0.6f, 0.6f))
            };

            foreach (var data in birchTreeData)
            {
                SceneUtils.InstantiateObjectInScene(birchPrefab, data.pos, Vector3.zero, data.scale);
            }
        }

        private void PlaceAdditionalPineTrees()
        {
            GameObject pinePrefab = GameObject.Find("TRN_PineTree_SingleB_Prefab_228");
            if (pinePrefab == null) return;

            var additionalTreeData = new[]
            {
                (pos: new Vector3(-1188.99f, 212.71f, 364.55f), scale: new Vector3(0.7f, 0.7f, 0.7f)),
                (pos: new Vector3(-1396.82f, 207.32f, 362.49f), scale: new Vector3(0.8f, 0.8f, 0.8f))
            };

            foreach (var data in additionalTreeData)
            {
                SceneUtils.InstantiateObjectInScene(pinePrefab, data.pos, Vector3.zero, data.scale);
            }

            // Remaining trees with 0.6f scale
            var standardScalePositions = new Vector3[]
            {
                new Vector3(-1396.16f, 208.44f, 352.34f),
                new Vector3(-1393.31f, 206.89f, 362.00f),
                new Vector3(-1305.42f, 185.68f, 395.82f),
                new Vector3(-1272.74f, 192.10f, 265.94f),
                new Vector3(-1406.33f, 213.89f, 292.12f),
                new Vector3(-1403.10f, 211.85f, 303.99f)
            };

            Vector3 standardScale = new Vector3(0.6f, 0.6f, 0.6f);

            foreach (var position in standardScalePositions)
            {
                SceneUtils.InstantiateObjectInScene(pinePrefab, position, Vector3.zero, standardScale);
            }
        }
    }
}