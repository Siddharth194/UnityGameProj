using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceBox : MonoBehaviour
{
    public List<Item> ListofItems = new List<Item>();
    public int size = 6;
    public ResourceBox instance;
    //public int number;

    void Start()
    {
        instance = this;
    }

    public bool AddItem(Item item)
    {
        if (ListofItems.Count < size)
        {
            ListofItems.Add(item);
            return true;
        }
        else return false;
    }
}
