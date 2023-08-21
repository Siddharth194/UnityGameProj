using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PickupItems : MonoBehaviour
{
    private bool canClick = true;
    private float cooldownDuration = 0.01f;
    public Transform Panel;

    private IEnumerator ResetClickCooldown()
    {
        yield return new WaitForSeconds(cooldownDuration);
        canClick = true;
    }

    private void Update()
    {
        for (int i = 0; i < Panel.childCount; i++)
        {
            Transform childTransform = Panel.GetChild(i);
            Transform buttonTransform = childTransform.Find("Button");

            if (buttonTransform != null)
            {
                Transform imageTransform = buttonTransform.Find("Icon");
                Transform closeButton = buttonTransform.Find("PickupImage");
                Image imageComponent = imageTransform.GetComponent<Image>();

                if (imageComponent != null && i < GetComponent<ResourceBox>().ListofItems.Count)
                { 
                    Sprite newSprite = GetComponent<ResourceBox>().ListofItems[i].icon;
                    imageComponent.enabled = true;
                    closeButton.gameObject.SetActive(true);
                    imageComponent.sprite = newSprite;

                    int capturedIndex = i; // Capture the current index for the lambda
                    Button cbClick = closeButton.GetComponent<Button>();

                    if (cbClick != null)
                    {
                        cbClick.onClick.RemoveAllListeners(); // Clear previous listeners
                        cbClick.onClick.AddListener(() => CloseClickFunc(capturedIndex));
                    }
                    else
                    {
                        Debug.LogWarning("Button component not found on the PickupImage object.");
                    }
                }
                else
                {
                    imageComponent.enabled = false;
                    closeButton.gameObject.SetActive(false);
                }
            }
            else
            {
                Debug.LogWarning("Button not found in child.");
            }
        }
    }

    private void CloseClickFunc(int index)
    {
        if (canClick)
        {
            canClick = false;
            StartCoroutine(ResetClickCooldown());

            ResourceBox resourceBox = GetComponent<ResourceBox>();

            if (resourceBox != null && index >= 0 && index < resourceBox.ListofItems.Count)
            {
                InventoryScript.instance.AddItem(resourceBox.ListofItems[index]);
                resourceBox.ListofItems.RemoveAt(index);
            }
        }
    }
}
