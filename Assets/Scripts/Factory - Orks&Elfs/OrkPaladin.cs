using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrkPaladin : Paladin
{
    private void Start()
    {
        Name = "���";
        MakeDamage();
    }

    protected override void MakeDamage()
    {
        base.MakeDamage();
    }

}
