using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor
{
    [CreateAssetMenu(fileName = "VisitorEnemyFactory", menuName = "Factory/VisitorEnemyFactory")]
    public class EnemyFactory : ScriptableObject
    {
        [SerializeField] private Ork _ork;
        [SerializeField] private Human _human;
        [SerializeField] private Elf _elf;

        public Enemy Get(EnemyType type)
        {
            switch (type)
            {
                case EnemyType.Ork:
                    return Instantiate(_ork);

                case EnemyType.Human:
                    return Instantiate(_human);

                case EnemyType.Elf:
                    return Instantiate(_elf);

                default:
                    return null;
            }

        }
    }
}
