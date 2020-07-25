using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable<T>
{
    T Health { get; set;}

    void Damage(T damageAmount);
}
