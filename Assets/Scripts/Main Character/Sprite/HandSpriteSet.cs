using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class HandSpriteSet : MonoBehaviour
{
    private bool attacking;
    //public int weapon = 0;
    private Transform parentTransform;
    public Animator anim;

    void Start()
    {
        parentTransform = transform;
    }

    void Update()
    {
        Transform LeftHand = parentTransform.Find("Left Hand");
        Transform RightHand = parentTransform.Find("Right Hand");
        SpriteResolver LSR = LeftHand.GetComponent<SpriteResolver>();
        SpriteResolver RSR = RightHand.GetComponent<SpriteResolver>();

        //attacking = anim.GetBool("attack");

        if (Attributes.instance.weapon == 0)
        {
            LSR.SetCategoryAndLabel("Left Hand", "Empty Left");
            RSR.SetCategoryAndLabel("Right Hand", "Empty Right");
        }
        else if (Attributes.instance.weapon == 1)
        {
            LSR.SetCategoryAndLabel("Left Hand", "Zip Left");
            RSR.SetCategoryAndLabel("Right Hand", "Zipgun Right");
        }

        //if (Input.GetKeyDown(KeyCode.E)) weapon = 1 - weapon;
        anim.SetFloat("weapon",Attributes.instance.weapon);
    }
}
