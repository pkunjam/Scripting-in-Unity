using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface_Enemy : MonoBehaviour, IDamageable
{
    public int Health
    {
        get
        {
            throw new System.NotImplementedException();
        }

        set
        {
            throw new System.NotImplementedException();
        }
    }

    public void Damage(int damageAmount)
    {
        Health -= damageAmount;
    }
}
