using System.Collections.Generic;
using UnityEngine;

public class SingleShotGun : Gun
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private int _ammoCount = 10;

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
            var bullet = Instantiate(_bulletPrefab, _spawnPosition.position, Quaternion.identity);
            _bullets.Add(bullet);
            CheckAmmo();
    }

    private void Update()
    {
        base.Shoot();
    }
}
