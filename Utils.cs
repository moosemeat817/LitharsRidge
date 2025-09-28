using MelonLoader.Utils;
using UnityEngine;
using System.Collections.Generic;
using MelonLoader;

namespace LitharsRidge
{
    public static class Utilities
    {
        // Utility method to disable game objects
        public static void DisableGameObjects(string[] objectPaths)
        {
            if (objectPaths == null)
            {
                //Melonlogger.Warning("****************************** Object paths array is null");
                return;
            }

            //Melonlogger.Msg("****************************** Disabling multiple game objects");
            int disabledCount = 0;
            foreach (string path in objectPaths)
            {
                if (string.IsNullOrEmpty(path))
                {
                    //Melonlogger.Warning("****************************** Null or empty path found in array");
                    continue;
                }

                GameObject obj = GameObject.Find(path);
                if (obj != null)
                {
                    obj.SetActive(false);
                    disabledCount++;
                    //Melonlogger.Msg($"****************************** Disabled object: {path}");
                }
                else
                {
                    //Melonlogger.Warning($"****************************** Failed to find object to disable: {path}");
                }
            }
            //Melonlogger.Msg($"****************************** Disabled {disabledCount} out of {objectPaths.Length} objects");
        }

        // Utility method for safely disabling objects (doesn't warn if not found)
        public static void SafeDisable(string objectPath)
        {
            if (string.IsNullOrEmpty(objectPath))
            {
                //Melonlogger.Warning("****************************** Null or empty object path provided");
                return;
            }

            GameObject obj = GameObject.Find(objectPath);
            if (obj != null)
            {
                obj.SetActive(false);
                //Melonlogger.Msg($"****************************** Safely disabled optional object: {objectPath}");
            }
            else
            {
                //Melonlogger.Msg($"****************************** Optional object not found (this is expected): {objectPath}");
            }
        }

        // Utility method to disable children by index
        public static void DisableChildrenByIndex(string parentPath, int[] childIndices)
        {
            if (string.IsNullOrEmpty(parentPath))
            {
                //Melonlogger.Warning("****************************** Null or empty parent path provided");
                return;
            }

            if (childIndices == null)
            {
                //Melonlogger.Warning("****************************** Child indices array is null");
                return;
            }

            //Melonlogger.Msg($"****************************** Disabling children by index for parent: {parentPath}");
            GameObject parent = GameObject.Find(parentPath);
            if (parent != null)
            {
                foreach (int index in childIndices)
                {
                    if (index >= 0 && index < parent.transform.childCount)
                    {
                        Transform child = parent.transform.GetChild(index);
                        if (child != null)
                        {
                            child.gameObject.SetActive(false);
                            //Melonlogger.Msg($"****************************** Disabled child at index {index}");
                        }
                        else
                        {
                            //Melonlogger.Warning($"****************************** Child at index {index} is null");
                        }
                    }
                    else
                    {
                        //Melonlogger.Warning($"****************************** Child index {index} out of range for {parentPath} (childCount: {parent.transform.childCount})");
                    }
                }
            }
            else
            {
                //Melonlogger.Warning($"****************************** Parent object not found: {parentPath}");
            }
        }

        // New utility method to disable children by name containing specific text
        public static void DisableChildrenByNameContains(string parentPath, string nameContains, bool caseSensitive = false)
        {
            if (string.IsNullOrEmpty(parentPath))
            {
                //Melonlogger.Warning("****************************** Null or empty parent path provided");
                return;
            }

            if (string.IsNullOrEmpty(nameContains))
            {
                //Melonlogger.Warning("****************************** Null or empty name filter provided");
                return;
            }

            //Melonlogger.Msg($"****************************** Disabling children containing '{nameContains}' for parent: {parentPath}");
            GameObject parent = GameObject.Find(parentPath);
            if (parent != null)
            {
                int disabledCount = 0;
                for (int i = 0; i < parent.transform.childCount; i++)
                {
                    Transform child = parent.transform.GetChild(i);
                    if (child != null)
                    {
                        string childName = child.name;
                        bool nameMatch = caseSensitive ?
                            childName.Contains(nameContains) :
                            childName.ToLower().Contains(nameContains.ToLower());

                        if (nameMatch)
                        {
                            child.gameObject.SetActive(false);
                            disabledCount++;
                            //Melonlogger.Msg($"****************************** Disabled child: {childName}");
                        }
                    }
                }
                //Melonlogger.Msg($"****************************** Disabled {disabledCount} children containing '{nameContains}'");
            }
            else
            {
                //Melonlogger.Warning($"****************************** Parent object not found: {parentPath}");
            }
        }

        // New utility method to disable children by multiple name filters
        public static void DisableChildrenByNameContains(string parentPath, string[] nameContains, bool caseSensitive = false)
        {
            if (string.IsNullOrEmpty(parentPath))
            {
                //Melonlogger.Warning("****************************** Null or empty parent path provided");
                return;
            }

            if (nameContains == null || nameContains.Length == 0)
            {
                //Melonlogger.Warning("****************************** Null or empty name filters array provided");
                return;
            }

            //Melonlogger.Msg($"****************************** Disabling children with multiple name filters for parent: {parentPath}");
            GameObject parent = GameObject.Find(parentPath);
            if (parent != null)
            {
                int disabledCount = 0;
                for (int i = 0; i < parent.transform.childCount; i++)
                {
                    Transform child = parent.transform.GetChild(i);
                    if (child != null)
                    {
                        string childName = child.name;
                        bool shouldDisable = false;

                        foreach (string filter in nameContains)
                        {
                            if (string.IsNullOrEmpty(filter)) continue;

                            bool nameMatch = caseSensitive ?
                                childName.Contains(filter) :
                                childName.ToLower().Contains(filter.ToLower());

                            if (nameMatch)
                            {
                                shouldDisable = true;
                                break;
                            }
                        }

                        if (shouldDisable)
                        {
                            child.gameObject.SetActive(false);
                            disabledCount++;
                            //Melonlogger.Msg($"****************************** Disabled child: {childName}");
                        }
                    }
                }
                //Melonlogger.Msg($"****************************** Disabled {disabledCount} children with name filters");
            }
            else
            {
                //Melonlogger.Warning($"****************************** Parent object not found: {parentPath}");
            }
        }

        // Utility method to enable children by index
        public static void EnableChildrenByIndex(string parentPath, int[] childIndices)
        {
            if (string.IsNullOrEmpty(parentPath))
            {
                //Melonlogger.Warning("****************************** Null or empty parent path provided");
                return;
            }

            if (childIndices == null)
            {
                //Melonlogger.Warning("****************************** Child indices array is null");
                return;
            }

            //Melonlogger.Msg($"****************************** Enabling children by index for parent: {parentPath}");
            GameObject parent = GameObject.Find(parentPath);
            if (parent != null)
            {
                foreach (int index in childIndices)
                {
                    if (index >= 0 && index < parent.transform.childCount)
                    {
                        Transform child = parent.transform.GetChild(index);
                        if (child != null)
                        {
                            child.gameObject.SetActive(true);
                            //Melonlogger.Msg($"****************************** Enabled child at index {index}");
                        }
                        else
                        {
                            //Melonlogger.Warning($"****************************** Child at index {index} is null");
                        }
                    }
                    else
                    {
                        //Melonlogger.Warning($"****************************** Child index {index} out of range for {parentPath} (childCount: {parent.transform.childCount})");
                    }
                }
            }
            else
            {
                //Melonlogger.Warning($"****************************** Parent object not found: {parentPath}");
            }
        }

        // Basic utility method to reposition objects (position and rotation only)
        public static void RepositionObjects(Dictionary<string, (Vector3 position, Vector3 rotation)> objects, string objectType = "objects")
        {
            if (objects == null)
            {
                //Melonlogger.Warning($"****************************** Objects dictionary is null for {objectType}");
                return;
            }

            //Melonlogger.Msg($"****************************** Beginning {objectType} repositioning");

            int repositionedCount = 0;
            foreach (var obj in objects)
            {
                if (string.IsNullOrEmpty(obj.Key))
                {
                    //Melonlogger.Warning($"****************************** Null or empty key found in {objectType} dictionary");
                    continue;
                }

                GameObject gameObj = GameObject.Find(obj.Key);
                if (gameObj != null)
                {
                    gameObj.transform.SetPositionAndRotation(
                        obj.Value.position,
                        Quaternion.Euler(obj.Value.rotation)
                    );
                    repositionedCount++;
                    //Melonlogger.Msg($"****************************** Repositioned {objectType.TrimEnd('s')}: {obj.Key}");
                }
                else
                {
                    //Melonlogger.Warning($"****************************** Failed to find {objectType.TrimEnd('s')} object: {obj.Key}");
                }
            }
            //Melonlogger.Msg($"****************************** Repositioned {repositionedCount} {objectType}");
        }

        // Overloaded utility method to reposition objects with optional scaling
        public static void RepositionObjects(Dictionary<string, (Vector3 position, Vector3 rotation, Vector3? scale)> objects, string objectType = "objects")
        {
            if (objects == null)
            {
                //Melonlogger.Warning($"****************************** Objects dictionary is null for {objectType}");
                return;
            }

            //Melonlogger.Msg($"****************************** Beginning {objectType} repositioning");

            int repositionedCount = 0;
            foreach (var obj in objects)
            {
                if (string.IsNullOrEmpty(obj.Key))
                {
                    //Melonlogger.Warning($"****************************** Null or empty key found in {objectType} dictionary");
                    continue;
                }

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
                        //Melonlogger.Msg($"****************************** Applied scale to {objectType.TrimEnd('s')}: {obj.Key}");
                    }

                    repositionedCount++;
                    //Melonlogger.Msg($"****************************** Repositioned {objectType.TrimEnd('s')}: {obj.Key}");
                }
                else
                {
                    //Melonlogger.Warning($"****************************** Failed to find {objectType.TrimEnd('s')} object: {obj.Key}");
                }
            }
            //Melonlogger.Msg($"****************************** Repositioned {repositionedCount} {objectType}");
        }

        // Legacy method names for backwards compatibility
        public static void RepositionMiscObjects(Dictionary<string, (Vector3 position, Vector3 rotation)> objects)
        {
            RepositionObjects(objects, "misc objects");
        }

        public static void RepositionPlayerSpawnPoints(Dictionary<string, (Vector3 position, Vector3 rotation)> objects)
        {
            RepositionObjects(objects, "player spawn points");
        }
    }
}