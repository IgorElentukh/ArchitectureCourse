using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkPlace : Places
{
    private void Start()
    {
        Name = "������";
    }

    public override void ActivityAtPlace()
    {
        Debug.Log($"{Name}. �������");
    }
}
