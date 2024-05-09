using System;
using UnityEngine;

public class ElfFactory : EnemyFactory
{
    [SerializeField] private Enemy _elfPaladinPrefab;
    [SerializeField] private Enemy _elfMagePrefab;
    
    public override Enemy GetEnemy(EnemyType enemyType)
    {
        switch(enemyType)
        {
            case EnemyType.Paladin:
                return Instantiate(_elfPaladinPrefab);

            case EnemyType.Mage:
                return Instantiate(_elfMagePrefab);

            default:
                throw new ArgumentException(nameof(enemyType));     
        }
    }
}
