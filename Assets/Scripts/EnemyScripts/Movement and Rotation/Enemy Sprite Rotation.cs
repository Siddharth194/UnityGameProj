using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpriteRotation : MonoBehaviour
{
    GameObject target;
    public Animator anim;

    private bool isAttacking = false;
    private bool isCoroutineRunning = false;
    
    private void Start()
    {
        target = GameObject.Find("vertopal.com_EmptyHand");
    }

    private void Update()
    {
        if (target != null)
        {
            Vector3 directionToTarget = target.GetComponent<Transform>().position - transform.position;
            directionToTarget.z = 0f;

            float targetAngle = Mathf.Atan2(directionToTarget.y, directionToTarget.x) * Mathf.Rad2Deg;

            Quaternion targetRotation = Quaternion.Euler(0, 0, targetAngle);
            transform.rotation = targetRotation;

            if (!isCoroutineRunning)
            {
                StartCoroutine(AttackCoroutine());
            }
        }
    }

    private IEnumerator AttackCoroutine()
    {
        isCoroutineRunning = true;

        // Wait for 1 second before starting the attack
        yield return new WaitForSeconds(2f);

        while (true)
        {
            float distance = Vector3.Distance(transform.position, target.GetComponent<Transform>().position);

            if (distance <= 4.0f && !isAttacking)
            {
                anim.SetBool("attacking", true);
                isAttacking = true;

                Attributes playerHealth = target.GetComponent<Attributes>();
                if (playerHealth != null)
                {
                    playerHealth.health -= 5f;
                }
            }
            else
            {
                anim.SetBool("attacking", false);
                isAttacking = false;
            }

            yield return new WaitForSeconds(0.75f);
        }

        isCoroutineRunning = false;
    }
}
