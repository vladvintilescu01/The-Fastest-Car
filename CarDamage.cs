using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDamage : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public CarControl damage_Steering; 

    void Start()
    {
        currentHealth = maxHealth;
        damage_Steering = GetComponent<CarControl>();
    }

    public void TakeDamage(int amount)
    {
            currentHealth -= amount;
            damage_Steering.steeringAngle -= 2;
    }
}
