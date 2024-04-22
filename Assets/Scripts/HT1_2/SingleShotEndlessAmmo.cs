using UnityEngine;

public class SingleShotEndlessAmmo : Gun
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _spawnPosition;

    protected override void CheckAmmo()
    {

    }

    protected override void InstantiateBullets()
    {
        var bullet = Instantiate(_bulletPrefab, _spawnPosition.position, Quaternion.identity);
        CheckAmmo();
    }

    void Update()
    {
        base.Shoot();
    }
}
