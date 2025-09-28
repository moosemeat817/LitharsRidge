using System;
using UnityEngine;
using Il2Cpp;

namespace LitharsRidge
{
    internal class SceneUtils
    {
        /// <summary>
        /// Instantiates a terrain object in the scene with collision
        /// </summary>
        public static void InstantiateObjectInScene(GameObject prefab, Vector3 position, Vector3 rotation, Vector3 scale)
        {
            if (prefab == null)
            {
                return;
            }

            try
            {
                GameObject instantiatedObject = GameObject.Instantiate(prefab);
                if (instantiatedObject == null)
                {
                    return;
                }

                instantiatedObject.transform.position = position;
                instantiatedObject.transform.rotation = Quaternion.Euler(rotation);
                instantiatedObject.transform.localScale = scale;
                instantiatedObject.name = "XXX_" + instantiatedObject.name;

                // Ensure the object has a collider for terrain interaction
                if (instantiatedObject.GetComponent<Collider>() == null)
                {
                    instantiatedObject.AddComponent<MeshCollider>();
                }
            }
            catch (Exception ex)
            {
                // Log error if logging system is available
                // For now, silently fail to prevent crashes
                return;
            }
        }

        /// <summary>
        /// Places custom assets in the scene using the AssetUtils system
        /// </summary>
        public static void PlaceAssetsInScene(string assetName, Vector3 position, Vector3 rotation, Vector3 scale)
        {
            if (string.IsNullOrEmpty(assetName))
            {
                return;
            }

            try
            {
                GameObject prefab = AssetUtils.GetPrefab(assetName);
                if (prefab == null)
                {
                    return;
                }

                prefab.transform.position = position;
                prefab.transform.rotation = Quaternion.Euler(rotation);
                prefab.transform.localScale = scale;
                prefab.name = "ZZZ_" + prefab.name;
            }
            catch (Exception ex)
            {
                // Log error if logging system is available
                // For now, silently fail to prevent crashes
                return;
            }
        }
    }
}