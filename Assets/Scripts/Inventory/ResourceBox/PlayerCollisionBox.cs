using UnityEngine;

public class PlayerCollisionBox: MonoBehaviour
{
    public Canvas canv;
    GameObject PrimaryEventSystem;
    public GameObject Panel;
    public Collider2D triggerColliderToCheckAgainst;
    public GameObject SecondaryEventSystem;
    bool active = false;

    void Start()
    {
        PrimaryEventSystem = GameObject.Find("Canvas/EventSystem");
        triggerColliderToCheckAgainst = GameObject.Find("vertopal.com_EmptyHand").GetComponent<Collider2D>();

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        PrimaryEventSystem.SetActive(false);
        canv.gameObject.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        canv.gameObject.SetActive(false);
        PrimaryEventSystem.SetActive(true);
    }

    private void Update()
    {
        if (triggerColliderToCheckAgainst != null)
        {
            bool isColliding = GetComponent<Collider2D>().IsTouching(triggerColliderToCheckAgainst);
            
            if (isColliding)
            {
                if (Input.GetKeyDown(KeyCode.P))
                    TogglePanel();
            }
        }
    }

    private void TogglePanel()
    {
        Debug.Log(active);

        if (active == false)
        {
            active = true;
            Panel.SetActive(true);
            SecondaryEventSystem.SetActive(true);
        }
        else if (active == true)
        {
            active = false;
            Panel.SetActive(false);
            SecondaryEventSystem.SetActive(false);
        }
    }
}
