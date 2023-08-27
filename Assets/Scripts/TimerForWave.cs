using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public float totalTime = 100.0f;
    private float remainingTime;
    public TextMeshProUGUI timerText;
    public int wavenumber = 1;
    public Transform Enemy;

    private bool flag = false;
    private bool newwave = false;
    private void Start()
    {
        remainingTime = totalTime;
    }

    private void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            UpdateTimerText();
        }

        else if (remainingTime <= 0)
        {
            if (!flag)
            {
                Debug.Log("A");
                flag = true;
                Enemy.GetComponent<EnemySpawn>().PickRandomElements(wavenumber*8);
                newwave = true;
            }
        }

        if (remainingTime < 0)
        {
            remainingTime = 0;
        }
        Debug.Log(remainingTime);

        if (Enemy.childCount == 0 && remainingTime <= 0 && newwave == true && wavenumber < 5)
        {
            flag = false;
            remainingTime = 10;
            wavenumber += 1;
            newwave = false;
        }
    }

    private void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);

        string timeText = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = timeText;
    }
}
