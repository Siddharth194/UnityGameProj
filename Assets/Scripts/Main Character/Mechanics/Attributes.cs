using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour
{
    public float health = 100;
    public float maxhealth = 100;
    public int kills = 0;
    public int level = 0;
    public int weapon = 0;
    public static Attributes instance;
    public Animator anim;

    void Start()
    {
        instance = this;
        maxhealth = 100;
        health = 100;
        kills = 0;
        level = 0;
    }

    void Update()
    {
        anim.SetFloat("weapon",weapon);
    }
}
