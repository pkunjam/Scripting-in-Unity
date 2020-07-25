using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface_Enemy : MonoBehaviour, IDamageable<float>
{
    public float Health
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

    public void Damage(float damageAmount)
    {
        Health -= damageAmount;
    }
}
