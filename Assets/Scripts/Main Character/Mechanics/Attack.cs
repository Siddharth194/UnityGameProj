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
    public float fireInterval = 0.1f;
    private float lastFireTime = 0f;
    public Transform flashsprite;

    void Start()
    {
        anim = GetComponent<Animator>();
        childTransform = parent.Find("gun_flash_pivot");
        childTransform.gameObject.SetActive(false);
    }

    void Update()
    {
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
                }
            }

            else if (Attributes.instance.weaponnum == 1 || Attributes.instance.weaponnum == 4)
            {
                anim.SetBool("attack", true);
                anim.Play("Shooting");
                StartCoroutine(WeaponFlash(5));
                //flashsprite.position = new Vector3(2.329f, 1.526f, 0f);

                if (Attributes.instance.weaponnum == 1)
                    Attributes.instance.weapon.durability -= 4;
                else Attributes.instance.weapon.durability -= 3;
                
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

                if (hit.collider != null && hit.collider.CompareTag("Enemy"))
                {
                    Collider2D x = hit.collider;
                    float distance = Vector3.Distance(hit.collider.GetComponent<Transform>().position, transform.position);

                    if (Attributes.instance.weapon != null && Attributes.instance.weapon.weapontype == 1)
                    {
                            Debug.Log("Mouse collided with the enemy: " + hit.collider.gameObject.name);
                            x.gameObject.GetComponent<EnemyAttributes>().damage(Attributes.instance.weapon.damage);
                    }
                }
            }

            if (Attributes.instance.weaponnum == 2 || Attributes.instance.weaponnum == 3)
            {
                anim.SetBool("attack", true);
                anim.Play("Knife attack");


                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

                RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

                if (hit.collider != null && hit.collider.CompareTag("Enemy"))
                {
                    if (Attributes.instance.weaponnum == 2) Attributes.instance.weapon.durability -= 2;
                    else Attributes.instance.weapon.durability -= 3.1f;
                    Collider2D x = hit.collider;
                    float distance = Vector3.Distance(hit.collider.GetComponent<Transform>().position, transform.position);

                    if (Attributes.instance.weapon != null && Attributes.instance.weapon.weapontype == 0)
                    {
                        if (distance < 4f)
                        {
                            Debug.Log("Mouse collided with the enemy: " + hit.collider.gameObject.name);
                            x.gameObject.GetComponent<EnemyAttributes>().damage(Attributes.instance.weapon.damage);
                        }
                    }
                }
            }
            
            // else if (Attributes.instance.weaponnum == 2)
            // {
            //     anim.SetBool("attack", true);
            //     anim.Play("Knife attack");
            //     //StartCoroutine(WeaponFlash(5));
            //     Attributes.instance.weapon.durability -= 4;
            //     Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //     Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            //     RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

            //     if (hit.collider != null && hit.collider.CompareTag("Enemy"))
            //     {
            //         Collider2D x = hit.collider;
            //         float distance = Vector3.Distance(hit.collider.GetComponent<Transform>().position, transform.position);

            //         if (Attributes.instance.weapon != null && Attributes.instance.weapon.weapontype == 1)
            //         {
            //                 Debug.Log("Mouse collided with the enemy: " + hit.collider.gameObject.name);
            //                 x.gameObject.GetComponent<EnemyAttributes>().damage(Attributes.instance.weapon.damage);
            //         }
            //     }
            // }
        }
        if (Input.GetMouseButton(0))
        {
            if (Attributes.instance.weapon.weaponID == 5)
            {
                //flashsprite.position = new Vector3(2.725f, 1.614f, 0f);
                if (Time.time - lastFireTime >= fireInterval)
                {
                    Fire();
                    lastFireTime = Time.time;
                }
            }
        }

        else
        {
            anim.SetBool("attack", false);
        }
    }
    
     private void Fire()
    {
        anim.SetBool("attack", true);
        anim.Play("AK Shooting");

        //childTransform.gameObject.SetActive(true);

        if (Attributes.instance.weaponnum == 5)
            Attributes.instance.weapon.durability -= 0.75f;

        
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        if (hit.collider != null && hit.collider.CompareTag("Enemy"))
        {
            Collider2D x = hit.collider;
            float distance = Vector3.Distance(hit.collider.GetComponent<Transform>().position, transform.position);

            if (Attributes.instance.weapon != null && Attributes.instance.weapon.weapontype == 1)
            {
                Debug.Log("Mouse collided with the enemy: " + hit.collider.gameObject.name);
                x.gameObject.GetComponent<EnemyAttributes>().damage(Attributes.instance.weapon.damage);
            }
        }

        StartCoroutine(WeaponFlash(5));
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
