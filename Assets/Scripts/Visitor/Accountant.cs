using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Visitor
{
    public class Accountant : MonoBehaviour // если делать его не монобехом, как можно передать в Spawner? Или там его просто нужно создать?
    {
        [SerializeField] private List<Enemy> _spawnedEnemies = new List<Enemy>();

        private EnemyVisitor _enemyVisitor;

        public event Action OnMassExceed;
        public int Value => _enemyVisitor.Score;
        public int Mass => _enemyVisitor.Weight;
        public List<Enemy> SpawnedEnemies { get => _spawnedEnemies; set => _spawnedEnemies = value; }

        private void Start()
        {
            _enemyVisitor = new EnemyVisitor();
        }
        public void OnEnemyDied(Enemy enemy)
        {
            enemy.OnDied -= OnEnemyDied;
            _spawnedEnemies.Remove(enemy);
            enemy.Accept(_enemyVisitor);
            
            if (Mass >= 150)
                OnMassExceed?.Invoke();

            Debug.Log("Счет " + Value);
            Debug.Log("Масса " + Mass);
        }

        private class EnemyVisitor : IEnemyVisitor
        {
            public int Score { get; private set; }
            public int Weight { get; private set; }
            public void Visit(Ork ork)
            {
                Score += 10;
                Weight += 20;
            }
            public void Visit(Human human)
            {
                Score += 5;
                Weight += 40;
            }
            public void Visit(Elf elf)
            {
                Score += 20;
                Weight += 30;
            }
        }
    }
}
