using UnityEngine;

public enum ItemType
{
    Consumable,
    Weapon,
    Resource
}

[System.Serializable]
public class Item : MonoBehaviour
{
    public string itemName;
    public int itemID;
    public ItemType itemType;
    public Sprite icon;
    public GameObject prefab; // If the item can be instantiated in the game world
    public int maxStackSize = 1;

    public Item(string name, int id, ItemType type, Sprite icon, GameObject prefab = null, int stackSize = 1)
    {
        itemName = name;
        itemID = id;
        itemType = type;
        this.icon = icon;
        this.prefab = prefab;
        maxStackSize = stackSize;
    }
}