using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    [SerializeField]
    private Item itemprefab;

    public static InventoryScript instance;

    public List<Item> ListofItems = new List<Item>();
    public int inventorysize = 16;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public bool AddItem(Item item)
    {
        if (ListofItems.Count < inventorysize)
        { ListofItems.Add(item); return true; }
        else return false;
    }
}