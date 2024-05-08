using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mage : Enemy
{
    protected override void MakeDamage()
    {
        Debug.Log($"Я {Name} - маг, я накладываю магию!");
    }
}
