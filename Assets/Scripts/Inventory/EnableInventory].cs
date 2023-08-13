using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisableInventory : MonoBehaviour
{
    public GameObject inv;
    private bool InvOpen = false;

    void Start()
    {
        inv.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && InvOpen == false)
        {
            InvOpen = true;
            inv.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.I) && InvOpen == true)
        {
            InvOpen = false;
            inv.SetActive(false);
        }
    }
}
