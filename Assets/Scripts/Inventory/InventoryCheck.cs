using UnityEngine;

public class AddGunToInventory : MonoBehaviour
{
    public int ID = 0;
    public Sprite mspistol;
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
            //Debug.Log(InventoryScript.instance.ListofItems.Count);
            //Destroy(gameObject);
        }
        else
        {
            Debug.Log("Inventory is full. Cannot add gun.");
        }
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            AddGunToInventoryAndDestroy();
        }
    }

}
