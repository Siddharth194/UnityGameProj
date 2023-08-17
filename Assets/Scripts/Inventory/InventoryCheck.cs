using UnityEngine;

public class AddGunToInventory : MonoBehaviour
{
    public int ID = 0;
    public Sprite mspistol;
    public Sprite Bandage;

    void Start()
    {
        int ID = 0;
    }


    private void AddGunToInventoryAndDestroy()
    {
        Item gunItem = new Item("Makeshift Pistol", ID, ItemType.Weapon, mspistol, null, 1);
        bool added = InventoryScript.instance.AddItem(gunItem);

        if (added)
        {
            ID += 1;
            Debug.Log("Gun added to inventory.");
        }
        else
        {
            Debug.Log("Inventory is full. Cannot add gun.");
        }
    }

    private void AddBandageToInventoryAndDestroy()
    {
        Item bdgItem = new Item("Bandage", ID, ItemType.Consumable, Bandage, null, 1);
        bool added = InventoryScript.instance.AddItem(bdgItem);

        if (added)
        {
            ID += 1;
            Debug.Log("Bandage added to inventory.");
        }
        else
        {
            Debug.Log("Inventory is full. Cannot add.");
        }
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            AddGunToInventoryAndDestroy();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            AddBandageToInventoryAndDestroy();
        }
    }

}
