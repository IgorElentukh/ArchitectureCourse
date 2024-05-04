using System;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public event Action OnCollision;
    
    public virtual void OnCollisionEnter(Collision collision)
    {
        OnCollision?.Invoke();
    }
}
