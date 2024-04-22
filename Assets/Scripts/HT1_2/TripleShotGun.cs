using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShotGun : Gun
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private List<Transform> _spawnPositions = new List<Transform>();
    [SerializeField] private int _ammoCount = 30;

    private List<GameObject> _bullets = new List<GameObject>();

    protected override void CheckAmmo()
    {
        if (_bullets.Count >= _ammoCount)
        {
            Debug.Log("Перезарядка");
            _bullets.Clear();
        }
    }

    protected override void InstantiateBullets()
    {
        foreach (Transform spawn in _spawnPositions)
        {
            var bullet = Instantiate(_bulletPrefab, spawn.position, Quaternion.identity);
            _bullets.Add(bullet);
            CheckAmmo();
        }
    }

    private void Update()
    {
        base.Shoot();
    }
}
