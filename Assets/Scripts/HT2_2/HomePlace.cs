using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomePlace : Places
{
    private void Awake()
    {
        Name = "Дом";
        Position = transform.position;

        Debug.Log(Name + Position);
    }

    public override void ActivityAtPlace()
    {
        Debug.Log($"{Name}. Отдыхаю");
    }
}
