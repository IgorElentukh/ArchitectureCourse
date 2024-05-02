using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkPlace : Places
{
    private void Awake()
    {
        Name = "������";
        Position = transform.position;

        Debug.Log(Name + Position);
    }

    public override void ActivityAtPlace()
    {
        Debug.Log($"{Name}. �������");
    }
}
