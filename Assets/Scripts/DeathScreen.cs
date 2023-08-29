using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeathScreen : MonoBehaviour
{

    public bool death1 = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (death1)
        {
            Color newc =  transform.GetComponent<Image>().color;
            newc.a = Mathf.Clamp01(newc.a + 0.01f);
            transform.GetComponent<Image>().color = newc;
        }
    }
}
