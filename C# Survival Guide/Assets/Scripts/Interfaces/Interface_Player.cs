using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interface_Player : MonoBehaviour, IDamageable, IShoot
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

    public void Shoot()
    {
        throw new System.NotImplementedException();
    }
}
