using System;
using UnityEngine;

public class Mediator : MonoBehaviour
{
    [SerializeField] private UIHandler _uiHandler;
    [SerializeField] private PlayerMovement _playerMovement;
    
    private Booster _booster;

    public void Initialize(Booster booster)
    {
        _booster = booster;
        _booster.OnCollision += UpdateUI;
    }

    private void OnEnable()
    {
        _uiHandler.OnLevelRestart += LevelRestart;
    }

    private void LevelRestart()
    {
        _playerMovement.SetStartPosition();
    }

    private void UpdateUI()
    {
        if (_booster.GetType() == typeof(LevelUpBooster))
        {
            _uiHandler.AddLevel();
            _booster.OnCollision -= UpdateUI;
        }
        else if (_booster.GetType() == typeof(HPDownBooster))
        {
            _uiHandler.TakeDamage();
            _booster.OnCollision -= UpdateUI;
        }
    }

    private void OnDisable()
    {
        _uiHandler.OnLevelRestart -= LevelRestart;
    }

}
