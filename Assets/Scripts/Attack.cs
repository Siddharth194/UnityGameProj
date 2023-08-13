using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndHoldTrigger : MonoBehaviour
{
    private Animator anim;
    public float phand = 0;
  
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            phand = 1 - phand;

            if (phand > 0.1)
            {
                anim.Play("Punch");
            }
            else
            {
                anim.Play("Punch right");
            }
        }
    }
}
