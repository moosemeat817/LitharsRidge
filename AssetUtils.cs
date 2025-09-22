using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.AddressableAssets;

namespace LitharsRidge
{
    internal static class AssetUtils
    {

        static Dictionary<string, GameObject> cachedPrefabs = new Dictionary<string, GameObject>();

        public static GameObject GetPrefab(string prefabName)
        {
            if (!cachedPrefabs.ContainsKey(prefabName))
            {
                GeneratePrefab(prefabName);
            }
            else if(cachedPrefabs.ContainsKey(prefabName) && cachedPrefabs[prefabName] == null)
            {
                cachedPrefabs.Remove(prefabName);
                GeneratePrefab(prefabName);
            }
            return GameObject.Instantiate(cachedPrefabs[prefabName]);
        }

        private static void GeneratePrefab(string prefabName)
        {
            GameObject go = new GameObject();
            go.name = prefabName;

            MeshFilter mf = go.AddComponent<MeshFilter>();
            MeshRenderer mr = go.AddComponent<MeshRenderer>();
            MeshCollider mc = go.AddComponent<MeshCollider>();

            switch (prefabName)
            {
           
                case "OBJ_WoodPlankSingle":
                    mf.sharedMesh = Addressables.LoadAssetAsync<Mesh>("Assets/ArtAssets/Env/Structures/STR_CoastalHouseG/OBJ_WoodPlankSingle.fbx").WaitForCompletion();
                    mr.sharedMaterial = Addressables.LoadAssetAsync<Material>("Assets/ArtAssets/Materials/Global/GLB_WallWoodNatural_B_Flat01.mat").WaitForCompletion();
                    mc.sharedMesh = mf.sharedMesh;
                    break;


                case "OBJ_WoodPlankSingle2":
                    mf.sharedMesh = Addressables.LoadAssetAsync<Mesh>("Assets/ArtAssets/Env/Structures/STR_CoastalHouseG/OBJ_WoodPlankSingle.fbx").WaitForCompletion();
                    mr.sharedMaterial = Addressables.LoadAssetAsync<Material>("Assets/ArtAssets/Materials/Global/GLB_Black_A01.mat").WaitForCompletion();
                    mc.sharedMesh = mf.sharedMesh;
                    break;

            }
        
            cachedPrefabs.Add(prefabName, go);
        }

    }
}
