using UnityEngine;
using Il2CppTLD.UI.Generics;

namespace LitharsRidge
{
    public class CustomLocationLabel : MonoBehaviour
    {
        public string locationName = "Custom Location";
        public float triggerDistance = 15f;

        private bool hasShownLabel = false;
        private Transform playerTransform;
        private Panel_HUD hudPanel;

        private void Start()
        {
            // Get reference to player and HUD
            var player = GameObject.FindGameObjectWithTag("Player");
            if (player != null)
            {
                playerTransform = player.transform;
            }

            // Try to get HUD panel reference
            try
            {
                // Method 1: Try to find the HUD panel directly
                var hudGO = GameObject.Find("Panel_HUD");
                if (hudGO != null)
                {
                    hudPanel = hudGO.GetComponent<Panel_HUD>();
                    if (hudPanel != null)
                    {
                        Debug.Log("CustomLocationLabel: Got HUD panel reference via GameObject.Find");
                    }
                }

                // Method 2: Try using InterfaceManager if available
                if (hudPanel == null)
                {
                    try
                    {
                        hudPanel = InterfaceManager.GetPanel<Panel_HUD>();
                        if (hudPanel != null)
                        {
                            Debug.Log("CustomLocationLabel: Got HUD panel reference via InterfaceManager");
                        }
                    }
                    catch
                    {
                        Debug.Log("CustomLocationLabel: InterfaceManager method failed");
                    }
                }

                // Method 3: Try finding through component search
                if (hudPanel == null)
                {
                    hudPanel = FindObjectOfType<Panel_HUD>();
                    if (hudPanel != null)
                    {
                        Debug.Log("CustomLocationLabel: Got HUD panel reference via FindObjectOfType");
                    }
                }

                if (hudPanel == null)
                {
                    Debug.Log("CustomLocationLabel: Could not find Panel_HUD");
                }
            }
            catch (System.Exception ex)
            {
                Debug.Log($"CustomLocationLabel: Failed to get HUD panel: {ex.Message}");
            }
        }

        private void Update()
        {
            if (playerTransform == null)
            {
                // Try to find player again
                var player = GameObject.FindGameObjectWithTag("Player");
                if (player != null)
                {
                    playerTransform = player.transform;
                    Debug.Log("CustomLocationLabel: Found player transform in Update");
                }
                else
                {
                    return;
                }
            }

            if (hudPanel == null)
            {
                // Try to find HUD again
                var hudGO = GameObject.Find("Panel_HUD");
                if (hudGO != null)
                {
                    hudPanel = hudGO.GetComponent<Panel_HUD>();
                    if (hudPanel != null)
                    {
                        Debug.Log("CustomLocationLabel: Found HUD panel in Update");
                    }
                }
                else
                {
                    return;
                }
            }

            if (hasShownLabel)
                return;

            // Check distance to player
            float distance = Vector3.Distance(transform.position, playerTransform.position);

            // Log every 60 frames (approximately once per second)
            if (Time.frameCount % 60 == 0)
            {
                Debug.Log($"CustomLocationLabel: Player distance = {distance:F2}m, Trigger radius = {triggerDistance}m, Player pos = {playerTransform.position}, Trigger pos = {transform.position}");
            }

            if (distance <= triggerDistance)
            {
                ShowLocationLabel();
            }
        }

        private void ShowLocationLabel()
        {
            try
            {
                Debug.Log($"CustomLocationLabel: Showing label '{locationName}'");

                // Try to use the HUD's location reveal system
                if (hudPanel != null)
                {
                    hudPanel.ShowLocationReveal(locationName, "", false);
                    hasShownLabel = true;
                    Debug.Log($"CustomLocationLabel: Successfully showed '{locationName}' via HUD");
                }
                else
                {
                    Debug.Log("CustomLocationLabel: HUD panel is null, cannot show location");
                }
            }
            catch (System.Exception ex)
            {
                Debug.Log($"CustomLocationLabel: Error showing location label: {ex.Message}");
            }
        }

        // Reset the label so it can be shown again (useful for testing)
        public void ResetLabel()
        {
            hasShownLabel = false;
        }

        // Optional: Draw debug sphere in scene view
        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, triggerDistance);
        }
    }
}
