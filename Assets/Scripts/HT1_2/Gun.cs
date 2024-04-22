using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    protected void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Звучит звук выстрела");
            Debug.Log("Происходит вспышка");
            InstantiateBullets();
            CheckAmmo();
        }
    }

    protected abstract void InstantiateBullets();
    protected abstract void CheckAmmo();
}
