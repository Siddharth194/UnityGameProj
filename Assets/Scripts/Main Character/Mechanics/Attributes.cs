using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour
{
    public float health = 100;
    public float maxhealth = 100;
    public int kills = 0;
    public int level = 0;
    public Item weapon;
    public static Attributes instance;
    public Animator anim;
    public int weaponnum;

    void Start()
    {
        instance = this;
        maxhealth = 100;
        health = 100;
        kills = 0;
        level = 0;
        weapon = null;
    }

    void Update()
    {
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

    }
}
