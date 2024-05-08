using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyChanger : MonoBehaviour
{
    [SerializeField] private EnemySpawner _spawner;
    [SerializeField] private ElfFactory _elfFactory;
    [SerializeField] private OrkFactory _orkFactory;
    [SerializeField] private Button _changeBtn;

    private void OnEnable()
    {
        _changeBtn.onClick.AddListener(ChangeEnemyType);
    }

    private void OnDisable()
    {
        _changeBtn?.onClick.RemoveListener(ChangeEnemyType);
    }

    private void ChangeEnemyType()
    {
        if (_spawner.EnemyFactory == _elfFactory)
            _spawner.EnemyFactory = _orkFactory;
        else if (_spawner.EnemyFactory == _orkFactory)
            _spawner.EnemyFactory = _elfFactory;

    }
}
