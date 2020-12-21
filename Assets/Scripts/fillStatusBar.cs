using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fillStatusBar : MonoBehaviour
{
    public PlayerHealth playerhealth;
    public Image fillImage;
    private Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        if (slider.value <= slider.minValue)
        {
            fillImage.enabled = false;
        }

        if (slider.value > slider.minValue && !fillImage.enabled)
        {
            fillImage.enabled = true;
        }
        float fillValue = playerhealth.currentHealth / playerhealth.maxHealth;
        slider.value = fillValue;
    }
}
