using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrkMage : Mage
{
    private void Start()
    {
        Name = "ќрк";
        MakeDamage();
    }

    protected override void MakeDamage()
    {
        base.MakeDamage();
    }

    // как можно организовать иерархию получше, чтобы не было необходимости в повторении кода? „тоб условно нужно было только 
    // задавать им€ и все, а все остальное уже срабатывало само?
}
