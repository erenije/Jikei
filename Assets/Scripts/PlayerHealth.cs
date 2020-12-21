using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public diespace1 dead;
    public float currentHealth = 10f;
    public float maxHealth = 10f;
    void Update()
    {
        if (currentHealth <= 0f )
        {
            dead.Pause();
        }
    }
}
