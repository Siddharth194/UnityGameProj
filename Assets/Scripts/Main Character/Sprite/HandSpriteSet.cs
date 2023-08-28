using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class HandSpriteSet : MonoBehaviour
{
    private bool attacking;
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

        if (Attributes.instance.weapon.weaponID == 0)
        {
            LSR.SetCategoryAndLabel("Left Hand", "Empty Left");
            RSR.SetCategoryAndLabel("Right Hand", "Empty Right");
        }
        else if (Attributes.instance.weapon.weaponID == 1 || Attributes.instance.weapon.weaponID == 4 || Attributes.instance.weapon.weaponID == 5)
        {
            LSR.SetCategoryAndLabel("Left Hand", "Zip Left");

            if (Attributes.instance.weapon.weaponID == 1)
                RSR.SetCategoryAndLabel("Right Hand", "Zipgun Right");
            else if (Attributes.instance.weapon.weaponID == 4)
                RSR.SetCategoryAndLabel("Right Hand", "Glock Right");
            else RSR.SetCategoryAndLabel("Right Hand", "AK Right");
        }
        else if (Attributes.instance.weapon.weaponID == 2 || Attributes.instance.weapon.weaponID == 3)
        {
            LSR.SetCategoryAndLabel("Left Hand", "Empty Left");
            RSR.SetCategoryAndLabel("Right Hand", "Knife Right");
        }

        //if (Input.GetKeyDown(KeyCode.E)) weapon = 1 - weapon;
        //anim.SetFloat("weapon",Attributes.instance.weapon);
    }
}
