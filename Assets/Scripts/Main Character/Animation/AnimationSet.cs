using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSet : MonoBehaviour
{

    public Animator animator;
    public float cwp;
    //public SpriteResolvers;
    // Start is called before the first frame update
    void Start()
    {
        cwp = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            cwp = 1 - cwp;
        }

        animator.SetFloat("weapon",cwp);
    }
}
