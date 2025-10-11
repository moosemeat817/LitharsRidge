using UnityEngine;
using Il2Cpp;

namespace LitharsRidge
{
    /// <summary>
    /// Adds a map marker for Lithar's Ridge by cloning STR_WoodCabinA_Prefab's MapDetail
    /// </summary>
    public class AddMapMarker
    {
        /// <summary>
        /// Clones the WoodCabinA prefab (invisibly) to get its MapDetail at the shelter location
        /// </summary>
        public static void AddLitharsRidgeMarker()
        {
            // Find the cloned security hut for position reference
            GameObject hutClone = GameObject.Find("STR_SecurityHutB_Prefab(Clone)");

            if (hutClone == null)
            {
                Debug.Log("AddMapMarker: Could not find STR_SecurityHutB_Prefab(Clone)");
                return;
            }

            Vector3 litharsRidgePosition = hutClone.transform.position;

            // Find the wood cabin prefab that has the MapDetail
            GameObject woodCabinPrefab = GameObject.Find("STR_WoodCabinA_Prefab");

            if (woodCabinPrefab == null)
            {
                Debug.Log("AddMapMarker: Could not find STR_WoodCabinA_Prefab");
                return;
            }

            Debug.Log("AddMapMarker: Found wood cabin prefab, cloning for map marker");

            // Clone the entire wood cabin (this includes its MapDetail component)
            GameObject markerClone = GameObject.Instantiate(woodCabinPrefab);
            markerClone.name = "LitharsRidge_MapMarker";

            // Bury it underground (below your shelter)
            markerClone.transform.position = litharsRidgePosition + new Vector3(0, -50f, 0);

            // Make the visual mesh invisible (we only want the MapDetail)
            MeshRenderer[] renderers = markerClone.GetComponentsInChildren<MeshRenderer>();
            foreach (MeshRenderer renderer in renderers)
            {
                renderer.enabled = false;
            }

            // Disable any colliders so it doesn't interfere with gameplay
            Collider[] colliders = markerClone.GetComponentsInChildren<Collider>();
            foreach (Collider collider in colliders)
            {
                collider.enabled = false;
            }

            // Get the MapDetail and configure it
            MapDetail mapDetail = markerClone.GetComponent<MapDetail>();

            if (mapDetail != null)
            {
                mapDetail.m_RequiresInteraction = false;
                mapDetail.ShowOnMap(true);

                Debug.Log("AddMapMarker: Successfully created underground map marker for Lithar's Ridge");
            }
            else
            {
                Debug.Log("AddMapMarker: Warning - cloned cabin has no MapDetail component");
            }
        }
    }
}