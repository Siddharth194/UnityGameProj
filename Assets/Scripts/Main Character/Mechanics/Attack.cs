using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class ClickAndHoldTrigger : MonoBehaviour
{
    private Animator anim;
    private float phand = 0;
    public Transform parent;
    private Transform childTransform;
    public Transform Enemies;
    private bool canClick = true;

    void Start()
    {
        anim = GetComponent<Animator>();
        childTransform = parent.Find("gun_flash_pivot");
        childTransform.gameObject.SetActive(false);
    }

    void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        // {
        //     if (Attributes.instance.weaponnum == 0)
        //     {
        //         anim.SetBool("attack", true);
        //         phand = 1 - phand;

        //         if (phand > 0.1)
        //         {
        //             anim.Play("Punch");
        //         }
        //         else
        //         {
        //             anim.Play("Punch right");
        //         }

        //     }
        //     else if (Attributes.instance.weaponnum == 1)
        //     {
        //         anim.SetBool("attack", true);
        //         anim.Play("Shooting");
        //         StartCoroutine(WeaponFlash(5));
        //     }
        //     Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //     Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        //     RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        //     if (hit.collider != null && hit.collider.CompareTag("Enemy"))
        //     {
        //         float distance = Vector3.Distance(hit.collider.GetComponent<Transform>().position, transform.position);

        //         if (Attributes.instance.weapon.weapontype == 0)
        //         {
        //             if (distance < 3.5f)
        //                 {
        //                     Debug.Log("Mouse collided with the enemy: " + hit.collider.gameObject.name);
        //                     hit.collider.GetComponent<EnemyAttributes>().damage(Attributes.instance.weapon.damage);
        //                 }
        //         }
        //         else
        //         {
        //             Debug.LogWarning("Mouse collided with the enemy");
        //         }
        // }
        // else
        // {
        //     anim.SetBool("attack", false);
        // }
        if (Input.GetMouseButtonDown(0))
{
    if (Attributes.instance.weaponnum == 0)
    {
        anim.SetBool("attack", true);
        phand = 1 - phand;

        if (phand > 0.1)
        {
            anim.Play("Punch");
        }
        else
        {
            anim.Play("Punch right");
        }

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        if (hit.collider != null && hit.collider.CompareTag("Enemy"))
        {
            Collider2D x = hit.collider;
            float distance = Vector3.Distance(hit.collider.GetComponent<Transform>().position, transform.position);

            if (Attributes.instance.weapon != null && Attributes.instance.weapon.weapontype == 0)
            {
                if (distance < 3.5f)
                {
                    Debug.Log("Mouse collided with the enemy: " + hit.collider.gameObject.name);
                    x.gameObject.GetComponent<EnemyAttributes>().damage(Attributes.instance.weapon.damage);
                }
            }
            else
            {
                Debug.LogWarning("Mouse collided with the enemy");
            }
        }
    }
    else if (Attributes.instance.weaponnum == 1)
    {
        anim.SetBool("attack", true);
        anim.Play("Shooting");
        StartCoroutine(WeaponFlash(5));
    }
    else
    {
        anim.SetBool("attack", false);
    }
}


    }
    

    void CloseClickFunc(int index)
    {
        if (canClick)
        {
            Debug.Log("Punch");
            canClick = false;
            StartCoroutine(ResetClickCooldown());
        }
    }

    private IEnumerator ResetClickCooldown()
    {
        yield return new WaitForSeconds(0.2f); // Change the cooldown time as needed
        canClick = true;
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
