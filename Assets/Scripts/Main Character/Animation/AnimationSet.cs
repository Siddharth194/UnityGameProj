using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSet : MonoBehaviour
{

    public Animator animator;
    public float cwp;
    void Start()
    {
        cwp = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            cwp = 1 - cwp;
        }
    }
}
