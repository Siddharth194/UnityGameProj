using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateResourceBoxes : MonoBehaviour
{
    public Sprite mspistol, knife, bandage, impknife, medKit, glock, aksprite;
    void Start()
    {
        // Item gunitem = AddGunToInventory.instance.CreateGun(); //new Item("Makeshift Pistol", ID, ItemType.Weapon, mspistol, 0, 1, null);
        // CreateResourceBoxes.spawnedPrefabs[1].GetComponent<ResourceBox>().AddItem(gunitem);
        // Debug.Log(CreateResourceBoxes.spawnedPrefabs[1]);

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 2; i++)
            {
                if (Random.value < 0.18)
                {
                Item gunitem = new Item("Makeshift Pistol", AddGunToInventory.instance.ID, ItemType.Weapon, mspistol, 25, 1, 1, null, 1);
                CreateResourceBoxes.spawnedPrefabs[i].GetComponent<ResourceBox>().ListofItems.Add(gunitem);
                }
                if (Random.value < 0.28)
                {
                Item impknifeitem = new Item("Improvised Knife", AddGunToInventory.instance.ID, ItemType.Weapon, impknife, 25, 3, 0, null, 1);
                CreateResourceBoxes.spawnedPrefabs[i].GetComponent<ResourceBox>().ListofItems.Add(impknifeitem);
                }
                if (Random.value < 0.18)
                {
                Item knifeitem = new Item("Battle Knife", AddGunToInventory.instance.ID, ItemType.Weapon, knife, 50, 2, 0, null, 1);
                CreateResourceBoxes.spawnedPrefabs[i].GetComponent<ResourceBox>().ListofItems.Add(knifeitem);
                }

                if (Random.value < 0.16)
                {
                    Item glockitem = new Item("Glock 17", AddGunToInventory.instance.ID, ItemType.Weapon, glock, 34, 4, 1, null, 1);
                    CreateResourceBoxes.spawnedPrefabs[i].GetComponent<ResourceBox>().ListofItems.Add(glockitem);
                }

                for (int k = 0; k < 2; k++)
                if (Random.value < 0.4)
                {
                    Item bdgItem = new Item("Bandage", AddGunToInventory.instance.ID, ItemType.Consumable, bandage, 25, -1, -1, null, 1);
                    CreateResourceBoxes.spawnedPrefabs[i].GetComponent<ResourceBox>().ListofItems.Add(bdgItem);
                }     

                if (Random.value < 0.25)
                {
                    Item bdgItem = new Item("Med Kit", AddGunToInventory.instance.ID, ItemType.Consumable, medKit, 75, -1, -1, null, 1);
                    CreateResourceBoxes.spawnedPrefabs[i].GetComponent<ResourceBox>().ListofItems.Add(bdgItem);
                }

                if (Random.value < 0.10)
                {
                    Item medKitItem = new Item("AK-47", AddGunToInventory.instance.ID, ItemType.Weapon, aksprite, 50, 5, 1, null, 1);
                    CreateResourceBoxes.spawnedPrefabs[i].GetComponent<ResourceBox>().ListofItems.Add(medKitItem);
                }
            }

        }
    }

    void Update()
    {
    }
}