using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace LitharsRidge
{
    internal static class AssetUtils
    {
        private static readonly Dictionary<string, GameObject> cachedPrefabs = new Dictionary<string, GameObject>();

        public static GameObject GetPrefab(string prefabName)
        {
            if (string.IsNullOrEmpty(prefabName))
            {
                return null;
            }

            // Check if prefab exists in cache and is not null
            if (!cachedPrefabs.ContainsKey(prefabName) || cachedPrefabs[prefabName] == null)
            {
                // Remove null entry if it exists
                if (cachedPrefabs.ContainsKey(prefabName))
                {
                    cachedPrefabs.Remove(prefabName);
                }

                GeneratePrefab(prefabName);
            }

            var cachedPrefab = cachedPrefabs[prefabName];
            return cachedPrefab != null ? GameObject.Instantiate(cachedPrefab) : null;
        }

        private static void GeneratePrefab(string prefabName)
        {
            if (string.IsNullOrEmpty(prefabName))
            {
                return;
            }

            GameObject go = new GameObject
            {
                name = prefabName
            };

            MeshFilter mf = go.AddComponent<MeshFilter>();
            MeshRenderer mr = go.AddComponent<MeshRenderer>();
            MeshCollider mc = go.AddComponent<MeshCollider>();

            switch (prefabName)
            {
                case "OBJ_WoodPlankSingle":
                    try
                    {
                        mf.sharedMesh = Addressables.LoadAssetAsync<Mesh>("Assets/ArtAssets/Env/Structures/STR_CoastalHouseG/OBJ_WoodPlankSingle.fbx").WaitForCompletion();
                        mr.sharedMaterial = Addressables.LoadAssetAsync<Material>("Assets/ArtAssets/Materials/Global/GLB_WallWoodNatural_B_Flat01.mat").WaitForCompletion();
                        mc.sharedMesh = mf.sharedMesh;
                    }
                    catch (Exception ex)
                    {
                        // Log error if needed - for now just destroy the incomplete object
                        GameObject.Destroy(go);
                        return;
                    }
                    break;

                default:
                    // Unknown prefab type - destroy the object
                    GameObject.Destroy(go);
                    return;
            }

            cachedPrefabs.Add(prefabName, go);
        }
    }
}