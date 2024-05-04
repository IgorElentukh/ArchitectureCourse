using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Places : MonoBehaviour
{
    protected string Name;
    protected Vector3 Position;

    protected virtual void Awake()
    {
        Position = transform.position;
    }


    public abstract void ActivityAtPlace();

}
