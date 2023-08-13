// using UnityEngine;
// using UnityEngine.UI;

// public class ChangeImageOfChildren : MonoBehaviour
// {
//     private void Update() // Change this to Start() if you only want it to run once at the beginning.
//     {
//         Transform parentTransform = transform;

//         for (int i = 0; i < parentTransform.childCount; i++)
//         {
//             Transform childTransform = parentTransform.GetChild(i);
//             Transform buttonTransform = childTransform.Find("InventoryButton");

//             if (buttonTransform != null)
//             {
//                 Transform imageTransform = buttonTransform.Find("Item Image");
//                 Transform closeButton = buttonTransform.Find("Close button");
//                 Image imageComponent = imageTransform.GetComponent<Image>();
//                 if (InventoryScript.instance == null) return;

//                 if (imageComponent != null && i < InventoryScript.instance.ListofItems.Count)
//                 { 
//                     Sprite newSprite = InventoryScript.instance.ListofItems[i].icon;
//                     imageComponent.enabled = true;
//                     closeButton.GetComponent<Image>().enabled = true;
//                     imageComponent.sprite = newSprite;
//                 }
//                 else
//                 {
//                     imageComponent.enabled = false;
//                     closeButton.GetComponent<Image>().enabled = false; 
//                 }
//             }
//             else
//             {
//                 Debug.LogWarning("Button not found in child.");
//             }
//         }
        
//         //Debug.Log(InventoryScript.instance.ListofItems.Count);
//         parentTransform = transform;
//         for (int j = 0; j < InventoryScript.instance.ListofItems.Count; j++)
//         {
//             //Debug.Log(j);//Debug.Log("Loop");
//             Transform childTransform = parentTransform.GetChild(j);
//             Transform buttonTransform = childTransform.Find("InventoryButton");
//             Transform closeButtonObj = buttonTransform.Find("Close button");
//             //Debug.Log(closeButtonObj.name);
//             Button cbClick = closeButtonObj.GetComponent<Button>();

//             int counter = 100;
//             cbClick.onClick.AddListener(() => IntFunc(j));
//         }
//     }

//     private void CloseClickFunc(int index)
//     {
//         if (index < InventoryScript.instance.ListofItems.Count+1)
//         {
//             InventoryScript.instance.ListofItems.RemoveAt(index-1);
//             Debug.Log(InventoryScript.instance.ListofItems.Count);
//         }
//     }
// };

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeImageOfChildren : MonoBehaviour
{
    private bool canClick = true;
    private float cooldownDuration = 0.01f; // Cooldown time in seconds

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
                Transform closeButton = buttonTransform.Find("Close button");
                Image imageComponent = imageTransform.GetComponent<Image>();
                if (InventoryScript.instance == null) return;

                if (imageComponent != null && i < InventoryScript.instance.ListofItems.Count)
                { 
                    Sprite newSprite = InventoryScript.instance.ListofItems[i].icon;
                    imageComponent.enabled = true;
                    closeButton.GetComponent<Image>().enabled = true;
                    imageComponent.sprite = newSprite;
                }
                else
                {
                    imageComponent.enabled = false;
                    closeButton.GetComponent<Image>().enabled = false; 
                }
            }
            else
            {
                Debug.LogWarning("Button not found in child.");
            }
        }
        
        //Debug.Log(InventoryScript.instance.ListofItems.Count);
        parentTransform = transform;
        for (int j = 0; j < InventoryScript.instance.ListofItems.Count; j++)
        {
            //Debug.Log(j);//Debug.Log("Loop");
            Transform childTransform = parentTransform.GetChild(j);
            Transform buttonTransform = childTransform.Find("InventoryButton");
            Transform closeButtonObj = buttonTransform.Find("Close button");
            //Debug.Log(closeButtonObj.name);
            Button cbClick = closeButtonObj.GetComponent<Button>();

            cbClick.onClick.AddListener(() => CloseClickFunc(j));
        }
    }

    private void CloseClickFunc(int index)
    {
        if (canClick)
        {
            canClick = false;
            StartCoroutine(ResetClickCooldown());

            if (index < InventoryScript.instance.ListofItems.Count)
            {
                InventoryScript.instance.ListofItems.RemoveAt(index);
            }
            else if (index == InventoryScript.instance.ListofItems.Count)
            {
                InventoryScript.instance.ListofItems.RemoveAt(index-1);
            }

            Debug.Log(InventoryScript.instance.ListofItems.Count);
        }
    }

    private IEnumerator ResetClickCooldown()
    {
        yield return new WaitForSeconds(cooldownDuration);
        canClick = true;
    }
}