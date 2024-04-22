using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int _speed;

    private Rigidbody _rb;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        _rb.velocity = transform.right * _speed;

        Destroy(gameObject, 3);
    }
}
