using UnityEngine;

public enum ItemType
{
    Consumable,
    Weapon,
    Resource
}

[System.Serializable]
public class Item
{
    public string itemName;
    public int itemID;
    public ItemType itemType;
    public Sprite icon;
    public GameObject prefab; // If the item can be instantiated in the game world
    public int damage;
    public int weaponID;
    public int maxStackSize = 1;
    public int weapontype;
    public int durability;

    public Item(string name, int id, ItemType type, Sprite icon,  int dmg, int wID, int wtype, GameObject prefab = null, int stackSize = 1)
    {
        itemName = name;
        itemID = id;
        itemType = type;
        this.icon = icon;
        this.prefab = prefab;
        maxStackSize = stackSize;
        weaponID = wID;
        damage = dmg;
        weapontype = wtype;
        durability = 100;
    }
}