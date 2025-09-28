using MelonLoader.Utils;
using UnityEngine;
using System.Collections.Generic;
using MelonLoader;

namespace LitharsRidge
{
    public static class Utilities
    {
        /// <summary>
        /// Disables multiple game objects by their paths
        /// </summary>
        public static void DisableGameObjects(string[] objectPaths)
        {
            if (objectPaths == null)
            {
                return;
            }

            int disabledCount = 0;
            foreach (string path in objectPaths)
            {
                if (string.IsNullOrEmpty(path))
                    continue;

                GameObject obj = GameObject.Find(path);
                if (obj != null)
                {
                    obj.SetActive(false);
                    disabledCount++;
                }
            }
        }

        /// <summary>
        /// Safely disables a game object without warnings if not found
        /// </summary>
        public static void SafeDisable(string objectPath)
        {
            if (string.IsNullOrEmpty(objectPath))
                return;

            GameObject obj = GameObject.Find(objectPath);
            if (obj != null)
            {
                obj.SetActive(false);
            }
        }

        /// <summary>
        /// Disables specific child objects by their indices
        /// </summary>
        public static void DisableChildrenByIndex(string parentPath, int[] childIndices)
        {
            if (string.IsNullOrEmpty(parentPath) || childIndices == null)
                return;

            GameObject parent = GameObject.Find(parentPath);
            if (parent == null)
                return;

            foreach (int index in childIndices)
            {
                if (index >= 0 && index < parent.transform.childCount)
                {
                    Transform child = parent.transform.GetChild(index);
                    if (child != null)
                    {
                        child.gameObject.SetActive(false);
                    }
                }
            }
        }

        /// <summary>
        /// Disables children whose names contain the specified text
        /// </summary>
        public static void DisableChildrenByNameContains(string parentPath, string nameContains, bool caseSensitive = false)
        {
            if (string.IsNullOrEmpty(parentPath) || string.IsNullOrEmpty(nameContains))
                return;

            GameObject parent = GameObject.Find(parentPath);
            if (parent == null)
                return;

            for (int i = 0; i < parent.transform.childCount; i++)
            {
                Transform child = parent.transform.GetChild(i);
                if (child == null)
                    continue;

                string childName = child.name;
                bool nameMatch = caseSensitive
                    ? childName.Contains(nameContains)
                    : childName.ToLower().Contains(nameContains.ToLower());

                if (nameMatch)
                {
                    child.gameObject.SetActive(false);
                }
            }
        }

        /// <summary>
        /// Disables children whose names contain any of the specified texts
        /// </summary>
        public static void DisableChildrenByNameContains(string parentPath, string[] nameContains, bool caseSensitive = false)
        {
            if (string.IsNullOrEmpty(parentPath) || nameContains == null || nameContains.Length == 0)
                return;

            GameObject parent = GameObject.Find(parentPath);
            if (parent == null)
                return;

            for (int i = 0; i < parent.transform.childCount; i++)
            {
                Transform child = parent.transform.GetChild(i);
                if (child == null)
                    continue;

                string childName = child.name;
                bool shouldDisable = false;

                foreach (string filter in nameContains)
                {
                    if (string.IsNullOrEmpty(filter))
                        continue;

                    bool nameMatch = caseSensitive
                        ? childName.Contains(filter)
                        : childName.ToLower().Contains(filter.ToLower());

                    if (nameMatch)
                    {
                        shouldDisable = true;
                        break;
                    }
                }

                if (shouldDisable)
                {
                    child.gameObject.SetActive(false);
                }
            }
        }

        /// <summary>
        /// Enables specific child objects by their indices
        /// </summary>
        public static void EnableChildrenByIndex(string parentPath, int[] childIndices)
        {
            if (string.IsNullOrEmpty(parentPath) || childIndices == null)
                return;

            GameObject parent = GameObject.Find(parentPath);
            if (parent == null)
                return;

            foreach (int index in childIndices)
            {
                if (index >= 0 && index < parent.transform.childCount)
                {
                    Transform child = parent.transform.GetChild(index);
                    if (child != null)
                    {
                        child.gameObject.SetActive(true);
                    }
                }
            }
        }

        /// <summary>
        /// Repositions objects using position and rotation data
        /// </summary>
        public static void RepositionObjects(Dictionary<string, (Vector3 position, Vector3 rotation)> objects, string objectType = "objects")
        {
            if (objects == null)
                return;

            foreach (var obj in objects)
            {
                if (string.IsNullOrEmpty(obj.Key))
                    continue;

                GameObject gameObj = GameObject.Find(obj.Key);
                if (gameObj != null)
                {
                    gameObj.transform.SetPositionAndRotation(
                        obj.Value.position,
                        Quaternion.Euler(obj.Value.rotation)
                    );
                }
            }
        }

        /// <summary>
        /// Repositions objects with optional scaling support
        /// </summary>
        public static void RepositionObjects(Dictionary<string, (Vector3 position, Vector3 rotation, Vector3? scale)> objects, string objectType = "objects")
        {
            if (objects == null)
                return;

            foreach (var obj in objects)
            {
                if (string.IsNullOrEmpty(obj.Key))
                    continue;

                GameObject gameObj = GameObject.Find(obj.Key);
                if (gameObj != null)
                {
                    gameObj.transform.SetPositionAndRotation(
                        obj.Value.position,
                        Quaternion.Euler(obj.Value.rotation)
                    );

                    // Apply scale if provided
                    if (obj.Value.scale.HasValue)
                    {
                        gameObj.transform.localScale = obj.Value.scale.Value;
                    }
                }
            }
        }

        /// <summary>
        /// Legacy method for backwards compatibility - repositions miscellaneous objects
        /// </summary>
        public static void RepositionMiscObjects(Dictionary<string, (Vector3 position, Vector3 rotation)> objects)
        {
            RepositionObjects(objects, "misc objects");
        }

        /// <summary>
        /// Legacy method for backwards compatibility - repositions player spawn points
        /// </summary>
        public static void RepositionPlayerSpawnPoints(Dictionary<string, (Vector3 position, Vector3 rotation)> objects)
        {
            RepositionObjects(objects, "player spawn points");
        }
    }
}