using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paladin : Enemy
{
    protected override void MakeDamage()
    {
        Debug.Log($"Я {Name} - паладин, я атакую!");
    }
}
