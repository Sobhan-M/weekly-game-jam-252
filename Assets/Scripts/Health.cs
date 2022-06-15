using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Health
{
    public void TakeDamage(float damageAmount);
    public void TakeHeal(float healAmount);
    public float GetCurrentHealth();
    public float GetMaxHealth();
    public bool IsDead();

}
