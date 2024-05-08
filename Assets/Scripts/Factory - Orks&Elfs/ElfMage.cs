using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfMage : Mage
{
    private void Start()
    {
        Name = "έλότ";
        MakeDamage();
    }

    protected override void MakeDamage()
    {
        base.MakeDamage();
    }
}
