using Il2Cpp;
using UnityEngine;
using Il2CppTLD.UI.Generics;

namespace LitharsRidge
{
    [RegisterTypeInIl2Cpp]
    public class LitharsRidgeTrigger : MonoBehaviour
    {
        private bool hasTriggered = false;

        public LitharsRidgeTrigger(System.IntPtr ptr) : base(ptr) { }

        private void OnTriggerEnter(Collider other)
        {
            if (hasTriggered) return;

            Debug.Log($"LitharsRidgeTrigger: Trigger entered by {other.gameObject.name}");

            // Check if it's the player
            if (other.gameObject.CompareTag("Player") || other.gameObject.name.Contains("Player"))
            {
                ShowLocationLabel();
            }
        }

        private void ShowLocationLabel()
        {
            try
            {
                Debug.Log("LitharsRidgeTrigger: Attempting to show location label");

                // Try to get HUD panel
                Panel_HUD hudPanel = InterfaceManager.GetPanel<Panel_HUD>();

                if (hudPanel != null)
                {
                    hudPanel.ShowLocationReveal("Lithar's Ridge", "", false);
                    hasTriggered = true;
                    Debug.Log("LitharsRidgeTrigger: Successfully showed location label!");
                }
                else
                {
                    Debug.Log("LitharsRidgeTrigger: Could not find HUD panel");
                }
            }
            catch (System.Exception ex)
            {
                Debug.Log($"LitharsRidgeTrigger: Error showing label - {ex.Message}");
            }
        }
    }
}