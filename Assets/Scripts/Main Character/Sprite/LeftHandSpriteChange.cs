using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LeftHandSpriteChange : MonoBehaviour
{
    private List<UnityEngine.U2D.Animation.SpriteResolver> images;
    private bool attacking;
    public int weapon = 0;
    public Animator anim;

    void Start() => images = new List<UnityEngine.U2D.Animation.SpriteResolver>(GetComponentsInChildren<UnityEngine.U2D.Animation.SpriteResolver>());

    void Update()
    {
        attacking = anim.GetBool("Attacking");

        if (attacking)
        {
            
            if (weapon == 0 && weapon < images.Count)
            {
                var item = images[weapon];
                item.SetCategoryAndLabel(item.GetCategory(), "Left Fist");
            }
            else
            {
                Debug.LogWarning("Weapon index out of range.");
            }
        }
        else
            images[0].SetCategoryAndLabel(images[0].GetCategory(), "Left Open");
    }
}

