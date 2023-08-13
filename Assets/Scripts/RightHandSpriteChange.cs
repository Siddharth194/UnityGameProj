using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HandSpriteChange : MonoBehaviour
{
    private List<UnityEngine.U2D.Animation.SpriteResolver> images;
    private bool attacking;
    public int weapon = 0; // Changed the type to int to use it as an index
    public Animator anim;

    // Start is called before the first frame update
    void Start() => images = new List<UnityEngine.U2D.Animation.SpriteResolver>(GetComponentsInChildren<UnityEngine.U2D.Animation.SpriteResolver>());

    // Update is called once per frame
    void Update()
    {
        // Removed 'private' from this line since it's already declared in the class
        attacking = anim.GetBool("Attacking");

        if (attacking)
        {
            // Check if the weapon index is within bounds of the images list
            if (weapon == 0 && weapon < images.Count)
            {
                var item = images[weapon];
                item.SetCategoryAndLabel(item.GetCategory(), "Right Fist");
            }
            else
            {
                Debug.LogWarning("Weapon index out of range.");
            }
        }
        else
            images[0].SetCategoryAndLabel(images[0].GetCategory(), "Right Open");
    }
}

