using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpriteRotation : MonoBehaviour
{
    GameObject target;

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
        }
    }
}
