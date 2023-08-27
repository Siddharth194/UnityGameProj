using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EquipAndUse : MonoBehaviour
{
    public Transform EButton, Panel, ItemInfo;
    public TextMeshProUGUI EBText, ItemName;
    public int currindex = -1;
    Transform childTransform, buttonTransform;
    Button ItemButton, EquipButton;

    void Start()
    {
        
    }

    void Update()
    {
        for (int j = 0; j < InventoryScript.instance.ListofItems.Count; j++)
        {
            childTransform = Panel.GetChild(j);
            buttonTransform = childTransform.Find("InventoryButton");
            ItemButton = buttonTransform.GetComponent<Button>();
            EquipButton = EButton.GetComponent<Button>();

            int itemIndex = j;
            ItemButton.onClick.AddListener(() => ClickFunc(itemIndex));
        }

        if (currindex != -1)
        {
            EquipButton.onClick.AddListener(() => EButtonClickFunc(currindex));
        }
    }

    void ClickFunc(int itemIndex)
    {
        currindex = itemIndex;
        //Debug.Log(itemIndex);
        EButton.gameObject.SetActive(true);
        ItemInfo.gameObject.SetActive(true);

        if (InventoryScript.instance.ListofItems[itemIndex].itemType == ItemType.Weapon)
            EBText.text = "Equip";
        else if (InventoryScript.instance.ListofItems[itemIndex].itemType == ItemType.Consumable)
            EBText.text = "Use";
        
        ItemInfo.GetComponent<Image>().sprite = InventoryScript.instance.ListofItems[itemIndex].icon;
        ItemName.text = InventoryScript.instance.ListofItems[itemIndex].itemName;
    }

    void EButtonClickFunc(int index)
    {
        if (InventoryScript.instance.ListofItems[index].itemType == ItemType.Weapon)
        {
            Attributes.instance.weapon = InventoryScript.instance.ListofItems[index];
            Attributes.instance.windex = index;
        }
        else if (InventoryScript.instance.ListofItems[index].itemType == ItemType.Consumable)
        {
            Attributes.instance.health += InventoryScript.instance.ListofItems[index].damage;
            if (Attributes.instance.health >= Attributes.instance.maxhealth) Attributes.instance.health = Attributes.instance.maxhealth;
            InventoryScript.instance.ListofItems.RemoveAt(index);
        }
    }
}


