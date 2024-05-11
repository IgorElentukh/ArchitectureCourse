using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor
{
    public abstract class Enemy : MonoBehaviour
    {
        public event Action<Enemy> OnDied;
        
        public void MoveTo(Vector3 position) => transform.position = position;

        public abstract void Accept (IEnemyVisitor visitor);
        public void Kill()
        {
            OnDied?.Invoke(this);
            Destroy(gameObject);
        }
    }
}
