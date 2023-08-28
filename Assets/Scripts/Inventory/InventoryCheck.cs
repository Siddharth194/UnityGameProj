using UnityEngine;

public class AddGunToInventory : MonoBehaviour
{
    public int ID = 1;
    public Sprite mspistol, knife, bandage, impknife, medKit;
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

    public Item CreateMKnife()
    {
        Item impknifeitem = new Item("Improvised Knife", ID, ItemType.Weapon, impknife, 20, 3, 0, null, 1);

        return impknifeitem;
    }
    public Item CreateKnife()
    {
        Item knifeitem = new Item("Knife", ID, ItemType.Weapon, knife, 34, 2, 0, null, 1);

        return knifeitem;
    }

    public Item CreateGun()
    {
        Item gunItem = new Item("Makeshift Pistol", ID, ItemType.Weapon, mspistol, 25, 1, 1, null, 1);
       
        return gunItem;
    }

    public Item CreateBandage()
    {
        Item bdgItem = new Item("Bandage", ID, ItemType.Consumable, bandage, 25, -1, -1, null, 1);

        return bdgItem;
    }

    public Item CreateMedkit()
    {
        Item MedKit = new Item("MedKit", ID, ItemType.Consumable, medKit, 75, -1, -1, null, 1);

        return MedKit;
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
        if (Input.GetKeyDown(KeyCode.K))
        {
            bool added = InventoryScript.instance.AddItem(CreateKnife());
            ID+=1;
        }
    }

}
