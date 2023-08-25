using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttributes : MonoBehaviour
{
    public float health = 100;
    public float maxhealth = 100;
    public static EnemyAttributes instance;
    public Animator anim;

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
        if (health <= 0) Destroy(transform.parent.gameObject);
    }
}
