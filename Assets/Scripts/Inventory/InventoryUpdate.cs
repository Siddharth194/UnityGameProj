using UnityEngine;
using UnityEngine.UI;

public class ChangeImageOfChildren : MonoBehaviour
{
    private void Update() // Change this to Start() if you only want it to run once at the beginning.
    {
        Transform parentTransform = transform;

        for (int i = 0; i < parentTransform.childCount; i++)
        {
            Transform childTransform = parentTransform.GetChild(i);
            Transform buttonTransform = childTransform.Find("InventoryButton");

            if (buttonTransform != null)
            {
                Transform imageTransform = buttonTransform.Find("Item Image");
                Image imageComponent = imageTransform.GetComponent<Image>();
                if (InventoryScript.instance == null) return;

                if (imageComponent != null && i < InventoryScript.instance.ListofItems.Count)
                {
                    Debug.Log("Image to Inventory");
                    Sprite newSprite = InventoryScript.instance.ListofItems[i].icon;
                    imageComponent.enabled = true;
                    imageComponent.sprite = newSprite;
                }
                else
                {
                    Debug.LogWarning("Image component not found or ListofItems index out of range.");
                }
            }
            else
            {
                Debug.LogWarning("Button not found in child.");
            }
        }
    }
}
