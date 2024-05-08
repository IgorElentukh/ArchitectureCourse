using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected string Name;

    protected abstract void MakeDamage();

    public void MoveTo(Vector3 position) => transform.position = position;
}
