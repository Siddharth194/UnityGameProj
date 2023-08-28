using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttributes : MonoBehaviour
{
    public float health = 100;
    public float maxhealth = 100;
    public static EnemyAttributes instance;
    public Animator anim;
    public bool dead = false;
    public GameObject prefabToSpawn, parent;
    void Start()
    {
        instance = this;
        maxhealth = 100;
        health = 100;
    }

    public void damage(int playerdmg)
    {
        health -= playerdmg;
    }
    void Update()
    {
        if (health <= 0 && dead == false) 
        {
            Instantiate(prefabToSpawn, transform.position, transform.rotation); //Quaternion.identity);
            Destroy(transform.parent.gameObject);
            dead = true;
        }
    }

}
