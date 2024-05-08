using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class OrkFactory : EnemyFactory
{
    [SerializeField] private Enemy _orkPaladinPrefab;
    [SerializeField] private Enemy _orkMagePrefab;
    public override Enemy GetEnemy(EnemyType enemyType)
    {
        switch (enemyType)
        {
            case EnemyType.Paladin:
                return Instantiate(_orkPaladinPrefab);

            case EnemyType.Mage:
                return Instantiate(_orkMagePrefab);

            default:
                throw new ArgumentException(nameof(enemyType));
        }
    }
}

