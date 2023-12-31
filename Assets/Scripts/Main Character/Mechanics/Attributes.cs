using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attributes : MonoBehaviour
{
    public float health;
    public float maxhealth = 100;
    public int kills = 0;
    public int level = 0;
    public Item weapon;
    public static Attributes instance;
    public Animator anim;
    public int weaponnum;
    public int windex;
    public Transform death;
    bool death1 = false;
    public GameObject player;

    void Start()
    {
        instance = this;
        maxhealth = 100;
        //health = 100;
        kills = 0;
        level = 0;
        weapon = null;
    }

    void Update()
    {
        if (health <= 0)
        {
            death.GetComponent<DeathScreen>().death1 = true;
            player.SetActive(false);
        }

        //if (death1 == false)
        //{
            if (weapon == null)
            {
                weaponnum = 0;
                weapon = new Item("Fist", 0, ItemType.Weapon, null, 10, 0, 0, null, 1);
            }
                
            else
            {
                if (weapon.itemName == "Makeshift Pistol")
                    weaponnum = 1;
            }
            weaponnum = weapon.weaponID;
            anim.SetFloat("weapon",weapon.weaponID);

            if (weapon.durability <= 0)
            {
                InventoryScript.instance.ListofItems.RemoveAt(windex);
                weapon = null;
            }
        //}
    }
}
