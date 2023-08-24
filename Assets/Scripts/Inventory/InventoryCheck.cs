using UnityEngine;

public class AddGunToInventory : MonoBehaviour
{
    public int ID = 1;
    public Sprite mspistol;
    public Sprite Bandage;
    public static AddGunToInventory instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            //Destroy(gameObject);
        }

        int ID = 1;
    }

    public Item CreateGun()
    {
        Item gunItem = new Item("Makeshift Pistol", ID, ItemType.Weapon, mspistol, 0, 1, 1, null, 1);
       
        return gunItem;
    }

    public Item CreateBandage()
    {
        Item bdgItem = new Item("Bandage", ID, ItemType.Consumable, Bandage, 0, -1, -1, null, 1);

        return bdgItem;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            bool added = InventoryScript.instance.AddItem(CreateBandage());
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
        if (Input.GetKeyDown(KeyCode.G))
        {
            bool added = InventoryScript.instance.AddItem(CreateGun());
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
    }

}
