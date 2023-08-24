using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateResourceBoxes : MonoBehaviour
{
    public Sprite mspistol;    
    void Start()
    {
        Item gunitem = AddGunToInventory.instance.CreateGun(); //new Item("Makeshift Pistol", ID, ItemType.Weapon, mspistol, 0, 1, null);
        CreateResourceBoxes.spawnedPrefabs[1].GetComponent<ResourceBox>().AddItem(gunitem);
        Debug.Log(CreateResourceBoxes.spawnedPrefabs[1]);
    }

    // Update is called once per frame
    void Update()
    {
        //AddGunToInventory.instance.CreateBandage();
    }
}
