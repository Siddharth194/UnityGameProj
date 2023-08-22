using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndHoldTrigger : MonoBehaviour
{
    private Animator anim;
    public float phand = 0;
    public Transform parent;
    private Transform childTransform;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        childTransform = parent.Find("gun_flash_pivot");
        childTransform.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Attributes.instance.weapon == 0)
            {
                anim.SetBool("attack",true);
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
            else if (Attributes.instance.weapon == 1)
            {
                anim.Play("Shooting");
                StartCoroutine(WeaponFlash(5));
            }
        }
        else anim.SetBool("attack",false);
    }

    private IEnumerator WeaponFlash(int framecount)
    {
        childTransform.gameObject.SetActive(true);
        while (framecount > 0)
        {
            yield return null;
            framecount--;
        }
        childTransform.gameObject.SetActive(false);
    }
}

