using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{

    public Animator anim;
    void Start()
    {
        anim.Play("death");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
