using UnityEngine;
using TMPro;

public class HealthBar : MonoBehaviour
{
    float nextlevelkills = 5;
    float maxhealth;
    float health;
    int level;
    int kills;

    public TextMeshProUGUI healthText; // Reference to your TextMeshProUGUI component

    void Start()
    {
        // Initialize healthText if not already assigned
        if (healthText == null)
        {
            Debug.LogWarning("HealthText not assigned in the Inspector. Please assign it.");
        }
    }

    void Update()
    {
        UpdateAttributesValues();
        //UpdateLevelBarSize();

        // Update the TextMeshProUGUI text with the current health value as a percentage
        if (healthText != null)
        {
            float healthPercentage = (health / maxhealth) * 100f;
            healthText.text = healthPercentage.ToString("F1") + "%"; // Update text with health percentage
        }
    }

    void UpdateAttributesValues()
    {
        // Fetch the current attribute values from the Attributes script
        maxhealth = Attributes.instance.maxhealth;
        health = Attributes.instance.health;
        level = Attributes.instance.level;
        kills = Attributes.instance.kills;
    }

    // void UpdateLevelBarSize()
    // {
    //     float levelRatio = (float)kills / nextlevelkills; // Replace with your level calculation logic
    //     // Update your level bar size or do any other related logic here
    // }
}
